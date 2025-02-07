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
    public partial class RiskyUser : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The activity related to user risk level change</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.RiskyUserHistoryItem>? History { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.RiskyUserHistoryItem> History { get; set; }
#endif
        /// <summary>Indicates whether the user is deleted. Possible values are: true, false.</summary>
        public bool? IsDeleted { get; set; }
        /// <summary>Indicates whether the backend is processing a user&apos;s risky state.</summary>
        public bool? IsProcessing { get; set; }
        /// <summary>The possible values are none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden, adminConfirmedUserCompromised, unknownFutureValue, adminConfirmedServicePrincipalCompromised, adminDismissedAllRiskForServicePrincipal, m365DAdminDismissedDetection, userChangedPasswordOnPremises, adminDismissedRiskForSignIn, adminConfirmedAccountSafe. Use the Prefer: include-unknown-enum-members request header to get the following value or values in this evolvable enum: adminConfirmedServicePrincipalCompromised, adminDismissedAllRiskForServicePrincipal, m365DAdminDismissedDetection, userChangedPasswordOnPremises, adminDismissedRiskForSignIn, adminConfirmedAccountSafe.</summary>
        public global::NoBackingStore.Graph.Models.RiskDetail? RiskDetail { get; set; }
        /// <summary>The date and time that the risky user was last updated. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? RiskLastUpdatedDateTime { get; set; }
        /// <summary>Level of the detected risky user. Possible values are: low, medium, high, hidden, none, unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.RiskLevel? RiskLevel { get; set; }
        /// <summary>State of the user&apos;s risk. Possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.RiskState? RiskState { get; set; }
        /// <summary>Risky user display name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserDisplayName { get; set; }
#nullable restore
#else
        public string UserDisplayName { get; set; }
#endif
        /// <summary>Risky user principal name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? UserPrincipalName { get; set; }
#nullable restore
#else
        public string UserPrincipalName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.RiskyUser"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.RiskyUser CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.riskyUserHistoryItem" => new global::NoBackingStore.Graph.Models.RiskyUserHistoryItem(),
                _ => new global::NoBackingStore.Graph.Models.RiskyUser(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "history", n => { History = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.RiskyUserHistoryItem>(global::NoBackingStore.Graph.Models.RiskyUserHistoryItem.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isDeleted", n => { IsDeleted = n.GetBoolValue(); } },
                { "isProcessing", n => { IsProcessing = n.GetBoolValue(); } },
                { "riskDetail", n => { RiskDetail = n.GetEnumValue<global::NoBackingStore.Graph.Models.RiskDetail>(); } },
                { "riskLastUpdatedDateTime", n => { RiskLastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "riskLevel", n => { RiskLevel = n.GetEnumValue<global::NoBackingStore.Graph.Models.RiskLevel>(); } },
                { "riskState", n => { RiskState = n.GetEnumValue<global::NoBackingStore.Graph.Models.RiskState>(); } },
                { "userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                { "userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.RiskyUserHistoryItem>("history", History);
            writer.WriteBoolValue("isDeleted", IsDeleted);
            writer.WriteBoolValue("isProcessing", IsProcessing);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.RiskDetail>("riskDetail", RiskDetail);
            writer.WriteDateTimeOffsetValue("riskLastUpdatedDateTime", RiskLastUpdatedDateTime);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.RiskLevel>("riskLevel", RiskLevel);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.RiskState>("riskState", RiskState);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
#pragma warning restore CS0618
