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
    public partial class VirtualEventPresenterDetails : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Bio of the presenter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ItemBody? Bio { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ItemBody Bio { get; set; }
#endif
        /// <summary>The presenter&apos;s company name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Company { get; set; }
#nullable restore
#else
        public string Company { get; set; }
#endif
        /// <summary>The presenter&apos;s job title.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle { get; set; }
#nullable restore
#else
        public string JobTitle { get; set; }
#endif
        /// <summary>The presenter&apos;s LinkedIn profile URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LinkedInProfileWebUrl { get; set; }
#nullable restore
#else
        public string LinkedInProfileWebUrl { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>The presenter&apos;s personal website URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PersonalSiteWebUrl { get; set; }
#nullable restore
#else
        public string PersonalSiteWebUrl { get; set; }
#endif
        /// <summary>The content stream of the presenter&apos;s photo.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Photo { get; set; }
#nullable restore
#else
        public byte[] Photo { get; set; }
#endif
        /// <summary>The presenter&apos;s Twitter profile URL.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TwitterProfileWebUrl { get; set; }
#nullable restore
#else
        public string TwitterProfileWebUrl { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.VirtualEventPresenterDetails"/> and sets the default values.
        /// </summary>
        public VirtualEventPresenterDetails()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.VirtualEventPresenterDetails"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.VirtualEventPresenterDetails CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.VirtualEventPresenterDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "bio", n => { Bio = n.GetObjectValue<global::NoBackingStore.Graph.Models.ItemBody>(global::NoBackingStore.Graph.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "company", n => { Company = n.GetStringValue(); } },
                { "jobTitle", n => { JobTitle = n.GetStringValue(); } },
                { "linkedInProfileWebUrl", n => { LinkedInProfileWebUrl = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "personalSiteWebUrl", n => { PersonalSiteWebUrl = n.GetStringValue(); } },
                { "photo", n => { Photo = n.GetByteArrayValue(); } },
                { "twitterProfileWebUrl", n => { TwitterProfileWebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ItemBody>("bio", Bio);
            writer.WriteStringValue("company", Company);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("linkedInProfileWebUrl", LinkedInProfileWebUrl);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("personalSiteWebUrl", PersonalSiteWebUrl);
            writer.WriteByteArrayValue("photo", Photo);
            writer.WriteStringValue("twitterProfileWebUrl", TwitterProfileWebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
