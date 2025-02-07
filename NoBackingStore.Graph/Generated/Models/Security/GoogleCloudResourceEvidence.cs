// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace NoBackingStore.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class GoogleCloudResourceEvidence : global::NoBackingStore.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The fullResourceName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FullResourceName { get; set; }
#nullable restore
#else
        public string FullResourceName { get; set; }
#endif
        /// <summary>The zone or region where the resource is located.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Location { get; set; }
#nullable restore
#else
        public string Location { get; set; }
#endif
        /// <summary>The type of location. Possible values are: unknown, regional, zonal, global, unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.Security.GoogleCloudLocationType? LocationType { get; set; }
        /// <summary>The Google project ID as defined by the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProjectId { get; set; }
#nullable restore
#else
        public string ProjectId { get; set; }
#endif
        /// <summary>The project number assigned by Google.</summary>
        public long? ProjectNumber { get; set; }
        /// <summary>The name of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceName { get; set; }
#nullable restore
#else
        public string ResourceName { get; set; }
#endif
        /// <summary>The type of the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceType { get; set; }
#nullable restore
#else
        public string ResourceType { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.Security.GoogleCloudResourceEvidence"/> and sets the default values.
        /// </summary>
        public GoogleCloudResourceEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.googleCloudResourceEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.Security.GoogleCloudResourceEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.Security.GoogleCloudResourceEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.Security.GoogleCloudResourceEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "fullResourceName", n => { FullResourceName = n.GetStringValue(); } },
                { "location", n => { Location = n.GetStringValue(); } },
                { "locationType", n => { LocationType = n.GetEnumValue<global::NoBackingStore.Graph.Models.Security.GoogleCloudLocationType>(); } },
                { "projectId", n => { ProjectId = n.GetStringValue(); } },
                { "projectNumber", n => { ProjectNumber = n.GetLongValue(); } },
                { "resourceName", n => { ResourceName = n.GetStringValue(); } },
                { "resourceType", n => { ResourceType = n.GetStringValue(); } },
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
            writer.WriteStringValue("fullResourceName", FullResourceName);
            writer.WriteStringValue("location", Location);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.Security.GoogleCloudLocationType>("locationType", LocationType);
            writer.WriteStringValue("projectId", ProjectId);
            writer.WriteLongValue("projectNumber", ProjectNumber);
            writer.WriteStringValue("resourceName", ResourceName);
            writer.WriteStringValue("resourceType", ResourceType);
        }
    }
}
#pragma warning restore CS0618
