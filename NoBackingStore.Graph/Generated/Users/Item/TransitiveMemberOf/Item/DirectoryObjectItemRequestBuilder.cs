// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using NoBackingStore.Graph.Models.ODataErrors;
using NoBackingStore.Graph.Models;
using NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.GraphAdministrativeUnit;
using NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.GraphDirectoryRole;
using NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.GraphGroup;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item
{
    /// <summary>
    /// Provides operations to manage the transitiveMemberOf property of the microsoft.graph.user entity.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DirectoryObjectItemRequestBuilder : BaseRequestBuilder
    {
        /// <summary>Casts the previous resource to administrativeUnit.</summary>
        public global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.GraphAdministrativeUnit.GraphAdministrativeUnitRequestBuilder GraphAdministrativeUnit
        {
            get => new global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.GraphAdministrativeUnit.GraphAdministrativeUnitRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to directoryRole.</summary>
        public global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.GraphDirectoryRole.GraphDirectoryRoleRequestBuilder GraphDirectoryRole
        {
            get => new global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.GraphDirectoryRole.GraphDirectoryRoleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Casts the previous resource to group.</summary>
        public global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.GraphGroup.GraphGroupRequestBuilder GraphGroup
        {
            get => new global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.GraphGroup.GraphGroupRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/transitiveMemberOf/{directoryObject%2Did}{?%24expand,%24select}", pathParameters)
        {
        }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder"/> and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DirectoryObjectItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/users/{user%2Did}/transitiveMemberOf/{directoryObject%2Did}{?%24expand,%24select}", rawUrl)
        {
        }
        /// <summary>
        /// The groups, including nested groups, and directory roles that a user is a member of. Nullable.
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.DirectoryObject"/></returns>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
        /// <exception cref="global::NoBackingStore.Graph.Models.ODataErrors.ODataError">When receiving a 4XX or 5XX status code</exception>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<global::NoBackingStore.Graph.Models.DirectoryObject?> GetAsync(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder.DirectoryObjectItemRequestBuilderGetQueryParameters>>? requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#nullable restore
#else
        public async Task<global::NoBackingStore.Graph.Models.DirectoryObject> GetAsync(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder.DirectoryObjectItemRequestBuilderGetQueryParameters>> requestConfiguration = default, CancellationToken cancellationToken = default)
        {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>>
            {
                { "XXX", global::NoBackingStore.Graph.Models.ODataErrors.ODataError.CreateFromDiscriminatorValue },
            };
            return await RequestAdapter.SendAsync<global::NoBackingStore.Graph.Models.DirectoryObject>(requestInfo, global::NoBackingStore.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// The groups, including nested groups, and directory roles that a user is a member of. Nullable.
        /// </summary>
        /// <returns>A <see cref="RequestInformation"/></returns>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder.DirectoryObjectItemRequestBuilderGetQueryParameters>>? requestConfiguration = default)
        {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RequestConfiguration<global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder.DirectoryObjectItemRequestBuilderGetQueryParameters>> requestConfiguration = default)
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
        /// <returns>A <see cref="global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder"/></returns>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder WithUrl(string rawUrl)
        {
            return new global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// The groups, including nested groups, and directory roles that a user is a member of. Nullable.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DirectoryObjectItemRequestBuilderGetQueryParameters 
        {
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
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        [Obsolete("This class is deprecated. Please use the generic RequestConfiguration class generated by the generator.")]
        [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
        public partial class DirectoryObjectItemRequestBuilderGetRequestConfiguration : RequestConfiguration<global::NoBackingStore.Graph.Users.Item.TransitiveMemberOf.Item.DirectoryObjectItemRequestBuilder.DirectoryObjectItemRequestBuilderGetQueryParameters>
        {
        }
    }
}
#pragma warning restore CS0618
