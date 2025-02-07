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
    public partial class ThreatAssessmentRequest : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The category property</summary>
        public global::NoBackingStore.Graph.Models.ThreatCategory? Category { get; set; }
        /// <summary>The content type of threat assessment. Possible values are: mail, url, file.</summary>
        public global::NoBackingStore.Graph.Models.ThreatAssessmentContentType? ContentType { get; set; }
        /// <summary>The threat assessment request creator.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentitySet? CreatedBy { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentitySet CreatedBy { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The expectedAssessment property</summary>
        public global::NoBackingStore.Graph.Models.ThreatExpectedAssessment? ExpectedAssessment { get; set; }
        /// <summary>The source of the threat assessment request. Possible values are: administrator.</summary>
        public global::NoBackingStore.Graph.Models.ThreatAssessmentRequestSource? RequestSource { get; set; }
        /// <summary>A collection of threat assessment results. Read-only. By default, a GET /threatAssessmentRequests/{id} does not return this property unless you apply $expand on it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ThreatAssessmentResult>? Results { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ThreatAssessmentResult> Results { get; set; }
#endif
        /// <summary>The assessment process status. Possible values are: pending, completed.</summary>
        public global::NoBackingStore.Graph.Models.ThreatAssessmentStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.ThreatAssessmentRequest"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.ThreatAssessmentRequest CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.emailFileAssessmentRequest" => new global::NoBackingStore.Graph.Models.EmailFileAssessmentRequest(),
                "#microsoft.graph.fileAssessmentRequest" => new global::NoBackingStore.Graph.Models.FileAssessmentRequest(),
                "#microsoft.graph.mailAssessmentRequest" => new global::NoBackingStore.Graph.Models.MailAssessmentRequest(),
                "#microsoft.graph.urlAssessmentRequest" => new global::NoBackingStore.Graph.Models.UrlAssessmentRequest(),
                _ => new global::NoBackingStore.Graph.Models.ThreatAssessmentRequest(),
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
                { "category", n => { Category = n.GetEnumValue<global::NoBackingStore.Graph.Models.ThreatCategory>(); } },
                { "contentType", n => { ContentType = n.GetEnumValue<global::NoBackingStore.Graph.Models.ThreatAssessmentContentType>(); } },
                { "createdBy", n => { CreatedBy = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>(global::NoBackingStore.Graph.Models.IdentitySet.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "expectedAssessment", n => { ExpectedAssessment = n.GetEnumValue<global::NoBackingStore.Graph.Models.ThreatExpectedAssessment>(); } },
                { "requestSource", n => { RequestSource = n.GetEnumValue<global::NoBackingStore.Graph.Models.ThreatAssessmentRequestSource>(); } },
                { "results", n => { Results = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ThreatAssessmentResult>(global::NoBackingStore.Graph.Models.ThreatAssessmentResult.CreateFromDiscriminatorValue)?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::NoBackingStore.Graph.Models.ThreatAssessmentStatus>(); } },
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
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ThreatCategory>("category", Category);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ThreatAssessmentContentType>("contentType", ContentType);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ThreatExpectedAssessment>("expectedAssessment", ExpectedAssessment);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ThreatAssessmentRequestSource>("requestSource", RequestSource);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ThreatAssessmentResult>("results", Results);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ThreatAssessmentStatus>("status", Status);
        }
    }
}
#pragma warning restore CS0618
