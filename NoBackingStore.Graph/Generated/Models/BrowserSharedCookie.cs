// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace NoBackingStore.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class BrowserSharedCookie : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The comment for the shared cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Comment { get; set; }
#nullable restore
#else
        public string Comment { get; set; }
#endif
        /// <summary>The date and time when the shared cookie was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The date and time when the shared cookie was deleted.</summary>
        public DateTimeOffset? DeletedDateTime { get; set; }
        /// <summary>The name of the cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The history of modifications applied to the cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.BrowserSharedCookieHistory>? History { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.BrowserSharedCookieHistory> History { get; set; }
#endif
        /// <summary>Controls whether a cookie is a host-only or domain cookie.</summary>
        public bool? HostOnly { get; set; }
        /// <summary>The URL of the cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HostOrDomain { get; set; }
#nullable restore
#else
        public string HostOrDomain { get; set; }
#endif
        /// <summary>The user who last modified the cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentitySet? LastModifiedBy { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentitySet LastModifiedBy { get; set; }
#endif
        /// <summary>The date and time when the cookie was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The path of the cookie.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; set; }
#nullable restore
#else
        public string Path { get; set; }
#endif
        /// <summary>The sourceEnvironment property</summary>
        public global::NoBackingStore.Graph.Models.BrowserSharedCookieSourceEnvironment? SourceEnvironment { get; set; }
        /// <summary>The status property</summary>
        public global::NoBackingStore.Graph.Models.BrowserSharedCookieStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.BrowserSharedCookie"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.BrowserSharedCookie CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.BrowserSharedCookie();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "comment", n => { Comment = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "history", n => { History = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.BrowserSharedCookieHistory>(global::NoBackingStore.Graph.Models.BrowserSharedCookieHistory.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostOnly", n => { HostOnly = n.GetBoolValue(); } },
                { "hostOrDomain", n => { HostOrDomain = n.GetStringValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>(global::NoBackingStore.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "path", n => { Path = n.GetStringValue(); } },
                { "sourceEnvironment", n => { SourceEnvironment = n.GetEnumValue<global::NoBackingStore.Graph.Models.BrowserSharedCookieSourceEnvironment>(); } },
                { "status", n => { Status = n.GetEnumValue<global::NoBackingStore.Graph.Models.BrowserSharedCookieStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("comment", Comment);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.BrowserSharedCookieHistory>("history", History);
            writer.WriteBoolValue("hostOnly", HostOnly);
            writer.WriteStringValue("hostOrDomain", HostOrDomain);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("path", Path);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.BrowserSharedCookieSourceEnvironment>("sourceEnvironment", SourceEnvironment);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.BrowserSharedCookieStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
