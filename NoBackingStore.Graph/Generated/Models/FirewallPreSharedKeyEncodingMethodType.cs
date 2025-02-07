// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace NoBackingStore.Graph.Models
{
    /// <summary>Possible values for firewallPreSharedKeyEncodingMethod</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum FirewallPreSharedKeyEncodingMethodType
    {
        /// <summary>No value configured by Intune, do not override the user-configured device default value</summary>
        [EnumMember(Value = "deviceDefault")]
        DeviceDefault,
        /// <summary>Preshared key is not encoded. Instead, it is kept in its wide-character format</summary>
        [EnumMember(Value = "none")]
        None,
        /// <summary>Encode the preshared key using UTF-8</summary>
        [EnumMember(Value = "utF8")]
        UtF8,
    }
}
