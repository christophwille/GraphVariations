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
    public partial class PlannerTask : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Number of checklist items with value set to false, representing incomplete items.</summary>
        public int? ActiveChecklistItemCount { get; set; }
        /// <summary>The categories to which the task has been applied. See applied Categories for possible values.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PlannerAppliedCategories? AppliedCategories { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PlannerAppliedCategories AppliedCategories { get; set; }
#endif
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by assignedTo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PlannerAssignedToTaskBoardTaskFormat? AssignedToTaskBoardFormat { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PlannerAssignedToTaskBoardTaskFormat AssignedToTaskBoardFormat { get; set; }
#endif
        /// <summary>Hint used to order items of this type in a list view. The format is defined as outlined here.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AssigneePriority { get; set; }
#nullable restore
#else
        public string AssigneePriority { get; set; }
#endif
        /// <summary>The set of assignees the task is assigned to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PlannerAssignments? Assignments { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PlannerAssignments Assignments { get; set; }
#endif
        /// <summary>Bucket ID to which the task belongs. The bucket needs to be in the plan that the task is in. It&apos;s 28 characters long and case-sensitive. Format validation is done on the service.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BucketId { get; set; }
#nullable restore
#else
        public string BucketId { get; set; }
#endif
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by bucket.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PlannerBucketTaskBoardTaskFormat? BucketTaskBoardFormat { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PlannerBucketTaskBoardTaskFormat BucketTaskBoardFormat { get; set; }
#endif
        /// <summary>Number of checklist items that are present on the task.</summary>
        public int? ChecklistItemCount { get; set; }
        /// <summary>Identity of the user that completed the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentitySet? CompletedBy { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentitySet CompletedBy { get; set; }
#endif
        /// <summary>Read-only. Date and time at which the &apos;percentComplete&apos; of the task is set to &apos;100&apos;. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CompletedDateTime { get; set; }
        /// <summary>Thread ID of the conversation on the task. This is the ID of the conversation thread object created in the group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ConversationThreadId { get; set; }
#nullable restore
#else
        public string ConversationThreadId { get; set; }
#endif
        /// <summary>Identity of the user that created the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>Read-only. Date and time at which the task is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Read-only. Nullable. More details about the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PlannerTaskDetails? Details { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PlannerTaskDetails Details { get; set; }
#endif
        /// <summary>Date and time at which the task is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DueDateTime { get; set; }
        /// <summary>Read-only. Value is true if the details object of the task has a nonempty description and false otherwise.</summary>
        public bool? HasDescription { get; set; }
        /// <summary>Hint used to order items of this type in a list view. The format is defined as outlined here.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OrderHint { get; set; }
#nullable restore
#else
        public string OrderHint { get; set; }
#endif
        /// <summary>Percentage of task completion. When set to 100, the task is considered completed.</summary>
        public int? PercentComplete { get; set; }
        /// <summary>Plan ID to which the task belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PlanId { get; set; }
#nullable restore
#else
        public string PlanId { get; set; }
#endif
        /// <summary>This sets the type of preview that shows up on the task. The possible values are: automatic, noPreview, checklist, description, reference.</summary>
        public global::NoBackingStore.Graph.Models.PlannerPreviewType? PreviewType { get; set; }
        /// <summary>Priority of the task. The valid range of values is between 0 and 10, with the increasing value being lower priority (0 has the highest priority and 10 has the lowest priority).  Currently, Planner interprets values 0 and 1 as &apos;urgent&apos;, 2, 3 and 4 as &apos;important&apos;, 5, 6, and 7 as &apos;medium&apos;, and 8, 9, and 10 as &apos;low&apos;.  Additionally, Planner sets the value 1 for &apos;urgent&apos;, 3 for &apos;important&apos;, 5 for &apos;medium&apos;, and 9 for &apos;low&apos;.</summary>
        public int? Priority { get; set; }
        /// <summary>Read-only. Nullable. Used to render the task correctly in the task board view when grouped by progress.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PlannerProgressTaskBoardTaskFormat? ProgressTaskBoardFormat { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PlannerProgressTaskBoardTaskFormat ProgressTaskBoardFormat { get; set; }
#endif
        /// <summary>Number of external references that exist on the task.</summary>
        public int? ReferenceCount { get; set; }
        /// <summary>Date and time at which the task starts. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>Title of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.PlannerTask"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.PlannerTask CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.PlannerTask();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activeChecklistItemCount", n => { ActiveChecklistItemCount = n.GetIntValue(); } },
                { "appliedCategories", n => { AppliedCategories = n.GetObjectValue<global::NoBackingStore.Graph.Models.PlannerAppliedCategories>(global::NoBackingStore.Graph.Models.PlannerAppliedCategories.CreateFromDiscriminatorValue); } },
                { "assignedToTaskBoardFormat", n => { AssignedToTaskBoardFormat = n.GetObjectValue<global::NoBackingStore.Graph.Models.PlannerAssignedToTaskBoardTaskFormat>(global::NoBackingStore.Graph.Models.PlannerAssignedToTaskBoardTaskFormat.CreateFromDiscriminatorValue); } },
                { "assigneePriority", n => { AssigneePriority = n.GetStringValue(); } },
                { "assignments", n => { Assignments = n.GetObjectValue<global::NoBackingStore.Graph.Models.PlannerAssignments>(global::NoBackingStore.Graph.Models.PlannerAssignments.CreateFromDiscriminatorValue); } },
                { "bucketId", n => { BucketId = n.GetStringValue(); } },
                { "bucketTaskBoardFormat", n => { BucketTaskBoardFormat = n.GetObjectValue<global::NoBackingStore.Graph.Models.PlannerBucketTaskBoardTaskFormat>(global::NoBackingStore.Graph.Models.PlannerBucketTaskBoardTaskFormat.CreateFromDiscriminatorValue); } },
                { "checklistItemCount", n => { ChecklistItemCount = n.GetIntValue(); } },
                { "completedBy", n => { CompletedBy = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>(global::NoBackingStore.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "completedDateTime", n => { CompletedDateTime = n.GetDateTimeOffsetValue(); } },
                { "conversationThreadId", n => { ConversationThreadId = n.GetStringValue(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>(global::NoBackingStore.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "details", n => { Details = n.GetObjectValue<global::NoBackingStore.Graph.Models.PlannerTaskDetails>(global::NoBackingStore.Graph.Models.PlannerTaskDetails.CreateFromDiscriminatorValue); } },
                { "dueDateTime", n => { DueDateTime = n.GetDateTimeOffsetValue(); } },
                { "hasDescription", n => { HasDescription = n.GetBoolValue(); } },
                { "orderHint", n => { OrderHint = n.GetStringValue(); } },
                { "percentComplete", n => { PercentComplete = n.GetIntValue(); } },
                { "planId", n => { PlanId = n.GetStringValue(); } },
                { "previewType", n => { PreviewType = n.GetEnumValue<global::NoBackingStore.Graph.Models.PlannerPreviewType>(); } },
                { "priority", n => { Priority = n.GetIntValue(); } },
                { "progressTaskBoardFormat", n => { ProgressTaskBoardFormat = n.GetObjectValue<global::NoBackingStore.Graph.Models.PlannerProgressTaskBoardTaskFormat>(global::NoBackingStore.Graph.Models.PlannerProgressTaskBoardTaskFormat.CreateFromDiscriminatorValue); } },
                { "referenceCount", n => { ReferenceCount = n.GetIntValue(); } },
                { "startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                { "title", n => { Title = n.GetStringValue(); } },
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
            writer.WriteIntValue("activeChecklistItemCount", ActiveChecklistItemCount);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PlannerAppliedCategories>("appliedCategories", AppliedCategories);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PlannerAssignedToTaskBoardTaskFormat>("assignedToTaskBoardFormat", AssignedToTaskBoardFormat);
            writer.WriteStringValue("assigneePriority", AssigneePriority);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PlannerAssignments>("assignments", Assignments);
            writer.WriteStringValue("bucketId", BucketId);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PlannerBucketTaskBoardTaskFormat>("bucketTaskBoardFormat", BucketTaskBoardFormat);
            writer.WriteIntValue("checklistItemCount", ChecklistItemCount);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>("completedBy", CompletedBy);
            writer.WriteDateTimeOffsetValue("completedDateTime", CompletedDateTime);
            writer.WriteStringValue("conversationThreadId", ConversationThreadId);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PlannerTaskDetails>("details", Details);
            writer.WriteDateTimeOffsetValue("dueDateTime", DueDateTime);
            writer.WriteBoolValue("hasDescription", HasDescription);
            writer.WriteStringValue("orderHint", OrderHint);
            writer.WriteIntValue("percentComplete", PercentComplete);
            writer.WriteStringValue("planId", PlanId);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.PlannerPreviewType>("previewType", PreviewType);
            writer.WriteIntValue("priority", Priority);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PlannerProgressTaskBoardTaskFormat>("progressTaskBoardFormat", ProgressTaskBoardFormat);
            writer.WriteIntValue("referenceCount", ReferenceCount);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("title", Title);
        }
    }
}
#pragma warning restore CS0618
