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
    public partial class EndUserNotificationDetail : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Email HTML content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EmailContent { get; set; }
#nullable restore
#else
        public string EmailContent { get; set; }
#endif
        /// <summary>Indicates whether this language is default.</summary>
        public bool? IsDefaultLangauge { get; set; }
        /// <summary>Notification language.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Language { get; set; }
#nullable restore
#else
        public string Language { get; set; }
#endif
        /// <summary>Notification locale.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Locale { get; set; }
#nullable restore
#else
        public string Locale { get; set; }
#endif
        /// <summary>The sentFrom property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.EmailIdentity? SentFrom { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.EmailIdentity SentFrom { get; set; }
#endif
        /// <summary>Mail subject.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.EndUserNotificationDetail"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.EndUserNotificationDetail CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.EndUserNotificationDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "emailContent", n => { EmailContent = n.GetStringValue(); } },
                { "isDefaultLangauge", n => { IsDefaultLangauge = n.GetBoolValue(); } },
                { "language", n => { Language = n.GetStringValue(); } },
                { "locale", n => { Locale = n.GetStringValue(); } },
                { "sentFrom", n => { SentFrom = n.GetObjectValue<global::NoBackingStore.Graph.Models.EmailIdentity>(global::NoBackingStore.Graph.Models.EmailIdentity.CreateFromDiscriminatorValue); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
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
            writer.WriteStringValue("emailContent", EmailContent);
            writer.WriteBoolValue("isDefaultLangauge", IsDefaultLangauge);
            writer.WriteStringValue("language", Language);
            writer.WriteStringValue("locale", Locale);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.EmailIdentity>("sentFrom", SentFrom);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
#pragma warning restore CS0618
