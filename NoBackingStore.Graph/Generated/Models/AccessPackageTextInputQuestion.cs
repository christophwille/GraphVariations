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
    public partial class AccessPackageTextInputQuestion : global::NoBackingStore.Graph.Models.AccessPackageQuestion, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether the answer is in single or multiple line format.</summary>
        public bool? IsSingleLineQuestion { get; set; }
        /// <summary>The regular expression pattern that any answer to this question must match.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RegexPattern { get; set; }
#nullable restore
#else
        public string RegexPattern { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.AccessPackageTextInputQuestion"/> and sets the default values.
        /// </summary>
        public AccessPackageTextInputQuestion() : base()
        {
            OdataType = "#microsoft.graph.accessPackageTextInputQuestion";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.AccessPackageTextInputQuestion"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.AccessPackageTextInputQuestion CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.AccessPackageTextInputQuestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "isSingleLineQuestion", n => { IsSingleLineQuestion = n.GetBoolValue(); } },
                { "regexPattern", n => { RegexPattern = n.GetStringValue(); } },
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
            writer.WriteBoolValue("isSingleLineQuestion", IsSingleLineQuestion);
            writer.WriteStringValue("regexPattern", RegexPattern);
        }
    }
}
#pragma warning restore CS0618
