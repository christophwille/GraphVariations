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
    public partial class OnenotePatchContentCommand : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The action property</summary>
        public global::NoBackingStore.Graph.Models.OnenotePatchActionType? Action { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A string of well-formed HTML to add to the page, and any image or file binary data. If the content contains binary data, the request must be sent using the multipart/form-data content type with a &apos;Commands&apos; part.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Content { get; set; }
#nullable restore
#else
        public string Content { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The location to add the supplied content, relative to the target element. The possible values are: after (default) or before.</summary>
        public global::NoBackingStore.Graph.Models.OnenotePatchInsertPosition? Position { get; set; }
        /// <summary>The element to update. Must be the #&lt;data-id&gt; or the generated &lt;id&gt; of the element, or the body or title keyword.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Target { get; set; }
#nullable restore
#else
        public string Target { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.OnenotePatchContentCommand"/> and sets the default values.
        /// </summary>
        public OnenotePatchContentCommand()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.OnenotePatchContentCommand"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.OnenotePatchContentCommand CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.OnenotePatchContentCommand();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "action", n => { Action = n.GetEnumValue<global::NoBackingStore.Graph.Models.OnenotePatchActionType>(); } },
                { "content", n => { Content = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "position", n => { Position = n.GetEnumValue<global::NoBackingStore.Graph.Models.OnenotePatchInsertPosition>(); } },
                { "target", n => { Target = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.OnenotePatchActionType>("action", Action);
            writer.WriteStringValue("content", Content);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.OnenotePatchInsertPosition>("position", Position);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
