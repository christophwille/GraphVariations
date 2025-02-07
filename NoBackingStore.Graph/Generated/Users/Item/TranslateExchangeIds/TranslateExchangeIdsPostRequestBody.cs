// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using NoBackingStore.Graph.Models;
using System.Collections.Generic;
using System.IO;
using System;
namespace NoBackingStore.Graph.Users.Item.TranslateExchangeIds
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class TranslateExchangeIdsPostRequestBody : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The InputIds property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? InputIds { get; set; }
#nullable restore
#else
        public List<string> InputIds { get; set; }
#endif
        /// <summary>The SourceIdType property</summary>
        public global::NoBackingStore.Graph.Models.ExchangeIdFormat? SourceIdType { get; set; }
        /// <summary>The TargetIdType property</summary>
        public global::NoBackingStore.Graph.Models.ExchangeIdFormat? TargetIdType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Users.Item.TranslateExchangeIds.TranslateExchangeIdsPostRequestBody"/> and sets the default values.
        /// </summary>
        public TranslateExchangeIdsPostRequestBody()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Users.Item.TranslateExchangeIds.TranslateExchangeIdsPostRequestBody"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Users.Item.TranslateExchangeIds.TranslateExchangeIdsPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Users.Item.TranslateExchangeIds.TranslateExchangeIdsPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "InputIds", n => { InputIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "SourceIdType", n => { SourceIdType = n.GetEnumValue<global::NoBackingStore.Graph.Models.ExchangeIdFormat>(); } },
                { "TargetIdType", n => { TargetIdType = n.GetEnumValue<global::NoBackingStore.Graph.Models.ExchangeIdFormat>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("InputIds", InputIds);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ExchangeIdFormat>("SourceIdType", SourceIdType);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.ExchangeIdFormat>("TargetIdType", TargetIdType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
