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
    public partial class ThreatIntelligence : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Refers to indicators of threat or compromise highlighted in an article.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.ArticleIndicator>? ArticleIndicators { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.ArticleIndicator> ArticleIndicators { get; set; }
#endif
        /// <summary>A list of article objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.Article>? Articles { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.Article> Articles { get; set; }
#endif
        /// <summary>Retrieve details about hostComponent objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.HostComponent>? HostComponents { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.HostComponent> HostComponents { get; set; }
#endif
        /// <summary>Retrieve details about hostCookie objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.HostCookie>? HostCookies { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.HostCookie> HostCookies { get; set; }
#endif
        /// <summary>Retrieve details about hostTracker objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.HostPair>? HostPairs { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.HostPair> HostPairs { get; set; }
#endif
        /// <summary>Retrieve details about hostPort objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.HostPort>? HostPorts { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.HostPort> HostPorts { get; set; }
#endif
        /// <summary>Refers to host objects that Microsoft Threat Intelligence has observed.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.Host>? Hosts { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.Host> Hosts { get; set; }
#endif
        /// <summary>Retrieve details about hostSslCertificate objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.HostSslCertificate>? HostSslCertificates { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.HostSslCertificate> HostSslCertificates { get; set; }
#endif
        /// <summary>Retrieve details about hostTracker objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.HostTracker>? HostTrackers { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.HostTracker> HostTrackers { get; set; }
#endif
        /// <summary>The intelligenceProfileIndicators property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.IntelligenceProfileIndicator>? IntelligenceProfileIndicators { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.IntelligenceProfileIndicator> IntelligenceProfileIndicators { get; set; }
#endif
        /// <summary>A list of intelligenceProfile objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.IntelligenceProfile>? IntelProfiles { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.IntelligenceProfile> IntelProfiles { get; set; }
#endif
        /// <summary>Retrieve details about passiveDnsRecord objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.PassiveDnsRecord>? PassiveDnsRecords { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.PassiveDnsRecord> PassiveDnsRecords { get; set; }
#endif
        /// <summary>Retrieve details about sslCertificate objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.SslCertificate>? SslCertificates { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.SslCertificate> SslCertificates { get; set; }
#endif
        /// <summary>Retrieve details about the subdomain.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.Subdomain>? Subdomains { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.Subdomain> Subdomains { get; set; }
#endif
        /// <summary>Retrieve details about vulnerabilities.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.Vulnerability>? Vulnerabilities { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.Vulnerability> Vulnerabilities { get; set; }
#endif
        /// <summary>Retrieve details about whoisHistoryRecord objects.Note: List retrieval is not yet supported.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.WhoisHistoryRecord>? WhoisHistoryRecords { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.WhoisHistoryRecord> WhoisHistoryRecords { get; set; }
#endif
        /// <summary>A list of whoisRecord objects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.Security.WhoisRecord>? WhoisRecords { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.Security.WhoisRecord> WhoisRecords { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.Security.ThreatIntelligence"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.Security.ThreatIntelligence CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::NoBackingStore.Graph.Models.Security.ThreatIntelligence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "articleIndicators", n => { ArticleIndicators = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.ArticleIndicator>(global::NoBackingStore.Graph.Models.Security.ArticleIndicator.CreateFromDiscriminatorValue)?.AsList(); } },
                { "articles", n => { Articles = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.Article>(global::NoBackingStore.Graph.Models.Security.Article.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostComponents", n => { HostComponents = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostComponent>(global::NoBackingStore.Graph.Models.Security.HostComponent.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostCookies", n => { HostCookies = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostCookie>(global::NoBackingStore.Graph.Models.Security.HostCookie.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostPairs", n => { HostPairs = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostPair>(global::NoBackingStore.Graph.Models.Security.HostPair.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostPorts", n => { HostPorts = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostPort>(global::NoBackingStore.Graph.Models.Security.HostPort.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostSslCertificates", n => { HostSslCertificates = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostSslCertificate>(global::NoBackingStore.Graph.Models.Security.HostSslCertificate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hostTrackers", n => { HostTrackers = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostTracker>(global::NoBackingStore.Graph.Models.Security.HostTracker.CreateFromDiscriminatorValue)?.AsList(); } },
                { "hosts", n => { Hosts = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.Host>(global::NoBackingStore.Graph.Models.Security.Host.CreateFromDiscriminatorValue)?.AsList(); } },
                { "intelProfiles", n => { IntelProfiles = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.IntelligenceProfile>(global::NoBackingStore.Graph.Models.Security.IntelligenceProfile.CreateFromDiscriminatorValue)?.AsList(); } },
                { "intelligenceProfileIndicators", n => { IntelligenceProfileIndicators = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.IntelligenceProfileIndicator>(global::NoBackingStore.Graph.Models.Security.IntelligenceProfileIndicator.CreateFromDiscriminatorValue)?.AsList(); } },
                { "passiveDnsRecords", n => { PassiveDnsRecords = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.PassiveDnsRecord>(global::NoBackingStore.Graph.Models.Security.PassiveDnsRecord.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sslCertificates", n => { SslCertificates = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.SslCertificate>(global::NoBackingStore.Graph.Models.Security.SslCertificate.CreateFromDiscriminatorValue)?.AsList(); } },
                { "subdomains", n => { Subdomains = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.Subdomain>(global::NoBackingStore.Graph.Models.Security.Subdomain.CreateFromDiscriminatorValue)?.AsList(); } },
                { "vulnerabilities", n => { Vulnerabilities = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.Vulnerability>(global::NoBackingStore.Graph.Models.Security.Vulnerability.CreateFromDiscriminatorValue)?.AsList(); } },
                { "whoisHistoryRecords", n => { WhoisHistoryRecords = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.WhoisHistoryRecord>(global::NoBackingStore.Graph.Models.Security.WhoisHistoryRecord.CreateFromDiscriminatorValue)?.AsList(); } },
                { "whoisRecords", n => { WhoisRecords = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.WhoisRecord>(global::NoBackingStore.Graph.Models.Security.WhoisRecord.CreateFromDiscriminatorValue)?.AsList(); } },
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
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.ArticleIndicator>("articleIndicators", ArticleIndicators);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.Article>("articles", Articles);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostComponent>("hostComponents", HostComponents);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostCookie>("hostCookies", HostCookies);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostPair>("hostPairs", HostPairs);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostPort>("hostPorts", HostPorts);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.Host>("hosts", Hosts);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostSslCertificate>("hostSslCertificates", HostSslCertificates);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.HostTracker>("hostTrackers", HostTrackers);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.IntelligenceProfileIndicator>("intelligenceProfileIndicators", IntelligenceProfileIndicators);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.IntelligenceProfile>("intelProfiles", IntelProfiles);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.PassiveDnsRecord>("passiveDnsRecords", PassiveDnsRecords);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.SslCertificate>("sslCertificates", SslCertificates);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.Subdomain>("subdomains", Subdomains);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.Vulnerability>("vulnerabilities", Vulnerabilities);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.WhoisHistoryRecord>("whoisHistoryRecords", WhoisHistoryRecords);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.Security.WhoisRecord>("whoisRecords", WhoisRecords);
        }
    }
}
#pragma warning restore CS0618
