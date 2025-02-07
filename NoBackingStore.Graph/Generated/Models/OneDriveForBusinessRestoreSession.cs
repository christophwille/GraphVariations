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
    public partial class OneDriveForBusinessRestoreSession : global::NoBackingStore.Graph.Models.RestoreSessionBase, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>A collection of restore points and destination details that can be used to restore a OneDrive for Business drive.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.DriveRestoreArtifact>? DriveRestoreArtifacts { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.DriveRestoreArtifact> DriveRestoreArtifacts { get; set; }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::NoBackingStore.Graph.Models.OneDriveForBusinessRestoreSession"/> and sets the default values.
        /// </summary>
        public OneDriveForBusinessRestoreSession() : base()
        {
            OdataType = "#microsoft.graph.oneDriveForBusinessRestoreSession";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.OneDriveForBusinessRestoreSession"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.OneDriveForBusinessRestoreSession CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.OneDriveForBusinessRestoreSession();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "driveRestoreArtifacts", n => { DriveRestoreArtifacts = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DriveRestoreArtifact>(global::NoBackingStore.Graph.Models.DriveRestoreArtifact.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.DriveRestoreArtifact>("driveRestoreArtifacts", DriveRestoreArtifacts);
        }
    }
}
#pragma warning restore CS0618
