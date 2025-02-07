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
    public partial class EmailFileAssessmentRequest : global::NoBackingStore.Graph.Models.ThreatAssessmentRequest, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Base64 encoded .eml email file content. The file content can&apos;t fetch back because it isn&apos;t stored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContentData { get; set; }
#nullable restore
#else
        public string ContentData { get; set; }
#endif
        /// <summary>The reason for mail routed to its destination. Possible values are: none, mailFlowRule, safeSender, blockedSender, advancedSpamFiltering, domainAllowList, domainBlockList, notInAddressBook, firstTimeSender, autoPurgeToInbox, autoPurgeToJunk, autoPurgeToDeleted, outbound, notJunk, junk.</summary>
        public global::NoBackingStore.Graph.Models.MailDestinationRoutingReason? DestinationRoutingReason { get; set; }
        /// <summary>The mail recipient whose policies are used to assess the mail.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RecipientEmail { get; set; }
#nullable restore
#else
        public string RecipientEmail { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.EmailFileAssessmentRequest"/> and sets the default values.
        /// </summary>
        public EmailFileAssessmentRequest() : base()
        {
            OdataType = "#microsoft.graph.emailFileAssessmentRequest";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.EmailFileAssessmentRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.EmailFileAssessmentRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.EmailFileAssessmentRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "contentData", n => { ContentData = n.GetStringValue(); } },
                { "destinationRoutingReason", n => { DestinationRoutingReason = n.GetEnumValue<global::NoBackingStore.Graph.Models.MailDestinationRoutingReason>(); } },
                { "recipientEmail", n => { RecipientEmail = n.GetStringValue(); } },
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
            writer.WriteStringValue("contentData", ContentData);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.MailDestinationRoutingReason>("destinationRoutingReason", DestinationRoutingReason);
            writer.WriteStringValue("recipientEmail", RecipientEmail);
        }
    }
}
#pragma warning restore CS0618
