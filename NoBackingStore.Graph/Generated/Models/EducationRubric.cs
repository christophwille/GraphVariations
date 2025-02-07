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
    public partial class EducationRubric : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The user who created this resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentitySet? CreatedBy { get; private set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentitySet CreatedBy { get; private set; }
#endif
        /// <summary>The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; private set; }
        /// <summary>The description of this rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.EducationItemBody? Description { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.EducationItemBody Description { get; set; }
#endif
        /// <summary>The name of this rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The grading type of this rubric. You can use null for a no-points rubric or educationAssignmentPointsGradeType for a points rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.EducationAssignmentGradeType? Grading { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.EducationAssignmentGradeType Grading { get; set; }
#endif
        /// <summary>The last user to modify the resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentitySet? LastModifiedBy { get; private set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentitySet LastModifiedBy { get; private set; }
#endif
        /// <summary>Moment in time when the resource was last modified. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; private set; }
        /// <summary>The collection of levels making up this rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.RubricLevel>? Levels { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.RubricLevel> Levels { get; set; }
#endif
        /// <summary>The collection of qualities making up this rubric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.RubricQuality>? Qualities { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.RubricQuality> Qualities { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.EducationRubric"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.EducationRubric CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.EducationRubric();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>(global::NoBackingStore.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "description", n => { Description = n.GetObjectValue<global::NoBackingStore.Graph.Models.EducationItemBody>(global::NoBackingStore.Graph.Models.EducationItemBody.CreateFromDiscriminatorValue); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "grading", n => { Grading = n.GetObjectValue<global::NoBackingStore.Graph.Models.EducationAssignmentGradeType>(global::NoBackingStore.Graph.Models.EducationAssignmentGradeType.CreateFromDiscriminatorValue); } },
                { "lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>(global::NoBackingStore.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "levels", n => { Levels = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.RubricLevel>(global::NoBackingStore.Graph.Models.RubricLevel.CreateFromDiscriminatorValue)?.AsList(); } },
                { "qualities", n => { Qualities = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.RubricQuality>(global::NoBackingStore.Graph.Models.RubricQuality.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.EducationItemBody>("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.EducationAssignmentGradeType>("grading", Grading);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.RubricLevel>("levels", Levels);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.RubricQuality>("qualities", Qualities);
        }
    }
}
#pragma warning restore CS0618
