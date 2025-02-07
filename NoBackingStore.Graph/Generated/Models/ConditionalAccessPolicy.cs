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
    public partial class ConditionalAccessPolicy : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The conditions property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ConditionalAccessConditionSet? Conditions { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ConditionalAccessConditionSet Conditions { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Readonly.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The description property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Specifies a display name for the conditionalAccessPolicy object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Specifies the grant controls that must be fulfilled to pass the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ConditionalAccessGrantControls? GrantControls { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ConditionalAccessGrantControls GrantControls { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Readonly.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>Specifies the session controls that are enforced after sign-in.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ConditionalAccessSessionControls? SessionControls { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ConditionalAccessSessionControls SessionControls { get; set; }
#endif
        /// <summary>The state property</summary>
        public global::NoBackingStore.Graph.Models.ConditionalAccessPolicyState? State { get; set; }
        /// <summary>The templateId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TemplateId { get; set; }
#nullable restore
#else
        public string TemplateId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.ConditionalAccessPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.ConditionalAccessPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.ConditionalAccessPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "conditions", n => { Conditions = n.GetObjectValue<global::NoBackingStore.Graph.Models.ConditionalAccessConditionSet>(global::NoBackingStore.Graph.Models.ConditionalAccessConditionSet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "grantControls", n => { GrantControls = n.GetObjectValue<global::NoBackingStore.Graph.Models.ConditionalAccessGrantControls>(global::NoBackingStore.Graph.Models.ConditionalAccessGrantControls.CreateFromDiscriminatorValue); } },
                { "modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "sessionControls", n => { SessionControls = n.GetObjectValue<global::NoBackingStore.Graph.Models.ConditionalAccessSessionControls>(global::NoBackingStore.Graph.Models.ConditionalAccessSessionControls.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<global::NoBackingStore.Graph.Models.ConditionalAccessPolicyState>(); } },
                { "templateId", n => { TemplateId = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ConditionalAccessConditionSet>("conditions", Conditions);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ConditionalAccessGrantControls>("grantControls", GrantControls);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ConditionalAccessSessionControls>("sessionControls", SessionControls);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ConditionalAccessPolicyState>("state", State);
            writer.WriteStringValue("templateId", TemplateId);
        }
    }
}
#pragma warning restore CS0618
