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
    public partial class Application : global::NoBackingStore.Graph.Models.DirectoryObject, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Defines custom behavior that a consuming service can use to call an app in specific contexts. For example, applications that can render file streams can set the addIns property for its &apos;FileHandler&apos; functionality. This lets services like Microsoft 365 call the application in the context of a document the user is working on.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.AddIn>? AddIns { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.AddIn> AddIns { get; set; }
#endif
        /// <summary>Specifies settings for an application that implements a web API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ApiApplication? Api { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ApiApplication Api { get; set; }
#endif
        /// <summary>The unique identifier for the application that is assigned to an application by Microsoft Entra ID. Not nullable. Read-only. Alternate key. Supports $filter (eq).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppId { get; set; }
#nullable restore
#else
        public string AppId { get; set; }
#endif
        /// <summary>Unique identifier of the applicationTemplate. Supports $filter (eq, not, ne). Read-only. null if the app wasn&apos;t created from an application template.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ApplicationTemplateId { get; set; }
#nullable restore
#else
        public string ApplicationTemplateId { get; set; }
#endif
        /// <summary>The appManagementPolicy applied to this application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.AppManagementPolicy>? AppManagementPolicies { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.AppManagementPolicy> AppManagementPolicies { get; set; }
#endif
        /// <summary>The collection of roles defined for the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.AppRole>? AppRoles { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.AppRole> AppRoles { get; set; }
#endif
        /// <summary>Specifies the certification status of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.Certification? Certification { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.Certification Certification { get; set; }
#endif
        /// <summary>The date and time the application was registered. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.  Supports $filter (eq, ne, not, ge, le, in, and eq on null values) and $orderby.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Supports $filter (/$count eq 0, /$count ne 0). Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.DirectoryObject? CreatedOnBehalfOf { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.DirectoryObject CreatedOnBehalfOf { get; set; }
#endif
        /// <summary>The defaultRedirectUri property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultRedirectUri { get; set; }
#nullable restore
#else
        public string DefaultRedirectUri { get; set; }
#endif
        /// <summary>Free text field to provide a description of the application object to end users. The maximum allowed size is 1,024 characters. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).  Supports $filter (eq, ne, not).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisabledByMicrosoftStatus { get; set; }
#nullable restore
#else
        public string DisabledByMicrosoftStatus { get; set; }
#endif
        /// <summary>The display name for the application. Maximum length is 256 characters. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>Read-only. Nullable. Supports $expand and $filter (/$count eq 0, /$count ne 0).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ExtensionProperty>? ExtensionProperties { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ExtensionProperty> ExtensionProperties { get; set; }
#endif
        /// <summary>Federated identities for applications. Supports $expand and $filter (startsWith, /$count eq 0, /$count ne 0).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.FederatedIdentityCredential>? FederatedIdentityCredentials { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.FederatedIdentityCredential> FederatedIdentityCredentials { get; set; }
#endif
        /// <summary>Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following valid string values: None, SecurityGroup (for security groups and Microsoft Entra roles), All (this gets all of the security groups, distribution groups, and Microsoft Entra directory roles that the signed-in user is a member of).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? GroupMembershipClaims { get; set; }
#nullable restore
#else
        public string GroupMembershipClaims { get; set; }
#endif
        /// <summary>The homeRealmDiscoveryPolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.HomeRealmDiscoveryPolicy>? HomeRealmDiscoveryPolicies { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies { get; set; }
#endif
        /// <summary>Also known as App ID URI, this value is set when an application is used as a resource app. The identifierUris acts as the prefix for the scopes you reference in your API&apos;s code, and it must be globally unique. You can use the default value provided, which is in the form api://&lt;appId&gt;, or specify a more readable URI like https://contoso.com/api. For more information on valid identifierUris patterns and best practices, see Microsoft Entra application registration security best practices. Not nullable. Supports $filter (eq, ne, ge, le, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IdentifierUris { get; set; }
#nullable restore
#else
        public List<string> IdentifierUris { get; set; }
#endif
        /// <summary>Basic profile information of the application such as  app&apos;s marketing, support, terms of service and privacy statement URLs. The terms of service and privacy statement are surfaced to users through the user consent experience. For more info, see How to: Add Terms of service and privacy statement for registered Microsoft Entra apps. Supports $filter (eq, ne, not, ge, le, and eq on null values).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.InformationalUrl? Info { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.InformationalUrl Info { get; set; }
#endif
        /// <summary>Specifies whether this application supports device authentication without a user. The default is false.</summary>
        public bool? IsDeviceOnlyAuthSupported { get; set; }
        /// <summary>Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false, which means the fallback application type is confidential client such as a web app. There are certain scenarios where Microsoft Entra ID can&apos;t determine the client application type. For example, the ROPC flow where it&apos;s configured without specifying a redirect URI. In those cases, Microsoft Entra ID interprets the application type based on the value of this property.</summary>
        public bool? IsFallbackPublicClient { get; set; }
        /// <summary>The collection of key credentials associated with the application. Not nullable. Supports $filter (eq, not, ge, le).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.KeyCredential>? KeyCredentials { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.KeyCredential> KeyCredentials { get; set; }
#endif
        /// <summary>The main logo for the application. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? Logo { get; set; }
#nullable restore
#else
        public byte[] Logo { get; set; }
#endif
        /// <summary>Specifies whether the Native Authentication APIs are enabled for the application. The possible values are: none and all. Default is none. For more information, see Native Authentication.</summary>
        public global::NoBackingStore.Graph.Models.NativeAuthenticationApisEnabled? NativeAuthenticationApisEnabled { get; set; }
        /// <summary>Notes relevant for the management of the application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Notes { get; set; }
#nullable restore
#else
        public string Notes { get; set; }
#endif
        /// <summary>The oauth2RequirePostResponse property</summary>
        public bool? Oauth2RequirePostResponse { get; set; }
        /// <summary>Application developers can configure optional claims in their Microsoft Entra applications to specify the claims that are sent to their application by the Microsoft security token service. For more information, see How to: Provide optional claims to your app.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.OptionalClaims? OptionalClaims { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.OptionalClaims OptionalClaims { get; set; }
#endif
        /// <summary>Directory objects that are owners of the application. Read-only. Nullable. Supports $expand, $filter (/$count eq 0, /$count ne 0, /$count eq 1, /$count ne 1), and $select nested in $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.DirectoryObject>? Owners { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.DirectoryObject> Owners { get; set; }
#endif
        /// <summary>Specifies parental control settings for an application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ParentalControlSettings? ParentalControlSettings { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ParentalControlSettings ParentalControlSettings { get; set; }
#endif
        /// <summary>The collection of password credentials associated with the application. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.PasswordCredential>? PasswordCredentials { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.PasswordCredential> PasswordCredentials { get; set; }
#endif
        /// <summary>Specifies settings for installed clients such as desktop or mobile devices.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PublicClientApplication? PublicClient { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PublicClientApplication PublicClient { get; set; }
#endif
        /// <summary>The verified publisher domain for the application. Read-only. For more information, see How to: Configure an application&apos;s publisher domain. Supports $filter (eq, ne, ge, le, startsWith).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? PublisherDomain { get; set; }
#nullable restore
#else
        public string PublisherDomain { get; set; }
#endif
        /// <summary>Specifies whether this application requires Microsoft Entra ID to verify the signed authentication requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.RequestSignatureVerification? RequestSignatureVerification { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.RequestSignatureVerification RequestSignatureVerification { get; set; }
#endif
        /// <summary>Specifies the resources that the application needs to access. This property also specifies the set of delegated permissions and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. No more than 50 resource services (APIs) can be configured. Beginning mid-October 2021, the total number of required permissions must not exceed 400. For more information, see Limits on requested permissions per app. Not nullable. Supports $filter (eq, not, ge, le).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.RequiredResourceAccess>? RequiredResourceAccess { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.RequiredResourceAccess> RequiredResourceAccess { get; set; }
#endif
        /// <summary>The URL where the service exposes SAML metadata for federation. This property is valid only for single-tenant applications. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SamlMetadataUrl { get; set; }
#nullable restore
#else
        public string SamlMetadataUrl { get; set; }
#endif
        /// <summary>References application or service contact information from a Service or Asset Management database. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServiceManagementReference { get; set; }
#nullable restore
#else
        public string ServiceManagementReference { get; set; }
#endif
        /// <summary>Specifies whether sensitive properties of a multitenant application should be locked for editing after the application is provisioned in a tenant. Nullable. null by default.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ServicePrincipalLockConfiguration? ServicePrincipalLockConfiguration { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ServicePrincipalLockConfiguration ServicePrincipalLockConfiguration { get; set; }
#endif
        /// <summary>Specifies the Microsoft accounts that are supported for the current application. The possible values are: AzureADMyOrg (default), AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount, and PersonalMicrosoftAccount. See more in the table. The value of this object also limits the number of permissions an app can request. For more information, see Limits on requested permissions per app. The value for this property has implications on other app object properties. As a result, if you change this property, you might need to change other properties first. For more information, see Validation differences for signInAudience.Supports $filter (eq, ne, not).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SignInAudience { get; set; }
#nullable restore
#else
        public string SignInAudience { get; set; }
#endif
        /// <summary>Specifies settings for a single-page application, including sign out URLs and redirect URIs for authorization codes and access tokens.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.SpaApplication? Spa { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.SpaApplication Spa { get; set; }
#endif
        /// <summary>Represents the capability for Microsoft Entra identity synchronization through the Microsoft Graph API.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.Synchronization? Synchronization { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.Synchronization Synchronization { get; set; }
#endif
        /// <summary>Custom strings that can be used to categorize and identify the application. Not nullable. Strings added here will also appear in the tags property of any associated service principals.Supports $filter (eq, not, ge, le, startsWith) and $search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Tags { get; set; }
#nullable restore
#else
        public List<string> Tags { get; set; }
#endif
        /// <summary>Specifies the keyId of a public key from the keyCredentials collection. When configured, Microsoft Entra ID encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.</summary>
        public Guid? TokenEncryptionKeyId { get; set; }
        /// <summary>The tokenIssuancePolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.TokenIssuancePolicy>? TokenIssuancePolicies { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.TokenIssuancePolicy> TokenIssuancePolicies { get; set; }
#endif
        /// <summary>The tokenLifetimePolicies property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.TokenLifetimePolicy>? TokenLifetimePolicies { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.TokenLifetimePolicy> TokenLifetimePolicies { get; set; }
#endif
        /// <summary>The unique identifier that can be assigned to an application and used as an alternate key. Immutable. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UniqueName { get; set; }
#nullable restore
#else
        public string UniqueName { get; set; }
#endif
        /// <summary>Specifies the verified publisher of the application. For more information about how publisher verification helps support application security, trustworthiness, and compliance, see Publisher verification.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.VerifiedPublisher? VerifiedPublisher { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.VerifiedPublisher VerifiedPublisher { get; set; }
#endif
        /// <summary>Specifies settings for a web application.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.WebApplication? Web { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.WebApplication Web { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.Application"/> and sets the default values.
        /// </summary>
        public Application() : base()
        {
            OdataType = "#microsoft.graph.application";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.Application"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.Application CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.Application();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "addIns", n => { AddIns = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.AddIn>(global::NoBackingStore.Graph.Models.AddIn.CreateFromDiscriminatorValue)?.AsList(); } },
                { "api", n => { Api = n.GetObjectValue<global::NoBackingStore.Graph.Models.ApiApplication>(global::NoBackingStore.Graph.Models.ApiApplication.CreateFromDiscriminatorValue); } },
                { "appId", n => { AppId = n.GetStringValue(); } },
                { "appManagementPolicies", n => { AppManagementPolicies = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.AppManagementPolicy>(global::NoBackingStore.Graph.Models.AppManagementPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "appRoles", n => { AppRoles = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.AppRole>(global::NoBackingStore.Graph.Models.AppRole.CreateFromDiscriminatorValue)?.AsList(); } },
                { "applicationTemplateId", n => { ApplicationTemplateId = n.GetStringValue(); } },
                { "certification", n => { Certification = n.GetObjectValue<global::NoBackingStore.Graph.Models.Certification>(global::NoBackingStore.Graph.Models.Certification.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "createdOnBehalfOf", n => { CreatedOnBehalfOf = n.GetObjectValue<global::NoBackingStore.Graph.Models.DirectoryObject>(global::NoBackingStore.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue); } },
                { "defaultRedirectUri", n => { DefaultRedirectUri = n.GetStringValue(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "disabledByMicrosoftStatus", n => { DisabledByMicrosoftStatus = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "extensionProperties", n => { ExtensionProperties = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ExtensionProperty>(global::NoBackingStore.Graph.Models.ExtensionProperty.CreateFromDiscriminatorValue)?.AsList(); } },
                { "federatedIdentityCredentials", n => { FederatedIdentityCredentials = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.FederatedIdentityCredential>(global::NoBackingStore.Graph.Models.FederatedIdentityCredential.CreateFromDiscriminatorValue)?.AsList(); } },
                { "groupMembershipClaims", n => { GroupMembershipClaims = n.GetStringValue(); } },
                { "homeRealmDiscoveryPolicies", n => { HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.HomeRealmDiscoveryPolicy>(global::NoBackingStore.Graph.Models.HomeRealmDiscoveryPolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "identifierUris", n => { IdentifierUris = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "info", n => { Info = n.GetObjectValue<global::NoBackingStore.Graph.Models.InformationalUrl>(global::NoBackingStore.Graph.Models.InformationalUrl.CreateFromDiscriminatorValue); } },
                { "isDeviceOnlyAuthSupported", n => { IsDeviceOnlyAuthSupported = n.GetBoolValue(); } },
                { "isFallbackPublicClient", n => { IsFallbackPublicClient = n.GetBoolValue(); } },
                { "keyCredentials", n => { KeyCredentials = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.KeyCredential>(global::NoBackingStore.Graph.Models.KeyCredential.CreateFromDiscriminatorValue)?.AsList(); } },
                { "logo", n => { Logo = n.GetByteArrayValue(); } },
                { "nativeAuthenticationApisEnabled", n => { NativeAuthenticationApisEnabled = n.GetEnumValue<global::NoBackingStore.Graph.Models.NativeAuthenticationApisEnabled>(); } },
                { "notes", n => { Notes = n.GetStringValue(); } },
                { "oauth2RequirePostResponse", n => { Oauth2RequirePostResponse = n.GetBoolValue(); } },
                { "optionalClaims", n => { OptionalClaims = n.GetObjectValue<global::NoBackingStore.Graph.Models.OptionalClaims>(global::NoBackingStore.Graph.Models.OptionalClaims.CreateFromDiscriminatorValue); } },
                { "owners", n => { Owners = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DirectoryObject>(global::NoBackingStore.Graph.Models.DirectoryObject.CreateFromDiscriminatorValue)?.AsList(); } },
                { "parentalControlSettings", n => { ParentalControlSettings = n.GetObjectValue<global::NoBackingStore.Graph.Models.ParentalControlSettings>(global::NoBackingStore.Graph.Models.ParentalControlSettings.CreateFromDiscriminatorValue); } },
                { "passwordCredentials", n => { PasswordCredentials = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PasswordCredential>(global::NoBackingStore.Graph.Models.PasswordCredential.CreateFromDiscriminatorValue)?.AsList(); } },
                { "publicClient", n => { PublicClient = n.GetObjectValue<global::NoBackingStore.Graph.Models.PublicClientApplication>(global::NoBackingStore.Graph.Models.PublicClientApplication.CreateFromDiscriminatorValue); } },
                { "publisherDomain", n => { PublisherDomain = n.GetStringValue(); } },
                { "requestSignatureVerification", n => { RequestSignatureVerification = n.GetObjectValue<global::NoBackingStore.Graph.Models.RequestSignatureVerification>(global::NoBackingStore.Graph.Models.RequestSignatureVerification.CreateFromDiscriminatorValue); } },
                { "requiredResourceAccess", n => { RequiredResourceAccess = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.RequiredResourceAccess>(global::NoBackingStore.Graph.Models.RequiredResourceAccess.CreateFromDiscriminatorValue)?.AsList(); } },
                { "samlMetadataUrl", n => { SamlMetadataUrl = n.GetStringValue(); } },
                { "serviceManagementReference", n => { ServiceManagementReference = n.GetStringValue(); } },
                { "servicePrincipalLockConfiguration", n => { ServicePrincipalLockConfiguration = n.GetObjectValue<global::NoBackingStore.Graph.Models.ServicePrincipalLockConfiguration>(global::NoBackingStore.Graph.Models.ServicePrincipalLockConfiguration.CreateFromDiscriminatorValue); } },
                { "signInAudience", n => { SignInAudience = n.GetStringValue(); } },
                { "spa", n => { Spa = n.GetObjectValue<global::NoBackingStore.Graph.Models.SpaApplication>(global::NoBackingStore.Graph.Models.SpaApplication.CreateFromDiscriminatorValue); } },
                { "synchronization", n => { Synchronization = n.GetObjectValue<global::NoBackingStore.Graph.Models.Synchronization>(global::NoBackingStore.Graph.Models.Synchronization.CreateFromDiscriminatorValue); } },
                { "tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
                { "tokenEncryptionKeyId", n => { TokenEncryptionKeyId = n.GetGuidValue(); } },
                { "tokenIssuancePolicies", n => { TokenIssuancePolicies = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.TokenIssuancePolicy>(global::NoBackingStore.Graph.Models.TokenIssuancePolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "tokenLifetimePolicies", n => { TokenLifetimePolicies = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.TokenLifetimePolicy>(global::NoBackingStore.Graph.Models.TokenLifetimePolicy.CreateFromDiscriminatorValue)?.AsList(); } },
                { "uniqueName", n => { UniqueName = n.GetStringValue(); } },
                { "verifiedPublisher", n => { VerifiedPublisher = n.GetObjectValue<global::NoBackingStore.Graph.Models.VerifiedPublisher>(global::NoBackingStore.Graph.Models.VerifiedPublisher.CreateFromDiscriminatorValue); } },
                { "web", n => { Web = n.GetObjectValue<global::NoBackingStore.Graph.Models.WebApplication>(global::NoBackingStore.Graph.Models.WebApplication.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.AddIn>("addIns", AddIns);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ApiApplication>("api", Api);
            writer.WriteStringValue("appId", AppId);
            writer.WriteStringValue("applicationTemplateId", ApplicationTemplateId);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.AppManagementPolicy>("appManagementPolicies", AppManagementPolicies);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.AppRole>("appRoles", AppRoles);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.Certification>("certification", Certification);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.DirectoryObject>("createdOnBehalfOf", CreatedOnBehalfOf);
            writer.WriteStringValue("defaultRedirectUri", DefaultRedirectUri);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("disabledByMicrosoftStatus", DisabledByMicrosoftStatus);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ExtensionProperty>("extensionProperties", ExtensionProperties);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.FederatedIdentityCredential>("federatedIdentityCredentials", FederatedIdentityCredentials);
            writer.WriteStringValue("groupMembershipClaims", GroupMembershipClaims);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteCollectionOfPrimitiveValues<string>("identifierUris", IdentifierUris);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.InformationalUrl>("info", Info);
            writer.WriteBoolValue("isDeviceOnlyAuthSupported", IsDeviceOnlyAuthSupported);
            writer.WriteBoolValue("isFallbackPublicClient", IsFallbackPublicClient);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.KeyCredential>("keyCredentials", KeyCredentials);
            writer.WriteByteArrayValue("logo", Logo);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.NativeAuthenticationApisEnabled>("nativeAuthenticationApisEnabled", NativeAuthenticationApisEnabled);
            writer.WriteStringValue("notes", Notes);
            writer.WriteBoolValue("oauth2RequirePostResponse", Oauth2RequirePostResponse);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.OptionalClaims>("optionalClaims", OptionalClaims);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DirectoryObject>("owners", Owners);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ParentalControlSettings>("parentalControlSettings", ParentalControlSettings);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.PasswordCredential>("passwordCredentials", PasswordCredentials);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PublicClientApplication>("publicClient", PublicClient);
            writer.WriteStringValue("publisherDomain", PublisherDomain);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.RequestSignatureVerification>("requestSignatureVerification", RequestSignatureVerification);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.RequiredResourceAccess>("requiredResourceAccess", RequiredResourceAccess);
            writer.WriteStringValue("samlMetadataUrl", SamlMetadataUrl);
            writer.WriteStringValue("serviceManagementReference", ServiceManagementReference);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ServicePrincipalLockConfiguration>("servicePrincipalLockConfiguration", ServicePrincipalLockConfiguration);
            writer.WriteStringValue("signInAudience", SignInAudience);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.SpaApplication>("spa", Spa);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.Synchronization>("synchronization", Synchronization);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteGuidValue("tokenEncryptionKeyId", TokenEncryptionKeyId);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
            writer.WriteStringValue("uniqueName", UniqueName);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.VerifiedPublisher>("verifiedPublisher", VerifiedPublisher);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.WebApplication>("web", Web);
        }
    }
}
#pragma warning restore CS0618
