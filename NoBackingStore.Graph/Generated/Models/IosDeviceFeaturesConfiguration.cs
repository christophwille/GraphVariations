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
    /// iOS Device Features Configuration Profile.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IosDeviceFeaturesConfiguration : global::NoBackingStore.Graph.Models.AppleDeviceFeaturesConfigurationBase, IParsable
    {
        /// <summary>Asset tag information for the device, displayed on the login window and lock screen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssetTagTemplate { get; set; }
#nullable restore
#else
        public string AssetTagTemplate { get; set; }
#endif
        /// <summary>A list of app and folders to appear on the Home Screen Dock. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.IosHomeScreenItem>? HomeScreenDockIcons { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.IosHomeScreenItem> HomeScreenDockIcons { get; set; }
#endif
        /// <summary>A list of pages on the Home Screen. This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.IosHomeScreenPage>? HomeScreenPages { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.IosHomeScreenPage> HomeScreenPages { get; set; }
#endif
        /// <summary>A footnote displayed on the login window and lock screen. Available in iOS 9.3.1 and later.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LockScreenFootnote { get; set; }
#nullable restore
#else
        public string LockScreenFootnote { get; set; }
#endif
        /// <summary>Notification settings for each bundle id. Applicable to devices in supervised mode only (iOS 9.3 and later). This collection can contain a maximum of 500 elements.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.IosNotificationSettings>? NotificationSettings { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.IosNotificationSettings> NotificationSettings { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.IosDeviceFeaturesConfiguration"/> and sets the default values.
        /// </summary>
        public IosDeviceFeaturesConfiguration() : base()
        {
            OdataType = "#microsoft.graph.iosDeviceFeaturesConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.IosDeviceFeaturesConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.IosDeviceFeaturesConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.IosDeviceFeaturesConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assetTagTemplate", n => { AssetTagTemplate = n.GetStringValue(); } },
                { "homeScreenDockIcons", n => { HomeScreenDockIcons = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IosHomeScreenItem>(global::NoBackingStore.Graph.Models.IosHomeScreenItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "homeScreenPages", n => { HomeScreenPages = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IosHomeScreenPage>(global::NoBackingStore.Graph.Models.IosHomeScreenPage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lockScreenFootnote", n => { LockScreenFootnote = n.GetStringValue(); } },
                { "notificationSettings", n => { NotificationSettings = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IosNotificationSettings>(global::NoBackingStore.Graph.Models.IosNotificationSettings.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteStringValue("assetTagTemplate", AssetTagTemplate);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IosHomeScreenItem>("homeScreenDockIcons", HomeScreenDockIcons);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IosHomeScreenPage>("homeScreenPages", HomeScreenPages);
            writer.WriteStringValue("lockScreenFootnote", LockScreenFootnote);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IosNotificationSettings>("notificationSettings", NotificationSettings);
        }
    }
}
#pragma warning restore CS0618
