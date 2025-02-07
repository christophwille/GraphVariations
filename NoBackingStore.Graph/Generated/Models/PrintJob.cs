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
    public partial class PrintJob : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The configuration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PrintJobConfiguration? Configuration { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PrintJobConfiguration Configuration { get; set; }
#endif
        /// <summary>The createdBy property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.UserIdentity? CreatedBy { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.UserIdentity CreatedBy { get; set; }
#endif
        /// <summary>The DateTimeOffset when the job was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The documents property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PrintDocument>? Documents { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PrintDocument> Documents { get; set; }
#endif
        /// <summary>If true, document can be fetched by printer.</summary>
        public bool? IsFetchable { get; set; }
        /// <summary>Contains the source job URL, if the job has been redirected from another printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RedirectedFrom { get; set; }
#nullable restore
#else
        public string RedirectedFrom { get; set; }
#endif
        /// <summary>Contains the destination job URL, if the job has been redirected to another printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RedirectedTo { get; set; }
#nullable restore
#else
        public string RedirectedTo { get; set; }
#endif
        /// <summary>The status property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PrintJobStatus? Status { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PrintJobStatus Status { get; set; }
#endif
        /// <summary>A list of printTasks that were triggered by this print job.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PrintTask>? Tasks { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PrintTask> Tasks { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.PrintJob"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.PrintJob CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.PrintJob();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "configuration", n => { Configuration = n.GetObjectValue<global::NoBackingStore.Graph.Models.PrintJobConfiguration>(global::NoBackingStore.Graph.Models.PrintJobConfiguration.CreateFromDiscriminatorValue); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::NoBackingStore.Graph.Models.UserIdentity>(global::NoBackingStore.Graph.Models.UserIdentity.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "documents", n => { Documents = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrintDocument>(global::NoBackingStore.Graph.Models.PrintDocument.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isFetchable", n => { IsFetchable = n.GetBoolValue(); } },
                { "redirectedFrom", n => { RedirectedFrom = n.GetStringValue(); } },
                { "redirectedTo", n => { RedirectedTo = n.GetStringValue(); } },
                { "status", n => { Status = n.GetObjectValue<global::NoBackingStore.Graph.Models.PrintJobStatus>(global::NoBackingStore.Graph.Models.PrintJobStatus.CreateFromDiscriminatorValue); } },
                { "tasks", n => { Tasks = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrintTask>(global::NoBackingStore.Graph.Models.PrintTask.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PrintJobConfiguration>("configuration", Configuration);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.UserIdentity>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrintDocument>("documents", Documents);
            writer.WriteBoolValue("isFetchable", IsFetchable);
            writer.WriteStringValue("redirectedFrom", RedirectedFrom);
            writer.WriteStringValue("redirectedTo", RedirectedTo);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PrintJobStatus>("status", Status);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PrintTask>("tasks", Tasks);
        }
    }
}
#pragma warning restore CS0618
