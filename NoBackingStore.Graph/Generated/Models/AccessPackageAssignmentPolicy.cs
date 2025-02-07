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
    public partial class AccessPackageAssignmentPolicy : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Access package containing this policy. Read-only.  Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.AccessPackage? AccessPackage { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.AccessPackage AccessPackage { get; set; }
#endif
        /// <summary>Principals that can be assigned the access package through this policy. The possible values are: notSpecified, specificDirectoryUsers, specificConnectedOrganizationUsers, specificDirectoryServicePrincipals, allMemberUsers, allDirectoryUsers, allDirectoryServicePrincipals, allConfiguredConnectedOrganizationUsers, allExternalUsers, unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.AllowedTargetScope? AllowedTargetScope { get; set; }
        /// <summary>This property is only present for an auto assignment policy; if absent, this is a request-based policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.AccessPackageAutomaticRequestSettings? AutomaticRequestSettings { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.AccessPackageAutomaticRequestSettings AutomaticRequestSettings { get; set; }
#endif
        /// <summary>Catalog of the access package containing this policy. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.AccessPackageCatalog? Catalog { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.AccessPackageCatalog Catalog { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The collection of stages when to execute one or more custom access package workflow extensions. Supports $expand.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.CustomExtensionStageSetting>? CustomExtensionStageSettings { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.CustomExtensionStageSetting> CustomExtensionStageSettings { get; set; }
#endif
        /// <summary>The description of the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The display name of the policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The expiration date for assignments created in this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ExpirationPattern? Expiration { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ExpirationPattern Expiration { get; set; }
#endif
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? ModifiedDateTime { get; set; }
        /// <summary>Questions that are posed to the  requestor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.AccessPackageQuestion>? Questions { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.AccessPackageQuestion> Questions { get; set; }
#endif
        /// <summary>Specifies the settings for approval of requests for an access package assignment through this policy. For example, if approval is required for new requests.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.AccessPackageAssignmentApprovalSettings? RequestApprovalSettings { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.AccessPackageAssignmentApprovalSettings RequestApprovalSettings { get; set; }
#endif
        /// <summary>Provides additional settings to select who can create a request for an access package assignment through this policy, and what they can include in their request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.AccessPackageAssignmentRequestorSettings? RequestorSettings { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.AccessPackageAssignmentRequestorSettings RequestorSettings { get; set; }
#endif
        /// <summary>Settings for access reviews of assignments through this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.AccessPackageAssignmentReviewSettings? ReviewSettings { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.AccessPackageAssignmentReviewSettings ReviewSettings { get; set; }
#endif
        /// <summary>The principals that can be assigned access from an access package through this policy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.SubjectSet>? SpecificAllowedTargets { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.SubjectSet> SpecificAllowedTargets { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.AccessPackageAssignmentPolicy"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.AccessPackageAssignmentPolicy CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.AccessPackageAssignmentPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "accessPackage", n => { AccessPackage = n.GetObjectValue<global::NoBackingStore.Graph.Models.AccessPackage>(global::NoBackingStore.Graph.Models.AccessPackage.CreateFromDiscriminatorValue); } },
                { "allowedTargetScope", n => { AllowedTargetScope = n.GetEnumValue<global::NoBackingStore.Graph.Models.AllowedTargetScope>(); } },
                { "automaticRequestSettings", n => { AutomaticRequestSettings = n.GetObjectValue<global::NoBackingStore.Graph.Models.AccessPackageAutomaticRequestSettings>(global::NoBackingStore.Graph.Models.AccessPackageAutomaticRequestSettings.CreateFromDiscriminatorValue); } },
                { "catalog", n => { Catalog = n.GetObjectValue<global::NoBackingStore.Graph.Models.AccessPackageCatalog>(global::NoBackingStore.Graph.Models.AccessPackageCatalog.CreateFromDiscriminatorValue); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "customExtensionStageSettings", n => { CustomExtensionStageSettings = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.CustomExtensionStageSetting>(global::NoBackingStore.Graph.Models.CustomExtensionStageSetting.CreateFromDiscriminatorValue)?.AsList(); } },
                { "description", n => { Description = n.GetStringValue(); } },
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "expiration", n => { Expiration = n.GetObjectValue<global::NoBackingStore.Graph.Models.ExpirationPattern>(global::NoBackingStore.Graph.Models.ExpirationPattern.CreateFromDiscriminatorValue); } },
                { "modifiedDateTime", n => { ModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                { "questions", n => { Questions = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.AccessPackageQuestion>(global::NoBackingStore.Graph.Models.AccessPackageQuestion.CreateFromDiscriminatorValue)?.AsList(); } },
                { "requestApprovalSettings", n => { RequestApprovalSettings = n.GetObjectValue<global::NoBackingStore.Graph.Models.AccessPackageAssignmentApprovalSettings>(global::NoBackingStore.Graph.Models.AccessPackageAssignmentApprovalSettings.CreateFromDiscriminatorValue); } },
                { "requestorSettings", n => { RequestorSettings = n.GetObjectValue<global::NoBackingStore.Graph.Models.AccessPackageAssignmentRequestorSettings>(global::NoBackingStore.Graph.Models.AccessPackageAssignmentRequestorSettings.CreateFromDiscriminatorValue); } },
                { "reviewSettings", n => { ReviewSettings = n.GetObjectValue<global::NoBackingStore.Graph.Models.AccessPackageAssignmentReviewSettings>(global::NoBackingStore.Graph.Models.AccessPackageAssignmentReviewSettings.CreateFromDiscriminatorValue); } },
                { "specificAllowedTargets", n => { SpecificAllowedTargets = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.SubjectSet>(global::NoBackingStore.Graph.Models.SubjectSet.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.AccessPackage>("accessPackage", AccessPackage);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.AllowedTargetScope>("allowedTargetScope", AllowedTargetScope);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.AccessPackageAutomaticRequestSettings>("automaticRequestSettings", AutomaticRequestSettings);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.AccessPackageCatalog>("catalog", Catalog);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.CustomExtensionStageSetting>("customExtensionStageSettings", CustomExtensionStageSettings);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ExpirationPattern>("expiration", Expiration);
            writer.WriteDateTimeOffsetValue("modifiedDateTime", ModifiedDateTime);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.AccessPackageQuestion>("questions", Questions);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.AccessPackageAssignmentApprovalSettings>("requestApprovalSettings", RequestApprovalSettings);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.AccessPackageAssignmentRequestorSettings>("requestorSettings", RequestorSettings);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.AccessPackageAssignmentReviewSettings>("reviewSettings", ReviewSettings);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.SubjectSet>("specificAllowedTargets", SpecificAllowedTargets);
        }
    }
}
#pragma warning restore CS0618
