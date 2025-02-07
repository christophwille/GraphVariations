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
    public partial class UserSimulationDetails : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of trainings assigned to a user in an attack simulation and training campaign.</summary>
        public int? AssignedTrainingsCount { get; set; }
        /// <summary>Number of trainings completed by a user in an attack simulation and training campaign.</summary>
        public int? CompletedTrainingsCount { get; set; }
        /// <summary>Date and time of the compromising online action by a user in an attack simulation and training campaign.</summary>
        public DateTimeOffset? CompromisedDateTime { get; set; }
        /// <summary>Number of trainings in progress by a user in an attack simulation and training campaign.</summary>
        public int? InProgressTrainingsCount { get; set; }
        /// <summary>Indicates whether a user was compromised in an attack simulation and training campaign.</summary>
        public bool? IsCompromised { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Date and time when a user reported the delivered payload as phishing in the attack simulation and training campaign.</summary>
        public DateTimeOffset? ReportedPhishDateTime { get; set; }
        /// <summary>List of simulation events of a user in the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.UserSimulationEventInfo>? SimulationEvents { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.UserSimulationEventInfo> SimulationEvents { get; set; }
#endif
        /// <summary>User in an attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.AttackSimulationUser? SimulationUser { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.AttackSimulationUser SimulationUser { get; set; }
#endif
        /// <summary>List of training events of a user in the attack simulation and training campaign.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.UserTrainingEventInfo>? TrainingEvents { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.UserTrainingEventInfo> TrainingEvents { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.UserSimulationDetails"/> and sets the default values.
        /// </summary>
        public UserSimulationDetails()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.UserSimulationDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.UserSimulationDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.UserSimulationDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "assignedTrainingsCount", n => { AssignedTrainingsCount = n.GetIntValue(); } },
                { "completedTrainingsCount", n => { CompletedTrainingsCount = n.GetIntValue(); } },
                { "compromisedDateTime", n => { CompromisedDateTime = n.GetDateTimeOffsetValue(); } },
                { "inProgressTrainingsCount", n => { InProgressTrainingsCount = n.GetIntValue(); } },
                { "isCompromised", n => { IsCompromised = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "reportedPhishDateTime", n => { ReportedPhishDateTime = n.GetDateTimeOffsetValue(); } },
                { "simulationEvents", n => { SimulationEvents = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.UserSimulationEventInfo>(global::NoBackingStore.Graph.Models.UserSimulationEventInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "simulationUser", n => { SimulationUser = n.GetObjectValue<global::NoBackingStore.Graph.Models.AttackSimulationUser>(global::NoBackingStore.Graph.Models.AttackSimulationUser.CreateFromDiscriminatorValue); } },
                { "trainingEvents", n => { TrainingEvents = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.UserTrainingEventInfo>(global::NoBackingStore.Graph.Models.UserTrainingEventInfo.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("assignedTrainingsCount", AssignedTrainingsCount);
            writer.WriteIntValue("completedTrainingsCount", CompletedTrainingsCount);
            writer.WriteDateTimeOffsetValue("compromisedDateTime", CompromisedDateTime);
            writer.WriteIntValue("inProgressTrainingsCount", InProgressTrainingsCount);
            writer.WriteBoolValue("isCompromised", IsCompromised);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteDateTimeOffsetValue("reportedPhishDateTime", ReportedPhishDateTime);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.UserSimulationEventInfo>("simulationEvents", SimulationEvents);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.AttackSimulationUser>("simulationUser", SimulationUser);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.UserTrainingEventInfo>("trainingEvents", TrainingEvents);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
