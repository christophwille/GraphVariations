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
    public partial class TrainingNotificationSetting : global::NoBackingStore.Graph.Models.EndUserNotificationSetting, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Training assignment details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.BaseEndUserNotification? TrainingAssignment { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.BaseEndUserNotification TrainingAssignment { get; set; }
#endif
        /// <summary>Training reminder details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.TrainingReminderNotification? TrainingReminder { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.TrainingReminderNotification TrainingReminder { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.TrainingNotificationSetting"/> and sets the default values.
        /// </summary>
        public TrainingNotificationSetting() : base()
        {
            OdataType = "#microsoft.graph.trainingNotificationSetting";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.TrainingNotificationSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.TrainingNotificationSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.TrainingNotificationSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "trainingAssignment", n => { TrainingAssignment = n.GetObjectValue<global::NoBackingStore.Graph.Models.BaseEndUserNotification>(global::NoBackingStore.Graph.Models.BaseEndUserNotification.CreateFromDiscriminatorValue); } },
                { "trainingReminder", n => { TrainingReminder = n.GetObjectValue<global::NoBackingStore.Graph.Models.TrainingReminderNotification>(global::NoBackingStore.Graph.Models.TrainingReminderNotification.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.BaseEndUserNotification>("trainingAssignment", TrainingAssignment);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.TrainingReminderNotification>("trainingReminder", TrainingReminder);
        }
    }
}
#pragma warning restore CS0618
