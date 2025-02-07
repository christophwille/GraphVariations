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
    public partial class MailboxConfigurationEvidence : global::NoBackingStore.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The configurationId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConfigurationId { get; set; }
#nullable restore
#else
        public string ConfigurationId { get; set; }
#endif
        /// <summary>The configurationType property</summary>
        public global::NoBackingStore.Graph.Models.Security.MailboxConfigurationType? ConfigurationType { get; set; }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The externalDirectoryObjectId property</summary>
        public Guid? ExternalDirectoryObjectId { get; set; }
        /// <summary>The mailboxPrimaryAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MailboxPrimaryAddress { get; set; }
#nullable restore
#else
        public string MailboxPrimaryAddress { get; set; }
#endif
        /// <summary>The upn property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Upn { get; set; }
#nullable restore
#else
        public string Upn { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.Security.MailboxConfigurationEvidence"/> and sets the default values.
        /// </summary>
        public MailboxConfigurationEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.mailboxConfigurationEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.Security.MailboxConfigurationEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.Security.MailboxConfigurationEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.Security.MailboxConfigurationEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configurationId", n => { ConfigurationId = n.GetStringValue(); } },
                { "configurationType", n => { ConfigurationType = n.GetEnumValue<global::NoBackingStore.Graph.Models.Security.MailboxConfigurationType>(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "externalDirectoryObjectId", n => { ExternalDirectoryObjectId = n.GetGuidValue(); } },
                { "mailboxPrimaryAddress", n => { MailboxPrimaryAddress = n.GetStringValue(); } },
                { "upn", n => { Upn = n.GetStringValue(); } },
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
            writer.WriteStringValue("configurationId", ConfigurationId);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.Security.MailboxConfigurationType>("configurationType", ConfigurationType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteGuidValue("externalDirectoryObjectId", ExternalDirectoryObjectId);
            writer.WriteStringValue("mailboxPrimaryAddress", MailboxPrimaryAddress);
            writer.WriteStringValue("upn", Upn);
        }
    }
}
#pragma warning restore CS0618
