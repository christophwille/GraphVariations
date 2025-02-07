// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace NoBackingStore.Graph.Models
{
    /// <summary>Possible values of Cloud Block Level</summary>
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    public enum DefenderCloudBlockLevelType
    {
        /// <summary>Default value, uses the default Windows Defender Antivirus blocking level and provides strong detection without increasing the risk of detecting legitimate files</summary>
        [EnumMember(Value = "notConfigured")]
        NotConfigured,
        /// <summary>High applies a strong level of detection.</summary>
        [EnumMember(Value = "high")]
        High,
        /// <summary>High + uses the High level and applies addition protection measures</summary>
        [EnumMember(Value = "highPlus")]
        HighPlus,
        /// <summary>Zero tolerance blocks all unknown executables</summary>
        [EnumMember(Value = "zeroTolerance")]
        ZeroTolerance,
    }
}
