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
    /// The user experience analytics insight is the recomendation to improve the user experience analytics score.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class UserExperienceAnalyticsInsight : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The unique identifier of the user experience analytics insight.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? InsightId { get; set; }
#nullable restore
#else
        public string InsightId { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Indicates severity of insights. Possible values are: None, Informational, Warning, Error.</summary>
        public global::NoBackingStore.Graph.Models.UserExperienceAnalyticsInsightSeverity? Severity { get; set; }
        /// <summary>The unique identifier of the user experience analytics metric.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserExperienceAnalyticsMetricId { get; set; }
#nullable restore
#else
        public string UserExperienceAnalyticsMetricId { get; set; }
#endif
        /// <summary>The value of the user experience analytics insight.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.UserExperienceAnalyticsInsightValue>? Values { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.UserExperienceAnalyticsInsightValue> Values { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.UserExperienceAnalyticsInsight"/> and sets the default values.
        /// </summary>
        public UserExperienceAnalyticsInsight()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.UserExperienceAnalyticsInsight"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.UserExperienceAnalyticsInsight CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.UserExperienceAnalyticsInsight();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "insightId", n => { InsightId = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "severity", n => { Severity = n.GetEnumValue<global::NoBackingStore.Graph.Models.UserExperienceAnalyticsInsightSeverity>(); } },
                { "userExperienceAnalyticsMetricId", n => { UserExperienceAnalyticsMetricId = n.GetStringValue(); } },
                { "values", n => { Values = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.UserExperienceAnalyticsInsightValue>(global::NoBackingStore.Graph.Models.UserExperienceAnalyticsInsightValue.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("insightId", InsightId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.UserExperienceAnalyticsInsightSeverity>("severity", Severity);
            writer.WriteStringValue("userExperienceAnalyticsMetricId", UserExperienceAnalyticsMetricId);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.UserExperienceAnalyticsInsightValue>("values", Values);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
