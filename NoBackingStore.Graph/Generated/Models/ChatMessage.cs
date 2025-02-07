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
    public partial class ChatMessage : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>References to attached objects like files, tabs, meetings etc.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ChatMessageAttachment>? Attachments { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ChatMessageAttachment> Attachments { get; set; }
#endif
        /// <summary>The body property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ItemBody? Body { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ItemBody Body { get; set; }
#endif
        /// <summary>If the message was sent in a channel, represents identity of the channel.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ChannelIdentity? ChannelIdentity { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ChannelIdentity ChannelIdentity { get; set; }
#endif
        /// <summary>If the message was sent in a chat, represents the identity of the chat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChatId { get; set; }
#nullable restore
#else
        public string ChatId { get; set; }
#endif
        /// <summary>Timestamp of when the chat message was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Read only. Timestamp at which the chat message was deleted, or null if not deleted.</summary>
        public DateTimeOffset? DeletedDateTime { get; set; }
        /// <summary>Read-only. Version number of the chat message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Etag { get; set; }
#nullable restore
#else
        public string Etag { get; set; }
#endif
        /// <summary>Read-only. If present, represents details of an event that happened in a chat, a channel, or a team, for example, adding new members. For event messages, the messageType property will be set to systemEventMessage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.EventMessageDetail? EventDetail { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.EventMessageDetail EventDetail { get; set; }
#endif
        /// <summary>Details of the sender of the chat message. Can only be set during migration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ChatMessageFromIdentitySet? From { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ChatMessageFromIdentitySet From { get; set; }
#endif
        /// <summary>Content in a message hosted by Microsoft Teams - for example, images or code snippets.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ChatMessageHostedContent>? HostedContents { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ChatMessageHostedContent> HostedContents { get; set; }
#endif
        /// <summary>The importance property</summary>
        public global::NoBackingStore.Graph.Models.ChatMessageImportance? Importance { get; set; }
        /// <summary>Read only. Timestamp when edits to the chat message were made. Triggers an &apos;Edited&apos; flag in the Teams UI. If no edits are made the value is null.</summary>
        public DateTimeOffset? LastEditedDateTime { get; set; }
        /// <summary>Read only. Timestamp when the chat message is created (initial setting) or modified, including when a reaction is added or removed.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>Locale of the chat message set by the client. Always set to en-us.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Locale { get; set; }
#nullable restore
#else
        public string Locale { get; set; }
#endif
        /// <summary>List of entities mentioned in the chat message. Supported entities are: user, bot, team, channel, chat, and tag.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ChatMessageMention>? Mentions { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ChatMessageMention> Mentions { get; set; }
#endif
        /// <summary>List of activity history of a message item, including modification time and actions, such as reactionAdded, reactionRemoved, or reaction changes, on the message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ChatMessageHistoryItem>? MessageHistory { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ChatMessageHistoryItem> MessageHistory { get; set; }
#endif
        /// <summary>The messageType property</summary>
        public global::NoBackingStore.Graph.Models.ChatMessageType? MessageType { get; set; }
        /// <summary>Defines the properties of a policy violation set by a data loss prevention (DLP) application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ChatMessagePolicyViolation? PolicyViolation { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ChatMessagePolicyViolation PolicyViolation { get; set; }
#endif
        /// <summary>Reactions for this chat message (for example, Like).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ChatMessageReaction>? Reactions { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ChatMessageReaction> Reactions { get; set; }
#endif
        /// <summary>Replies for a specified message. Supports $expand for channel messages.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ChatMessage>? Replies { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ChatMessage> Replies { get; set; }
#endif
        /// <summary>Read-only. ID of the parent chat message or root chat message of the thread. (Only applies to chat messages in channels, not chats.)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ReplyToId { get; set; }
#nullable restore
#else
        public string ReplyToId { get; set; }
#endif
        /// <summary>The subject of the chat message, in plaintext.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>Summary text of the chat message that could be used for push notifications and summary views or fall back views. Only applies to channel chat messages, not chat messages in a chat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Summary { get; set; }
#nullable restore
#else
        public string Summary { get; set; }
#endif
        /// <summary>Read-only. Link to the message in Microsoft Teams.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; set; }
#nullable restore
#else
        public string WebUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.ChatMessage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.ChatMessage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.ChatMessage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "attachments", n => { Attachments = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessageAttachment>(global::NoBackingStore.Graph.Models.ChatMessageAttachment.CreateFromDiscriminatorValue)?.AsList(); } },
                { "body", n => { Body = n.GetObjectValue<global::NoBackingStore.Graph.Models.ItemBody>(global::NoBackingStore.Graph.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "channelIdentity", n => { ChannelIdentity = n.GetObjectValue<global::NoBackingStore.Graph.Models.ChannelIdentity>(global::NoBackingStore.Graph.Models.ChannelIdentity.CreateFromDiscriminatorValue); } },
                { "chatId", n => { ChatId = n.GetStringValue(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "deletedDateTime", n => { DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "etag", n => { Etag = n.GetStringValue(); } },
                { "eventDetail", n => { EventDetail = n.GetObjectValue<global::NoBackingStore.Graph.Models.EventMessageDetail>(global::NoBackingStore.Graph.Models.EventMessageDetail.CreateFromDiscriminatorValue); } },
                { "from", n => { From = n.GetObjectValue<global::NoBackingStore.Graph.Models.ChatMessageFromIdentitySet>(global::NoBackingStore.Graph.Models.ChatMessageFromIdentitySet.CreateFromDiscriminatorValue); } },
                { "hostedContents", n => { HostedContents = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessageHostedContent>(global::NoBackingStore.Graph.Models.ChatMessageHostedContent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "importance", n => { Importance = n.GetEnumValue<global::NoBackingStore.Graph.Models.ChatMessageImportance>(); } },
                { "lastEditedDateTime", n => { LastEditedDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "locale", n => { Locale = n.GetStringValue(); } },
                { "mentions", n => { Mentions = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessageMention>(global::NoBackingStore.Graph.Models.ChatMessageMention.CreateFromDiscriminatorValue)?.AsList(); } },
                { "messageHistory", n => { MessageHistory = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessageHistoryItem>(global::NoBackingStore.Graph.Models.ChatMessageHistoryItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "messageType", n => { MessageType = n.GetEnumValue<global::NoBackingStore.Graph.Models.ChatMessageType>(); } },
                { "policyViolation", n => { PolicyViolation = n.GetObjectValue<global::NoBackingStore.Graph.Models.ChatMessagePolicyViolation>(global::NoBackingStore.Graph.Models.ChatMessagePolicyViolation.CreateFromDiscriminatorValue); } },
                { "reactions", n => { Reactions = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessageReaction>(global::NoBackingStore.Graph.Models.ChatMessageReaction.CreateFromDiscriminatorValue)?.AsList(); } },
                { "replies", n => { Replies = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessage>(global::NoBackingStore.Graph.Models.ChatMessage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "replyToId", n => { ReplyToId = n.GetStringValue(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
                { "summary", n => { Summary = n.GetStringValue(); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessageAttachment>("attachments", Attachments);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ItemBody>("body", Body);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ChannelIdentity>("channelIdentity", ChannelIdentity);
            writer.WriteStringValue("chatId", ChatId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteStringValue("etag", Etag);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.EventMessageDetail>("eventDetail", EventDetail);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ChatMessageFromIdentitySet>("from", From);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessageHostedContent>("hostedContents", HostedContents);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ChatMessageImportance>("importance", Importance);
            writer.WriteDateTimeOffsetValue("lastEditedDateTime", LastEditedDateTime);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("locale", Locale);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessageMention>("mentions", Mentions);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessageHistoryItem>("messageHistory", MessageHistory);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ChatMessageType>("messageType", MessageType);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ChatMessagePolicyViolation>("policyViolation", PolicyViolation);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessageReaction>("reactions", Reactions);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessage>("replies", Replies);
            writer.WriteStringValue("replyToId", ReplyToId);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("summary", Summary);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
#pragma warning restore CS0618
