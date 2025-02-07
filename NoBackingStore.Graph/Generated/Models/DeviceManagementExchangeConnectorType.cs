// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace NoBackingStore.Graph.Models
{
    /// <summary>The type of Exchange Connector.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DeviceManagementExchangeConnectorType
    {
        /// <summary>Connects to on-premises Exchange Environment.</summary>
        [EnumMember(Value = "onPremises")]
        OnPremises,
        /// <summary>Connects to O365 multi-tenant Exchange environment</summary>
        [EnumMember(Value = "hosted")]
        Hosted,
        /// <summary>Intune Service connects directly to O365 multi-tenant Exchange environment</summary>
        [EnumMember(Value = "serviceToService")]
        ServiceToService,
        /// <summary>Connects to O365 Dedicated Exchange environment.</summary>
        [EnumMember(Value = "dedicated")]
        Dedicated,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
