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
    public partial class MessageRule : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Actions to be taken on a message when the corresponding conditions are fulfilled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.MessageRuleActions? Actions { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.MessageRuleActions Actions { get; set; }
#endif
        /// <summary>Conditions that when fulfilled trigger the corresponding actions for that rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.MessageRulePredicates? Conditions { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.MessageRulePredicates Conditions { get; set; }
#endif
        /// <summary>The display name of the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Exception conditions for the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.MessageRulePredicates? Exceptions { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.MessageRulePredicates Exceptions { get; set; }
#endif
        /// <summary>Indicates whether the rule is in an error condition. Read-only.</summary>
        public bool? HasError { get; set; }
        /// <summary>Indicates whether the rule is enabled to be applied to messages.</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>Indicates if the rule is read-only and cannot be modified or deleted by the rules REST API.</summary>
        public bool? IsReadOnly { get; set; }
        /// <summary>Indicates the order in which the rule is executed, among other rules.</summary>
        public int? Sequence { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.MessageRule"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.MessageRule CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.MessageRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actions", n => { Actions = n.GetObjectValue<global::NoBackingStore.Graph.Models.MessageRuleActions>(global::NoBackingStore.Graph.Models.MessageRuleActions.CreateFromDiscriminatorValue); } },
                { "conditions", n => { Conditions = n.GetObjectValue<global::NoBackingStore.Graph.Models.MessageRulePredicates>(global::NoBackingStore.Graph.Models.MessageRulePredicates.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "exceptions", n => { Exceptions = n.GetObjectValue<global::NoBackingStore.Graph.Models.MessageRulePredicates>(global::NoBackingStore.Graph.Models.MessageRulePredicates.CreateFromDiscriminatorValue); } },
                { "hasError", n => { HasError = n.GetBoolValue(); } },
                { "isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                { "isReadOnly", n => { IsReadOnly = n.GetBoolValue(); } },
                { "sequence", n => { Sequence = n.GetIntValue(); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.MessageRuleActions>("actions", Actions);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.MessageRulePredicates>("conditions", Conditions);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.MessageRulePredicates>("exceptions", Exceptions);
            writer.WriteBoolValue("hasError", HasError);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteBoolValue("isReadOnly", IsReadOnly);
            writer.WriteIntValue("sequence", Sequence);
        }
    }
}
#pragma warning restore CS0618
