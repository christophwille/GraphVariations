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
namespace NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule
{
    /// <summary>
    /// Provides operations to call the getSchedule method.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class GetScheduleRequestBuilder : BaseRequestBuilder
    {
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetScheduleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetScheduleRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/calendarGroups/{calendarGroup%2Did}/calendars/{calendar%2Did}/getSchedule", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetScheduleRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GetScheduleRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/calendarGroups/{calendarGroup%2Did}/calendars/{calendar%2Did}/getSchedule", rawUrl)
        {
        }
        /// <summary>
        /// Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/calendar-getschedule?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::NoBackingStore.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostResponse?> PostAsGetSchedulePostResponseAsync(global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostResponse> PostAsGetSchedulePostResponseAsync(global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::NoBackingStore.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostResponse>(requestInfo, global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.
        /// Find more info here <see href="https://learn.microsoft.com/graph/api/calendar-getschedule?view=graph-rest-1.0" />
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetScheduleResponse"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::NoBackingStore.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
        [Obsolete("This method is obsolete. Use PostAsGetSchedulePostResponseAsync instead.")]
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetScheduleResponse?> PostAsync(global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetScheduleResponse> PostAsync(global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::NoBackingStore.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetScheduleResponse>(requestInfo, global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetScheduleResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Get the free/busy availability information for a collection of users, distributions lists, or resources (rooms or equipment) for a specified time period.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetSchedulePostRequestBody body, Action<RequestConfiguration<DefaultQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetScheduleRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetScheduleRequestBuilder WithUrl(string rawUrl)
        {
            return new global::NoBackingStore.Graph.Users.Item.CalendarGroups.Item.Calendars.Item.GetSchedule.GetScheduleRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class GetScheduleRequestBuilderPostRequestConfiguration : RequestConfiguration<DefaultQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
