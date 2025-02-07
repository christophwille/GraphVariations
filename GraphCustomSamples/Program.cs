using Azure.Identity;
using GraphVariations.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using Microsoft.Kiota.Authentication.Azure;
using Microsoft.Kiota.Http.HttpClientLibrary;
using NoBackingStore.Graph;
using NoBackingStore.Graph.Models;
using Simple.OData.Client;
using System.Net.Http.Headers;
using System.Text.Json;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

var (tenantId, clientId, clientSecret) = (
    configuration["TenantId"],
    configuration["AppPrincipalId"],
    configuration["Password"]);

// #1 - Custom SDK
//var resultCustomSdk = await PageCustomSdkAsync();
//Console.WriteLine($"Done Custom SDK. {resultCustomSdk.Entities.Count} entities and {resultCustomSdk.PageRequests} page requests issued");

// #2 - Naked REST (without resilience, yes)
//var resultNakedRest = await PageNakedRestAsync();
//Console.WriteLine($"Done naked REST. {resultNakedRest.Entities.Count} entities and {resultNakedRest.PageRequests} page requests issued");

// #3 - Simple.OData.Client
var resultSimpleODataClient = await PageSimpleODataClientAsync();
Console.WriteLine($"Done Simple.OData.Client. {resultSimpleODataClient.Entities.Count}");

Console.WriteLine("Program ended");

async Task<PagedRequestResponse<User>> PageCustomSdkAsync()
{
    // See https://github.com/MartinM85/BlogDiscussion/discussions/6#discussioncomment-12090253
    var clientSecretCredential = new ClientSecretCredential(tenantId, clientId, clientSecret);
    var tokenProvider = new AzureIdentityAuthenticationProvider(clientSecretCredential);
    var requestAdapter = new HttpClientRequestAdapter(tokenProvider);

    var client = new UsersClient(requestAdapter);

    // There is no PageIterator in the generated code

    List<User> users = new();
    var resultPageOne = await client.Users.GetAsync(requestConfiguration =>
        {
            requestConfiguration.QueryParameters.Top = 10;
        });

    if (resultPageOne == null)
    {
        Console.WriteLine("No users found. Program ended");
        return new(users);
    }

    users.AddRange(resultPageOne.Value);
    var pageRequest = resultPageOne.OdataNextLink;
    int pageRequests = 0;

    while (pageRequest != null)
    {
        var nextPage = await client.Users.WithUrl(pageRequest).GetAsync();
        users.AddRange(nextPage.Value);
        pageRequest = nextPage.OdataNextLink;
        pageRequests++;
    }

    return new(users, pageRequests);
}

async Task<string> GetAuthTokenViaMSAL()
{
    // This is standard MSAL
    var cca = ConfidentialClientApplicationBuilder
        .Create(clientId)
        .WithClientSecret(clientSecret)
        .WithTenantId(tenantId)
    .Build();

    var authResult = await cca.AcquireTokenForClient(new string[] { "https://graph.microsoft.com/.default" }).ExecuteAsync();

    return authResult.AccessToken;
}

async Task<PagedRequestResponse<GraphVariations.Common.RestModels.User>> PageNakedRestAsync()
{
    List<GraphVariations.Common.RestModels.User> users = new();

    var token = await GetAuthTokenViaMSAL();

    string pageRequest = $"https://graph.microsoft.com/v1.0/users?$top=10";
    int pageRequests = -1;

    // Yes, I know. But this is demo-ware. If you want to do it right, see:
    // https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient-guidelines#recommended-use
    var client = new System.Net.Http.HttpClient();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

    do
    {
        pageRequests++;
        var httpResponse = await client.GetAsync(pageRequest);
        httpResponse.EnsureSuccessStatusCode();

        var responseString = await httpResponse.Content.ReadAsStringAsync();
        var page = JsonSerializer.Deserialize<GraphVariations.Common.RestModels.UserApiResponse>(responseString);

        users.AddRange(page.Value);
        pageRequest = page.NextLink;

    } while (pageRequest != null);

    return new(users, pageRequests);
}

async Task<PagedRequestResponse<GraphVariations.Common.RestModels.User>> PageSimpleODataClientAsync()
{
    var token = await GetAuthTokenViaMSAL();

    var client = new ODataClient(new ODataClientSettings(new Uri("https://graph.microsoft.com/v1.0/"))
    {
        OnTrace = (x, y) => Console.WriteLine(string.Format(x, y)),
        BeforeRequest = (message) => message.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token),
        // MetadataDocument = "../../../metadata.xml" // we'd need the OData document from https://graph.microsoft.com/v1.0/$metadata
    });

    // More Simple.OData.Client samples (for Exchange) can be found at 
    // https://github.com/christophwille/talkingtoexorestapi/blob/f3c5a8adfac4f8f1a6a3b5cf4f752a8f5e4f3ec5/src/GetMailBoxDemo/Program.cs#L74
    var annotations = new ODataFeedAnnotations();
    var users = (await client.For<GraphVariations.Common.RestModels.User>().FindEntriesAsync(annotations)).ToList();

    while (annotations.NextPageLink != null)
    {
        users.AddRange(await client.For<GraphVariations.Common.RestModels.User>().FindEntriesAsync(annotations.NextPageLink, annotations));
    }

    return new(users);
}