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
    public partial class WorkbookChartDataLabels : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Represents the format of chart data labels, which includes fill and font formatting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.WorkbookChartDataLabelFormat? Format { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.WorkbookChartDataLabelFormat Format { get; set; }
#endif
        /// <summary>DataLabelPosition value that represents the position of the data label. The possible values are: None, Center, InsideEnd, InsideBase, OutsideEnd, Left, Right, Top, Bottom, BestFit, Callout.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Position { get; set; }
#nullable restore
#else
        public string Position { get; set; }
#endif
        /// <summary>String that represents the separator used for the data labels on a chart.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Separator { get; set; }
#nullable restore
#else
        public string Separator { get; set; }
#endif
        /// <summary>Boolean value that represents whether the data label bubble size is visible.</summary>
        public bool? ShowBubbleSize { get; set; }
        /// <summary>Boolean value that represents whether the data label category name is visible.</summary>
        public bool? ShowCategoryName { get; set; }
        /// <summary>Boolean value that represents whether the data label legend key is visible.</summary>
        public bool? ShowLegendKey { get; set; }
        /// <summary>Boolean value that represents whether the data label percentage is visible.</summary>
        public bool? ShowPercentage { get; set; }
        /// <summary>Boolean value that represents whether the data label series name is visible.</summary>
        public bool? ShowSeriesName { get; set; }
        /// <summary>Boolean value that represents whether the data label value is visible.</summary>
        public bool? ShowValue { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.WorkbookChartDataLabels"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.WorkbookChartDataLabels CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.WorkbookChartDataLabels();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "format", n => { Format = n.GetObjectValue<global::NoBackingStore.Graph.Models.WorkbookChartDataLabelFormat>(global::NoBackingStore.Graph.Models.WorkbookChartDataLabelFormat.CreateFromDiscriminatorValue); } },
                { "position", n => { Position = n.GetStringValue(); } },
                { "separator", n => { Separator = n.GetStringValue(); } },
                { "showBubbleSize", n => { ShowBubbleSize = n.GetBoolValue(); } },
                { "showCategoryName", n => { ShowCategoryName = n.GetBoolValue(); } },
                { "showLegendKey", n => { ShowLegendKey = n.GetBoolValue(); } },
                { "showPercentage", n => { ShowPercentage = n.GetBoolValue(); } },
                { "showSeriesName", n => { ShowSeriesName = n.GetBoolValue(); } },
                { "showValue", n => { ShowValue = n.GetBoolValue(); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.WorkbookChartDataLabelFormat>("format", Format);
            writer.WriteStringValue("position", Position);
            writer.WriteStringValue("separator", Separator);
            writer.WriteBoolValue("showBubbleSize", ShowBubbleSize);
            writer.WriteBoolValue("showCategoryName", ShowCategoryName);
            writer.WriteBoolValue("showLegendKey", ShowLegendKey);
            writer.WriteBoolValue("showPercentage", ShowPercentage);
            writer.WriteBoolValue("showSeriesName", ShowSeriesName);
            writer.WriteBoolValue("showValue", ShowValue);
        }
    }
}
#pragma warning restore CS0618
