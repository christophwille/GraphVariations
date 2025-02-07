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
    /// Singleton entity that acts as a container for all device app management functionality.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class DeviceAppManagement : global::NoBackingStore.Graph.Models.Entity, IParsable
    {
        /// <summary>Android managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.AndroidManagedAppProtection>? AndroidManagedAppProtections { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.AndroidManagedAppProtection> AndroidManagedAppProtections { get; set; }
#endif
        /// <summary>Default managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.DefaultManagedAppProtection>? DefaultManagedAppProtections { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.DefaultManagedAppProtection> DefaultManagedAppProtections { get; set; }
#endif
        /// <summary>iOS managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.IosManagedAppProtection>? IosManagedAppProtections { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.IosManagedAppProtection> IosManagedAppProtections { get; set; }
#endif
        /// <summary>Whether the account is enabled for syncing applications from the Microsoft Store for Business.</summary>
        public bool? IsEnabledForMicrosoftStoreForBusiness { get; set; }
        /// <summary>Managed app policies.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ManagedAppPolicy>? ManagedAppPolicies { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ManagedAppPolicy> ManagedAppPolicies { get; set; }
#endif
        /// <summary>The managed app registrations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ManagedAppRegistration>? ManagedAppRegistrations { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ManagedAppRegistration> ManagedAppRegistrations { get; set; }
#endif
        /// <summary>The managed app statuses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ManagedAppStatus>? ManagedAppStatuses { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ManagedAppStatus> ManagedAppStatuses { get; set; }
#endif
        /// <summary>The Managed eBook.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ManagedEBook>? ManagedEBooks { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ManagedEBook> ManagedEBooks { get; set; }
#endif
        /// <summary>Windows information protection for apps running on devices which are MDM enrolled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.MdmWindowsInformationProtectionPolicy>? MdmWindowsInformationProtectionPolicies { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.MdmWindowsInformationProtectionPolicy> MdmWindowsInformationProtectionPolicies { get; set; }
#endif
        /// <summary>The locale information used to sync applications from the Microsoft Store for Business. Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is -&lt;country/regioncode2&gt;, where  is a lowercase two-letter code derived from ISO 639-1 and &lt;country/regioncode2&gt; is an uppercase two-letter code derived from ISO 3166. For example, en-US for English (United States) is a specific culture.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MicrosoftStoreForBusinessLanguage { get; set; }
#nullable restore
#else
        public string MicrosoftStoreForBusinessLanguage { get; set; }
#endif
        /// <summary>The last time an application sync from the Microsoft Store for Business was completed.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime { get; set; }
        /// <summary>The last time the apps from the Microsoft Store for Business were synced successfully for the account.</summary>
        public DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime { get; set; }
        /// <summary>The mobile app categories.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.MobileAppCategory>? MobileAppCategories { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.MobileAppCategory> MobileAppCategories { get; set; }
#endif
        /// <summary>The Managed Device Mobile Application Configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ManagedDeviceMobileAppConfiguration>? MobileAppConfigurations { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ManagedDeviceMobileAppConfiguration> MobileAppConfigurations { get; set; }
#endif
        /// <summary>The mobile apps.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.MobileApp>? MobileApps { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.MobileApp> MobileApps { get; set; }
#endif
        /// <summary>Targeted managed app configurations.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.TargetedManagedAppConfiguration>? TargetedManagedAppConfigurations { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.TargetedManagedAppConfiguration> TargetedManagedAppConfigurations { get; set; }
#endif
        /// <summary>List of Vpp tokens for this organization.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.VppToken>? VppTokens { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.VppToken> VppTokens { get; set; }
#endif
        /// <summary>Windows information protection for apps running on devices which are not MDM enrolled.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.WindowsInformationProtectionPolicy>? WindowsInformationProtectionPolicies { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.WindowsInformationProtectionPolicy> WindowsInformationProtectionPolicies { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.DeviceAppManagement"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.DeviceAppManagement CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.DeviceAppManagement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "androidManagedAppProtections", n => { AndroidManagedAppProtections = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.AndroidManagedAppProtection>(global::NoBackingStore.Graph.Models.AndroidManagedAppProtection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "defaultManagedAppProtections", n => { DefaultManagedAppProtections = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DefaultManagedAppProtection>(global::NoBackingStore.Graph.Models.DefaultManagedAppProtection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "iosManagedAppProtections", n => { IosManagedAppProtections = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IosManagedAppProtection>(global::NoBackingStore.Graph.Models.IosManagedAppProtection.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isEnabledForMicrosoftStoreForBusiness", n => { IsEnabledForMicrosoftStoreForBusiness = n.GetBoolValue(); } },
                { "managedAppPolicies", n => { ManagedAppPolicies = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedAppPolicy>(global::NoBackingStore.Graph.Models.ManagedAppPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedAppRegistrations", n => { ManagedAppRegistrations = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedAppRegistration>(global::NoBackingStore.Graph.Models.ManagedAppRegistration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedAppStatuses", n => { ManagedAppStatuses = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedAppStatus>(global::NoBackingStore.Graph.Models.ManagedAppStatus.CreateFromDiscriminatorValue)?.AsList(); } },
                { "managedEBooks", n => { ManagedEBooks = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedEBook>(global::NoBackingStore.Graph.Models.ManagedEBook.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mdmWindowsInformationProtectionPolicies", n => { MdmWindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MdmWindowsInformationProtectionPolicy>(global::NoBackingStore.Graph.Models.MdmWindowsInformationProtectionPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "microsoftStoreForBusinessLanguage", n => { MicrosoftStoreForBusinessLanguage = n.GetStringValue(); } },
                { "microsoftStoreForBusinessLastCompletedApplicationSyncTime", n => { MicrosoftStoreForBusinessLastCompletedApplicationSyncTime = n.GetDateTimeOffsetValue(); } },
                { "microsoftStoreForBusinessLastSuccessfulSyncDateTime", n => { MicrosoftStoreForBusinessLastSuccessfulSyncDateTime = n.GetDateTimeOffsetValue(); } },
                { "mobileAppCategories", n => { MobileAppCategories = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MobileAppCategory>(global::NoBackingStore.Graph.Models.MobileAppCategory.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mobileAppConfigurations", n => { MobileAppConfigurations = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedDeviceMobileAppConfiguration>(global::NoBackingStore.Graph.Models.ManagedDeviceMobileAppConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "mobileApps", n => { MobileApps = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MobileApp>(global::NoBackingStore.Graph.Models.MobileApp.CreateFromDiscriminatorValue)?.AsList(); } },
                { "targetedManagedAppConfigurations", n => { TargetedManagedAppConfigurations = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.TargetedManagedAppConfiguration>(global::NoBackingStore.Graph.Models.TargetedManagedAppConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "vppTokens", n => { VppTokens = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.VppToken>(global::NoBackingStore.Graph.Models.VppToken.CreateFromDiscriminatorValue)?.AsList(); } },
                { "windowsInformationProtectionPolicies", n => { WindowsInformationProtectionPolicies = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.WindowsInformationProtectionPolicy>(global::NoBackingStore.Graph.Models.WindowsInformationProtectionPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.AndroidManagedAppProtection>("androidManagedAppProtections", AndroidManagedAppProtections);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DefaultManagedAppProtection>("defaultManagedAppProtections", DefaultManagedAppProtections);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IosManagedAppProtection>("iosManagedAppProtections", IosManagedAppProtections);
            writer.WriteBoolValue("isEnabledForMicrosoftStoreForBusiness", IsEnabledForMicrosoftStoreForBusiness);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedAppPolicy>("managedAppPolicies", ManagedAppPolicies);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedAppRegistration>("managedAppRegistrations", ManagedAppRegistrations);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedAppStatus>("managedAppStatuses", ManagedAppStatuses);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedEBook>("managedEBooks", ManagedEBooks);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MdmWindowsInformationProtectionPolicy>("mdmWindowsInformationProtectionPolicies", MdmWindowsInformationProtectionPolicies);
            writer.WriteStringValue("microsoftStoreForBusinessLanguage", MicrosoftStoreForBusinessLanguage);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastCompletedApplicationSyncTime", MicrosoftStoreForBusinessLastCompletedApplicationSyncTime);
            writer.WriteDateTimeOffsetValue("microsoftStoreForBusinessLastSuccessfulSyncDateTime", MicrosoftStoreForBusinessLastSuccessfulSyncDateTime);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MobileAppCategory>("mobileAppCategories", MobileAppCategories);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedDeviceMobileAppConfiguration>("mobileAppConfigurations", MobileAppConfigurations);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MobileApp>("mobileApps", MobileApps);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.TargetedManagedAppConfiguration>("targetedManagedAppConfigurations", TargetedManagedAppConfigurations);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.VppToken>("vppTokens", VppTokens);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.WindowsInformationProtectionPolicy>("windowsInformationProtectionPolicies", WindowsInformationProtectionPolicies);
        }
    }
}
#pragma warning restore CS0618
