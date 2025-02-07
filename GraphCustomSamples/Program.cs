﻿using Azure.Identity;
using GraphVariations.Common;
using Microsoft.Extensions.Configuration;
using Microsoft.Kiota.Authentication.Azure;
using Microsoft.Kiota.Http.HttpClientLibrary;
using NoBackingStore.Graph;
using NoBackingStore.Graph.Models;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

var (tenantId, clientId, clientSecret) = (
    configuration["TenantId"],
    configuration["AppPrincipalId"],
    configuration["Password"]);


var resultCustomSdk = await PageCustomSdkAsync();
Console.WriteLine($"Done Custom SDK. {resultCustomSdk.Entities.Count} entities and {resultCustomSdk.PageRequests} page requests issued");

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