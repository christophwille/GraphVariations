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
    public partial class IdentityProviderBase : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The display name of the identity provider.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.IdentityProviderBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.IdentityProviderBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.appleManagedIdentityProvider" => new global::NoBackingStore.Graph.Models.AppleManagedIdentityProvider(),
                "#microsoft.graph.builtInIdentityProvider" => new global::NoBackingStore.Graph.Models.BuiltInIdentityProvider(),
                "#microsoft.graph.internalDomainFederation" => new global::NoBackingStore.Graph.Models.InternalDomainFederation(),
                "#microsoft.graph.samlOrWsFedExternalDomainFederation" => new global::NoBackingStore.Graph.Models.SamlOrWsFedExternalDomainFederation(),
                "#microsoft.graph.samlOrWsFedProvider" => new global::NoBackingStore.Graph.Models.SamlOrWsFedProvider(),
                "#microsoft.graph.socialIdentityProvider" => new global::NoBackingStore.Graph.Models.SocialIdentityProvider(),
                _ => new global::NoBackingStore.Graph.Models.IdentityProviderBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
#pragma warning restore CS0618
