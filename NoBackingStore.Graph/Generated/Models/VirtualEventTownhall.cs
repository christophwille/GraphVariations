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
    public partial class VirtualEventTownhall : global::NoBackingStore.Graph.Models.VirtualEvent, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The audience to whom the town hall is visible. Possible values are: everyone, organization, and unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.MeetingAudience? Audience { get; set; }
        /// <summary>Identity information of the coorganizers of the town hall.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.CommunicationsUserIdentity>? CoOrganizers { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.CommunicationsUserIdentity> CoOrganizers { get; set; }
#endif
        /// <summary>The attendees invited to the town hall. The supported identities are: communicationsUserIdentity and communicationsGuestIdentity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Identity>? InvitedAttendees { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Identity> InvitedAttendees { get; set; }
#endif
        /// <summary>Indicates whether the town hall is only open to invited people and groups within your organization. The isInviteOnly property can only be true if the value of the audience property is set to organization.</summary>
        public bool? IsInviteOnly { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.VirtualEventTownhall"/> and sets the default values.
        /// </summary>
        public VirtualEventTownhall() : base()
        {
            OdataType = "#microsoft.graph.virtualEventTownhall";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.VirtualEventTownhall"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.VirtualEventTownhall CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.VirtualEventTownhall();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "audience", n => { Audience = n.GetEnumValue<global::NoBackingStore.Graph.Models.MeetingAudience>(); } },
                { "coOrganizers", n => { CoOrganizers = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.CommunicationsUserIdentity>(global::NoBackingStore.Graph.Models.CommunicationsUserIdentity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "invitedAttendees", n => { InvitedAttendees = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Identity>(global::NoBackingStore.Graph.Models.Identity.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isInviteOnly", n => { IsInviteOnly = n.GetBoolValue(); } },
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
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.MeetingAudience>("audience", Audience);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.CommunicationsUserIdentity>("coOrganizers", CoOrganizers);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Identity>("invitedAttendees", InvitedAttendees);
            writer.WriteBoolValue("isInviteOnly", IsInviteOnly);
        }
    }
}
#pragma warning restore CS0618
