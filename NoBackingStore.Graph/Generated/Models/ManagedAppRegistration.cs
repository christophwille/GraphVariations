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
    /// The ManagedAppEntity is the base entity type for all other entity types under app management workflow.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ManagedAppRegistration : global::NoBackingStore.Graph.Models.Entity, IParsable
    {
        /// <summary>The app package Identifier</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.MobileAppIdentifier? AppIdentifier { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.MobileAppIdentifier AppIdentifier { get; set; }
#endif
        /// <summary>App version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationVersion { get; set; }
#nullable restore
#else
        public string ApplicationVersion { get; set; }
#endif
        /// <summary>Zero or more policys already applied on the registered app when it last synchronized with managment service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ManagedAppPolicy>? AppliedPolicies { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ManagedAppPolicy> AppliedPolicies { get; set; }
#endif
        /// <summary>Date and time of creation</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Host device name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceName { get; set; }
#nullable restore
#else
        public string DeviceName { get; set; }
#endif
        /// <summary>App management SDK generated tag, which helps relate apps hosted on the same device. Not guaranteed to relate apps in all conditions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceTag { get; set; }
#nullable restore
#else
        public string DeviceTag { get; set; }
#endif
        /// <summary>Host device type</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeviceType { get; set; }
#nullable restore
#else
        public string DeviceType { get; set; }
#endif
        /// <summary>Zero or more reasons an app registration is flagged. E.g. app running on rooted device</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ManagedAppFlaggedReason?>? FlaggedReasons { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ManagedAppFlaggedReason?> FlaggedReasons { get; set; }
#endif
        /// <summary>Zero or more policies admin intended for the app as of now.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ManagedAppPolicy>? IntendedPolicies { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ManagedAppPolicy> IntendedPolicies { get; set; }
#endif
        /// <summary>Date and time of last the app synced with management service.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>App management SDK version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ManagementSdkVersion { get; set; }
#nullable restore
#else
        public string ManagementSdkVersion { get; set; }
#endif
        /// <summary>Zero or more long running operations triggered on the app registration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ManagedAppOperation>? Operations { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ManagedAppOperation> Operations { get; set; }
#endif
        /// <summary>Operating System version</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlatformVersion { get; set; }
#nullable restore
#else
        public string PlatformVersion { get; set; }
#endif
        /// <summary>The user Id to who this app registration belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserId { get; set; }
#nullable restore
#else
        public string UserId { get; set; }
#endif
        /// <summary>Version of the entity.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.ManagedAppRegistration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.ManagedAppRegistration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidManagedAppRegistration" => new global::NoBackingStore.Graph.Models.AndroidManagedAppRegistration(),
                "#microsoft.graph.iosManagedAppRegistration" => new global::NoBackingStore.Graph.Models.IosManagedAppRegistration(),
                _ => new global::NoBackingStore.Graph.Models.ManagedAppRegistration(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "appIdentifier", n => { AppIdentifier = n.GetObjectValue<global::NoBackingStore.Graph.Models.MobileAppIdentifier>(global::NoBackingStore.Graph.Models.MobileAppIdentifier.CreateFromDiscriminatorValue); } },
                { "applicationVersion", n => { ApplicationVersion = n.GetStringValue(); } },
                { "appliedPolicies", n => { AppliedPolicies = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedAppPolicy>(global::NoBackingStore.Graph.Models.ManagedAppPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "deviceName", n => { DeviceName = n.GetStringValue(); } },
                { "deviceTag", n => { DeviceTag = n.GetStringValue(); } },
                { "deviceType", n => { DeviceType = n.GetStringValue(); } },
                { "flaggedReasons", n => { FlaggedReasons = n.GetCollectionOfEnumValues<global::NoBackingStore.Graph.Models.ManagedAppFlaggedReason>()?.AsList(); } },
                { "intendedPolicies", n => { IntendedPolicies = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedAppPolicy>(global::NoBackingStore.Graph.Models.ManagedAppPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                { "managementSdkVersion", n => { ManagementSdkVersion = n.GetStringValue(); } },
                { "operations", n => { Operations = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedAppOperation>(global::NoBackingStore.Graph.Models.ManagedAppOperation.CreateFromDiscriminatorValue)?.AsList(); } },
                { "platformVersion", n => { PlatformVersion = n.GetStringValue(); } },
                { "userId", n => { UserId = n.GetStringValue(); } },
                { "version", n => { Version = n.GetStringValue(); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.MobileAppIdentifier>("appIdentifier", AppIdentifier);
            writer.WriteStringValue("applicationVersion", ApplicationVersion);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedAppPolicy>("appliedPolicies", AppliedPolicies);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("deviceName", DeviceName);
            writer.WriteStringValue("deviceTag", DeviceTag);
            writer.WriteStringValue("deviceType", DeviceType);
            writer.WriteCollectionOfEnumValues<global::NoBackingStore.Graph.Models.ManagedAppFlaggedReason>("flaggedReasons", FlaggedReasons);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedAppPolicy>("intendedPolicies", IntendedPolicies);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("managementSdkVersion", ManagementSdkVersion);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ManagedAppOperation>("operations", Operations);
            writer.WriteStringValue("platformVersion", PlatformVersion);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
