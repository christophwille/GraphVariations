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
    public partial class RegistryKeyState : IAdditionalDataHolder, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A Windows registry hive : HKEYCURRENTCONFIG HKEYCURRENTUSER HKEYLOCALMACHINE/SAM HKEYLOCALMACHINE/Security HKEYLOCALMACHINE/Software HKEYLOCALMACHINE/System HKEY_USERS/.Default. Possible values are: unknown, currentConfig, currentUser, localMachineSam, localMachineSecurity, localMachineSoftware, localMachineSystem, usersDefault.</summary>
        public global::NoBackingStore.Graph.Models.RegistryHive? Hive { get; set; }
        /// <summary>Current (i.e. changed) registry key (excludes HIVE).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType { get; set; }
#nullable restore
#else
        public string OdataType { get; set; }
#endif
        /// <summary>Previous (i.e. before changed) registry key (excludes HIVE).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OldKey { get; set; }
#nullable restore
#else
        public string OldKey { get; set; }
#endif
        /// <summary>Previous (i.e. before changed) registry key value data (contents).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OldValueData { get; set; }
#nullable restore
#else
        public string OldValueData { get; set; }
#endif
        /// <summary>Previous (i.e. before changed) registry key value name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OldValueName { get; set; }
#nullable restore
#else
        public string OldValueName { get; set; }
#endif
        /// <summary>Operation that changed the registry key name and/or value. Possible values are: unknown, create, modify, delete.</summary>
        public global::NoBackingStore.Graph.Models.RegistryOperation? Operation { get; set; }
        /// <summary>Process ID (PID) of the process that modified the registry key (process details will appear in the alert &apos;processes&apos; collection).</summary>
        public int? ProcessId { get; set; }
        /// <summary>Current (i.e. changed) registry key value data (contents).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValueData { get; set; }
#nullable restore
#else
        public string ValueData { get; set; }
#endif
        /// <summary>Current (i.e. changed) registry key value name</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ValueName { get; set; }
#nullable restore
#else
        public string ValueName { get; set; }
#endif
        /// <summary>Registry key value type REGBINARY REGDWORD REGDWORDLITTLEENDIAN REGDWORDBIGENDIANREGEXPANDSZ REGLINK REGMULTISZ REGNONE REGQWORD REGQWORDLITTLEENDIAN REG_SZ Possible values are: unknown, binary, dword, dwordLittleEndian, dwordBigEndian, expandSz, link, multiSz, none, qword, qwordlittleEndian, sz.</summary>
        public global::NoBackingStore.Graph.Models.RegistryValueType? ValueType { get; set; }
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.RegistryKeyState"/> and sets the default values.
        /// </summary>
        public RegistryKeyState()
        {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.RegistryKeyState"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static global::NoBackingStore.Graph.Models.RegistryKeyState CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.RegistryKeyState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public virtual IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>
            {
                { "hive", n => { Hive = n.GetEnumValue<global::NoBackingStore.Graph.Models.RegistryHive>(); } },
                { "key", n => { Key = n.GetStringValue(); } },
                { "@odata.type", n => { OdataType = n.GetStringValue(); } },
                { "oldKey", n => { OldKey = n.GetStringValue(); } },
                { "oldValueData", n => { OldValueData = n.GetStringValue(); } },
                { "oldValueName", n => { OldValueName = n.GetStringValue(); } },
                { "operation", n => { Operation = n.GetEnumValue<global::NoBackingStore.Graph.Models.RegistryOperation>(); } },
                { "processId", n => { ProcessId = n.GetIntValue(); } },
                { "valueData", n => { ValueData = n.GetStringValue(); } },
                { "valueName", n => { ValueName = n.GetStringValue(); } },
                { "valueType", n => { ValueType = n.GetEnumValue<global::NoBackingStore.Graph.Models.RegistryValueType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public virtual void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.RegistryHive>("hive", Hive);
            writer.WriteStringValue("key", Key);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("oldKey", OldKey);
            writer.WriteStringValue("oldValueData", OldValueData);
            writer.WriteStringValue("oldValueName", OldValueName);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.RegistryOperation>("operation", Operation);
            writer.WriteIntValue("processId", ProcessId);
            writer.WriteStringValue("valueData", ValueData);
            writer.WriteStringValue("valueName", ValueName);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.RegistryValueType>("valueType", ValueType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
#pragma warning restore CS0618
