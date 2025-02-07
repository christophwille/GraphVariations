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
    public partial class ChannelDescriptionUpdatedEventMessageDetail : global::NoBackingStore.Graph.Models.EventMessageDetail, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The updated description of the channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChannelDescription { get; set; }
#nullable restore
#else
        public string ChannelDescription { get; set; }
#endif
        /// <summary>Unique identifier of the channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChannelId { get; set; }
#nullable restore
#else
        public string ChannelId { get; set; }
#endif
        /// <summary>Initiator of the event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentitySet? Initiator { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentitySet Initiator { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.ChannelDescriptionUpdatedEventMessageDetail"/> and sets the default values.
        /// </summary>
        public ChannelDescriptionUpdatedEventMessageDetail() : base()
        {
            OdataType = "#microsoft.graph.channelDescriptionUpdatedEventMessageDetail";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.ChannelDescriptionUpdatedEventMessageDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.ChannelDescriptionUpdatedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.ChannelDescriptionUpdatedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "channelDescription", n => { ChannelDescription = n.GetStringValue(); } },
                { "channelId", n => { ChannelId = n.GetStringValue(); } },
                { "initiator", n => { Initiator = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>(global::NoBackingStore.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
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
            writer.WriteStringValue("channelDescription", ChannelDescription);
            writer.WriteStringValue("channelId", ChannelId);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>("initiator", Initiator);
        }
    }
}
#pragma warning restore CS0618
