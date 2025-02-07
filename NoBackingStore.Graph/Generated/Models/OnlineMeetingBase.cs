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
    public partial class OnlineMeetingBase : global::NoBackingStore.Graph.Models.Entity, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>Indicates whether attendees can turn on their camera.</summary>
        public bool? AllowAttendeeToEnableCamera { get; set; }
        /// <summary>Indicates whether attendees can turn on their microphone.</summary>
        public bool? AllowAttendeeToEnableMic { get; set; }
        /// <summary>Specifies who can be a presenter in a meeting.</summary>
        public global::NoBackingStore.Graph.Models.OnlineMeetingPresenters? AllowedPresenters { get; set; }
        /// <summary>Specifies the mode of the meeting chat.</summary>
        public global::NoBackingStore.Graph.Models.MeetingChatMode? AllowMeetingChat { get; set; }
        /// <summary>Specifies if participants are allowed to rename themselves in an instance of the meeting.</summary>
        public bool? AllowParticipantsToChangeName { get; set; }
        /// <summary>Indicates whether recording is enabled for the meeting.</summary>
        public bool? AllowRecording { get; set; }
        /// <summary>Indicates if Teams reactions are enabled for the meeting.</summary>
        public bool? AllowTeamworkReactions { get; set; }
        /// <summary>Indicates whether transcription is enabled for the meeting.</summary>
        public bool? AllowTranscription { get; set; }
        /// <summary>The attendance reports of an online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::NoBackingStore.Graph.Models.MeetingAttendanceReport>? AttendanceReports { get; set; }
#nullable restore
#else
        public List<global::NoBackingStore.Graph.Models.MeetingAttendanceReport> AttendanceReports { get; set; }
#endif
        /// <summary>The phone access (dial-in) information for an online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.AudioConferencing? AudioConferencing { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.AudioConferencing AudioConferencing { get; set; }
#endif
        /// <summary>The chat information associated with this online meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ChatInfo? ChatInfo { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ChatInfo ChatInfo { get; set; }
#endif
        /// <summary>Specifies the configuration settings for meeting chat restrictions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ChatRestrictions? ChatRestrictions { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ChatRestrictions ChatRestrictions { get; set; }
#endif
        /// <summary>Indicates whether to announce when callers join or leave.</summary>
        public bool? IsEntryExitAnnounced { get; set; }
        /// <summary>The join information in the language and locale variant specified in &apos;Accept-Language&apos; request HTTP header. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.ItemBody? JoinInformation { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.ItemBody JoinInformation { get; set; }
#endif
        /// <summary>Specifies the joinMeetingId, the meeting passcode, and the requirement for the passcode. Once an onlineMeeting is created, the joinMeetingIdSettings can&apos;t be modified. To make any changes to this property, you must cancel this meeting and create a new one.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.JoinMeetingIdSettings? JoinMeetingIdSettings { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.JoinMeetingIdSettings JoinMeetingIdSettings { get; set; }
#endif
        /// <summary>The join URL of the online meeting. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? JoinWebUrl { get; set; }
#nullable restore
#else
        public string JoinWebUrl { get; set; }
#endif
        /// <summary>Specifies which participants can bypass the meeting lobby.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.LobbyBypassSettings? LobbyBypassSettings { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.LobbyBypassSettings LobbyBypassSettings { get; set; }
#endif
        /// <summary>Indicates whether to record the meeting automatically.</summary>
        public bool? RecordAutomatically { get; set; }
        /// <summary>Specifies whether meeting chat history is shared with participants.  Possible values are: all, none, unknownFutureValue.</summary>
        public global::NoBackingStore.Graph.Models.MeetingChatHistoryDefaultMode? ShareMeetingChatHistoryDefault { get; set; }
        /// <summary>The subject of the online meeting.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Subject { get; set; }
#nullable restore
#else
        public string Subject { get; set; }
#endif
        /// <summary>The video teleconferencing ID. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? VideoTeleconferenceId { get; set; }
#nullable restore
#else
        public string VideoTeleconferenceId { get; set; }
#endif
        /// <summary>Specifies whether the client application should apply a watermark to a content type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::NoBackingStore.Graph.Models.WatermarkProtectionValues? WatermarkProtection { get; set; }
#nullable restore
#else
        public global::NoBackingStore.Graph.Models.WatermarkProtectionValues WatermarkProtection { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::NoBackingStore.Graph.Models.OnlineMeetingBase"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::NoBackingStore.Graph.Models.OnlineMeetingBase CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch
            {
                "#microsoft.graph.onlineMeeting" => new global::NoBackingStore.Graph.Models.OnlineMeeting(),
                "#microsoft.graph.virtualEventSession" => new global::NoBackingStore.Graph.Models.VirtualEventSession(),
                _ => new global::NoBackingStore.Graph.Models.OnlineMeetingBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "allowAttendeeToEnableCamera", n => { AllowAttendeeToEnableCamera = n.GetBoolValue(); } },
                { "allowAttendeeToEnableMic", n => { AllowAttendeeToEnableMic = n.GetBoolValue(); } },
                { "allowMeetingChat", n => { AllowMeetingChat = n.GetEnumValue<global::NoBackingStore.Graph.Models.MeetingChatMode>(); } },
                { "allowParticipantsToChangeName", n => { AllowParticipantsToChangeName = n.GetBoolValue(); } },
                { "allowRecording", n => { AllowRecording = n.GetBoolValue(); } },
                { "allowTeamworkReactions", n => { AllowTeamworkReactions = n.GetBoolValue(); } },
                { "allowTranscription", n => { AllowTranscription = n.GetBoolValue(); } },
                { "allowedPresenters", n => { AllowedPresenters = n.GetEnumValue<global::NoBackingStore.Graph.Models.OnlineMeetingPresenters>(); } },
                { "attendanceReports", n => { AttendanceReports = n.GetCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MeetingAttendanceReport>(global::NoBackingStore.Graph.Models.MeetingAttendanceReport.CreateFromDiscriminatorValue)?.AsList(); } },
                { "audioConferencing", n => { AudioConferencing = n.GetObjectValue<global::NoBackingStore.Graph.Models.AudioConferencing>(global::NoBackingStore.Graph.Models.AudioConferencing.CreateFromDiscriminatorValue); } },
                { "chatInfo", n => { ChatInfo = n.GetObjectValue<global::NoBackingStore.Graph.Models.ChatInfo>(global::NoBackingStore.Graph.Models.ChatInfo.CreateFromDiscriminatorValue); } },
                { "chatRestrictions", n => { ChatRestrictions = n.GetObjectValue<global::NoBackingStore.Graph.Models.ChatRestrictions>(global::NoBackingStore.Graph.Models.ChatRestrictions.CreateFromDiscriminatorValue); } },
                { "isEntryExitAnnounced", n => { IsEntryExitAnnounced = n.GetBoolValue(); } },
                { "joinInformation", n => { JoinInformation = n.GetObjectValue<global::NoBackingStore.Graph.Models.ItemBody>(global::NoBackingStore.Graph.Models.ItemBody.CreateFromDiscriminatorValue); } },
                { "joinMeetingIdSettings", n => { JoinMeetingIdSettings = n.GetObjectValue<global::NoBackingStore.Graph.Models.JoinMeetingIdSettings>(global::NoBackingStore.Graph.Models.JoinMeetingIdSettings.CreateFromDiscriminatorValue); } },
                { "joinWebUrl", n => { JoinWebUrl = n.GetStringValue(); } },
                { "lobbyBypassSettings", n => { LobbyBypassSettings = n.GetObjectValue<global::NoBackingStore.Graph.Models.LobbyBypassSettings>(global::NoBackingStore.Graph.Models.LobbyBypassSettings.CreateFromDiscriminatorValue); } },
                { "recordAutomatically", n => { RecordAutomatically = n.GetBoolValue(); } },
                { "shareMeetingChatHistoryDefault", n => { ShareMeetingChatHistoryDefault = n.GetEnumValue<global::NoBackingStore.Graph.Models.MeetingChatHistoryDefaultMode>(); } },
                { "subject", n => { Subject = n.GetStringValue(); } },
                { "videoTeleconferenceId", n => { VideoTeleconferenceId = n.GetStringValue(); } },
                { "watermarkProtection", n => { WatermarkProtection = n.GetObjectValue<global::NoBackingStore.Graph.Models.WatermarkProtectionValues>(global::NoBackingStore.Graph.Models.WatermarkProtectionValues.CreateFromDiscriminatorValue); } },
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
            writer.WriteBoolValue("allowAttendeeToEnableCamera", AllowAttendeeToEnableCamera);
            writer.WriteBoolValue("allowAttendeeToEnableMic", AllowAttendeeToEnableMic);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.OnlineMeetingPresenters>("allowedPresenters", AllowedPresenters);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.MeetingChatMode>("allowMeetingChat", AllowMeetingChat);
            writer.WriteBoolValue("allowParticipantsToChangeName", AllowParticipantsToChangeName);
            writer.WriteBoolValue("allowRecording", AllowRecording);
            writer.WriteBoolValue("allowTeamworkReactions", AllowTeamworkReactions);
            writer.WriteBoolValue("allowTranscription", AllowTranscription);
            writer.WriteCollectionOfObjectValues<global::NoBackingStore.Graph.Models.MeetingAttendanceReport>("attendanceReports", AttendanceReports);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.AudioConferencing>("audioConferencing", AudioConferencing);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ChatInfo>("chatInfo", ChatInfo);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ChatRestrictions>("chatRestrictions", ChatRestrictions);
            writer.WriteBoolValue("isEntryExitAnnounced", IsEntryExitAnnounced);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.ItemBody>("joinInformation", JoinInformation);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.JoinMeetingIdSettings>("joinMeetingIdSettings", JoinMeetingIdSettings);
            writer.WriteStringValue("joinWebUrl", JoinWebUrl);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.LobbyBypassSettings>("lobbyBypassSettings", LobbyBypassSettings);
            writer.WriteBoolValue("recordAutomatically", RecordAutomatically);
            writer.WriteEnumValue<global::NoBackingStore.Graph.Models.MeetingChatHistoryDefaultMode>("shareMeetingChatHistoryDefault", ShareMeetingChatHistoryDefault);
            writer.WriteStringValue("subject", Subject);
            writer.WriteStringValue("videoTeleconferenceId", VideoTeleconferenceId);
            writer.WriteObjectValue<global::NoBackingStore.Graph.Models.WatermarkProtectionValues>("watermarkProtection", WatermarkProtection);
        }
    }
}
#pragma warning restore CS0618
