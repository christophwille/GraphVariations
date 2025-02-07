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
    public partial class AccessPackageAssignment : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Read-only. Nullable. Supports $filter (eq) on the id property and $expand query parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.AccessPackage? AccessPackage { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.AccessPackage AccessPackage { get; set; }
#endif
        /// <summary>Read-only. Supports $filter (eq) on the id property and $expand query parameters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.AccessPackageAssignmentPolicy? AssignmentPolicy { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.AccessPackageAssignmentPolicy AssignmentPolicy { get; set; }
#endif
        /// <summary>Information about all the custom extension calls that were made during the access package assignment workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.CustomExtensionCalloutInstance>? CustomExtensionCalloutInstances { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.CustomExtensionCalloutInstance> CustomExtensionCalloutInstances { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? ExpiredDateTime { get; set; }
        /// <summary>When the access assignment is to be in place. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.EntitlementManagementSchedule? Schedule { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.EntitlementManagementSchedule Schedule { get; set; }
#endif
        /// <summary>The state of the access package assignment. The possible values are: delivering, partiallyDelivered, delivered, expired, deliveryFailed, unknownFutureValue. Read-only. Supports $filter (eq).</summary>
        public global::NoBackingStore.Graph.Models.AccessPackageAssignmentState? State { get; set; }
        /// <summary>More information about the assignment lifecycle. Possible values include Delivering, Delivered, NearExpiry1DayNotificationTriggered, or ExpiredNotificationTriggered. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Status { get; set; }
#nullable restore
#else
        public string Status { get; set; }
#endif
        /// <summary>The subject of the access package assignment. Read-only. Nullable. Supports $expand. Supports $filter (eq) on objectId.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.AccessPackageSubject? Target { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.AccessPackageSubject Target { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.AccessPackageAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.AccessPackageAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.AccessPackageAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackage", n => { AccessPackage = n.GetObjectValue<global::NoBackingStore.Graph.Models.AccessPackage>(global::NoBackingStore.Graph.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                { "assignmentPolicy", n => { AssignmentPolicy = n.GetObjectValue<global::NoBackingStore.Graph.Models.AccessPackageAssignmentPolicy>(global::NoBackingStore.Graph.Models.AccessPackageAssignmentPolicy.CreateFromDiscriminatorValue); } },
                { "customExtensionCalloutInstances", n => { CustomExtensionCalloutInstances = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.CustomExtensionCalloutInstance>(global::NoBackingStore.Graph.Models.CustomExtensionCalloutInstance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "expiredDateTime", n => { ExpiredDateTime = n.GetDateTimeOffsetValue(); } },
                { "schedule", n => { Schedule = n.GetObjectValue<global::NoBackingStore.Graph.Models.EntitlementManagementSchedule>(global::NoBackingStore.Graph.Models.EntitlementManagementSchedule.CreateFromDiscriminatorValue); } },
                { "state", n => { State = n.GetEnumValue<global::NoBackingStore.Graph.Models.AccessPackageAssignmentState>(); } },
                { "status", n => { Status = n.GetStringValue(); } },
                { "target", n => { Target = n.GetObjectValue<global::NoBackingStore.Graph.Models.AccessPackageSubject>(global::NoBackingStore.Graph.Models.AccessPackageSubject.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.AccessPackageAssignmentPolicy>("assignmentPolicy", AssignmentPolicy);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.CustomExtensionCalloutInstance>("customExtensionCalloutInstances", CustomExtensionCalloutInstances);
            writer.WriteDateTimeOffsetValue("expiredDateTime", ExpiredDateTime);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.EntitlementManagementSchedule>("schedule", Schedule);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.AccessPackageAssignmentState>("state", State);
            writer.WriteStringValue("status", Status);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.AccessPackageSubject>("target", Target);
        }
    }
}
#pragma warning restore CS0618
