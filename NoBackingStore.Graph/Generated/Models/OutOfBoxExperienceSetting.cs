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
    /// The Windows Autopilot Deployment Profile settings used by the device for the out-of-box experience. Supports: $select, $top, $skip. $Search, $orderBy and $filter are not supported.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class OutOfBoxExperienceSetting : IAdditionalDataHolder, IParsable
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The deviceUsageType property</summary>
        public global::NoBackingStore.Graph.Models.WindowsDeviceUsageType? DeviceUsageType { get; set; }
        /// <summary>When TRUE, the link that allows user to start over with a different account on company sign-in is hidden. When false, the link that allows user to start over with a different account on company sign-in is available. Default value is FALSE.</summary>
        public bool? EscapeLinkHidden { get; set; }
        /// <summary>When TRUE, EULA is hidden to the end user during OOBE. When FALSE, EULA is shown to the end user during OOBE. Default value is FALSE.</summary>
        public bool? EulaHidden { get; set; }
        /// <summary>When TRUE, the keyboard selection page is hidden to the end user during OOBE if Language and Region are set. When FALSE, the keyboard selection page is skipped during OOBE.</summary>
        public bool? KeyboardSelectionPageSkipped { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>When TRUE, privacy settings is hidden to the end user during OOBE. When FALSE, privacy settings is shown to the end user during OOBE. Default value is FALSE.</summary>
        public bool? PrivacySettingsHidden { get; set; }
        /// <summary>The userType property</summary>
        public global::NoBackingStore.Graph.Models.WindowsUserType? UserType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.OutOfBoxExperienceSetting"/> and sets the default values.
        /// </summary>
        public OutOfBoxExperienceSetting()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.OutOfBoxExperienceSetting"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.OutOfBoxExperienceSetting CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.OutOfBoxExperienceSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "deviceUsageType", n => { DeviceUsageType = n.GetEnumValue<global::NoBackingStore.Graph.Models.WindowsDeviceUsageType>(); } },
                { "escapeLinkHidden", n => { EscapeLinkHidden = n.GetBoolValue(); } },
                { "eulaHidden", n => { EulaHidden = n.GetBoolValue(); } },
                { "keyboardSelectionPageSkipped", n => { KeyboardSelectionPageSkipped = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "privacySettingsHidden", n => { PrivacySettingsHidden = n.GetBoolValue(); } },
                { "userType", n => { UserType = n.GetEnumValue<global::NoBackingStore.Graph.Models.WindowsUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.WindowsDeviceUsageType>("deviceUsageType", DeviceUsageType);
            writer.WriteBoolValue("escapeLinkHidden", EscapeLinkHidden);
            writer.WriteBoolValue("eulaHidden", EulaHidden);
            writer.WriteBoolValue("keyboardSelectionPageSkipped", KeyboardSelectionPageSkipped);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteBoolValue("privacySettingsHidden", PrivacySettingsHidden);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.WindowsUserType>("userType", UserType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
