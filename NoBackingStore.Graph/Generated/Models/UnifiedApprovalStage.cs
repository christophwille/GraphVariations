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
    public partial class UnifiedApprovalStage : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The number of days that a request can be pending a response before it is automatically denied.</summary>
        public int? ApprovalStageTimeOutInDays { get; set; }
        /// <summary>The escalation approvers for this stage when the primary approvers don&apos;t respond.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.SubjectSet>? EscalationApprovers { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.SubjectSet> EscalationApprovers { get; set; }
#endif
        /// <summary>The time a request can be pending a response from a primary approver before it can be escalated to the escalation approvers.</summary>
        public int? EscalationTimeInMinutes { get; set; }
        /// <summary>Indicates whether the approver must provide justification for their reponse.</summary>
        public bool? IsApproverJustificationRequired { get; set; }
        /// <summary>Indicates whether escalation if enabled.</summary>
        public bool? IsEscalationEnabled { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The primary approvers of this stage.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.SubjectSet>? PrimaryApprovers { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.SubjectSet> PrimaryApprovers { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.UnifiedApprovalStage"/> and sets the default values.
        /// </summary>
        public UnifiedApprovalStage()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.UnifiedApprovalStage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.UnifiedApprovalStage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.UnifiedApprovalStage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "approvalStageTimeOutInDays", n => { ApprovalStageTimeOutInDays = n.GetIntValue(); } },
                { "escalationApprovers", n => { EscalationApprovers = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.SubjectSet>(global::NoBackingStore.Graph.Models.SubjectSet.CreateFromDiscriminatorValue)?.AsList(); } },
                { "escalationTimeInMinutes", n => { EscalationTimeInMinutes = n.GetIntValue(); } },
                { "isApproverJustificationRequired", n => { IsApproverJustificationRequired = n.GetBoolValue(); } },
                { "isEscalationEnabled", n => { IsEscalationEnabled = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "primaryApprovers", n => { PrimaryApprovers = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.SubjectSet>(global::NoBackingStore.Graph.Models.SubjectSet.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("approvalStageTimeOutInDays", ApprovalStageTimeOutInDays);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.SubjectSet>("escalationApprovers", EscalationApprovers);
            writer.WriteIntValue("escalationTimeInMinutes", EscalationTimeInMinutes);
            writer.WriteBoolValue("isApproverJustificationRequired", IsApproverJustificationRequired);
            writer.WriteBoolValue("isEscalationEnabled", IsEscalationEnabled);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.SubjectSet>("primaryApprovers", PrimaryApprovers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
