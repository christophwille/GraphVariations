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
    public partial class Person : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The person&apos;s birthday.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Birthday { get; set; }
#nullable restore
#else
        public string Birthday { get; set; }
#endif
        /// <summary>The name of the person&apos;s company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName { get; set; }
#nullable restore
#else
        public string CompanyName { get; set; }
#endif
        /// <summary>The person&apos;s department.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Department { get; set; }
#nullable restore
#else
        public string Department { get; set; }
#endif
        /// <summary>The person&apos;s display name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The person&apos;s given name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GivenName { get; set; }
#nullable restore
#else
        public string GivenName { get; set; }
#endif
        /// <summary>The instant message voice over IP (VOIP) session initiation protocol (SIP) address for the user. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImAddress { get; set; }
#nullable restore
#else
        public string ImAddress { get; set; }
#endif
        /// <summary>True if the user has flagged this person as a favorite.</summary>
        public bool? IsFavorite { get; set; }
        /// <summary>The person&apos;s job title.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle { get; set; }
#nullable restore
#else
        public string JobTitle { get; set; }
#endif
        /// <summary>The location of the person&apos;s office.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OfficeLocation { get; set; }
#nullable restore
#else
        public string OfficeLocation { get; set; }
#endif
        /// <summary>Free-form notes that the user has taken about this person.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PersonNotes { get; set; }
#nullable restore
#else
        public string PersonNotes { get; set; }
#endif
        /// <summary>The type of person.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PersonType? PersonType { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PersonType PersonType { get; set; }
#endif
        /// <summary>The person&apos;s phone numbers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Phone>? Phones { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Phone> Phones { get; set; }
#endif
        /// <summary>The person&apos;s addresses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Location>? PostalAddresses { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Location> PostalAddresses { get; set; }
#endif
        /// <summary>The person&apos;s profession.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Profession { get; set; }
#nullable restore
#else
        public string Profession { get; set; }
#endif
        /// <summary>The person&apos;s email addresses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ScoredEmailAddress>? ScoredEmailAddresses { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ScoredEmailAddress> ScoredEmailAddresses { get; set; }
#endif
        /// <summary>The person&apos;s surname.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Surname { get; set; }
#nullable restore
#else
        public string Surname { get; set; }
#endif
        /// <summary>The user principal name (UPN) of the person. The UPN is an Internet-style login name for the person based on the Internet standard RFC 822. By convention, this should map to the person&apos;s email name. The general format is alias@domain.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>The person&apos;s websites.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Website>? Websites { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Website> Websites { get; set; }
#endif
        /// <summary>The phonetic Japanese name of the person&apos;s company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? YomiCompany { get; set; }
#nullable restore
#else
        public string YomiCompany { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.Person"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.Person CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.Person();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "birthday", n => { Birthday = n.GetStringValue(); } },
                { "companyName", n => { CompanyName = n.GetStringValue(); } },
                { "department", n => { Department = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "givenName", n => { GivenName = n.GetStringValue(); } },
                { "imAddress", n => { ImAddress = n.GetStringValue(); } },
                { "isFavorite", n => { IsFavorite = n.GetBoolValue(); } },
                { "jobTitle", n => { JobTitle = n.GetStringValue(); } },
                { "officeLocation", n => { OfficeLocation = n.GetStringValue(); } },
                { "personNotes", n => { PersonNotes = n.GetStringValue(); } },
                { "personType", n => { PersonType = n.GetObjectValue<global::NoBackingStore.Graph.Models.PersonType>(global::NoBackingStore.Graph.Models.PersonType.CreateFromDiscriminatorValue); } },
                { "phones", n => { Phones = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Phone>(global::NoBackingStore.Graph.Models.Phone.CreateFromDiscriminatorValue)?.AsList(); } },
                { "postalAddresses", n => { PostalAddresses = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Location>(global::NoBackingStore.Graph.Models.Location.CreateFromDiscriminatorValue)?.AsList(); } },
                { "profession", n => { Profession = n.GetStringValue(); } },
                { "scoredEmailAddresses", n => { ScoredEmailAddresses = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ScoredEmailAddress>(global::NoBackingStore.Graph.Models.ScoredEmailAddress.CreateFromDiscriminatorValue)?.AsList(); } },
                { "surname", n => { Surname = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                { "websites", n => { Websites = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Website>(global::NoBackingStore.Graph.Models.Website.CreateFromDiscriminatorValue)?.AsList(); } },
                { "yomiCompany", n => { YomiCompany = n.GetStringValue(); } },
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
            writer.WriteStringValue("birthday", Birthday);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("imAddress", ImAddress);
            writer.WriteBoolValue("isFavorite", IsFavorite);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("officeLocation", OfficeLocation);
            writer.WriteStringValue("personNotes", PersonNotes);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PersonType>("personType", PersonType);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Phone>("phones", Phones);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Location>("postalAddresses", PostalAddresses);
            writer.WriteStringValue("profession", Profession);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ScoredEmailAddress>("scoredEmailAddresses", ScoredEmailAddresses);
            writer.WriteStringValue("surname", Surname);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Website>("websites", Websites);
            writer.WriteStringValue("yomiCompany", YomiCompany);
        }
    }
}
#pragma warning restore CS0618
