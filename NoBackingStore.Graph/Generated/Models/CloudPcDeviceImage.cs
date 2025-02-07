// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System;
namespace NoBackingStore.Graph.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class CloudPcDeviceImage : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The display name of the associated device image. The device image display name and the version are used to uniquely identify the Cloud PC device image. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The error code of the status of the image that indicates why the upload failed, if applicable. Possible values are: internalServerError, sourceImageNotFound, osVersionNotSupported, sourceImageInvalid, sourceImageNotGeneralized, unknownFutureValue, vmAlreadyAzureAdJoined, paidSourceImageNotSupport, sourceImageNotSupportCustomizeVMName, sourceImageSizeExceedsLimitation. Use the Prefer: include-unknown-enum-members request header to get the following values from this evolvable enum: vmAlreadyAzureAdJoined, paidSourceImageNotSupport, sourceImageNotSupportCustomizeVMName, sourceImageSizeExceedsLimitation. Read-only.</summary>
        public global::NoBackingStore.Graph.Models.CloudPcDeviceImageErrorCode? ErrorCode { get; set; }
        /// <summary>The date when the image became unavailable. Read-only.</summary>
        public Date? ExpirationDate { get; set; }
        /// <summary>The data and time when the image was last modified. The timestamp represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The operating system (OS) of the image. For example, Windows 10 Enterprise. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OperatingSystem { get; set; }
#nullable restore
#else
        public string OperatingSystem { get; set; }
#endif
        /// <summary>The OS build version of the image. For example, 1909. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OsBuildNumber { get; set; }
#nullable restore
#else
        public string OsBuildNumber { get; set; }
#endif
        /// <summary>The OS status of this image. Possible values are: supported, supportedWithWarning, unknown, unknownFutureValue. The default value is unknown. Read-only.</summary>
        public global::NoBackingStore.Graph.Models.CloudPcDeviceImageOsStatus? OsStatus { get; set; }
        /// <summary>The unique identifier (ID) of the source image resource on Azure. The required ID format is: &apos;/subscriptions/{subscription-id}/resourceGroups/{resourceGroupName}/providers/Microsoft.Compute/images/{imageName}&apos;. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceImageResourceId { get; set; }
#nullable restore
#else
        public string SourceImageResourceId { get; set; }
#endif
        /// <summary>The status of the image on the Cloud PC. Possible values are: pending, ready, failed, unknownFutureValue. Read-only.</summary>
        public global::NoBackingStore.Graph.Models.CloudPcDeviceImageStatus? Status { get; set; }
        /// <summary>The image version. For example, 0.0.1 and 1.5.13. Read-only.</summary>
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
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.CloudPcDeviceImage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.CloudPcDeviceImage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.CloudPcDeviceImage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "errorCode", n => { ErrorCode = n.GetEnumValue<global::NoBackingStore.Graph.Models.CloudPcDeviceImageErrorCode>(); } },
                { "expirationDate", n => { ExpirationDate = n.GetDateValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "operatingSystem", n => { OperatingSystem = n.GetStringValue(); } },
                { "osBuildNumber", n => { OsBuildNumber = n.GetStringValue(); } },
                { "osStatus", n => { OsStatus = n.GetEnumValue<global::NoBackingStore.Graph.Models.CloudPcDeviceImageOsStatus>(); } },
                { "sourceImageResourceId", n => { SourceImageResourceId = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::NoBackingStore.Graph.Models.CloudPcDeviceImageStatus>(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.CloudPcDeviceImageErrorCode>("errorCode", ErrorCode);
            writer.WriteDateValue("expirationDate", ExpirationDate);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("operatingSystem", OperatingSystem);
            writer.WriteStringValue("osBuildNumber", OsBuildNumber);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.CloudPcDeviceImageOsStatus>("osStatus", OsStatus);
            writer.WriteStringValue("sourceImageResourceId", SourceImageResourceId);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.CloudPcDeviceImageStatus>("status", Status);
            writer.WriteStringValue("version", Version);
        }
    }
}
#pragma warning restore CS0618
