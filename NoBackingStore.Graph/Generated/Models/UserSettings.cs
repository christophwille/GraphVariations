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
    public partial class UserSettings : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Reflects the organization level setting controlling delegate access to the trending API. When set to true, the organization doesn&apos;t have access to Office Delve. The relevancy of the content displayed in Microsoft 365, for example in Suggested sites in SharePoint Home and the Discover view in OneDrive for work or school is affected for the whole organization. This setting is read-only and can only be changed by administrators in the SharePoint admin center.</summary>
        public bool? ContributionToContentDiscoveryAsOrganizationDisabled { get; set; }
        /// <summary>When set to true, the delegate access to the user&apos;s trending API is disabled. When set to true, documents in the user&apos;s Office Delve are disabled. When set to true, the relevancy of the content displayed in Microsoft 365, for example in Suggested sites in SharePoint Home and the Discover view in OneDrive for work or school is affected. Users can control this setting in Office Delve.</summary>
        public bool? ContributionToContentDiscoveryDisabled { get; set; }
        /// <summary>The user&apos;s settings for the visibility of meeting hour insights, and insights derived between a user and other items in Microsoft 365, such as documents or sites. Get userInsightsSettings through this navigation property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.UserInsightsSettings? ItemInsights { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.UserInsightsSettings ItemInsights { get; set; }
#endif
        /// <summary>The shiftPreferences property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ShiftPreferences? ShiftPreferences { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ShiftPreferences ShiftPreferences { get; set; }
#endif
        /// <summary>The storage property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.UserStorage? Storage { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.UserStorage Storage { get; set; }
#endif
        /// <summary>The windows property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.WindowsSetting>? Windows { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.WindowsSetting> Windows { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.UserSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.UserSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.UserSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "contributionToContentDiscoveryAsOrganizationDisabled", n => { ContributionToContentDiscoveryAsOrganizationDisabled = n.GetBoolValue(); } },
                { "contributionToContentDiscoveryDisabled", n => { ContributionToContentDiscoveryDisabled = n.GetBoolValue(); } },
                { "itemInsights", n => { ItemInsights = n.GetObjectValue<global::NoBackingStore.Graph.Models.UserInsightsSettings>(global::NoBackingStore.Graph.Models.UserInsightsSettings.CreateFromDiscriminatorValue); } },
                { "shiftPreferences", n => { ShiftPreferences = n.GetObjectValue<global::NoBackingStore.Graph.Models.ShiftPreferences>(global::NoBackingStore.Graph.Models.ShiftPreferences.CreateFromDiscriminatorValue); } },
                { "storage", n => { Storage = n.GetObjectValue<global::NoBackingStore.Graph.Models.UserStorage>(global::NoBackingStore.Graph.Models.UserStorage.CreateFromDiscriminatorValue); } },
                { "windows", n => { Windows = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.WindowsSetting>(global::NoBackingStore.Graph.Models.WindowsSetting.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteBoolValue("contributionToContentDiscoveryAsOrganizationDisabled", ContributionToContentDiscoveryAsOrganizationDisabled);
            writer.WriteBoolValue("contributionToContentDiscoveryDisabled", ContributionToContentDiscoveryDisabled);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.UserInsightsSettings>("itemInsights", ItemInsights);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ShiftPreferences>("shiftPreferences", ShiftPreferences);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.UserStorage>("storage", Storage);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.WindowsSetting>("windows", Windows);
        }
    }
}
#pragma warning restore CS0618
