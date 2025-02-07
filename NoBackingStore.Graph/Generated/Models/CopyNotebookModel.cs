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
    public partial class CopyNotebookModel : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The createdBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreatedBy { get; set; }
#nullable restore
#else
        public string CreatedBy { get; set; }
#endif
        /// <summary>The createdByIdentity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentitySet? CreatedByIdentity { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentitySet CreatedByIdentity { get; set; }
#endif
        /// <summary>The createdTime property</summary>
        public DateTimeOffset? CreatedTime { get; set; }
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The isDefault property</summary>
        public bool? IsDefault { get; set; }
        /// <summary>The isShared property</summary>
        public bool? IsShared { get; set; }
        /// <summary>The lastModifiedBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedBy { get; set; }
#nullable restore
#else
        public string LastModifiedBy { get; set; }
#endif
        /// <summary>The lastModifiedByIdentity property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentitySet? LastModifiedByIdentity { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentitySet LastModifiedByIdentity { get; set; }
#endif
        /// <summary>The lastModifiedTime property</summary>
        public DateTimeOffset? LastModifiedTime { get; set; }
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.NotebookLinks? Links { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.NotebookLinks Links { get; set; }
#endif
        /// <summary>The name property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The sectionGroupsUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SectionGroupsUrl { get; set; }
#nullable restore
#else
        public string SectionGroupsUrl { get; set; }
#endif
        /// <summary>The sectionsUrl property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SectionsUrl { get; set; }
#nullable restore
#else
        public string SectionsUrl { get; set; }
#endif
        /// <summary>The self property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; set; }
#nullable restore
#else
        public string Self { get; set; }
#endif
        /// <summary>The userRole property</summary>
        public global::NoBackingStore.Graph.Models.OnenoteUserRole? UserRole { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.CopyNotebookModel"/> and sets the default values.
        /// </summary>
        public CopyNotebookModel()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.CopyNotebookModel"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.CopyNotebookModel CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.CopyNotebookModel();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "createdBy", n => { CreatedBy = n.GetStringValue(); } },
                { "createdByIdentity", n => { CreatedByIdentity = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>(global::NoBackingStore.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdTime", n => { CreatedTime = n.GetDateTimeOffsetValue(); } },
                { "id", n => { Id = n.GetStringValue(); } },
                { "isDefault", n => { IsDefault = n.GetBoolValue(); } },
                { "isShared", n => { IsShared = n.GetBoolValue(); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetStringValue(); } },
                { "lastModifiedByIdentity", n => { LastModifiedByIdentity = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>(global::NoBackingStore.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedTime", n => { LastModifiedTime = n.GetDateTimeOffsetValue(); } },
                { "links", n => { Links = n.GetObjectValue<global::NoBackingStore.Graph.Models.NotebookLinks>(global::NoBackingStore.Graph.Models.NotebookLinks.CreateFromDiscriminatorValue); } },
                { "name", n => { Name = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "sectionGroupsUrl", n => { SectionGroupsUrl = n.GetStringValue(); } },
                { "sectionsUrl", n => { SectionsUrl = n.GetStringValue(); } },
                { "self", n => { Self = n.GetStringValue(); } },
                { "userRole", n => { UserRole = n.GetEnumValue<global::NoBackingStore.Graph.Models.OnenoteUserRole>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("createdBy", CreatedBy);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>("createdByIdentity", CreatedByIdentity);
            writer.WriteDateTimeOffsetValue("createdTime", CreatedTime);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteStringValue("lastModifiedBy", LastModifiedBy);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>("lastModifiedByIdentity", LastModifiedByIdentity);
            writer.WriteDateTimeOffsetValue("lastModifiedTime", LastModifiedTime);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.NotebookLinks>("links", Links);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("sectionGroupsUrl", SectionGroupsUrl);
            writer.WriteStringValue("sectionsUrl", SectionsUrl);
            writer.WriteStringValue("self", Self);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.OnenoteUserRole>("userRole", UserRole);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
