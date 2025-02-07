// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace NoBackingStore.Graph.Models
{
    /// <summary>
    /// Represents the status of a Viva Engage async operation that is an operation that transcends thelifetime of a single API request. These operations are long-running or too expensive to completewithin the time frame of their original request.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class EngagementAsyncOperation : global::NoBackingStore.Graph.Models.LongRunningOperation, IParsable
    {
        /// <summary>The type of the long-running operation. The possible values are: createCommunity, unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.EngagementAsyncOperationType? OperationType { get; set; }
        /// <summary>The ID of the object created or modified as a result of this async operation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ResourceId { get; set; }
#nullable restore
#else
        public string ResourceId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.EngagementAsyncOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.EngagementAsyncOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.EngagementAsyncOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "operationType", n => { OperationType = n.GetEnumValue<global::NoBackingStore.Graph.Models.EngagementAsyncOperationType>(); } },
                { "resourceId", n => { ResourceId = n.GetStringValue(); } },
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
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.EngagementAsyncOperationType>("operationType", OperationType);
            writer.WriteStringValue("resourceId", ResourceId);
        }
    }
}
#pragma warning restore CS0618
