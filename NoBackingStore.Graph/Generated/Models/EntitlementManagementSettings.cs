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
    public partial class EntitlementManagementSettings : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>If externalUserLifecycleAction is blockSignInAndDelete, the duration, typically many days, after an external user is blocked from sign in before their account is deleted.</summary>
        public TimeSpan? DurationUntilExternalUserDeletedAfterBlocked { get; set; }
        /// <summary>Automatic action that the service should take when an external user&apos;s last access package assignment is removed. The possible values are: none, blockSignIn, blockSignInAndDelete, unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.AccessPackageExternalUserLifecycleAction? ExternalUserLifecycleAction { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.EntitlementManagementSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.EntitlementManagementSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.EntitlementManagementSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "durationUntilExternalUserDeletedAfterBlocked", n => { DurationUntilExternalUserDeletedAfterBlocked = n.GetTimeSpanValue(); } },
                { "externalUserLifecycleAction", n => { ExternalUserLifecycleAction = n.GetEnumValue<global::NoBackingStore.Graph.Models.AccessPackageExternalUserLifecycleAction>(); } },
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
            writer.WriteTimeSpanValue("durationUntilExternalUserDeletedAfterBlocked", DurationUntilExternalUserDeletedAfterBlocked);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.AccessPackageExternalUserLifecycleAction>("externalUserLifecycleAction", ExternalUserLifecycleAction);
        }
    }
}
#pragma warning restore CS0618
