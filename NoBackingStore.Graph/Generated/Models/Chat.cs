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
    public partial class Chat : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The chatType property</summary>
        public global::NoBackingStore.Graph.Models.ChatType? ChatType { get; set; }
        /// <summary>Date and time at which the chat was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>A collection of all the apps in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.TeamsAppInstallation>? InstalledApps { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.TeamsAppInstallation> InstalledApps { get; set; }
#endif
        /// <summary>Indicates whether the chat is hidden for all its members. Read-only.</summary>
        public bool? IsHiddenForAllMembers { get; set; }
        /// <summary>Preview of the last message sent in the chat. Null if no messages were sent in the chat. Currently, only the list chats operation supports this property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ChatMessageInfo? LastMessagePreview { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ChatMessageInfo LastMessagePreview { get; set; }
#endif
        /// <summary>Date and time at which the chat was renamed or the list of members was last changed. Read-only.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>A collection of all the members in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ConversationMember>? Members { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ConversationMember> Members { get; set; }
#endif
        /// <summary>A collection of all the messages in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ChatMessage>? Messages { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ChatMessage> Messages { get; set; }
#endif
        /// <summary>Represents details about an online meeting. If the chat isn&apos;t associated with an online meeting, the property is empty. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.TeamworkOnlineMeetingInfo? OnlineMeetingInfo { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.TeamworkOnlineMeetingInfo OnlineMeetingInfo { get; set; }
#endif
        /// <summary>A collection of permissions granted to apps for the chat.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ResourceSpecificPermissionGrant>? PermissionGrants { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ResourceSpecificPermissionGrant> PermissionGrants { get; set; }
#endif
        /// <summary>A collection of all the pinned messages in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PinnedChatMessageInfo>? PinnedMessages { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PinnedChatMessageInfo> PinnedMessages { get; set; }
#endif
        /// <summary>A collection of all the tabs in the chat. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.TeamsTab>? Tabs { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.TeamsTab> Tabs { get; set; }
#endif
        /// <summary>The identifier of the tenant in which the chat was created. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>(Optional) Subject or topic for the chat. Only available for group chats.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Topic { get; set; }
#nullable restore
#else
        public string Topic { get; set; }
#endif
        /// <summary>Represents caller-specific information about the chat, such as the last message read date and time. This property is populated only when the request is made in a delegated context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ChatViewpoint? Viewpoint { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ChatViewpoint Viewpoint { get; set; }
#endif
        /// <summary>The URL for the chat in Microsoft Teams. The URL should be treated as an opaque blob, and not parsed. Read-only.</summary>
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
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.Chat"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.Chat CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.Chat();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "chatType", n => { ChatType = n.GetEnumValue<global::NoBackingStore.Graph.Models.ChatType>(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "installedApps", n => { InstalledApps = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.TeamsAppInstallation>(global::NoBackingStore.Graph.Models.TeamsAppInstallation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isHiddenForAllMembers", n => { IsHiddenForAllMembers = n.GetBoolValue(); } },
                { "lastMessagePreview", n => { LastMessagePreview = n.GetObjectValue<global::NoBackingStore.Graph.Models.ChatMessageInfo>(global::NoBackingStore.Graph.Models.ChatMessageInfo.CreateFromDiscriminatorValue); } },
                { "lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "members", n => { Members = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ConversationMember>(global::NoBackingStore.Graph.Models.ConversationMember.CreateFromDiscriminatorValue)?.AsList(); } },
                { "messages", n => { Messages = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessage>(global::NoBackingStore.Graph.Models.ChatMessage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "onlineMeetingInfo", n => { OnlineMeetingInfo = n.GetObjectValue<global::NoBackingStore.Graph.Models.TeamworkOnlineMeetingInfo>(global::NoBackingStore.Graph.Models.TeamworkOnlineMeetingInfo.CreateFromDiscriminatorValue); } },
                { "permissionGrants", n => { PermissionGrants = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ResourceSpecificPermissionGrant>(global::NoBackingStore.Graph.Models.ResourceSpecificPermissionGrant.CreateFromDiscriminatorValue)?.AsList(); } },
                { "pinnedMessages", n => { PinnedMessages = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PinnedChatMessageInfo>(global::NoBackingStore.Graph.Models.PinnedChatMessageInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tabs", n => { Tabs = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.TeamsTab>(global::NoBackingStore.Graph.Models.TeamsTab.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
                { "topic", n => { Topic = n.GetStringValue(); } },
                { "viewpoint", n => { Viewpoint = n.GetObjectValue<global::NoBackingStore.Graph.Models.ChatViewpoint>(global::NoBackingStore.Graph.Models.ChatViewpoint.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ChatType>("chatType", ChatType);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.TeamsAppInstallation>("installedApps", InstalledApps);
            writer.WriteBoolValue("isHiddenForAllMembers", IsHiddenForAllMembers);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ChatMessageInfo>("lastMessagePreview", LastMessagePreview);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ConversationMember>("members", Members);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ChatMessage>("messages", Messages);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.TeamworkOnlineMeetingInfo>("onlineMeetingInfo", OnlineMeetingInfo);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ResourceSpecificPermissionGrant>("permissionGrants", PermissionGrants);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PinnedChatMessageInfo>("pinnedMessages", PinnedMessages);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.TeamsTab>("tabs", Tabs);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("topic", Topic);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ChatViewpoint>("viewpoint", Viewpoint);
            writer.WriteStringValue("webUrl", WebUrl);
        }
    }
}
#pragma warning restore CS0618
