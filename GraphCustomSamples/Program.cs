using Azure.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Kiota.Authentication.Azure;
using Microsoft.Kiota.Http.HttpClientLibrary;
using NoBackingStore.Graph;

var builder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile("appsettings.Local.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = builder.Build();

var (tenantId, clientId, clientSecret) = (
    configuration["TenantId"],
    configuration["AppPrincipalId"],
    configuration["Password"]);

// See https://github.com/MartinM85/BlogDiscussion/discussions/6#discussioncomment-12090253
var clientSecretCredential = new ClientSecretCredential(tenantId, clientId, clientSecret);
var tokenProvider = new AzureIdentityAuthenticationProvider(clientSecretCredential);
var requestAdapter = new HttpClientRequestAdapter(tokenProvider);

var client = new UsersClient(requestAdapter);
var result = await client.Users.GetAsync();

Console.WriteLine("Program ended");