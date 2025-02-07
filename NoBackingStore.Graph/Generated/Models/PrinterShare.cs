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
    public partial class PrinterShare : global::NoBackingStore.Graph.Models.PrinterBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>If true, all users and groups will be granted access to this printer share. This supersedes the allow lists defined by the allowedUsers and allowedGroups navigation properties.</summary>
        public bool? AllowAllUsers { get; set; }
        /// <summary>The groups whose users have access to print using the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Group>? AllowedGroups { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Group> AllowedGroups { get; set; }
#endif
        /// <summary>The users who have access to print using the printer.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.User>? AllowedUsers { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.User> AllowedUsers { get; set; }
#endif
        /// <summary>The DateTimeOffset when the printer share was created. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The printer that this printer share is related to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.Printer? Printer { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.Printer Printer { get; set; }
#endif
        /// <summary>Additional data for a printer share as viewed by the signed-in user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.PrinterShareViewpoint? ViewPoint { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.PrinterShareViewpoint ViewPoint { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.PrinterShare"/> and sets the default values.
        /// </summary>
        public PrinterShare() : base()
        {
            OdataType = "#microsoft.graph.printerShare";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.PrinterShare"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.PrinterShare CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.PrinterShare();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowAllUsers", n => { AllowAllUsers = n.GetBoolValue(); } },
                { "allowedGroups", n => { AllowedGroups = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Group>(global::NoBackingStore.Graph.Models.Group.CreateFromDiscriminatorValue)?.AsList(); } },
                { "allowedUsers", n => { AllowedUsers = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.User>(global::NoBackingStore.Graph.Models.User.CreateFromDiscriminatorValue)?.AsList(); } },
                { "createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                { "printer", n => { Printer = n.GetObjectValue<global::NoBackingStore.Graph.Models.Printer>(global::NoBackingStore.Graph.Models.Printer.CreateFromDiscriminatorValue); } },
                { "viewPoint", n => { ViewPoint = n.GetObjectValue<global::NoBackingStore.Graph.Models.PrinterShareViewpoint>(global::NoBackingStore.Graph.Models.PrinterShareViewpoint.CreateFromDiscriminatorValue); } },
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
            writer.WriteBoolValue("allowAllUsers", AllowAllUsers);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Group>("allowedGroups", AllowedGroups);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.User>("allowedUsers", AllowedUsers);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.Printer>("printer", Printer);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.PrinterShareViewpoint>("viewPoint", ViewPoint);
        }
    }
}
#pragma warning restore CS0618
