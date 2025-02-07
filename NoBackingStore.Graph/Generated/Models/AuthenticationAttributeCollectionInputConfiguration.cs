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
    public partial class AuthenticationAttributeCollectionInputConfiguration : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The built-in or custom attribute for which a value is being collected.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Attribute { get; set; }
#nullable restore
#else
        public string Attribute { get; set; }
#endif
        /// <summary>The default value of the attribute displayed to the end user. The capability to set the default value isn&apos;t available through the Microsoft Entra admin center.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultValue { get; set; }
#nullable restore
#else
        public string DefaultValue { get; set; }
#endif
        /// <summary>Defines whether the attribute is editable by the end user.</summary>
        public bool? Editable { get; set; }
        /// <summary>Defines whether the attribute is displayed to the end user. The capability to hide isn&apos;t available through the Microsoft Entra admin center.</summary>
        public bool? Hidden { get; set; }
        /// <summary>The inputType property</summary>
        public global::NoBackingStore.Graph.Models.AuthenticationAttributeCollectionInputType? InputType { get; set; }
        /// <summary>The label of the attribute field that&apos;s displayed to end user, unless overridden.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; set; }
#nullable restore
#else
        public string Label { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The option values for certain multiple-option input types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.AuthenticationAttributeCollectionOptionConfiguration>? Options { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.AuthenticationAttributeCollectionOptionConfiguration> Options { get; set; }
#endif
        /// <summary>Defines whether the field is required.</summary>
        public bool? Required { get; set; }
        /// <summary>The regex for the value of the field. For more information about the supported regexes, see validationRegEx values for inputType objects. To understand how to specify regexes, see the Regular expressions cheat sheet.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValidationRegEx { get; set; }
#nullable restore
#else
        public string ValidationRegEx { get; set; }
#endif
        /// <summary>Defines whether Microsoft Entra ID stores the value that it collects.</summary>
        public bool? WriteToDirectory { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.AuthenticationAttributeCollectionInputConfiguration"/> and sets the default values.
        /// </summary>
        public AuthenticationAttributeCollectionInputConfiguration()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.AuthenticationAttributeCollectionInputConfiguration"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.AuthenticationAttributeCollectionInputConfiguration CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.AuthenticationAttributeCollectionInputConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "attribute", n => { Attribute = n.GetStringValue(); } },
                { "defaultValue", n => { DefaultValue = n.GetStringValue(); } },
                { "editable", n => { Editable = n.GetBoolValue(); } },
                { "hidden", n => { Hidden = n.GetBoolValue(); } },
                { "inputType", n => { InputType = n.GetEnumValue<global::NoBackingStore.Graph.Models.AuthenticationAttributeCollectionInputType>(); } },
                { "label", n => { Label = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "options", n => { Options = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.AuthenticationAttributeCollectionOptionConfiguration>(global::NoBackingStore.Graph.Models.AuthenticationAttributeCollectionOptionConfiguration.CreateFromDiscriminatorValue)?.AsList(); } },
                { "required", n => { Required = n.GetBoolValue(); } },
                { "validationRegEx", n => { ValidationRegEx = n.GetStringValue(); } },
                { "writeToDirectory", n => { WriteToDirectory = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("attribute", Attribute);
            writer.WriteStringValue("defaultValue", DefaultValue);
            writer.WriteBoolValue("editable", Editable);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.AuthenticationAttributeCollectionInputType>("inputType", InputType);
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.AuthenticationAttributeCollectionOptionConfiguration>("options", Options);
            writer.WriteBoolValue("required", Required);
            writer.WriteStringValue("validationRegEx", ValidationRegEx);
            writer.WriteBoolValue("writeToDirectory", WriteToDirectory);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
