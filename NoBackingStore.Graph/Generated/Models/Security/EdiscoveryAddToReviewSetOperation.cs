// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace NoBackingStore.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class EdiscoveryAddToReviewSetOperation : global::NoBackingStore.Graph.Models.Security.CaseOperation, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>eDiscovery review set to which items matching source collection query gets added.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.Security.EdiscoveryReviewSet? ReviewSet { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.Security.EdiscoveryReviewSet ReviewSet { get; set; }
#endif
        /// <summary>eDiscovery search that gets added to review set.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.Security.EdiscoverySearch? Search { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.Security.EdiscoverySearch Search { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.Security.EdiscoveryAddToReviewSetOperation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.Security.EdiscoveryAddToReviewSetOperation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.Security.EdiscoveryAddToReviewSetOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "reviewSet", n => { ReviewSet = n.GetObjectValue<global::NoBackingStore.Graph.Models.Security.EdiscoveryReviewSet>(global::NoBackingStore.Graph.Models.Security.EdiscoveryReviewSet.CreateFromDiscriminatorValue); } },
                { "search", n => { Search = n.GetObjectValue<global::NoBackingStore.Graph.Models.Security.EdiscoverySearch>(global::NoBackingStore.Graph.Models.Security.EdiscoverySearch.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.Security.EdiscoveryReviewSet>("reviewSet", ReviewSet);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.Security.EdiscoverySearch>("search", Search);
        }
    }
}
#pragma warning restore CS0618
