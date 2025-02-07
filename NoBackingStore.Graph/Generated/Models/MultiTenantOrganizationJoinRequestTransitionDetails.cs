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
    public partial class MultiTenantOrganizationJoinRequestTransitionDetails : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>State of the tenant in the multitenant organization currently being processed. The possible values are: pending, active, removed, unknownFutureValue. Read-only.</summary>
        public global::NoBackingStore.Graph.Models.MultiTenantOrganizationMemberState? DesiredMemberState { get; set; }
        /// <summary>Details that explain the processing status if any. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Details { get; set; }
#nullable restore
#else
        public string Details { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Processing state of the asynchronous job. The possible values are: notStarted, running, succeeded, failed, unknownFutureValue. Read-only.</summary>
        public global::NoBackingStore.Graph.Models.MultiTenantOrganizationMemberProcessingStatus? Status { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.MultiTenantOrganizationJoinRequestTransitionDetails"/> and sets the default values.
        /// </summary>
        public MultiTenantOrganizationJoinRequestTransitionDetails()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.MultiTenantOrganizationJoinRequestTransitionDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.MultiTenantOrganizationJoinRequestTransitionDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.MultiTenantOrganizationJoinRequestTransitionDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "desiredMemberState", n => { DesiredMemberState = n.GetEnumValue<global::NoBackingStore.Graph.Models.MultiTenantOrganizationMemberState>(); } },
                { "details", n => { Details = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "status", n => { Status = n.GetEnumValue<global::NoBackingStore.Graph.Models.MultiTenantOrganizationMemberProcessingStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.MultiTenantOrganizationMemberState>("desiredMemberState", DesiredMemberState);
            writer.WriteStringValue("details", Details);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.MultiTenantOrganizationMemberProcessingStatus>("status", Status);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
