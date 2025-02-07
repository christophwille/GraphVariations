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
    public partial class AdministrativeUnit : global::NoBackingStore.Graph.Models.DirectoryObject, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>An optional description for the administrative unit. Supports $filter (eq, ne, in, startsWith), $search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Display name for the administrative unit. Maximum length is 256 characters. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The collection of open extensions defined for this administrative unit. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Extension>? Extensions { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Extension> Extensions { get; set; }
#endif
        /// <summary>The isMemberManagementRestricted property</summary>
        public bool? IsMemberManagementRestricted { get; set; }
        /// <summary>Users and groups that are members of this administrative unit. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.DirectoryObject>? Members { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.DirectoryObject> Members { get; set; }
#endif
        /// <summary>The dynamic membership rule for the administrative unit. For more information about the rules you can use for dynamic administrative units and dynamic groups, see Manage rules for dynamic membership groups in Microsoft Entra ID.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembershipRule { get; set; }
#nullable restore
#else
        public string MembershipRule { get; set; }
#endif
        /// <summary>Controls whether the dynamic membership rule is actively processed. Set to On to activate the dynamic membership rule, or Paused to stop updating membership dynamically.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembershipRuleProcessingState { get; set; }
#nullable restore
#else
        public string MembershipRuleProcessingState { get; set; }
#endif
        /// <summary>Indicates the membership type for the administrative unit. The possible values are: dynamic, assigned. If not set, the default value is null and the default behavior is assigned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MembershipType { get; set; }
#nullable restore
#else
        public string MembershipType { get; set; }
#endif
        /// <summary>Scoped-role members of this administrative unit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ScopedRoleMembership>? ScopedRoleMembers { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ScopedRoleMembership> ScopedRoleMembers { get; set; }
#endif
        /// <summary>Controls whether the administrative unit and its members are hidden or public. Can be set to HiddenMembership. If not set, the default value is null and the default behavior is public. When set to HiddenMembership, only members of the administrative unit can list other members of the administrative unit.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Visibility { get; set; }
#nullable restore
#else
        public string Visibility { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.AdministrativeUnit"/> and sets the default values.
        /// </summary>
        public AdministrativeUnit() : base()
        {
            OdataType = "#microsoft.graph.administrativeUnit";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.AdministrativeUnit"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.AdministrativeUnit CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.AdministrativeUnit();
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
                { "extensions", n => { Extensions = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Extension>(global::NoBackingStore.Graph.Models.Extension.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isMemberManagementRestricted", n => { IsMemberManagementRestricted = n.GetBoolValue(); } },
                { "members", n => { Members = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DirectoryObject>(global::NoBackingStore.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "membershipRule", n => { MembershipRule = n.GetStringValue(); } },
                { "membershipRuleProcessingState", n => { MembershipRuleProcessingState = n.GetStringValue(); } },
                { "membershipType", n => { MembershipType = n.GetStringValue(); } },
                { "scopedRoleMembers", n => { ScopedRoleMembers = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ScopedRoleMembership>(global::NoBackingStore.Graph.Models.ScopedRoleMembership.CreateFromDiscriminatorValue)?.AsList(); } },
                { "visibility", n => { Visibility = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Extension>("extensions", Extensions);
            writer.WriteBoolValue("isMemberManagementRestricted", IsMemberManagementRestricted);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DirectoryObject>("members", Members);
            writer.WriteStringValue("membershipRule", MembershipRule);
            writer.WriteStringValue("membershipRuleProcessingState", MembershipRuleProcessingState);
            writer.WriteStringValue("membershipType", MembershipType);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ScopedRoleMembership>("scopedRoleMembers", ScopedRoleMembers);
            writer.WriteStringValue("visibility", Visibility);
        }
    }
}
#pragma warning restore CS0618
