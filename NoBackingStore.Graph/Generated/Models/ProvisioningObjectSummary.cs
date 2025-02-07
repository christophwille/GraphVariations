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
    public partial class ProvisioningObjectSummary : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.  SUpports $filter (eq, gt, lt) and orderby.</summary>
        public DateTimeOffset? ActivityDateTime { get; set; }
        /// <summary>Unique ID of this change in this cycle. Supports $filter (eq, contains).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ChangeId { get; set; }
#nullable restore
#else
        public string ChangeId { get; set; }
#endif
        /// <summary>Unique ID per job iteration. Supports $filter (eq, contains).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CycleId { get; set; }
#nullable restore
#else
        public string CycleId { get; set; }
#endif
        /// <summary>Indicates how long this provisioning action took to finish. Measured in milliseconds.</summary>
        public int? DurationInMilliseconds { get; set; }
        /// <summary>Details of who initiated this provisioning. Supports $filter (eq, contains).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.Initiator? InitiatedBy { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.Initiator InitiatedBy { get; set; }
#endif
        /// <summary>The unique ID for the whole provisioning job. Supports $filter (eq, contains).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobId { get; set; }
#nullable restore
#else
        public string JobId { get; set; }
#endif
        /// <summary>Details of each property that was modified in this provisioning action on this object.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ModifiedProperty>? ModifiedProperties { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ModifiedProperty> ModifiedProperties { get; set; }
#endif
        /// <summary>Indicates the activity name or the operation name. Possible values are: create, update, delete, stageddelete, disable, other and unknownFutureValue. For a list of activities logged, refer to Microsoft Entra activity list. Supports $filter (eq, contains).</summary>
        public global::NoBackingStore.Graph.Models.ProvisioningAction? ProvisioningAction { get; set; }
        /// <summary>Details of provisioning status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ProvisioningStatusInfo? ProvisioningStatusInfo { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ProvisioningStatusInfo ProvisioningStatusInfo { get; set; }
#endif
        /// <summary>Details of each step in provisioning.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ProvisioningStep>? ProvisioningSteps { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ProvisioningStep> ProvisioningSteps { get; set; }
#endif
        /// <summary>Represents the service principal used for provisioning. Supports $filter (eq) for id and name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ProvisioningServicePrincipal? ServicePrincipal { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ProvisioningServicePrincipal ServicePrincipal { get; set; }
#endif
        /// <summary>Details of source object being provisioned. Supports $filter (eq, contains) for identityType, id, and displayName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ProvisionedIdentity? SourceIdentity { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ProvisionedIdentity SourceIdentity { get; set; }
#endif
        /// <summary>Details of source system of the object being provisioned. Supports $filter (eq, contains) for displayName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ProvisioningSystem? SourceSystem { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ProvisioningSystem SourceSystem { get; set; }
#endif
        /// <summary>Details of target object being provisioned. Supports $filter (eq, contains) for identityType, id, and displayName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ProvisionedIdentity? TargetIdentity { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ProvisionedIdentity TargetIdentity { get; set; }
#endif
        /// <summary>Details of target system of the object being provisioned. Supports $filter (eq, contains) for displayName.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ProvisioningSystem? TargetSystem { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ProvisioningSystem TargetSystem { get; set; }
#endif
        /// <summary>Unique Microsoft Entra tenant ID. Supports $filter (eq, contains).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantId { get; set; }
#nullable restore
#else
        public string TenantId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.ProvisioningObjectSummary"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.ProvisioningObjectSummary CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.ProvisioningObjectSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                { "changeId", n => { ChangeId = n.GetStringValue(); } },
                { "cycleId", n => { CycleId = n.GetStringValue(); } },
                { "durationInMilliseconds", n => { DurationInMilliseconds = n.GetIntValue(); } },
                { "initiatedBy", n => { InitiatedBy = n.GetObjectValue<global::NoBackingStore.Graph.Models.Initiator>(global::NoBackingStore.Graph.Models.Initiator.CreateFromDiscriminatorValue); } },
                { "jobId", n => { JobId = n.GetStringValue(); } },
                { "modifiedProperties", n => { ModifiedProperties = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ModifiedProperty>(global::NoBackingStore.Graph.Models.ModifiedProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "provisioningAction", n => { ProvisioningAction = n.GetEnumValue<global::NoBackingStore.Graph.Models.ProvisioningAction>(); } },
                { "provisioningStatusInfo", n => { ProvisioningStatusInfo = n.GetObjectValue<global::NoBackingStore.Graph.Models.ProvisioningStatusInfo>(global::NoBackingStore.Graph.Models.ProvisioningStatusInfo.CreateFromDiscriminatorValue); } },
                { "provisioningSteps", n => { ProvisioningSteps = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ProvisioningStep>(global::NoBackingStore.Graph.Models.ProvisioningStep.CreateFromDiscriminatorValue)?.AsList(); } },
                { "servicePrincipal", n => { ServicePrincipal = n.GetObjectValue<global::NoBackingStore.Graph.Models.ProvisioningServicePrincipal>(global::NoBackingStore.Graph.Models.ProvisioningServicePrincipal.CreateFromDiscriminatorValue); } },
                { "sourceIdentity", n => { SourceIdentity = n.GetObjectValue<global::NoBackingStore.Graph.Models.ProvisionedIdentity>(global::NoBackingStore.Graph.Models.ProvisionedIdentity.CreateFromDiscriminatorValue); } },
                { "sourceSystem", n => { SourceSystem = n.GetObjectValue<global::NoBackingStore.Graph.Models.ProvisioningSystem>(global::NoBackingStore.Graph.Models.ProvisioningSystem.CreateFromDiscriminatorValue); } },
                { "targetIdentity", n => { TargetIdentity = n.GetObjectValue<global::NoBackingStore.Graph.Models.ProvisionedIdentity>(global::NoBackingStore.Graph.Models.ProvisionedIdentity.CreateFromDiscriminatorValue); } },
                { "targetSystem", n => { TargetSystem = n.GetObjectValue<global::NoBackingStore.Graph.Models.ProvisioningSystem>(global::NoBackingStore.Graph.Models.ProvisioningSystem.CreateFromDiscriminatorValue); } },
                { "tenantId", n => { TenantId = n.GetStringValue(); } },
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
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("changeId", ChangeId);
            writer.WriteStringValue("cycleId", CycleId);
            writer.WriteIntValue("durationInMilliseconds", DurationInMilliseconds);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.Initiator>("initiatedBy", InitiatedBy);
            writer.WriteStringValue("jobId", JobId);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ModifiedProperty>("modifiedProperties", ModifiedProperties);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ProvisioningAction>("provisioningAction", ProvisioningAction);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ProvisioningStatusInfo>("provisioningStatusInfo", ProvisioningStatusInfo);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ProvisioningStep>("provisioningSteps", ProvisioningSteps);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ProvisioningServicePrincipal>("servicePrincipal", ServicePrincipal);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ProvisionedIdentity>("sourceIdentity", SourceIdentity);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ProvisioningSystem>("sourceSystem", SourceSystem);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ProvisionedIdentity>("targetIdentity", TargetIdentity);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ProvisioningSystem>("targetSystem", TargetSystem);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
#pragma warning restore CS0618
