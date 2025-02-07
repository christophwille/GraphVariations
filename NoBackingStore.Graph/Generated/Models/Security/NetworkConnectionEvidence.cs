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
    public partial class NetworkConnectionEvidence : global::NoBackingStore.Graph.Models.Security.AlertEvidence, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The destinationAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.Security.IpEvidence? DestinationAddress { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.Security.IpEvidence DestinationAddress { get; set; }
#endif
        /// <summary>The destinationPort property</summary>
        public int? DestinationPort { get; set; }
        /// <summary>The protocol property</summary>
        public global::NoBackingStore.Graph.Models.Security.ProtocolType? Protocol { get; set; }
        /// <summary>The sourceAddress property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.Security.IpEvidence? SourceAddress { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.Security.IpEvidence SourceAddress { get; set; }
#endif
        /// <summary>The sourcePort property</summary>
        public int? SourcePort { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.Security.NetworkConnectionEvidence"/> and sets the default values.
        /// </summary>
        public NetworkConnectionEvidence() : base()
        {
            OdataType = "#microsoft.graph.security.networkConnectionEvidence";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.Security.NetworkConnectionEvidence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.Security.NetworkConnectionEvidence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.Security.NetworkConnectionEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "destinationAddress", n => { DestinationAddress = n.GetObjectValue<global::NoBackingStore.Graph.Models.Security.IpEvidence>(global::NoBackingStore.Graph.Models.Security.IpEvidence.CreateFromDiscriminatorValue); } },
                { "destinationPort", n => { DestinationPort = n.GetIntValue(); } },
                { "protocol", n => { Protocol = n.GetEnumValue<global::NoBackingStore.Graph.Models.Security.ProtocolType>(); } },
                { "sourceAddress", n => { SourceAddress = n.GetObjectValue<global::NoBackingStore.Graph.Models.Security.IpEvidence>(global::NoBackingStore.Graph.Models.Security.IpEvidence.CreateFromDiscriminatorValue); } },
                { "sourcePort", n => { SourcePort = n.GetIntValue(); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.Security.IpEvidence>("destinationAddress", DestinationAddress);
            writer.WriteIntValue("destinationPort", DestinationPort);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.Security.ProtocolType>("protocol", Protocol);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.Security.IpEvidence>("sourceAddress", SourceAddress);
            writer.WriteIntValue("sourcePort", SourcePort);
        }
    }
}
#pragma warning restore CS0618
