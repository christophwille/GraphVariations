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
    public partial class PlannerPlan : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Read-only. Nullable. Collection of buckets in the plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PlannerBucket>? Buckets { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PlannerBucket> Buckets { get; set; }
#endif
        /// <summary>Identifies the container of the plan. Specify only the url, the containerId and type, or all properties. After it&apos;s set, this property can’t be updated. Required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PlannerPlanContainer? Container { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PlannerPlanContainer Container { get; set; }
#endif
        /// <summary>Read-only. The user who created the plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>Read-only. Date and time at which the plan is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Read-only. Nullable. Extra details about the plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PlannerPlanDetails? Details { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PlannerPlanDetails Details { get; set; }
#endif
        /// <summary>Use the container property instead. ID of the group that owns the plan. After it&apos;s set, this property can’t be updated. This property won&apos;t return a valid group ID if the container of the plan isn&apos;t a group.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Owner { get; set; }
#nullable restore
#else
        public string Owner { get; set; }
#endif
        /// <summary>Read-only. Nullable. Collection of tasks in the plan.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PlannerTask>? Tasks { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PlannerTask> Tasks { get; set; }
#endif
        /// <summary>Required. Title of the plan.</summary>
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
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.PlannerPlan"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.PlannerPlan CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.PlannerPlan();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "buckets", n => { Buckets = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PlannerBucket>(global::NoBackingStore.Graph.Models.PlannerBucket.CreateFromDiscriminatorValue)?.AsList(); } },
                { "container", n => { Container = n.GetObjectValue<global::NoBackingStore.Graph.Models.PlannerPlanContainer>(global::NoBackingStore.Graph.Models.PlannerPlanContainer.CreateFromDiscriminatorValue); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>(global::NoBackingStore.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "details", n => { Details = n.GetObjectValue<global::NoBackingStore.Graph.Models.PlannerPlanDetails>(global::NoBackingStore.Graph.Models.PlannerPlanDetails.CreateFromDiscriminatorValue); } },
                { "owner", n => { Owner = n.GetStringValue(); } },
                { "tasks", n => { Tasks = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PlannerTask>(global::NoBackingStore.Graph.Models.PlannerTask.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PlannerBucket>("buckets", Buckets);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PlannerPlanContainer>("container", Container);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PlannerPlanDetails>("details", Details);
            writer.WriteStringValue("owner", Owner);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PlannerTask>("tasks", Tasks);
            writer.WriteStringValue("title", Title);
        }
    }
}
#pragma warning restore CS0618
