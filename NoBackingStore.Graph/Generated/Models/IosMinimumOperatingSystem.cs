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
    /// Contains properties of the minimum operating system required for an iOS mobile app.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class IosMinimumOperatingSystem : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>When TRUE, only Version 10.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V100 { get; set; }
        /// <summary>When TRUE, only Version 11.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V110 { get; set; }
        /// <summary>When TRUE, only Version 12.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V120 { get; set; }
        /// <summary>When TRUE, only Version 13.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V130 { get; set; }
        /// <summary>When TRUE, only Version 14.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V140 { get; set; }
        /// <summary>When TRUE, only Version 15.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V150 { get; set; }
        /// <summary>When TRUE, only Version 8.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V80 { get; set; }
        /// <summary>When TRUE, only Version 9.0 or later is supported. Default value is FALSE. Exactly one of the minimum operating system boolean values will be TRUE.</summary>
        public bool? V90 { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.IosMinimumOperatingSystem"/> and sets the default values.
        /// </summary>
        public IosMinimumOperatingSystem()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.IosMinimumOperatingSystem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.IosMinimumOperatingSystem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.IosMinimumOperatingSystem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "v10_0", n => { V100 = n.GetBoolValue(); } },
                { "v11_0", n => { V110 = n.GetBoolValue(); } },
                { "v12_0", n => { V120 = n.GetBoolValue(); } },
                { "v13_0", n => { V130 = n.GetBoolValue(); } },
                { "v14_0", n => { V140 = n.GetBoolValue(); } },
                { "v15_0", n => { V150 = n.GetBoolValue(); } },
                { "v8_0", n => { V80 = n.GetBoolValue(); } },
                { "v9_0", n => { V90 = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("v10_0", V100);
            writer.WriteBoolValue("v11_0", V110);
            writer.WriteBoolValue("v12_0", V120);
            writer.WriteBoolValue("v13_0", V130);
            writer.WriteBoolValue("v14_0", V140);
            writer.WriteBoolValue("v15_0", V150);
            writer.WriteBoolValue("v8_0", V80);
            writer.WriteBoolValue("v9_0", V90);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
