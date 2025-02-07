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
    public partial class PrivilegedAccessGroup : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The assignmentApprovals property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Approval>? AssignmentApprovals { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Approval> AssignmentApprovals { get; set; }
#endif
        /// <summary>The instances of assignment schedules to activate a just-in-time access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance>? AssignmentScheduleInstances { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance> AssignmentScheduleInstances { get; set; }
#endif
        /// <summary>The schedule requests for operations to create, update, delete, extend, and renew an assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentScheduleRequest>? AssignmentScheduleRequests { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentScheduleRequest> AssignmentScheduleRequests { get; set; }
#endif
        /// <summary>The assignment schedules to activate a just-in-time access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentSchedule>? AssignmentSchedules { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentSchedule> AssignmentSchedules { get; set; }
#endif
        /// <summary>The instances of eligibility schedules to activate a just-in-time access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance>? EligibilityScheduleInstances { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance> EligibilityScheduleInstances { get; set; }
#endif
        /// <summary>The schedule requests for operations to create, update, delete, extend, and renew an eligibility.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilityScheduleRequest>? EligibilityScheduleRequests { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilityScheduleRequest> EligibilityScheduleRequests { get; set; }
#endif
        /// <summary>The eligibility schedules to activate a just-in-time access.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilitySchedule>? EligibilitySchedules { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilitySchedule> EligibilitySchedules { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.PrivilegedAccessGroup"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.PrivilegedAccessGroup CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.PrivilegedAccessGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "assignmentApprovals", n => { AssignmentApprovals = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Approval>(global::NoBackingStore.Graph.Models.Approval.CreateFromDiscriminatorValue)?.AsList(); } },
                { "assignmentScheduleInstances", n => { AssignmentScheduleInstances = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance>(global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "assignmentScheduleRequests", n => { AssignmentScheduleRequests = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentScheduleRequest>(global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentScheduleRequest.CreateFromDiscriminatorValue)?.AsList(); } },
                { "assignmentSchedules", n => { AssignmentSchedules = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentSchedule>(global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentSchedule.CreateFromDiscriminatorValue)?.AsList(); } },
                { "eligibilityScheduleInstances", n => { EligibilityScheduleInstances = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance>(global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance.CreateFromDiscriminatorValue)?.AsList(); } },
                { "eligibilityScheduleRequests", n => { EligibilityScheduleRequests = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilityScheduleRequest>(global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilityScheduleRequest.CreateFromDiscriminatorValue)?.AsList(); } },
                { "eligibilitySchedules", n => { EligibilitySchedules = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilitySchedule>(global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilitySchedule.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Approval>("assignmentApprovals", AssignmentApprovals);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentScheduleInstance>("assignmentScheduleInstances", AssignmentScheduleInstances);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentScheduleRequest>("assignmentScheduleRequests", AssignmentScheduleRequests);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupAssignmentSchedule>("assignmentSchedules", AssignmentSchedules);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilityScheduleInstance>("eligibilityScheduleInstances", EligibilityScheduleInstances);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilityScheduleRequest>("eligibilityScheduleRequests", EligibilityScheduleRequests);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrivilegedAccessGroupEligibilitySchedule>("eligibilitySchedules", EligibilitySchedules);
        }
    }
}
#pragma warning restore CS0618
