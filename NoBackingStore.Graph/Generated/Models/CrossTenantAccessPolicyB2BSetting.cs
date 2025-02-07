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
    public partial class CrossTenantAccessPolicyB2BSetting : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of applications targeted with your cross-tenant access policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyTargetConfiguration? Applications { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyTargetConfiguration Applications { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The list of users and groups targeted with your cross-tenant access policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyTargetConfiguration? UsersAndGroups { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyTargetConfiguration UsersAndGroups { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyB2BSetting"/> and sets the default values.
        /// </summary>
        public CrossTenantAccessPolicyB2BSetting()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyB2BSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyB2BSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.crossTenantAccessPolicyTenantRestrictions" => new global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyTenantRestrictions(),
                _ => new global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyB2BSetting(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "applications", n => { Applications = n.GetObjectValue<global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyTargetConfiguration>(global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyTargetConfiguration.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "usersAndGroups", n => { UsersAndGroups = n.GetObjectValue<global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyTargetConfiguration>(global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyTargetConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyTargetConfiguration>("applications", Applications);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyTargetConfiguration>("usersAndGroups", UsersAndGroups);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
