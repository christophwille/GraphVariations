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
    public partial class CrossTenantAccessPolicy : global::NoBackingStore.Graph.Models.PolicyBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Used to specify which Microsoft clouds an organization would like to collaborate with. By default, this value is empty. Supported values for this field are: microsoftonline.com, microsoftonline.us, and partner.microsoftonline.cn.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedCloudEndpoints { get; set; }
#nullable restore
#else
        public List<string> AllowedCloudEndpoints { get; set; }
#endif
        /// <summary>Defines the default configuration for how your organization interacts with external Microsoft Entra organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyConfigurationDefault? Default { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyConfigurationDefault Default { get; set; }
#endif
        /// <summary>Defines partner-specific configurations for external Microsoft Entra organizations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyConfigurationPartner>? Partners { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyConfigurationPartner> Partners { get; set; }
#endif
        /// <summary>Represents the base policy in the directory for multitenant organization settings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PolicyTemplate? Templates { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PolicyTemplate Templates { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.CrossTenantAccessPolicy"/> and sets the default values.
        /// </summary>
        public CrossTenantAccessPolicy() : base()
        {
            OdataType = "#microsoft.graph.crossTenantAccessPolicy";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.CrossTenantAccessPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.CrossTenantAccessPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.CrossTenantAccessPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowedCloudEndpoints", n => { AllowedCloudEndpoints = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "default", n => { Default = n.GetObjectValue<global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyConfigurationDefault>(global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyConfigurationDefault.CreateFromDiscriminatorValue); } },
                { "partners", n => { Partners = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyConfigurationPartner>(global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyConfigurationPartner.CreateFromDiscriminatorValue)?.AsList(); } },
                { "templates", n => { Templates = n.GetObjectValue<global::NoBackingStore.Graph.Models.PolicyTemplate>(global::NoBackingStore.Graph.Models.PolicyTemplate.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("allowedCloudEndpoints", AllowedCloudEndpoints);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyConfigurationDefault>("default", Default);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.CrossTenantAccessPolicyConfigurationPartner>("partners", Partners);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PolicyTemplate>("templates", Templates);
        }
    }
}
#pragma warning restore CS0618
