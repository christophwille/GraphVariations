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
    public partial class ServiceUpdateMessage : global::NoBackingStore.Graph.Models.ServiceAnnouncementBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The expected deadline of the action for the message.</summary>
        public DateTimeOffset? ActionRequiredByDateTime { get; set; }
        /// <summary>A collection of serviceAnnouncementAttachments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ServiceAnnouncementAttachment>? Attachments { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ServiceAnnouncementAttachment> Attachments { get; set; }
#endif
        /// <summary>The zip file that contains all attachments for a message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? AttachmentsArchive { get; set; }
#nullable restore
#else
        public byte[] AttachmentsArchive { get; set; }
#endif
        /// <summary>The body property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ItemBody? Body { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ItemBody Body { get; set; }
#endif
        /// <summary>The category property</summary>
        public global::NoBackingStore.Graph.Models.ServiceUpdateCategory? Category { get; set; }
        /// <summary>Indicates whether the message has any attachment.</summary>
        public bool? HasAttachments { get; set; }
        /// <summary>Indicates whether the message describes a major update for the service.</summary>
        public bool? IsMajorChange { get; set; }
        /// <summary>The affected services by the service message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Services { get; set; }
#nullable restore
#else
        public List<string> Services { get; set; }
#endif
        /// <summary>The severity property</summary>
        public global::NoBackingStore.Graph.Models.ServiceUpdateSeverity? Severity { get; set; }
        /// <summary>A collection of tags for the service message. Tags are provided by the service team/support team who post the message to tell whether this message contains privacy data, or whether this message is for a service new feature update, and so on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>Represents user viewpoints data of the service message. This data includes message status such as whether the user has archived, read, or marked the message as favorite. This property is null when accessed with application permissions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ServiceUpdateMessageViewpoint? ViewPoint { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ServiceUpdateMessageViewpoint ViewPoint { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.ServiceUpdateMessage"/> and sets the default values.
        /// </summary>
        public ServiceUpdateMessage() : base()
        {
            OdataType = "#microsoft.graph.serviceUpdateMessage";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.ServiceUpdateMessage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.ServiceUpdateMessage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.ServiceUpdateMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "actionRequiredByDateTime", n => { ActionRequiredByDateTime = n.GetDateTimeOffsetValue(); } },
                { "attachments", n => { Attachments = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ServiceAnnouncementAttachment>(global::NoBackingStore.Graph.Models.ServiceAnnouncementAttachment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "attachmentsArchive", n => { AttachmentsArchive = n.GetByteArrayValue(); } },
                { "body", n => { Body = n.GetObjectValue<global::NoBackingStore.Graph.Models.ItemBody>(global::NoBackingStore.Graph.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "category", n => { Category = n.GetEnumValue<global::NoBackingStore.Graph.Models.ServiceUpdateCategory>(); } },
                { "hasAttachments", n => { HasAttachments = n.GetBoolValue(); } },
                { "isMajorChange", n => { IsMajorChange = n.GetBoolValue(); } },
                { "services", n => { Services = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "severity", n => { Severity = n.GetEnumValue<global::NoBackingStore.Graph.Models.ServiceUpdateSeverity>(); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "viewPoint", n => { ViewPoint = n.GetObjectValue<global::NoBackingStore.Graph.Models.ServiceUpdateMessageViewpoint>(global::NoBackingStore.Graph.Models.ServiceUpdateMessageViewpoint.CreateFromDiscriminatorValue); } },
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
            writer.WriteDateTimeOffsetValue("actionRequiredByDateTime", ActionRequiredByDateTime);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ServiceAnnouncementAttachment>("attachments", Attachments);
            writer.WriteByteArrayValue("attachmentsArchive", AttachmentsArchive);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ItemBody>("body", Body);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ServiceUpdateCategory>("category", Category);
            writer.WriteBoolValue("hasAttachments", HasAttachments);
            writer.WriteBoolValue("isMajorChange", IsMajorChange);
            writer.WriteCollectionOfPrimitiveValues<string>("services", Services);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ServiceUpdateSeverity>("severity", Severity);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ServiceUpdateMessageViewpoint>("viewPoint", ViewPoint);
        }
    }
}
#pragma warning restore CS0618
