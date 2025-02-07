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
    public partial class EducationAssignment : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Optional field to control the assignment behavior for students who are added after the assignment is published. If not specified, defaults to none. Supported values are: none, assignIfOpen. For example, a teacher can use assignIfOpen to indicate that an assignment should be assigned to any new student who joins the class while the assignment is still open, and none to indicate that an assignment shouldn&apos;t be assigned to new students.</summary>
        public global::NoBackingStore.Graph.Models.EducationAddedStudentAction? AddedStudentAction { get; set; }
        /// <summary>Optional field to control the assignment behavior  for adding assignments to students&apos; and teachers&apos; calendars when the assignment is published. The possible values are: none, studentsAndPublisher, studentsAndTeamOwners, unknownFutureValue, and studentsOnly. Use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: studentsOnly. The default value is none.</summary>
        public global::NoBackingStore.Graph.Models.EducationAddToCalendarOptions? AddToCalendarAction { get; set; }
        /// <summary>Identifies whether students can submit after the due date. If this property isn&apos;t specified during create, it defaults to true.</summary>
        public bool? AllowLateSubmissions { get; set; }
        /// <summary>Identifies whether students can add their own resources to a submission or if they can only modify resources added by the teacher.</summary>
        public bool? AllowStudentsToAddResourcesToSubmission { get; set; }
        /// <summary>The date when the assignment should become active. If in the future, the assignment isn&apos;t shown to the student until this date. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? AssignDateTime { get; private set; }
        /// <summary>The moment that the assignment was published to students and the assignment shows up on the students timeline. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? AssignedDateTime { get; private set; }
        /// <summary>Which users, or whole class should receive a submission object once the assignment is published.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.EducationAssignmentRecipient? AssignTo { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.EducationAssignmentRecipient AssignTo { get; set; }
#endif
        /// <summary>When set, enables users to easily find assignments of a given type. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.EducationCategory>? Categories { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.EducationCategory> Categories { get; set; }
#endif
        /// <summary>Class to which this assignment belongs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ClassId { get; set; }
#nullable restore
#else
        public string ClassId { get; set; }
#endif
        /// <summary>Date when the assignment is closed for submissions. This is an optional field that can be null if the assignment doesn&apos;t allowLateSubmissions or when the closeDateTime is the same as the dueDateTime. But if specified, then the closeDateTime must be greater than or equal to the dueDateTime. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CloseDateTime { get; set; }
        /// <summary>Who created the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentitySet? CreatedBy { get; private set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentitySet CreatedBy { get; private set; }
#endif
        /// <summary>Moment when the assignment was created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; private set; }
        /// <summary>Name of the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Date when the students assignment is due. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DueDateTime { get; set; }
        /// <summary>Folder URL where all the feedback file resources for this assignment are stored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FeedbackResourcesFolderUrl { get; private set; }
#nullable restore
#else
        public string FeedbackResourcesFolderUrl { get; private set; }
#endif
        /// <summary>How the assignment will be graded.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.EducationAssignmentGradeType? Grading { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.EducationAssignmentGradeType Grading { get; set; }
#endif
        /// <summary>When set, enables users to weight assignments differently when computing a class average grade.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.EducationGradingCategory? GradingCategory { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.EducationGradingCategory GradingCategory { get; set; }
#endif
        /// <summary>Instructions for the assignment. The instructions and the display name tell the student what to do.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.EducationItemBody? Instructions { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.EducationItemBody Instructions { get; set; }
#endif
        /// <summary>Who last modified the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentitySet? LastModifiedBy { get; private set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentitySet LastModifiedBy { get; private set; }
#endif
        /// <summary>The date and time on which the assignment was modified. A student submission doesn&apos;t modify the assignment; only teachers can update assignments. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? LastModifiedDateTime { get; private set; }
        /// <summary>The URL of the module from which to access the assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModuleUrl { get; set; }
#nullable restore
#else
        public string ModuleUrl { get; set; }
#endif
        /// <summary>Optional field to specify the URL of the channel to post the assignment publish notification. If not specified or null, defaults to the General channel. This field only applies to assignments where the assignTo value is educationAssignmentClassRecipient. Updating the notificationChannelUrl isn&apos;t allowed after the assignment is published.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NotificationChannelUrl { get; set; }
#nullable restore
#else
        public string NotificationChannelUrl { get; set; }
#endif
        /// <summary>Learning objects that are associated with this assignment. Only teachers can modify this list. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.EducationAssignmentResource>? Resources { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.EducationAssignmentResource> Resources { get; set; }
#endif
        /// <summary>Folder URL where all the file resources for this assignment are stored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourcesFolderUrl { get; private set; }
#nullable restore
#else
        public string ResourcesFolderUrl { get; private set; }
#endif
        /// <summary>When set, the grading rubric attached to this assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.EducationRubric? Rubric { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.EducationRubric Rubric { get; set; }
#endif
        /// <summary>Status of the assignment.  You can&apos;t PATCH this value. Possible values are: draft, scheduled, published, assigned, unknownFutureValue, inactive. Use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: inactive.</summary>
        public global::NoBackingStore.Graph.Models.EducationAssignmentStatus? Status { get; private set; }
        /// <summary>Once published, there&apos;s a submission object for each student representing their work and grade. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.EducationSubmission>? Submissions { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.EducationSubmission> Submissions { get; set; }
#endif
        /// <summary>The deep link URL for the given assignment.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WebUrl { get; private set; }
#nullable restore
#else
        public string WebUrl { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.EducationAssignment"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.EducationAssignment CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.EducationAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addToCalendarAction", n => { AddToCalendarAction = n.GetEnumValue<global::NoBackingStore.Graph.Models.EducationAddToCalendarOptions>(); } },
                { "addedStudentAction", n => { AddedStudentAction = n.GetEnumValue<global::NoBackingStore.Graph.Models.EducationAddedStudentAction>(); } },
                { "allowLateSubmissions", n => { AllowLateSubmissions = n.GetBoolValue(); } },
                { "allowStudentsToAddResourcesToSubmission", n => { AllowStudentsToAddResourcesToSubmission = n.GetBoolValue(); } },
                { "assignDateTime", n => { AssignDateTime = n.GetDateTimeOffsetValue(); } },
                { "assignTo", n => { AssignTo = n.GetObjectValue<global::NoBackingStore.Graph.Models.EducationAssignmentRecipient>(global::NoBackingStore.Graph.Models.EducationAssignmentRecipient.CreateFromDiscriminatorValue); } },
                { "assignedDateTime", n => { AssignedDateTime = n.GetDateTimeOffsetValue(); } },
                { "categories", n => { Categories = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.EducationCategory>(global::NoBackingStore.Graph.Models.EducationCategory.CreateFromDiscriminatorValue)?.AsList(); } },
                { "classId", n => { ClassId = n.GetStringValue(); } },
                { "closeDateTime", n => { CloseDateTime = n.GetDateTimeOffsetValue(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>(global::NoBackingStore.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "dueDateTime", n => { DueDateTime = n.GetDateTimeOffsetValue(); } },
                { "feedbackResourcesFolderUrl", n => { FeedbackResourcesFolderUrl = n.GetStringValue(); } },
                { "grading", n => { Grading = n.GetObjectValue<global::NoBackingStore.Graph.Models.EducationAssignmentGradeType>(global::NoBackingStore.Graph.Models.EducationAssignmentGradeType.CreateFromDiscriminatorValue); } },
                { "gradingCategory", n => { GradingCategory = n.GetObjectValue<global::NoBackingStore.Graph.Models.EducationGradingCategory>(global::NoBackingStore.Graph.Models.EducationGradingCategory.CreateFromDiscriminatorValue); } },
                { "instructions", n => { Instructions = n.GetObjectValue<global::NoBackingStore.Graph.Models.EducationItemBody>(global::NoBackingStore.Graph.Models.EducationItemBody.CreateFromDiscriminatorValue); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>(global::NoBackingStore.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "moduleUrl", n => { ModuleUrl = n.GetStringValue(); } },
                { "notificationChannelUrl", n => { NotificationChannelUrl = n.GetStringValue(); } },
                { "resources", n => { Resources = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.EducationAssignmentResource>(global::NoBackingStore.Graph.Models.EducationAssignmentResource.CreateFromDiscriminatorValue)?.AsList(); } },
                { "resourcesFolderUrl", n => { ResourcesFolderUrl = n.GetStringValue(); } },
                { "rubric", n => { Rubric = n.GetObjectValue<global::NoBackingStore.Graph.Models.EducationRubric>(global::NoBackingStore.Graph.Models.EducationRubric.CreateFromDiscriminatorValue); } },
                { "status", n => { Status = n.GetEnumValue<global::NoBackingStore.Graph.Models.EducationAssignmentStatus>(); } },
                { "submissions", n => { Submissions = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.EducationSubmission>(global::NoBackingStore.Graph.Models.EducationSubmission.CreateFromDiscriminatorValue)?.AsList(); } },
                { "webUrl", n => { WebUrl = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.EducationAddedStudentAction>("addedStudentAction", AddedStudentAction);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.EducationAddToCalendarOptions>("addToCalendarAction", AddToCalendarAction);
            writer.WriteBoolValue("allowLateSubmissions", AllowLateSubmissions);
            writer.WriteBoolValue("allowStudentsToAddResourcesToSubmission", AllowStudentsToAddResourcesToSubmission);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.EducationAssignmentRecipient>("assignTo", AssignTo);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.EducationCategory>("categories", Categories);
            writer.WriteStringValue("classId", ClassId);
            writer.WriteDateTimeOffsetValue("closeDateTime", CloseDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("dueDateTime", DueDateTime);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.EducationAssignmentGradeType>("grading", Grading);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.EducationGradingCategory>("gradingCategory", GradingCategory);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.EducationItemBody>("instructions", Instructions);
            writer.WriteStringValue("moduleUrl", ModuleUrl);
            writer.WriteStringValue("notificationChannelUrl", NotificationChannelUrl);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.EducationAssignmentResource>("resources", Resources);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.EducationRubric>("rubric", Rubric);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.EducationSubmission>("submissions", Submissions);
        }
    }
}
#pragma warning restore CS0618
