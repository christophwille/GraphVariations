// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace NoBackingStore.Graph.Models
{
    /// <summary>Contains value for auto-update superseded apps.</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum Win32LobAutoUpdateSupersededAppsState
    {
        /// <summary>Indicates that the auto-update superseded apps state is not configured and the app will not auto-update the superseded apps.</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>Indicates that the auto-update superseded apps state is enabled and the app will auto-update the superseded apps if the superseded apps are installed on the device.</summary>
        [EnumMember(Value = "enabled")]
        Enabled,
        /// <summary>Evolvable enumeration sentinel value. Do not use.</summary>
        [EnumMember(Value = "unknownFutureValue")]
        UnknownFutureValue,
    }
}
