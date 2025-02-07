// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace NoBackingStore.Graph.Models
{
    /// <summary>
    /// Represents a community in Viva Engage that is a central place for conversations,files, events, and updates for people sharing a common interest or goal.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class Community : global::NoBackingStore.Graph.Models.Entity, IParsable
    {
        /// <summary>The description of the community. The maximum length is 1,024 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The name of the community. The maximum length is 255 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The Microsoft 365 group that manages the membership of this community.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.Group? Group { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.Group Group { get; set; }
#endif
        /// <summary>The ID of the Microsoft 365 group that manages the membership of this community.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupId { get; set; }
#nullable restore
#else
        public string GroupId { get; set; }
#endif
        /// <summary>The admins of the community. Limited to 100 users. If this property isn&apos;t specified when you create the community, the calling user is automatically assigned as the community owner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.User>? Owners { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.User> Owners { get; set; }
#endif
        /// <summary>Types of communityPrivacy.</summary>
        public global::NoBackingStore.Graph.Models.CommunityPrivacy? Privacy { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.Community"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.Community CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.Community();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "group", n => { Group = n.GetObjectValue<global::NoBackingStore.Graph.Models.Group>(global::NoBackingStore.Graph.Models.Group.CreateFromDiscriminatorValue); } },
                { "groupId", n => { GroupId = n.GetStringValue(); } },
                { "owners", n => { Owners = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.User>(global::NoBackingStore.Graph.Models.User.CreateFromDiscriminatorValue)?.AsList(); } },
                { "privacy", n => { Privacy = n.GetEnumValue<global::NoBackingStore.Graph.Models.CommunityPrivacy>(); } },
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
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.Group>("group", Group);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.User>("owners", Owners);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.CommunityPrivacy>("privacy", Privacy);
        }
    }
}
#pragma warning restore CS0618
