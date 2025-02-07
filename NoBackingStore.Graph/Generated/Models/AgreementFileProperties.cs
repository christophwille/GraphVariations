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
    public partial class AgreementFileProperties : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The date time representing when the file was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Localized display name of the policy file of an agreement. The localized display name is shown to end users who view the agreement.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Data that represents the terms of use PDF document. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.AgreementFileData? FileData { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.AgreementFileData FileData { get; set; }
#endif
        /// <summary>Name of the agreement file (for example, TOU.pdf). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FileName { get; set; }
#nullable restore
#else
        public string FileName { get; set; }
#endif
        /// <summary>If none of the languages matches the client preference, indicates whether this is the default agreement file. If none of the files are marked as default, the first one is treated as the default. Read-only.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>Indicates whether the agreement file is a major version update. Major version updates invalidate the agreement&apos;s acceptances on the corresponding language.</summary>
        public bool? IsMajorVersion { get; set; }
        /// <summary>The language of the agreement file in the format &apos;languagecode2-country/regioncode2&apos;. &apos;languagecode2&apos; is a lowercase two-letter code derived from ISO 639-1, while &apos;country/regioncode2&apos; is derived from ISO 3166 and usually consists of two uppercase letters, or a BCP-47 language tag. For example, U.S. English is en-US. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.AgreementFileProperties"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.AgreementFileProperties CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.agreementFile" => new global::NoBackingStore.Graph.Models.AgreementFile(),
                "#microsoft.graph.agreementFileLocalization" => new global::NoBackingStore.Graph.Models.AgreementFileLocalization(),
                "#microsoft.graph.agreementFileVersion" => new global::NoBackingStore.Graph.Models.AgreementFileVersion(),
                _ => new global::NoBackingStore.Graph.Models.AgreementFileProperties(),
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
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "fileData", n => { FileData = n.GetObjectValue<global::NoBackingStore.Graph.Models.AgreementFileData>(global::NoBackingStore.Graph.Models.AgreementFileData.CreateFromDiscriminatorValue); } },
                { "fileName", n => { FileName = n.GetStringValue(); } },
                { "isDefault", n => { IsDefault = n.GetBoolValue(); } },
                { "isMajorVersion", n => { IsMajorVersion = n.GetBoolValue(); } },
                { "language", n => { Language = n.GetStringValue(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.AgreementFileData>("fileData", FileData);
            writer.WriteStringValue("fileName", FileName);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteBoolValue("isMajorVersion", IsMajorVersion);
            writer.WriteStringValue("language", Language);
        }
    }
}
#pragma warning restore CS0618
