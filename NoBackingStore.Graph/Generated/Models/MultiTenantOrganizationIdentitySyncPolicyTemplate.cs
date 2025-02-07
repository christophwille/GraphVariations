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
    public partial class MultiTenantOrganizationIdentitySyncPolicyTemplate : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The templateApplicationLevel property</summary>
        public global::NoBackingStore.Graph.Models.TemplateApplicationLevel? TemplateApplicationLevel { get; set; }
        /// <summary>Defines whether users can be synchronized from the partner tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.CrossTenantUserSyncInbound? UserSyncInbound { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.CrossTenantUserSyncInbound UserSyncInbound { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.MultiTenantOrganizationIdentitySyncPolicyTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "templateApplicationLevel", n => { TemplateApplicationLevel = n.GetEnumValue<global::NoBackingStore.Graph.Models.TemplateApplicationLevel>(); } },
                { "userSyncInbound", n => { UserSyncInbound = n.GetObjectValue<global::NoBackingStore.Graph.Models.CrossTenantUserSyncInbound>(global::NoBackingStore.Graph.Models.CrossTenantUserSyncInbound.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.TemplateApplicationLevel>("templateApplicationLevel", TemplateApplicationLevel);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.CrossTenantUserSyncInbound>("userSyncInbound", UserSyncInbound);
        }
    }
}
#pragma warning restore CS0618
