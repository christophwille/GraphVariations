using Azure.Identity;
using GraphVariations.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Text.Json;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

var (tenantId, clientId, clientSecret) = (
    configuration["TenantId"],
    configuration["AppPrincipalId"],
    configuration["Password"]
);

// https://learn.microsoft.com/en-us/graph/sdks/choose-authentication-providers?tabs=csharp
// https://learn.microsoft.com/en-us/graph/sdks/choose-authentication-providers?tabs=csharp#using-a-client-secret
var options = new ClientSecretCredentialOptions
{
    AuthorityHost = AzureAuthorityHosts.AzurePublicCloud,
};

var clientSecretCredential = new ClientSecretCredential(tenantId, clientId, clientSecret, options);

var scopes = new[] { "https://graph.microsoft.com/.default" };
var graphClient = new GraphServiceClient(clientSecretCredential, scopes);

const int pageSize = 10;

// # 1 - simply give me whatever fits in one reponse
//var resultSingleCall = await graphClient.Users.GetAsync();
//Console.WriteLine($"Done simple. {resultSingleCall.Value.Count} entities");

// #2 - use the standard iterator pattern from https://learn.microsoft.com/en-us/graph/sdks/paging?tabs=csharp
//var resultIterator = await PageViaIteratorAsync<User, UserCollectionResponse>(() => graphClient.Users.GetAsync(requestConfiguration =>
//{
//    requestConfiguration.QueryParameters.Top = pageSize;
//}));
//Console.WriteLine($"Done iterator. {resultIterator.Entities.Count} entities and {resultIterator.PageRequests} page requests issued");

// #3 - OdataNextLink. Generic variant of https://learn.microsoft.com/en-us/graph/sdks/paging?tabs=csharp#manually-requesting-subsequent-pages
//var resultOdataLink = await PageViaOdataLinkAsync<User, UserCollectionResponse>(
//    () => graphClient.Users.GetAsync(requestConfiguration =>
//            {
//                requestConfiguration.QueryParameters.Top = pageSize;
//            }),
//    nextLink => graphClient.Users.WithUrl(nextLink).GetAsync());
//Console.WriteLine($"Done OdataNextLink. {resultOdataLink.Entities.Count} entities and {resultOdataLink.PageRequests} page requests issued");

// #4 -RequestInformation
////var requestInfo = graphClient.Users.ToGetRequestInformation(requestConfiguration =>
////            {
////                requestConfiguration.QueryParameters.Top = pageSize;
////            });
////var user = await graphClient.RequestAdapter.SendAsync(requestInfo, UserCollectionResponse.CreateFromDiscriminatorValue);
//var resultRequestInfo = await PageViaRequestInformationAsync<User, UserCollectionResponse>(
//            graphClient.Users.ToGetRequestInformation(requestConfiguration =>
//            {
//                requestConfiguration.QueryParameters.Top = pageSize;
//            }),
//            UserCollectionResponse.CreateFromDiscriminatorValue);
//Console.WriteLine($"Done RequestInformation. {resultRequestInfo.Entities.Count} entities and {resultRequestInfo.PageRequests} page requests issued");

// #5 - RequestInformation, but using ConvertToNativeRequestAsync & custom models (side-step backing store that way)
var resultNativeRequest = await PageNativeRequestCustomModelsAsync(graphClient.Users.ToGetRequestInformation(requestConfiguration =>
{
    requestConfiguration.QueryParameters.Top = pageSize;
}));
Console.WriteLine($"Done RequestInformation. {resultNativeRequest.Entities.Count} entities and {resultNativeRequest.PageRequests} page requests issued");


Console.WriteLine("Program ended");

async Task<PagedRequestResponse<TEntity>> PageViaIteratorAsync<TEntity, TCollectionPage>(Func<Task<TCollectionPage?>> getFirstPage)
    where TCollectionPage : Microsoft.Graph.Models.BaseCollectionPaginationCountResponse, new()
{
    List<TEntity> retval = new();

    TCollectionPage? entities = await getFirstPage();
    if (null == entities) return new(retval);

    int pageRequests = 0;

    var pageIterator = PageIterator<TEntity, TCollectionPage>
        .CreatePageIterator(
            graphClient,
            entities,
            (entity) =>
            {
                retval.Add(entity);
                return true;
            },
            (req) =>
            {
                pageRequests++;
                return req;  // eg Re-add the header to subsequent requests
            });

    await pageIterator.IterateAsync();

    return new(retval, pageRequests);
}

async Task<PagedRequestResponse<TEntity>> PageViaOdataLinkAsync<TEntity, TCollectionPage>(
        Func<Task<TCollectionPage?>> getFirstPage,
        Func<string, Task<TCollectionPage?>> getNextPage)
    where TCollectionPage : Microsoft.Graph.Models.BaseCollectionPaginationCountResponse, new()
{
    List<TEntity> retval = new();

    TCollectionPage? firstPage = await getFirstPage();
    if (null == firstPage) return new(retval);

    // BaseCollectionPaginationCountResponse does not have the .Value property (who designed Kiota codegen???)
    retval.AddRange(firstPage.BackingStore?.Get<List<TEntity>?>("value"));

    // Get subsequent pages
    var pageRequest = firstPage.OdataNextLink;
    int pageRequests = 0;

    while (pageRequest != null)
    {
        var nextPage = await getNextPage(pageRequest);
        retval.AddRange(nextPage.BackingStore?.Get<List<TEntity>?>("value"));
        pageRequest = nextPage.OdataNextLink;
        pageRequests++;
    }

    return new(retval, pageRequests);
}

async Task<PagedRequestResponse<TEntity>> PageViaRequestInformationAsync<TEntity, TCollectionPage>(
        RequestInformation requestInfo, ParsableFactory<TCollectionPage> factory)
    where TCollectionPage : Microsoft.Graph.Models.BaseCollectionPaginationCountResponse, new()
    where TEntity : IParsable
{
    List<TEntity> retval = new();

    TCollectionPage? firstPage = await graphClient.RequestAdapter.SendAsync(requestInfo, factory);
    if (null == firstPage) return new(retval);

    // BaseCollectionPaginationCountResponse does not have the .Value property (who designed Kiota codegen???)
    retval.AddRange(firstPage.BackingStore?.Get<List<TEntity>?>("value"));

    // Get subsequent pages
    var pageRequest = firstPage.OdataNextLink;
    int pageRequests = 0;

    while (pageRequest != null)
    {
        requestInfo.URI = new Uri(pageRequest);
        var nextPage = await graphClient.RequestAdapter.SendAsync(requestInfo, factory);
        retval.AddRange(nextPage.BackingStore?.Get<List<TEntity>?>("value"));
        pageRequest = nextPage.OdataNextLink;
        pageRequests++;
    }

    return new(retval, pageRequests);
}

async Task<PagedRequestResponse<GraphVariations.Common.RestModels.User>> PageNativeRequestCustomModelsAsync(RequestInformation requestInfo)
{
    // Yes, I know. But this is demo-ware. If you want to do it right, see:
    // https://learn.microsoft.com/en-us/dotnet/fundamentals/networking/http/httpclient-guidelines#recommended-use
    var client = new System.Net.Http.HttpClient();
    string? pageRequest = null;

    using (var httpRequest = await graphClient.RequestAdapter.ConvertToNativeRequestAsync<System.Net.Http.HttpRequestMessage>(requestInfo))
    {
        using (var httpResponse = await client.SendAsync(httpRequest))
        {
            httpResponse.EnsureSuccessStatusCode();

            var responseString = await httpResponse.Content.ReadAsStringAsync();
            var page = JsonSerializer.Deserialize<GraphVariations.Common.RestModels.UserApiResponse>(responseString);

            pageRequest = page.NextLink;
        }
    }

    // TODO: Perform actual paging. This is only page #1 here.
    // TODO: Make generic like everything else

    return new(new());
}