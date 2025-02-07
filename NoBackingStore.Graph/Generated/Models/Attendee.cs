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
    public partial class Attendee : global::NoBackingStore.Graph.Models.AttendeeBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>An alternate date/time proposed by the attendee for a meeting request to start and end. If the attendee hasn&apos;t proposed another time, then this property isn&apos;t included in a response of a GET event.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.TimeSlot? ProposedNewTime { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.TimeSlot ProposedNewTime { get; set; }
#endif
        /// <summary>The attendee&apos;s response (none, accepted, declined, etc.) for the event and date-time that the response was sent.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ResponseStatus? Status { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ResponseStatus Status { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.Attendee"/> and sets the default values.
        /// </summary>
        public Attendee() : base()
        {
            OdataType = "#microsoft.graph.attendee";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.Attendee"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.Attendee CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.Attendee();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "proposedNewTime", n => { ProposedNewTime = n.GetObjectValue<global::NoBackingStore.Graph.Models.TimeSlot>(global::NoBackingStore.Graph.Models.TimeSlot.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetObjectValue<global::NoBackingStore.Graph.Models.ResponseStatus>(global::NoBackingStore.Graph.Models.ResponseStatus.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.TimeSlot>("proposedNewTime", ProposedNewTime);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ResponseStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
