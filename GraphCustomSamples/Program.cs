using Azure.Identity;
using GraphVariations.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Identity.Client;
using Microsoft.Kiota.Authentication.Azure;
using Microsoft.Kiota.Http.HttpClientLibrary;
using NoBackingStore.Graph;
using NoBackingStore.Graph.Models;
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
var resultNakedRest = await PageNakedRestAsync();
Console.WriteLine($"Done naked REST. {resultNakedRest.Entities.Count} entities and {resultNakedRest.PageRequests} page requests issued");

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

async Task<PagedRequestResponse<GraphVariations.Common.RestModels.User>> PageNakedRestAsync()
{
    List<GraphVariations.Common.RestModels.User> users = new();

    // This is standard MSAL
    var cca = ConfidentialClientApplicationBuilder
        .Create(clientId)
        .WithClientSecret(clientSecret)
        .WithTenantId(tenantId)
    .Build();

    var authResult = await cca.AcquireTokenForClient(new string[] { "https://graph.microsoft.com/.default" }).ExecuteAsync();

    string pageRequest = $"https://graph.microsoft.com/v1.0/users?$top=10";
    int pageRequests = -1;

    // Yes, I know. But this is demo-ware. If you want to do it right, see:
    // https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient-guidelines#recommended-use
    var client = new System.Net.Http.HttpClient();
    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", authResult.AccessToken);

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