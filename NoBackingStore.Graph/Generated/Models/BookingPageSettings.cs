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
    public partial class BookingPageSettings : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The accessControl property</summary>
        public global::NoBackingStore.Graph.Models.BookingPageAccessControl? AccessControl { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Custom color for the booking page. The value should be in Hex format. For example, #123456.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BookingPageColorCode { get; set; }
#nullable restore
#else
        public string BookingPageColorCode { get; set; }
#endif
        /// <summary>The time zone of the customer. For a list of possible values, see dateTimeTimeZone.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BusinessTimeZone { get; set; }
#nullable restore
#else
        public string BusinessTimeZone { get; set; }
#endif
        /// <summary>The personal data collection and usage consent message in the booking page.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomerConsentMessage { get; set; }
#nullable restore
#else
        public string CustomerConsentMessage { get; set; }
#endif
        /// <summary>Determines whether the one-time password is required to create an appointment. The default value is false.</summary>
        public bool? EnforceOneTimePassword { get; set; }
        /// <summary>Indicates whether the business logo is displayed on the booking page. The default value is false.</summary>
        public bool? IsBusinessLogoDisplayEnabled { get; set; }
        /// <summary>Enables personal data collection and the usage consent toggle on the booking page. The default value is false.</summary>
        public bool? IsCustomerConsentEnabled { get; set; }
        /// <summary>Indicates whether web crawlers index this page. The defaults value is false.</summary>
        public bool? IsSearchEngineIndexabilityDisabled { get; set; }
        /// <summary>Indicates whether the time zone of the time slot is set to the time zone of the business. The default value is false.</summary>
        public bool? IsTimeSlotTimeZoneSetToBusinessTimeZone { get; set; }
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>URL of a webpage that provides the terms and conditions of the business. If a privacy policy isn&apos;t included, the following text appears on the booking page as default: &apos;The policies and practices of {bookingbusinessname} apply to the use of your data.&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PrivacyPolicyWebUrl { get; set; }
#nullable restore
#else
        public string PrivacyPolicyWebUrl { get; set; }
#endif
        /// <summary>URL of a webpage that provides the terms and conditions of the business.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TermsAndConditionsWebUrl { get; set; }
#nullable restore
#else
        public string TermsAndConditionsWebUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.BookingPageSettings"/> and sets the default values.
        /// </summary>
        public BookingPageSettings()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.BookingPageSettings"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.BookingPageSettings CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.BookingPageSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "accessControl", n => { AccessControl = n.GetEnumValue<global::NoBackingStore.Graph.Models.BookingPageAccessControl>(); } },
                { "bookingPageColorCode", n => { BookingPageColorCode = n.GetStringValue(); } },
                { "businessTimeZone", n => { BusinessTimeZone = n.GetStringValue(); } },
                { "customerConsentMessage", n => { CustomerConsentMessage = n.GetStringValue(); } },
                { "enforceOneTimePassword", n => { EnforceOneTimePassword = n.GetBoolValue(); } },
                { "isBusinessLogoDisplayEnabled", n => { IsBusinessLogoDisplayEnabled = n.GetBoolValue(); } },
                { "isCustomerConsentEnabled", n => { IsCustomerConsentEnabled = n.GetBoolValue(); } },
                { "isSearchEngineIndexabilityDisabled", n => { IsSearchEngineIndexabilityDisabled = n.GetBoolValue(); } },
                { "isTimeSlotTimeZoneSetToBusinessTimeZone", n => { IsTimeSlotTimeZoneSetToBusinessTimeZone = n.GetBoolValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "privacyPolicyWebUrl", n => { PrivacyPolicyWebUrl = n.GetStringValue(); } },
                { "termsAndConditionsWebUrl", n => { TermsAndConditionsWebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.BookingPageAccessControl>("accessControl", AccessControl);
            writer.WriteStringValue("bookingPageColorCode", BookingPageColorCode);
            writer.WriteStringValue("businessTimeZone", BusinessTimeZone);
            writer.WriteStringValue("customerConsentMessage", CustomerConsentMessage);
            writer.WriteBoolValue("enforceOneTimePassword", EnforceOneTimePassword);
            writer.WriteBoolValue("isBusinessLogoDisplayEnabled", IsBusinessLogoDisplayEnabled);
            writer.WriteBoolValue("isCustomerConsentEnabled", IsCustomerConsentEnabled);
            writer.WriteBoolValue("isSearchEngineIndexabilityDisabled", IsSearchEngineIndexabilityDisabled);
            writer.WriteBoolValue("isTimeSlotTimeZoneSetToBusinessTimeZone", IsTimeSlotTimeZoneSetToBusinessTimeZone);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("privacyPolicyWebUrl", PrivacyPolicyWebUrl);
            writer.WriteStringValue("termsAndConditionsWebUrl", TermsAndConditionsWebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
