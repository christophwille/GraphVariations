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
    /// Contains properties and inherited properties for the macOS LOB App.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class MacOSLobApp : global::NoBackingStore.Graph.Models.MobileLobApp, IParsable
    {
        /// <summary>The build number of the package. This should match the package CFBundleShortVersionString of the .pkg file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BuildNumber { get; set; }
#nullable restore
#else
        public string BuildNumber { get; set; }
#endif
        /// <summary>The primary bundleId of the package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BundleId { get; set; }
#nullable restore
#else
        public string BundleId { get; set; }
#endif
        /// <summary>List of ComplexType macOSLobChildApp objects. Represents the apps expected to be installed by the package.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.MacOSLobChildApp>? ChildApps { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.MacOSLobChildApp> ChildApps { get; set; }
#endif
        /// <summary>When TRUE, indicates that the app&apos;s version will NOT be used to detect if the app is installed on a device. When FALSE, indicates that the app&apos;s version will be used to detect if the app is installed on a device. Set this to true for apps that use a self update feature.</summary>
        public bool? IgnoreVersionDetection { get; set; }
        /// <summary>When TRUE, indicates that the app will be installed as managed (requires macOS 11.0 and other managed package restrictions). When FALSE, indicates that the app will be installed as unmanaged.</summary>
        public bool? InstallAsManaged { get; set; }
        /// <summary>The MD5 hash codes. This is empty if the package was uploaded directly. If the Intune App Wrapping Tool is used to create a .intunemac, this value can be found inside the Detection.xml file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Md5Hash { get; set; }
#nullable restore
#else
        public List<string> Md5Hash { get; set; }
#endif
        /// <summary>The chunk size for MD5 hash. This is &apos;0&apos; or empty if the package was uploaded directly. If the Intune App Wrapping Tool is used to create a .intunemac, this value can be found inside the Detection.xml file.</summary>
        public int? Md5HashChunkSize { get; set; }
        /// <summary>ComplexType macOSMinimumOperatingSystem that indicates the minimum operating system applicable for the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.MacOSMinimumOperatingSystem? MinimumSupportedOperatingSystem { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.MacOSMinimumOperatingSystem MinimumSupportedOperatingSystem { get; set; }
#endif
        /// <summary>The version number of the package. This should match the package CFBundleVersion in the packageinfo file.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VersionNumber { get; set; }
#nullable restore
#else
        public string VersionNumber { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.MacOSLobApp"/> and sets the default values.
        /// </summary>
        public MacOSLobApp() : base()
        {
            OdataType = "#microsoft.graph.macOSLobApp";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.MacOSLobApp"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.MacOSLobApp CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.MacOSLobApp();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "buildNumber", n => { BuildNumber = n.GetStringValue(); } },
                { "bundleId", n => { BundleId = n.GetStringValue(); } },
                { "childApps", n => { ChildApps = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MacOSLobChildApp>(global::NoBackingStore.Graph.Models.MacOSLobChildApp.CreateFromDiscriminatorValue)?.AsList(); } },
                { "ignoreVersionDetection", n => { IgnoreVersionDetection = n.GetBoolValue(); } },
                { "installAsManaged", n => { InstallAsManaged = n.GetBoolValue(); } },
                { "md5Hash", n => { Md5Hash = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "md5HashChunkSize", n => { Md5HashChunkSize = n.GetIntValue(); } },
                { "minimumSupportedOperatingSystem", n => { MinimumSupportedOperatingSystem = n.GetObjectValue<global::NoBackingStore.Graph.Models.MacOSMinimumOperatingSystem>(global::NoBackingStore.Graph.Models.MacOSMinimumOperatingSystem.CreateFromDiscriminatorValue); } },
                { "versionNumber", n => { VersionNumber = n.GetStringValue(); } },
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
            writer.WriteStringValue("buildNumber", BuildNumber);
            writer.WriteStringValue("bundleId", BundleId);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MacOSLobChildApp>("childApps", ChildApps);
            writer.WriteBoolValue("ignoreVersionDetection", IgnoreVersionDetection);
            writer.WriteBoolValue("installAsManaged", InstallAsManaged);
            writer.WriteCollectionOfPrimitiveValues<string>("md5Hash", Md5Hash);
            writer.WriteIntValue("md5HashChunkSize", Md5HashChunkSize);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.MacOSMinimumOperatingSystem>("minimumSupportedOperatingSystem", MinimumSupportedOperatingSystem);
            writer.WriteStringValue("versionNumber", VersionNumber);
        }
    }
}
#pragma warning restore CS0618
