// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using NoBackingStore.Graph.Models.ODataErrors;
using NoBackingStore.Graph.Models;
using NoBackingStore.Graph.Users.Item.OnlineMeetings.Count;
using NoBackingStore.Graph.Users.Item.OnlineMeetings.CreateOrGet;
using NoBackingStore.Graph.Users.Item.OnlineMeetings.GetAllRecordingsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime;
using NoBackingStore.Graph.Users.Item.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime;
using NoBackingStore.Graph.Users.Item.OnlineMeetings.Item;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace NoBackingStore.Graph.Users.Item.OnlineMeetings
{
    /// <summary>
    /// Provides operations to manage the onlineMeetings property of the microsoft.graph.user entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OnlineMeetingsRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Provides operations to count the resources in the collection.</summary>
        public global::NoBackingStore.Graph.Users.Item.OnlineMeetings.Count.CountRequestBuilder Count
        {
            get => new global::NoBackingStore.Graph.Users.Item.OnlineMeetings.Count.CountRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the createOrGet method.</summary>
        public global::NoBackingStore.Graph.Users.Item.OnlineMeetings.CreateOrGet.CreateOrGetRequestBuilder CreateOrGet
        {
            get => new global::NoBackingStore.Graph.Users.Item.OnlineMeetings.CreateOrGet.CreateOrGetRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAllRecordings method.</summary>
        public global::NoBackingStore.Graph.Users.Item.OnlineMeetings.GetAllRecordingsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllRecordingsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder GetAllRecordingsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime
        {
            get => new global::NoBackingStore.Graph.Users.Item.OnlineMeetings.GetAllRecordingsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllRecordingsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to call the getAllTranscripts method.</summary>
        public global::NoBackingStore.Graph.Users.Item.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime
        {
            get => new global::NoBackingStore.Graph.Users.Item.OnlineMeetings.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTime.GetAllTranscriptsmeetingOrganizerUserIdMeetingOrganizerUserIdWithStartDateTimeWithEndDateTimeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Provides operations to manage the onlineMeetings property of the microsoft.graph.user entity.</summary>
        /// <param name="position">The unique identifier of onlineMeeting</param>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Users.Item.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder"/></returns>
        public global::NoBackingStore.Graph.Users.Item.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder this[string position]
        {
            get
            {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("onlineMeeting%2Did", position);
                return new global::NoBackingStore.Graph.Users.Item.OnlineMeetings.Item.OnlineMeetingItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Users.Item.OnlineMeetings.OnlineMeetingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OnlineMeetingsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/onlineMeetings{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Users.Item.OnlineMeetings.OnlineMeetingsRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public OnlineMeetingsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/onlineMeetings{?%24count,%24expand,%24filter,%24orderby,%24search,%24select,%24skip,%24top}", rawUrl)
        {
        }
        /// <summary>
        /// Information about a meeting, including the URL used to join a meeting, the attendees list, and the description.
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.OnlineMeetingCollectionResponse"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::NoBackingStore.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::NoBackingStore.Graph.Models.OnlineMeetingCollectionResponse?> GetAsync(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.OnlineMeetings.OnlineMeetingsRequestBuilder.OnlineMeetingsRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::NoBackingStore.Graph.Models.OnlineMeetingCollectionResponse> GetAsync(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.OnlineMeetings.OnlineMeetingsRequestBuilder.OnlineMeetingsRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::NoBackingStore.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::NoBackingStore.Graph.Models.OnlineMeetingCollectionResponse>(requestInfo, global::NoBackingStore.Graph.Models.OnlineMeetingCollectionResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Create new navigation property to onlineMeetings for users
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.OnlineMeeting"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::NoBackingStore.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::NoBackingStore.Graph.Models.OnlineMeeting?> PostAsync(global::NoBackingStore.Graph.Models.OnlineMeeting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::NoBackingStore.Graph.Models.OnlineMeeting> PostAsync(global::NoBackingStore.Graph.Models.OnlineMeeting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::NoBackingStore.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::NoBackingStore.Graph.Models.OnlineMeeting>(requestInfo, global::NoBackingStore.Graph.Models.OnlineMeeting.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Information about a meeting, including the URL used to join a meeting, the attendees list, and the description.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.OnlineMeetings.OnlineMeetingsRequestBuilder.OnlineMeetingsRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.OnlineMeetings.OnlineMeetingsRequestBuilder.OnlineMeetingsRequestBuilderGetQueryParameters>> requestConfiguration = default)
        {
#endif
            var requestInfo = new RequestInformation(Method.GET, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            return requestInfo;
        }
        /// <summary>
        /// Create new navigation property to onlineMeetings for users
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::NoBackingStore.Graph.Models.OnlineMeeting body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::NoBackingStore.Graph.Models.OnlineMeeting body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation(Method.POST, UrlTemplate, PathParameters);
            requestInfo.Configure(requestConfiguration);
            requestInfo.Headers.TryAdd("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Users.Item.OnlineMeetings.OnlineMeetingsRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::NoBackingStore.Graph.Users.Item.OnlineMeetings.OnlineMeetingsRequestBuilder WithUrl(string rawUrl)
        {
            return new global::NoBackingStore.Graph.Users.Item.OnlineMeetings.OnlineMeetingsRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Information about a meeting, including the URL used to join a meeting, the attendees list, and the description.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OnlineMeetingsRequestBuilderGetQueryParameters 
        {
            /// <summary>Include count of items</summary>
            [QueryParameter("%24count")]
            public bool? Count { get; set; }
            /// <summary>Expand related entities</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24expand")]
            public string[]? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("%24expand")]
            public string[] Expand { get; set; }
#endif
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
            /// <summary>Order items by property values</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24orderby")]
            public string[]? Orderby { get; set; }
#nullable restore
#else
            [QueryParameter("%24orderby")]
            public string[] Orderby { get; set; }
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
            /// <summary>Select properties to be returned</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("%24select")]
            public string[]? Select { get; set; }
#nullable restore
#else
            [QueryParameter("%24select")]
            public string[] Select { get; set; }
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
        public partial class OnlineMeetingsRequestBuilderGetRequestConfiguration : RequestConfiguration<global::NoBackingStore.Graph.Users.Item.OnlineMeetings.OnlineMeetingsRequestBuilder.OnlineMeetingsRequestBuilderGetQueryParameters>
        {
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class OnlineMeetingsRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
