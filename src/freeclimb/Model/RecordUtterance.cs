/*
 * FreeClimb API
 *
 * FreeClimb is a cloud-based application programming interface (API) that puts the power of the Vail platform in your hands. FreeClimb simplifies the process of creating applications that can use a full range of telephony features without requiring specialized or on-site telephony equipment. Using the FreeClimb REST API to write applications is easy! You have the option to use the language of your choice or hit the API directly. Your application can execute a command by issuing a RESTful request to the FreeClimb API. The base URL to send HTTP requests to the FreeClimb REST API is: /apiserver. FreeClimb authenticates and processes your request.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@freeclimb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = freeclimb.Client.OpenAPIDateConverter;

namespace freeclimb.Model
{
    /// <summary>
    /// The &#x60;RecordUtterance&#x60; command records the caller&#39;s voice and returns the URL of a file containing the audio recording. &#x60;RecordUtterance&#x60; is blocking and is a terminal command. As such, the &#x60;actionUrl&#x60; property is required, and control of the Call picks up using the PerCL returned in response to the &#x60;actionUrl&#x60;. Recording information is returned in the &#x60;actionUrl&#x60; request.
    /// </summary>
    [DataContract(Name = "RecordUtterance")]
    [JsonConverter(typeof(JsonSubtypes), "Command")]
    [JsonSubtypes.KnownSubType(typeof(AddToConference), "AddToConference")]
    [JsonSubtypes.KnownSubType(typeof(CreateConference), "CreateConference")]
    [JsonSubtypes.KnownSubType(typeof(Dequeue), "Dequeue")]
    [JsonSubtypes.KnownSubType(typeof(Enqueue), "Enqueue")]
    [JsonSubtypes.KnownSubType(typeof(GetDigits), "GetDigits")]
    [JsonSubtypes.KnownSubType(typeof(GetSpeech), "GetSpeech")]
    [JsonSubtypes.KnownSubType(typeof(Hangup), "Hangup")]
    [JsonSubtypes.KnownSubType(typeof(OutDial), "OutDial")]
    [JsonSubtypes.KnownSubType(typeof(Park), "Park")]
    [JsonSubtypes.KnownSubType(typeof(Pause), "Pause")]
    [JsonSubtypes.KnownSubType(typeof(Play), "Play")]
    [JsonSubtypes.KnownSubType(typeof(PlayEarlyMedia), "PlayEarlyMedia")]
    [JsonSubtypes.KnownSubType(typeof(RecordUtterance), "RecordUtterance")]
    [JsonSubtypes.KnownSubType(typeof(Redirect), "Redirect")]
    [JsonSubtypes.KnownSubType(typeof(Reject), "Reject")]
    [JsonSubtypes.KnownSubType(typeof(RemoveFromConference), "RemoveFromConference")]
    [JsonSubtypes.KnownSubType(typeof(Say), "Say")]
    [JsonSubtypes.KnownSubType(typeof(SendDigits), "SendDigits")]
    [JsonSubtypes.KnownSubType(typeof(SetListen), "SetListen")]
    [JsonSubtypes.KnownSubType(typeof(SetTalk), "SetTalk")]
    [JsonSubtypes.KnownSubType(typeof(Sms), "Sms")]
    [JsonSubtypes.KnownSubType(typeof(StartRecordCall), "StartRecordCall")]
    [JsonSubtypes.KnownSubType(typeof(TerminateConference), "TerminateConference")]
    [JsonSubtypes.KnownSubType(typeof(Unpark), "Unpark")]
    public partial class RecordUtterance : PerclCommand, IEquatable<RecordUtterance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordUtterance" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RecordUtterance() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordUtterance" /> class.
        /// </summary>
        /// <param name="actionUrl">URL to which information on the completed recording is submitted. The PerCL received in response is then used to continue with Call processing. (required).</param>
        /// <param name="silenceTimeoutMs">Interval of silence that should elapse before ending the recording..</param>
        /// <param name="finishOnKey">Key that triggers the end of the recording. any digit, &#39;#&#39;, or &#39;*&#39;.</param>
        /// <param name="maxLengthSec">Maximum length for the command execution in seconds..</param>
        /// <param name="playBeep">Indicates whether to play a beep sound before the start of the recording. If set to &#x60;false&#x60;, no beep is played..</param>
        /// <param name="autoStart">If &#x60;false&#x60;, recording begins immediately after the RecordUtterance command is processed. If &#x60;true&#x60;, recording begins when audio is present and if audio begins before the &#x60;maxLengthSec&#x60; timeout. If no audio begins before &#x60;maxLengthSec&#x60;, no recording is generated..</param>
        /// <param name="privacyMode">Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance..</param>
        /// <param name="command">Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) (default to &quot;RecordUtterance&quot;).</param>
        public RecordUtterance(string actionUrl = default(string), int silenceTimeoutMs = default(int), string finishOnKey = default(string), int maxLengthSec = default(int), bool playBeep = default(bool), bool autoStart = default(bool), bool privacyMode = default(bool), string command = "RecordUtterance") : base(command)
        {
            // to ensure "actionUrl" is required (not null)
            if (actionUrl == null) {
                throw new ArgumentNullException("actionUrl is a required property for RecordUtterance and cannot be null");
            }
            this.ActionUrl = actionUrl;
            this.SilenceTimeoutMs = silenceTimeoutMs;
            this.FinishOnKey = finishOnKey;
            this.MaxLengthSec = maxLengthSec;
            this.PlayBeep = playBeep;
            this.AutoStart = autoStart;
            this.PrivacyMode = privacyMode;
        }

        /// <summary>
        /// URL to which information on the completed recording is submitted. The PerCL received in response is then used to continue with Call processing.
        /// </summary>
        /// <value>URL to which information on the completed recording is submitted. The PerCL received in response is then used to continue with Call processing.</value>
        [DataMember(Name = "actionUrl", IsRequired = true, EmitDefaultValue = false)]
        public string ActionUrl { get; set; }

        /// <summary>
        /// Interval of silence that should elapse before ending the recording.
        /// </summary>
        /// <value>Interval of silence that should elapse before ending the recording.</value>
        [DataMember(Name = "silenceTimeoutMs", EmitDefaultValue = false)]
        public int SilenceTimeoutMs { get; set; }

        /// <summary>
        /// Key that triggers the end of the recording. any digit, &#39;#&#39;, or &#39;*&#39;
        /// </summary>
        /// <value>Key that triggers the end of the recording. any digit, &#39;#&#39;, or &#39;*&#39;</value>
        [DataMember(Name = "finishOnKey", EmitDefaultValue = false)]
        public string FinishOnKey { get; set; }

        /// <summary>
        /// Maximum length for the command execution in seconds.
        /// </summary>
        /// <value>Maximum length for the command execution in seconds.</value>
        [DataMember(Name = "maxLengthSec", EmitDefaultValue = false)]
        public int MaxLengthSec { get; set; }

        /// <summary>
        /// Indicates whether to play a beep sound before the start of the recording. If set to &#x60;false&#x60;, no beep is played.
        /// </summary>
        /// <value>Indicates whether to play a beep sound before the start of the recording. If set to &#x60;false&#x60;, no beep is played.</value>
        [DataMember(Name = "playBeep", EmitDefaultValue = true)]
        public bool PlayBeep { get; set; }

        /// <summary>
        /// If &#x60;false&#x60;, recording begins immediately after the RecordUtterance command is processed. If &#x60;true&#x60;, recording begins when audio is present and if audio begins before the &#x60;maxLengthSec&#x60; timeout. If no audio begins before &#x60;maxLengthSec&#x60;, no recording is generated.
        /// </summary>
        /// <value>If &#x60;false&#x60;, recording begins immediately after the RecordUtterance command is processed. If &#x60;true&#x60;, recording begins when audio is present and if audio begins before the &#x60;maxLengthSec&#x60; timeout. If no audio begins before &#x60;maxLengthSec&#x60;, no recording is generated.</value>
        [DataMember(Name = "autoStart", EmitDefaultValue = true)]
        public bool AutoStart { get; set; }

        /// <summary>
        /// Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance.
        /// </summary>
        /// <value>Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance.</value>
        [DataMember(Name = "privacyMode", EmitDefaultValue = true)]
        public bool PrivacyMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecordUtterance {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ActionUrl: ").Append(ActionUrl).Append("\n");
            sb.Append("  SilenceTimeoutMs: ").Append(SilenceTimeoutMs).Append("\n");
            sb.Append("  FinishOnKey: ").Append(FinishOnKey).Append("\n");
            sb.Append("  MaxLengthSec: ").Append(MaxLengthSec).Append("\n");
            sb.Append("  PlayBeep: ").Append(PlayBeep).Append("\n");
            sb.Append("  AutoStart: ").Append(AutoStart).Append("\n");
            sb.Append("  PrivacyMode: ").Append(PrivacyMode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            JsonSerializer jsonSerializer = JsonSerializer.Create();
            jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

            StringBuilder strb = new StringBuilder();
            jsonSerializer.Serialize(new StringWriter(strb), ToKvp());

            return strb.ToString();
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the RecordUtterance instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("actionUrl", ActionUrl);          
            props.Add("silenceTimeoutMs", SilenceTimeoutMs);          
            props.Add("finishOnKey", FinishOnKey);          
            props.Add("maxLengthSec", MaxLengthSec);          
            props.Add("playBeep", PlayBeep);          
            props.Add("autoStart", AutoStart);          
            props.Add("privacyMode", PrivacyMode);          
            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("RecordUtterance",props);
            return command;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordUtterance);
        }

        /// <summary>
        /// Returns true if RecordUtterance instances are equal
        /// </summary>
        /// <param name="input">Instance of RecordUtterance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordUtterance input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.ActionUrl == input.ActionUrl ||
                    (this.ActionUrl != null &&
                    this.ActionUrl.Equals(input.ActionUrl))
                ) && base.Equals(input) && 
                (
                    this.SilenceTimeoutMs == input.SilenceTimeoutMs ||
                    this.SilenceTimeoutMs.Equals(input.SilenceTimeoutMs)
                ) && base.Equals(input) && 
                (
                    this.FinishOnKey == input.FinishOnKey ||
                    (this.FinishOnKey != null &&
                    this.FinishOnKey.Equals(input.FinishOnKey))
                ) && base.Equals(input) && 
                (
                    this.MaxLengthSec == input.MaxLengthSec ||
                    this.MaxLengthSec.Equals(input.MaxLengthSec)
                ) && base.Equals(input) && 
                (
                    this.PlayBeep == input.PlayBeep ||
                    this.PlayBeep.Equals(input.PlayBeep)
                ) && base.Equals(input) && 
                (
                    this.AutoStart == input.AutoStart ||
                    this.AutoStart.Equals(input.AutoStart)
                ) && base.Equals(input) && 
                (
                    this.PrivacyMode == input.PrivacyMode ||
                    this.PrivacyMode.Equals(input.PrivacyMode)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = base.GetHashCode();
                if (this.ActionUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ActionUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SilenceTimeoutMs.GetHashCode();
                if (this.FinishOnKey != null)
                {
                    hashCode = (hashCode * 59) + this.FinishOnKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MaxLengthSec.GetHashCode();
                hashCode = (hashCode * 59) + this.PlayBeep.GetHashCode();
                hashCode = (hashCode * 59) + this.AutoStart.GetHashCode();
                hashCode = (hashCode * 59) + this.PrivacyMode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public override IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected override IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }

}
