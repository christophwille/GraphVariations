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
    public partial class SitePage : global::NoBackingStore.Graph.Models.BaseSitePage, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates the layout of the content in a given SharePoint page, including horizontal sections and vertical sections.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.CanvasLayout? CanvasLayout { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.CanvasLayout CanvasLayout { get; set; }
#endif
        /// <summary>Indicates the promotion kind of the sitePage. The possible values are: microsoftReserved, page, newsPost, unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.PagePromotionType? PromotionKind { get; set; }
        /// <summary>Reactions information for the page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ReactionsFacet? Reactions { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ReactionsFacet Reactions { get; set; }
#endif
        /// <summary>Determines whether or not to show comments at the bottom of the page.</summary>
        public bool? ShowComments { get; set; }
        /// <summary>Determines whether or not to show recommended pages at the bottom of the page.</summary>
        public bool? ShowRecommendedPages { get; set; }
        /// <summary>Url of the sitePage&apos;s thumbnail image</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThumbnailWebUrl { get; set; }
#nullable restore
#else
        public string ThumbnailWebUrl { get; set; }
#endif
        /// <summary>Title area on the SharePoint page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.TitleArea? TitleArea { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.TitleArea TitleArea { get; set; }
#endif
        /// <summary>Collection of webparts on the SharePoint page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.WebPart>? WebParts { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.WebPart> WebParts { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.SitePage"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.SitePage CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.SitePage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "canvasLayout", n => { CanvasLayout = n.GetObjectValue<global::NoBackingStore.Graph.Models.CanvasLayout>(global::NoBackingStore.Graph.Models.CanvasLayout.CreateFromDiscriminatorValue); } },
                { "promotionKind", n => { PromotionKind = n.GetEnumValue<global::NoBackingStore.Graph.Models.PagePromotionType>(); } },
                { "reactions", n => { Reactions = n.GetObjectValue<global::NoBackingStore.Graph.Models.ReactionsFacet>(global::NoBackingStore.Graph.Models.ReactionsFacet.CreateFromDiscriminatorValue); } },
                { "showComments", n => { ShowComments = n.GetBoolValue(); } },
                { "showRecommendedPages", n => { ShowRecommendedPages = n.GetBoolValue(); } },
                { "thumbnailWebUrl", n => { ThumbnailWebUrl = n.GetStringValue(); } },
                { "titleArea", n => { TitleArea = n.GetObjectValue<global::NoBackingStore.Graph.Models.TitleArea>(global::NoBackingStore.Graph.Models.TitleArea.CreateFromDiscriminatorValue); } },
                { "webParts", n => { WebParts = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.WebPart>(global::NoBackingStore.Graph.Models.WebPart.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.CanvasLayout>("canvasLayout", CanvasLayout);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.PagePromotionType>("promotionKind", PromotionKind);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ReactionsFacet>("reactions", Reactions);
            writer.WriteBoolValue("showComments", ShowComments);
            writer.WriteBoolValue("showRecommendedPages", ShowRecommendedPages);
            writer.WriteStringValue("thumbnailWebUrl", ThumbnailWebUrl);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.TitleArea>("titleArea", TitleArea);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.WebPart>("webParts", WebParts);
        }
    }
}
#pragma warning restore CS0618
