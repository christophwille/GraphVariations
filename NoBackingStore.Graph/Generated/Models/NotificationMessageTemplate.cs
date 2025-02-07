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
    /// Notification messages are messages that are sent to end users who are determined to be not-compliant with the compliance policies defined by the administrator. Administrators choose notifications and configure them in the Intune Admin Console using the compliance policy creation page under the “Actions for non-compliance” section. Use the notificationMessageTemplate object to create your own custom notifications for administrators to choose while configuring actions for non-compliance.
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public partial class NotificationMessageTemplate : global::NoBackingStore.Graph.Models.Entity, IParsable
    {
        /// <summary>Branding Options for the Message Template. Branding is defined in the Intune Admin Console.</summary>
        public global::NoBackingStore.Graph.Models.NotificationTemplateBrandingOptions? BrandingOptions { get; set; }
        /// <summary>The default locale to fallback onto when the requested locale is not available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultLocale { get; set; }
#nullable restore
#else
        public string DefaultLocale { get; set; }
#endif
        /// <summary>Display name for the Notification Message Template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>DateTime the object was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The list of localized messages for this Notification Message Template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.LocalizedNotificationMessage>? LocalizedNotificationMessages { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.LocalizedNotificationMessage> LocalizedNotificationMessages { get; set; }
#endif
        /// <summary>List of Scope Tags for this Entity instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? RoleScopeTagIds { get; set; }
#nullable restore
#else
        public List<string> RoleScopeTagIds { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.NotificationMessageTemplate"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.NotificationMessageTemplate CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.NotificationMessageTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "brandingOptions", n => { BrandingOptions = n.GetEnumValue<global::NoBackingStore.Graph.Models.NotificationTemplateBrandingOptions>(); } },
                { "defaultLocale", n => { DefaultLocale = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "localizedNotificationMessages", n => { LocalizedNotificationMessages = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.LocalizedNotificationMessage>(global::NoBackingStore.Graph.Models.LocalizedNotificationMessage.CreateFromDiscriminatorValue)?.AsList(); } },
                { "roleScopeTagIds", n => { RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.NotificationTemplateBrandingOptions>("brandingOptions", BrandingOptions);
            writer.WriteStringValue("defaultLocale", DefaultLocale);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.LocalizedNotificationMessage>("localizedNotificationMessages", LocalizedNotificationMessages);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}
#pragma warning restore CS0618
