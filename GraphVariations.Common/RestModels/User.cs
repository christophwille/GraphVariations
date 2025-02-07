using System.Text.Json.Serialization;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.

namespace GraphVariations.Common.RestModels
{
    public class User
    {
        [JsonPropertyName("Id")]
        public string Id { get; set; }
        [JsonPropertyName("businessPhones")]
        public List<string> BusinessPhones { get; set; }
        [JsonPropertyName("displayName")]
        public string DisplayName { get; set; }
        [JsonPropertyName("givenName")]
        public string GivenName { get; set; }
        [JsonPropertyName("jobTitle")]
        public string JobTitle { get; set; }
        [JsonPropertyName("mail")]
        public string Mail { get; set; }
        [JsonPropertyName("mobilePhone")]
        public string MobilePhone { get; set; }
        [JsonPropertyName("officeLocation")]
        public string OfficeLocation { get; set; }
        [JsonPropertyName("surname")]
        public string Surname { get; set; }
        [JsonPropertyName("userPrincipalName")]
        public string UserPrincipalName { get; set; }
        [JsonPropertyName("userType")]
        public string UserType { get; set; }
        [JsonPropertyName("externalUserState")]
        public string ExternalUserState { get; set; }
        [JsonPropertyName("externalUserStateChangeDateTime")]
        public DateTimeOffset? ExternalUserStateChangeDateTime { get; set; }
        [JsonPropertyName("accountEnabled")]
        public bool AccountEnabled { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }
        [JsonPropertyName("country")]
        public string Country { get; set; }
        [JsonPropertyName("department")]
        public string Department { get; set; }
        [JsonPropertyName("mailNickname")]
        public string MailNickname { get; set; }
        [JsonPropertyName("usageLocation")]
        public string UsageLocation { get; set; }
        [JsonPropertyName("streetAddress")]
        public string StreetAddress { get; set; }
        [JsonPropertyName("state")]
        public string State { get; set; }
        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }
        [JsonPropertyName("onPremisesSyncEnabled")]
        public bool? OnPremisesSyncEnabled { get; set; }
        [JsonPropertyName("onPremisesExtensionAttributes")]
        public OnPremisesExtensionAttributes OnPremisesExtensionAttributes { get; set; }
        [JsonPropertyName("assignedLicenses")]
        public List<AssignedLicense> AssignedLicenses { get; set; }
        [JsonPropertyName("assignedPlans")]
        public List<AssignedPlan> AssignedPlans { get; set; }

        [JsonPropertyName("@removed")]
        public Removed Removed { get; set; }
    }

    public class AssignedLicense
    {
        [JsonPropertyName("disabledPlans")]
        public List<string> DisabledPlans { get; set; }
        [JsonPropertyName("skuId")]
        public string SkuId { get; set; }
    }

    public class AssignedPlan
    {
        [JsonPropertyName("assignedDateTime")]
        public DateTime AssignedDateTime { get; set; }
        [JsonPropertyName("capabilityStatus")]
        public string CapabilityStatus { get; set; }
        [JsonPropertyName("service")]
        public string Service { get; set; }
        [JsonPropertyName("servicePlanId")]
        public string ServicePlanId { get; set; }
    }

    public class OnPremisesExtensionAttributes
    {
        [JsonPropertyName("extensionAttribute1")]
        public string? ExtensionAttribute1 { get; set; }
        [JsonPropertyName("extensionAttribute2")]
        public string? ExtensionAttribute2 { get; set; }
        [JsonPropertyName("extensionAttribute3")]
        public string? ExtensionAttribute3 { get; set; }
        [JsonPropertyName("extensionAttribute4")]
        public string? ExtensionAttribute4 { get; set; }
        [JsonPropertyName("extensionAttribute5")]
        public string? ExtensionAttribute5 { get; set; }
        [JsonPropertyName("extensionAttribute6")]
        public string? ExtensionAttribute6 { get; set; }
        [JsonPropertyName("extensionAttribute7")]
        public string? ExtensionAttribute7 { get; set; }
        [JsonPropertyName("extensionAttribute8")]
        public string? ExtensionAttribute8 { get; set; }
        [JsonPropertyName("extensionAttribute9")]
        public string? ExtensionAttribute9 { get; set; }
        [JsonPropertyName("extensionAttribute10")]
        public string? ExtensionAttribute10 { get; set; }
        [JsonPropertyName("extensionAttribute11")]
        public string? ExtensionAttribute11 { get; set; }
        [JsonPropertyName("extensionAttribute12")]
        public string? ExtensionAttribute12 { get; set; }
        [JsonPropertyName("extensionAttribute13")]
        public string? ExtensionAttribute13 { get; set; }
        [JsonPropertyName("extensionAttribute14")]
        public string? ExtensionAttribute14 { get; set; }
        [JsonPropertyName("ExtensionAttribute15")]
        public string? extensionAttribute15 { get; set; }
    }

    public class Removed
    {
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}

#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
