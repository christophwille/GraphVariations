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
    public partial class SubscribedSku : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The unique ID of the account this SKU belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountId { get; set; }
#nullable restore
#else
        public string AccountId { get; set; }
#endif
        /// <summary>The name of the account this SKU belongs to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountName { get; set; }
#nullable restore
#else
        public string AccountName { get; set; }
#endif
        /// <summary>The target class for this SKU. Only SKUs with target class User are assignable. Possible values are: User, Company.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AppliesTo { get; set; }
#nullable restore
#else
        public string AppliesTo { get; set; }
#endif
        /// <summary>Enabled indicates that the prepaidUnits property has at least one unit that is enabled. LockedOut indicates that the customer canceled their subscription. Possible values are: Enabled, Warning, Suspended, Deleted, LockedOut.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CapabilityStatus { get; set; }
#nullable restore
#else
        public string CapabilityStatus { get; set; }
#endif
        /// <summary>The number of licenses that have been assigned.</summary>
        public int? ConsumedUnits { get; set; }
        /// <summary>Information about the number and status of prepaid licenses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.LicenseUnitsDetail? PrepaidUnits { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.LicenseUnitsDetail PrepaidUnits { get; set; }
#endif
        /// <summary>Information about the service plans that are available with the SKU. Not nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.ServicePlanInfo>? ServicePlans { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.ServicePlanInfo> ServicePlans { get; set; }
#endif
        /// <summary>The unique identifier (GUID) for the service SKU.</summary>
        public Guid? SkuId { get; set; }
        /// <summary>The SKU part number; for example: AAD_PREMIUM or RMSBASIC. To get a list of commercial subscriptions that an organization has acquired, see List subscribedSkus.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SkuPartNumber { get; set; }
#nullable restore
#else
        public string SkuPartNumber { get; set; }
#endif
        /// <summary>A list of all subscription IDs associated with this SKU.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SubscriptionIds { get; set; }
#nullable restore
#else
        public List<string> SubscriptionIds { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.SubscribedSku"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.SubscribedSku CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.SubscribedSku();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accountId", n => { AccountId = n.GetStringValue(); } },
                { "accountName", n => { AccountName = n.GetStringValue(); } },
                { "appliesTo", n => { AppliesTo = n.GetStringValue(); } },
                { "capabilityStatus", n => { CapabilityStatus = n.GetStringValue(); } },
                { "consumedUnits", n => { ConsumedUnits = n.GetIntValue(); } },
                { "prepaidUnits", n => { PrepaidUnits = n.GetObjectValue<global::NoBackingStore.Graph.Models.LicenseUnitsDetail>(global::NoBackingStore.Graph.Models.LicenseUnitsDetail.CreateFromDiscriminatorValue); } },
                { "servicePlans", n => { ServicePlans = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ServicePlanInfo>(global::NoBackingStore.Graph.Models.ServicePlanInfo.CreateFromDiscriminatorValue)?.AsList(); } },
                { "skuId", n => { SkuId = n.GetGuidValue(); } },
                { "skuPartNumber", n => { SkuPartNumber = n.GetStringValue(); } },
                { "subscriptionIds", n => { SubscriptionIds = n.GetCollectionOfPrimitiveValues<string>()?.AsList(); } },
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
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteStringValue("accountName", AccountName);
            writer.WriteStringValue("appliesTo", AppliesTo);
            writer.WriteStringValue("capabilityStatus", CapabilityStatus);
            writer.WriteIntValue("consumedUnits", ConsumedUnits);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.LicenseUnitsDetail>("prepaidUnits", PrepaidUnits);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.ServicePlanInfo>("servicePlans", ServicePlans);
            writer.WriteGuidValue("skuId", SkuId);
            writer.WriteStringValue("skuPartNumber", SkuPartNumber);
            writer.WriteCollectionOfPrimitiveValues<string>("subscriptionIds", SubscriptionIds);
        }
    }
}
#pragma warning restore CS0618
