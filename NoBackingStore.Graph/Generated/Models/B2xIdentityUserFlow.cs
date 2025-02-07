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
    public partial class B2xIdentityUserFlow : global::NoBackingStore.Graph.Models.IdentityUserFlow, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Configuration for enabling an API connector for use as part of the self-service sign-up user flow. You can only obtain the value of this object using Get userFlowApiConnectorConfiguration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.UserFlowApiConnectorConfiguration? ApiConnectorConfiguration { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.UserFlowApiConnectorConfiguration ApiConnectorConfiguration { get; set; }
#endif
        /// <summary>The identity providers included in the user flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.IdentityProvider>? IdentityProviders { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.IdentityProvider> IdentityProviders { get; set; }
#endif
        /// <summary>The languages supported for customization within the user flow. Language customization is enabled by default in self-service sign-up user flow. You can&apos;t create custom languages in self-service sign-up user flows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.UserFlowLanguageConfiguration>? Languages { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.UserFlowLanguageConfiguration> Languages { get; set; }
#endif
        /// <summary>The user attribute assignments included in the user flow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.IdentityUserFlowAttributeAssignment>? UserAttributeAssignments { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.IdentityUserFlowAttributeAssignment> UserAttributeAssignments { get; set; }
#endif
        /// <summary>The userFlowIdentityProviders property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.IdentityProviderBase>? UserFlowIdentityProviders { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.IdentityProviderBase> UserFlowIdentityProviders { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.B2xIdentityUserFlow"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.B2xIdentityUserFlow CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.B2xIdentityUserFlow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "apiConnectorConfiguration", n => { ApiConnectorConfiguration = n.GetObjectValue<global::NoBackingStore.Graph.Models.UserFlowApiConnectorConfiguration>(global::NoBackingStore.Graph.Models.UserFlowApiConnectorConfiguration.CreateFromDiscriminatorValue); } },
                { "identityProviders", n => { IdentityProviders = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityProvider>(global::NoBackingStore.Graph.Models.IdentityProvider.CreateFromDiscriminatorValue)?.AsList(); } },
                { "languages", n => { Languages = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.UserFlowLanguageConfiguration>(global::NoBackingStore.Graph.Models.UserFlowLanguageConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userAttributeAssignments", n => { UserAttributeAssignments = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityUserFlowAttributeAssignment>(global::NoBackingStore.Graph.Models.IdentityUserFlowAttributeAssignment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "userFlowIdentityProviders", n => { UserFlowIdentityProviders = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityProviderBase>(global::NoBackingStore.Graph.Models.IdentityProviderBase.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.UserFlowApiConnectorConfiguration>("apiConnectorConfiguration", ApiConnectorConfiguration);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityProvider>("identityProviders", IdentityProviders);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.UserFlowLanguageConfiguration>("languages", Languages);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityUserFlowAttributeAssignment>("userAttributeAssignments", UserAttributeAssignments);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityProviderBase>("userFlowIdentityProviders", UserFlowIdentityProviders);
        }
    }
}
#pragma warning restore CS0618
