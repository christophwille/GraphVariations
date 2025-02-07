// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace NoBackingStore.Graph.Models.IdentityGovernance
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class LifecycleWorkflowsContainer : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The customTaskExtension instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.IdentityGovernance.CustomTaskExtension>? CustomTaskExtensions { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.IdentityGovernance.CustomTaskExtension> CustomTaskExtensions { get; set; }
#endif
        /// <summary>Deleted workflows in your lifecycle workflows instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.DeletedItemContainer? DeletedItems { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.DeletedItemContainer DeletedItems { get; set; }
#endif
        /// <summary>The insight container holding workflow insight summaries for a tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentityGovernance.Insights? Insights { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentityGovernance.Insights Insights { get; set; }
#endif
        /// <summary>The settings property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.IdentityGovernance.LifecycleManagementSettings? Settings { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.IdentityGovernance.LifecycleManagementSettings Settings { get; set; }
#endif
        /// <summary>The definition of tasks within the lifecycle workflows instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.IdentityGovernance.TaskDefinition>? TaskDefinitions { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.IdentityGovernance.TaskDefinition> TaskDefinitions { get; set; }
#endif
        /// <summary>The workflows in the lifecycle workflows instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.IdentityGovernance.Workflow>? Workflows { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.IdentityGovernance.Workflow> Workflows { get; set; }
#endif
        /// <summary>The workflow templates in the lifecycle workflow instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.IdentityGovernance.WorkflowTemplate>? WorkflowTemplates { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.IdentityGovernance.WorkflowTemplate> WorkflowTemplates { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.IdentityGovernance.LifecycleWorkflowsContainer"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.IdentityGovernance.LifecycleWorkflowsContainer CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.IdentityGovernance.LifecycleWorkflowsContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "customTaskExtensions", n => { CustomTaskExtensions = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityGovernance.CustomTaskExtension>(global::NoBackingStore.Graph.Models.IdentityGovernance.CustomTaskExtension.CreateFromDiscriminatorValue)?.AsList(); } },
                { "deletedItems", n => { DeletedItems = n.GetObjectValue<global::NoBackingStore.Graph.Models.DeletedItemContainer>(global::NoBackingStore.Graph.Models.DeletedItemContainer.CreateFromDiscriminatorValue); } },
                { "insights", n => { Insights = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentityGovernance.Insights>(global::NoBackingStore.Graph.Models.IdentityGovernance.Insights.CreateFromDiscriminatorValue); } },
                { "settings", n => { Settings = n.GetObjectValue<global::NoBackingStore.Graph.Models.IdentityGovernance.LifecycleManagementSettings>(global::NoBackingStore.Graph.Models.IdentityGovernance.LifecycleManagementSettings.CreateFromDiscriminatorValue); } },
                { "taskDefinitions", n => { TaskDefinitions = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityGovernance.TaskDefinition>(global::NoBackingStore.Graph.Models.IdentityGovernance.TaskDefinition.CreateFromDiscriminatorValue)?.AsList(); } },
                { "workflowTemplates", n => { WorkflowTemplates = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityGovernance.WorkflowTemplate>(global::NoBackingStore.Graph.Models.IdentityGovernance.WorkflowTemplate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "workflows", n => { Workflows = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityGovernance.Workflow>(global::NoBackingStore.Graph.Models.IdentityGovernance.Workflow.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityGovernance.CustomTaskExtension>("customTaskExtensions", CustomTaskExtensions);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.DeletedItemContainer>("deletedItems", DeletedItems);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.IdentityGovernance.Insights>("insights", Insights);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.IdentityGovernance.LifecycleManagementSettings>("settings", Settings);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityGovernance.TaskDefinition>("taskDefinitions", TaskDefinitions);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityGovernance.Workflow>("workflows", Workflows);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.IdentityGovernance.WorkflowTemplate>("workflowTemplates", WorkflowTemplates);
        }
    }
}
#pragma warning restore CS0618
