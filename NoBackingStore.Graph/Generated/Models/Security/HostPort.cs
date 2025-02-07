// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace NoBackingStore.Graph.Models.Security
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class HostPort : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The hostPortBanners retrieved from scanning the port.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.HostPortBanner>? Banners { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.HostPortBanner> Banners { get; set; }
#endif
        /// <summary>The first date and time when Microsoft Defender Threat Intelligence observed the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? FirstSeenDateTime { get; set; }
        /// <summary>The host property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.Security.Host? Host { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.Security.Host Host { get; set; }
#endif
        /// <summary>The last date and time when Microsoft Defender Threat Intelligence scanned the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastScanDateTime { get; set; }
        /// <summary>The last date and time when Microsoft Defender Threat Intelligence observed the hostPort. The timestamp type represents date and time information using ISO 8601 format and is always in UTC. For example, midnight UTC on Jan 1, 2014, is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? LastSeenDateTime { get; set; }
        /// <summary>The most recent sslCertificate used to communicate on the port.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.Security.SslCertificate? MostRecentSslCertificate { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.Security.SslCertificate MostRecentSslCertificate { get; set; }
#endif
        /// <summary>The numerical identifier of the port which is standardized across the internet.</summary>
        public int? Port { get; set; }
        /// <summary>The general protocol used to scan the port. The possible values are: tcp, udp, unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.Security.HostPortProtocol? Protocol { get; set; }
        /// <summary>The hostPortComponents retrieved from scanning the port.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.HostPortComponent>? Services { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.HostPortComponent> Services { get; set; }
#endif
        /// <summary>The status of the port. The possible values are: open, filtered, closed, unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.Security.HostPortStatus? Status { get; set; }
        /// <summary>The total amount of times that Microsoft Defender Threat Intelligence has observed the hostPort in all its scans.</summary>
        public int? TimesObserved { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.Security.HostPort"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.Security.HostPort CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.Security.HostPort();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "banners", n => { Banners = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostPortBanner>(global::NoBackingStore.Graph.Models.Security.HostPortBanner.CreateFromDiscriminatorValue)?.AsList(); } },
                { "firstSeenDateTime", n => { FirstSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "host", n => { Host = n.GetObjectValue<global::NoBackingStore.Graph.Models.Security.Host>(global::NoBackingStore.Graph.Models.Security.Host.CreateFromDiscriminatorValue); } },
                { "lastScanDateTime", n => { LastScanDateTime = n.GetDateTimeOffsetValue(); } },
                { "lastSeenDateTime", n => { LastSeenDateTime = n.GetDateTimeOffsetValue(); } },
                { "mostRecentSslCertificate", n => { MostRecentSslCertificate = n.GetObjectValue<global::NoBackingStore.Graph.Models.Security.SslCertificate>(global::NoBackingStore.Graph.Models.Security.SslCertificate.CreateFromDiscriminatorValue); } },
                { "port", n => { Port = n.GetIntValue(); } },
                { "protocol", n => { Protocol = n.GetEnumValue<global::NoBackingStore.Graph.Models.Security.HostPortProtocol>(); } },
                { "services", n => { Services = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostPortComponent>(global::NoBackingStore.Graph.Models.Security.HostPortComponent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "status", n => { Status = n.GetEnumValue<global::NoBackingStore.Graph.Models.Security.HostPortStatus>(); } },
                { "timesObserved", n => { TimesObserved = n.GetIntValue(); } },
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
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostPortBanner>("banners", Banners);
            writer.WriteDateTimeOffsetValue("firstSeenDateTime", FirstSeenDateTime);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.Security.Host>("host", Host);
            writer.WriteDateTimeOffsetValue("lastScanDateTime", LastScanDateTime);
            writer.WriteDateTimeOffsetValue("lastSeenDateTime", LastSeenDateTime);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.Security.SslCertificate>("mostRecentSslCertificate", MostRecentSslCertificate);
            writer.WriteIntValue("port", Port);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.Security.HostPortProtocol>("protocol", Protocol);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostPortComponent>("services", Services);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.Security.HostPortStatus>("status", Status);
            writer.WriteIntValue("timesObserved", TimesObserved);
        }
    }
}
#pragma warning restore CS0618
