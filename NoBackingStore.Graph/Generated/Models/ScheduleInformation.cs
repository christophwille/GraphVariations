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
    public partial class ScheduleInformation : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Represents a merged view of availability of all the items in scheduleItems. The view consists of time slots. Availability during each time slot is indicated with: 0= free or working elswhere, 1= tentative, 2= busy, 3= out of office.Note: Working elsewhere is set to 0 instead of 4 for backward compatibility. For details, see the Q&amp;A and Exchange 2007 and Exchange 2010 do not use the WorkingElsewhere value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvailabilityView { get; set; }
#nullable restore
#else
        public string AvailabilityView { get; set; }
#endif
        /// <summary>Error information from attempting to get the availability of the user, distribution list, or resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.FreeBusyError? Error { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.FreeBusyError Error { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>An SMTP address of the user, distribution list, or resource, identifying an instance of scheduleInformation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScheduleId { get; set; }
#nullable restore
#else
        public string ScheduleId { get; set; }
#endif
        /// <summary>Contains the items that describe the availability of the user or resource.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ScheduleItem>? ScheduleItems { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ScheduleItem> ScheduleItems { get; set; }
#endif
        /// <summary>The days of the week and hours in a specific time zone that the user works. These are set as part of the user&apos;s mailboxSettings.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.WorkingHours? WorkingHours { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.WorkingHours WorkingHours { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.ScheduleInformation"/> and sets the default values.
        /// </summary>
        public ScheduleInformation()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.ScheduleInformation"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.ScheduleInformation CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.ScheduleInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "availabilityView", n => { AvailabilityView = n.GetStringValue(); } },
                { "error", n => { Error = n.GetObjectValue<global::NoBackingStore.Graph.Models.FreeBusyError>(global::NoBackingStore.Graph.Models.FreeBusyError.CreateFromDiscriminatorValue); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "scheduleId", n => { ScheduleId = n.GetStringValue(); } },
                { "scheduleItems", n => { ScheduleItems = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ScheduleItem>(global::NoBackingStore.Graph.Models.ScheduleItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "workingHours", n => { WorkingHours = n.GetObjectValue<global::NoBackingStore.Graph.Models.WorkingHours>(global::NoBackingStore.Graph.Models.WorkingHours.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("availabilityView", AvailabilityView);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.FreeBusyError>("error", Error);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("scheduleId", ScheduleId);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ScheduleItem>("scheduleItems", ScheduleItems);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.WorkingHours>("workingHours", WorkingHours);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
