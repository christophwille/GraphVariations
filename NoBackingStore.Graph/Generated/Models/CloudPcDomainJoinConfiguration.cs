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
    public partial class CloudPcDomainJoinConfiguration : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies the method by which the provisioned Cloud PC joins Microsoft Entra ID. If you choose the hybridAzureADJoin type, only provide a value for the onPremisesConnectionId property and leave the regionName property empty. If you choose the azureADJoin type, provide a value for either the onPremisesConnectionId or the regionName property. Possible values are: azureADJoin, hybridAzureADJoin, unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.CloudPcDomainJoinType? DomainJoinType { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The Azure network connection ID that matches the virtual network IT admins want the provisioning policy to use when they create Cloud PCs. You can use this property in both domain join types: Azure AD joined or Hybrid Microsoft Entra joined. If you enter an onPremisesConnectionId, leave the regionName property empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OnPremisesConnectionId { get; set; }
#nullable restore
#else
        public string OnPremisesConnectionId { get; set; }
#endif
        /// <summary>The logical geographic group this region belongs to. Multiple regions can belong to one region group. A customer can select a regionGroup when they provision a Cloud PC, and the Cloud PC is put in one of the regions in the group based on resource status. For example, the Europe region group contains the Northern Europe and Western Europe regions. Possible values are: default, australia, canada, usCentral, usEast, usWest, france, germany, europeUnion, unitedKingdom, japan, asia, india, southAmerica, euap, usGovernment, usGovernmentDOD, unknownFutureValue, norway, switzerland, southKorea. Use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: norway, switzerland, southKorea. Read-only.</summary>
        public global::NoBackingStore.Graph.Models.CloudPcRegionGroup? RegionGroup { get; set; }
        /// <summary>The supported Azure region where the IT admin wants the provisioning policy to create Cloud PCs. Within this region, the Windows 365 service creates and manages the underlying virtual network. This option is available only when the IT admin selects Microsoft Entra joined as the domain join type. If you enter a regionName, leave the onPremisesConnectionId property empty.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegionName { get; set; }
#nullable restore
#else
        public string RegionName { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.CloudPcDomainJoinConfiguration"/> and sets the default values.
        /// </summary>
        public CloudPcDomainJoinConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.CloudPcDomainJoinConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.CloudPcDomainJoinConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.CloudPcDomainJoinConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "domainJoinType", n => { DomainJoinType = n.GetEnumValue<global::NoBackingStore.Graph.Models.CloudPcDomainJoinType>(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "onPremisesConnectionId", n => { OnPremisesConnectionId = n.GetStringValue(); } },
                { "regionGroup", n => { RegionGroup = n.GetEnumValue<global::NoBackingStore.Graph.Models.CloudPcRegionGroup>(); } },
                { "regionName", n => { RegionName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.CloudPcDomainJoinType>("domainJoinType", DomainJoinType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("onPremisesConnectionId", OnPremisesConnectionId);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.CloudPcRegionGroup>("regionGroup", RegionGroup);
            writer.WriteStringValue("regionName", RegionName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
