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
    public partial class MicrosoftManagedTrainingSetting : global::NoBackingStore.Graph.Models.TrainingSetting, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The completion date for the training. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CompletionDateTime { get; set; }
        /// <summary>The training completion duration that needs to be provided before scheduling the training. The possible values are: week, fortnite, month, unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.TrainingCompletionDuration? TrainingCompletionDuration { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.MicrosoftManagedTrainingSetting"/> and sets the default values.
        /// </summary>
        public MicrosoftManagedTrainingSetting() : base()
        {
            OdataType = "#microsoft.graph.microsoftManagedTrainingSetting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.MicrosoftManagedTrainingSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.MicrosoftManagedTrainingSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.MicrosoftManagedTrainingSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                { "trainingCompletionDuration", n => { TrainingCompletionDuration = n.GetEnumValue<global::NoBackingStore.Graph.Models.TrainingCompletionDuration>(); } },
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
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.TrainingCompletionDuration>("trainingCompletionDuration", TrainingCompletionDuration);
        }
    }
}
#pragma warning restore CS0618
