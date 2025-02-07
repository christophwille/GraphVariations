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
    public partial class TodoTaskList : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The name of the task list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; set; }
#nullable restore
#else
        public string DisplayName { get; set; }
#endif
        /// <summary>The collection of open extensions defined for the task list. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Extension>? Extensions { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Extension> Extensions { get; set; }
#endif
        /// <summary>True if the user is owner of the given task list.</summary>
        public bool? IsOwner { get; set; }
        /// <summary>True if the task list is shared with other users</summary>
        public bool? IsShared { get; set; }
        /// <summary>The tasks in this task list. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.TodoTask>? Tasks { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.TodoTask> Tasks { get; set; }
#endif
        /// <summary>The wellknownListName property</summary>
        public global::NoBackingStore.Graph.Models.WellknownListName? WellknownListName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.TodoTaskList"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.TodoTaskList CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.TodoTaskList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "displayName", n => { DisplayName = n.GetStringValue(); } },
                { "extensions", n => { Extensions = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Extension>(global::NoBackingStore.Graph.Models.Extension.CreateFromDiscriminatorValue)?.AsList(); } },
                { "isOwner", n => { IsOwner = n.GetBoolValue(); } },
                { "isShared", n => { IsShared = n.GetBoolValue(); } },
                { "tasks", n => { Tasks = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.TodoTask>(global::NoBackingStore.Graph.Models.TodoTask.CreateFromDiscriminatorValue)?.AsList(); } },
                { "wellknownListName", n => { WellknownListName = n.GetEnumValue<global::NoBackingStore.Graph.Models.WellknownListName>(); } },
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
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Extension>("extensions", Extensions);
            writer.WriteBoolValue("isOwner", IsOwner);
            writer.WriteBoolValue("isShared", IsShared);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.TodoTask>("tasks", Tasks);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.WellknownListName>("wellknownListName", WellknownListName);
        }
    }
}
#pragma warning restore CS0618
