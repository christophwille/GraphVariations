// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using NoBackingStore.Graph.Models.ODataErrors;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures
{
    /// <summary>
    /// Provides operations to call the getManagedDevicesWithAppFailures method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class GetManagedDevicesWithAppFailuresRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetManagedDevicesWithAppFailuresRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/getManagedDevicesWithAppFailures(){?%24count,%24filter,%24search,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetManagedDevicesWithAppFailuresRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/getManagedDevicesWithAppFailures(){?%24count,%24filter,%24search,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Retrieves the list of devices with failed apps
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-troubleshooting-user-getmanageddeviceswithappfailures?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresGetResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::NoBackingStore.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresGetResponse?> GetAsGetManagedDevicesWithAppFailuresGetResponseAsync(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresRequestBuilder.GetManagedDevicesWithAppFailuresRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresGetResponse> GetAsGetManagedDevicesWithAppFailuresGetResponseAsync(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresRequestBuilder.GetManagedDevicesWithAppFailuresRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::NoBackingStore.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresGetResponse>(requestInfo, global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresGetResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves the list of devices with failed apps
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/intune-troubleshooting-user-getmanageddeviceswithappfailures?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::NoBackingStore.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use GetAsGetManagedDevicesWithAppFailuresGetResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresResponse?> GetAsync(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresRequestBuilder.GetManagedDevicesWithAppFailuresRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresResponse> GetAsync(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresRequestBuilder.GetManagedDevicesWithAppFailuresRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::NoBackingStore.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresResponse>(requestInfo, global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Retrieves the list of devices with failed apps
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresRequestBuilder.GetManagedDevicesWithAppFailuresRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresRequestBuilder.GetManagedDevicesWithAppFailuresRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresRequestBuilder WithUrl(string rawUrl)
        {
            return new global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Retrieves the list of devices with failed apps
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class GetManagedDevicesWithAppFailuresRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Filter items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24filter")]
            public string? Filter { get; set; }
#nullable restore
#else
            [QueryParameter("%24filter")]
            public string Filter { get; set; }
#endif
            /// <summary>Search items by search phrases</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24search")]
            public string? Search { get; set; }
#nullable restore
#else
            [QueryParameter("%24search")]
            public string Search { get; set; }
#endif
            /// <summary>Skip the first n items</summary>
            [QueryParameter("%24skip")]
            public int? Skip { get; set; }
            /// <summary>Show only the first n items</summary>
            [QueryParameter("%24top")]
            public int? Top { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class GetManagedDevicesWithAppFailuresRequestBuilderGetRequestConfiguration : RequestConfiguration<global::NoBackingStore.Graph.Users.Item.GetManagedDevicesWithAppFailures.GetManagedDevicesWithAppFailuresRequestBuilder.GetManagedDevicesWithAppFailuresRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
