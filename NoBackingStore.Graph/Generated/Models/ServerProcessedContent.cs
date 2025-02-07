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
    public partial class ServerProcessedContent : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A key-value map where keys are string identifiers and values are rich text with HTML format. SharePoint servers treat the values as HTML content and run services like safety checks, search index and link fixup on them.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair>? HtmlStrings { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair> HtmlStrings { get; set; }
#endif
        /// <summary>A key-value map where keys are string identifiers and values are image sources. SharePoint servers treat the values as image sources and run services like search index and link fixup on them.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair>? ImageSources { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair> ImageSources { get; set; }
#endif
        /// <summary>A key-value map where keys are string identifiers and values are links. SharePoint servers treat the values as links and run services like link fixup on them.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair>? Links { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair> Links { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>A key-value map where keys are string identifiers and values are strings that should be search indexed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair>? SearchablePlainTexts { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair> SearchablePlainTexts { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.ServerProcessedContent"/> and sets the default values.
        /// </summary>
        public ServerProcessedContent()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.ServerProcessedContent"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.ServerProcessedContent CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.ServerProcessedContent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "htmlStrings", n => { HtmlStrings = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair>(global::NoBackingStore.Graph.Models.MetaDataKeyStringPair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "imageSources", n => { ImageSources = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair>(global::NoBackingStore.Graph.Models.MetaDataKeyStringPair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "links", n => { Links = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair>(global::NoBackingStore.Graph.Models.MetaDataKeyStringPair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "searchablePlainTexts", n => { SearchablePlainTexts = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair>(global::NoBackingStore.Graph.Models.MetaDataKeyStringPair.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair>("htmlStrings", HtmlStrings);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair>("imageSources", ImageSources);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair>("links", Links);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MetaDataKeyStringPair>("searchablePlainTexts", SearchablePlainTexts);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
