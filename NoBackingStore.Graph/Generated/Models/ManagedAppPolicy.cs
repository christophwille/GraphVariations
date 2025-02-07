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
    /// The ManagedAppPolicy resource represents a base type for platform specific policies.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class ManagedAppPolicy : global::NoBackingStore.Graph.Models.Entity, IParsable
    {
        /// <summary>The date and time the policy was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The policy&apos;s description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Policy display name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Last time the policy was modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
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
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.ManagedAppPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.ManagedAppPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.androidManagedAppProtection" => new global::NoBackingStore.Graph.Models.AndroidManagedAppProtection(),
                "#microsoft.graph.defaultManagedAppProtection" => new global::NoBackingStore.Graph.Models.DefaultManagedAppProtection(),
                "#microsoft.graph.iosManagedAppProtection" => new global::NoBackingStore.Graph.Models.IosManagedAppProtection(),
                "#microsoft.graph.managedAppConfiguration" => new global::NoBackingStore.Graph.Models.ManagedAppConfiguration(),
                "#microsoft.graph.managedAppProtection" => new global::NoBackingStore.Graph.Models.ManagedAppProtection(),
                "#microsoft.graph.mdmWindowsInformationProtectionPolicy" => new global::NoBackingStore.Graph.Models.MdmWindowsInformationProtectionPolicy(),
                "#microsoft.graph.targetedManagedAppConfiguration" => new global::NoBackingStore.Graph.Models.TargetedManagedAppConfiguration(),
                "#microsoft.graph.targetedManagedAppProtection" => new global::NoBackingStore.Graph.Models.TargetedManagedAppProtection(),
                "#microsoft.graph.windowsInformationProtection" => new global::NoBackingStore.Graph.Models.WindowsInformationProtection(),
                "#microsoft.graph.windowsInformationProtectionPolicy" => new global::NoBackingStore.Graph.Models.WindowsInformationProtectionPolicy(),
                _ => new global::NoBackingStore.Graph.Models.ManagedAppPolicy(),
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
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
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
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
