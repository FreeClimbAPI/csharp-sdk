using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace com.freeclimb
{
    /// <summary>
    /// ERequestType enumeration with a default value of NONE.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum ERequestType
    {
#pragma warning disable 1591 // XML comment compiler warning
        [EnumMember(Value = "")]
        NONE = 0,

        [EnumMember(Value = "inboundCall")]
        InboundCall,

        [EnumMember(Value = "inboundMessage")]
        InboundMessage,

        [EnumMember(Value = "record")]
        Record,

        [EnumMember(Value = "getDigits")]
        GetDigits,

        [EnumMember(Value = "getSpeech")]
        GetSpeech,

        [EnumMember(Value = "redirect")]
        Redirect,

        [EnumMember(Value = "pause")]
        Pause,

        [EnumMember(Value = "outDialStart")]
        OutDialStart,

        [EnumMember(Value = "outDialConnect")]
        OutDialConnect,

        [EnumMember(Value = "outDialApiConnect")]
        OutDialApiConnect,

        [EnumMember(Value = "ifMachine")]
        IfMachine,

        [EnumMember(Value = "dequeue")]
        Dequeue,

        [EnumMember(Value = "queueWait")]
        QueueWait,

        [EnumMember(Value = "addToQueueNotification")]
        AddToQueueNotification,

        [EnumMember(Value = "removeFromQueueNotification")]
        RemoveFromQueueNotification,

        [EnumMember(Value = "leaveConference")]
        LeaveConference,

        [EnumMember(Value = "addToConferenceNotification")]
        AddToConferenceNotification,

        [EnumMember(Value = "callStatus")]
        CallStatus,

        [EnumMember(Value = "conferenceStatus")]
        ConferenceStatus,

        [EnumMember(Value = "createConference")]
        CreateConference,

        [EnumMember(Value = "conferenceRecordingStatus")]
        ConferenceRecordingStatus,

        [EnumMember(Value = "conferenceCallControl")]
        ConferenceCallControl,

        [EnumMember(Value = "numberVerification")]
        NumberVerification,

        [EnumMember(Value = "machineDetected")]
        MachineDetected,

        [EnumMember(Value = "usageTrigger")]
        UsageTrigger,

        [EnumMember(Value = "messageDelivery")]
        MessageDelivery,

        [EnumMember(Value = "messageStatus")]
        MessageStatus

#pragma warning restore 1591 
    }
}
