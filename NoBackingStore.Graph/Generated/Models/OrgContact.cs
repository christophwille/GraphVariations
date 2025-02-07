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
    public partial class OrgContact : global::NoBackingStore.Graph.Models.DirectoryObject, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Postal addresses for this organizational contact. For now a contact can only have one physical address.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PhysicalOfficeAddress>? Addresses { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PhysicalOfficeAddress> Addresses { get; set; }
#endif
        /// <summary>Name of the company that this organizational contact belongs to.  Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CompanyName { get; set; }
#nullable restore
#else
        public string CompanyName { get; set; }
#endif
        /// <summary>The name for the department in which the contact works.  Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Department { get; set; }
#nullable restore
#else
        public string Department { get; set; }
#endif
        /// <summary>The contact&apos;s direct reports. (The users and contacts that have their manager property set to this contact.)  Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.DirectoryObject>? DirectReports { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.DirectoryObject> DirectReports { get; set; }
#endif
        /// <summary>Display name for this organizational contact. Maximum length is 256 characters. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values), $search, and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>First name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GivenName { get; set; }
#nullable restore
#else
        public string GivenName { get; set; }
#endif
        /// <summary>Job title for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JobTitle { get; set; }
#nullable restore
#else
        public string JobTitle { get; set; }
#endif
        /// <summary>The SMTP address for the contact, for example, &apos;jeff@contoso.com&apos;. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Mail { get; set; }
#nullable restore
#else
        public string Mail { get; set; }
#endif
        /// <summary>Email alias (portion of email address pre-pending the @ symbol) for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MailNickname { get; set; }
#nullable restore
#else
        public string MailNickname { get; set; }
#endif
        /// <summary>The user or contact that is this contact&apos;s manager. Read-only. Supports $expand and $filter (eq) by id.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.DirectoryObject? Manager { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.DirectoryObject Manager { get; set; }
#endif
        /// <summary>Groups that this contact is a member of. Read-only. Nullable. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.DirectoryObject>? MemberOf { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.DirectoryObject> MemberOf { get; set; }
#endif
        /// <summary>Date and time when this organizational contact was last synchronized from on-premises AD. This date and time information uses ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $filter (eq, ne, not, ge, le, in).</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
        /// <summary>List of any synchronization provisioning errors for this organizational contact. Supports $filter (eq, not for category and propertyCausingError), /$count eq 0, /$count ne 0.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.OnPremisesProvisioningError>? OnPremisesProvisioningErrors { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.OnPremisesProvisioningError> OnPremisesProvisioningErrors { get; set; }
#endif
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced and now mastered in Exchange; null if this object has never been synced from an on-premises directory (default).   Supports $filter (eq, ne, not, in, and eq for null values).</summary>
        public bool? OnPremisesSyncEnabled { get; set; }
        /// <summary>List of phones for this organizational contact. Phone types can be mobile, business, and businessFax. Only one of each type can ever be present in the collection.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Phone>? Phones { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Phone> Phones { get; set; }
#endif
        /// <summary>For example: &apos;SMTP: bob@contoso.com&apos;, &apos;smtp: bob@sales.contoso.com&apos;. The any operator is required for filter expressions on multi-valued properties. Supports $filter (eq, not, ge, le, startsWith, /$count eq 0, /$count ne 0).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProxyAddresses { get; set; }
#nullable restore
#else
        public List<string> ProxyAddresses { get; set; }
#endif
        /// <summary>Errors published by a federated service describing a non-transient, service-specific error regarding the properties or link from an organizational contact object .  Supports $filter (eq, not, for isResolved and serviceInstance).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ServiceProvisioningError>? ServiceProvisioningErrors { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ServiceProvisioningError> ServiceProvisioningErrors { get; set; }
#endif
        /// <summary>Last name for this organizational contact. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq for null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Surname { get; set; }
#nullable restore
#else
        public string Surname { get; set; }
#endif
        /// <summary>Groups that this contact is a member of, including groups that the contact is nested under. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.DirectoryObject>? TransitiveMemberOf { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.DirectoryObject> TransitiveMemberOf { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.OrgContact"/> and sets the default values.
        /// </summary>
        public OrgContact() : base()
        {
            OdataType = "#microsoft.graph.orgContact";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.OrgContact"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.OrgContact CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.OrgContact();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addresses", n => { Addresses = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PhysicalOfficeAddress>(global::NoBackingStore.Graph.Models.PhysicalOfficeAddress.CreateFromDiscriminatorValue)?.AsList(); } },
                { "companyName", n => { CompanyName = n.GetStringValue(); } },
                { "department", n => { Department = n.GetStringValue(); } },
                { "directReports", n => { DirectReports = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DirectoryObject>(global::NoBackingStore.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "givenName", n => { GivenName = n.GetStringValue(); } },
                { "jobTitle", n => { JobTitle = n.GetStringValue(); } },
                { "mail", n => { Mail = n.GetStringValue(); } },
                { "mailNickname", n => { MailNickname = n.GetStringValue(); } },
                { "manager", n => { Manager = n.GetObjectValue<global::NoBackingStore.Graph.Models.DirectoryObject>(global::NoBackingStore.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue); } },
                { "memberOf", n => { MemberOf = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DirectoryObject>(global::NoBackingStore.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "onPremisesLastSyncDateTime", n => { OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                { "onPremisesProvisioningErrors", n => { OnPremisesProvisioningErrors = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.OnPremisesProvisioningError>(global::NoBackingStore.Graph.Models.OnPremisesProvisioningError.CreateFromDiscriminatorValue)?.AsList(); } },
                { "onPremisesSyncEnabled", n => { OnPremisesSyncEnabled = n.GetBoolValue(); } },
                { "phones", n => { Phones = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Phone>(global::NoBackingStore.Graph.Models.Phone.CreateFromDiscriminatorValue)?.AsList(); } },
                { "proxyAddresses", n => { ProxyAddresses = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "serviceProvisioningErrors", n => { ServiceProvisioningErrors = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ServiceProvisioningError>(global::NoBackingStore.Graph.Models.ServiceProvisioningError.CreateFromDiscriminatorValue)?.AsList(); } },
                { "surname", n => { Surname = n.GetStringValue(); } },
                { "transitiveMemberOf", n => { TransitiveMemberOf = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DirectoryObject>(global::NoBackingStore.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PhysicalOfficeAddress>("addresses", Addresses);
            writer.WriteStringValue("companyName", CompanyName);
            writer.WriteStringValue("department", Department);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DirectoryObject>("directReports", DirectReports);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("givenName", GivenName);
            writer.WriteStringValue("jobTitle", JobTitle);
            writer.WriteStringValue("mail", Mail);
            writer.WriteStringValue("mailNickname", MailNickname);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.DirectoryObject>("manager", Manager);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DirectoryObject>("memberOf", MemberOf);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.OnPremisesProvisioningError>("onPremisesProvisioningErrors", OnPremisesProvisioningErrors);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Phone>("phones", Phones);
            writer.WriteCollectionOfPrimitiveValues<string>("proxyAddresses", ProxyAddresses);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ServiceProvisioningError>("serviceProvisioningErrors", ServiceProvisioningErrors);
            writer.WriteStringValue("surname", Surname);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DirectoryObject>("transitiveMemberOf", TransitiveMemberOf);
        }
    }
}
#pragma warning restore CS0618
