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
using freeclimb.Enums;

namespace freeclimb.Model
{
    /// <summary>
    /// The &#x60;Play&#x60; command plays an audio file back to the caller. The audio file may be located at any location accessible via a URL. &#x60;Play&#x60; can exist as a stand-alone command or as a nested command. It does not allow barge-in unless nested within a &#x60;GetSpeech&#x60; command. The file will always be played to completion unless nested.
    /// </summary>
    [DataContract(Name = "Play")]
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
    public partial class Play : PerclCommand, IEquatable<Play>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Play" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Play() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Play" /> class.
        /// </summary>
        /// <param name="file">RL of the audio file to be played to the caller. The URL can be the &#x60;recordingUrl&#x60; generated from the &#x60;RecordUtterance&#x60; or &#x60;StartRecordCall&#x60; PerCL commands.  (required).</param>
        /// <param name="loop">Number of times the audio file is played. Specifying &#39;0&#39; causes the Play action to loop until the Call is hung up..</param>
        /// <param name="conferenceId">ID of the Conference the audio should be rendered to. If this is not specified, the audio is by default rendered to the caller associated with the call leg that corresponds to the current PerCL execution context. The call leg associated with this command must be in the specified Conference or the command will return an error..</param>
        /// <param name="privacyMode">Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance..</param>
        /// <param name="command">Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) (default to &quot;Play&quot;).</param>
        public Play(string file = default(string), int loop = default(int), string conferenceId = default(string), bool privacyMode = default(bool), string command = "Play") : base(command)
        {
            // to ensure "file" is required (not null)
            if (file == null) {
                throw new ArgumentNullException("file is a required property for Play and cannot be null");
            }
            this.File = file;
            this.Loop = loop;
            this.ConferenceId = conferenceId;
            this.PrivacyMode = privacyMode;
        }

        /// <summary>
        /// RL of the audio file to be played to the caller. The URL can be the &#x60;recordingUrl&#x60; generated from the &#x60;RecordUtterance&#x60; or &#x60;StartRecordCall&#x60; PerCL commands. 
        /// </summary>
        /// <value>RL of the audio file to be played to the caller. The URL can be the &#x60;recordingUrl&#x60; generated from the &#x60;RecordUtterance&#x60; or &#x60;StartRecordCall&#x60; PerCL commands. </value>
        [DataMember(Name = "file", IsRequired = true, EmitDefaultValue = false)]
        public string File { get; set; }

        /// <summary>
        /// Number of times the audio file is played. Specifying &#39;0&#39; causes the Play action to loop until the Call is hung up.
        /// </summary>
        /// <value>Number of times the audio file is played. Specifying &#39;0&#39; causes the Play action to loop until the Call is hung up.</value>
        [DataMember(Name = "loop", EmitDefaultValue = false)]
        public int Loop { get; set; }

        /// <summary>
        /// ID of the Conference the audio should be rendered to. If this is not specified, the audio is by default rendered to the caller associated with the call leg that corresponds to the current PerCL execution context. The call leg associated with this command must be in the specified Conference or the command will return an error.
        /// </summary>
        /// <value>ID of the Conference the audio should be rendered to. If this is not specified, the audio is by default rendered to the caller associated with the call leg that corresponds to the current PerCL execution context. The call leg associated with this command must be in the specified Conference or the command will return an error.</value>
        [DataMember(Name = "conferenceId", EmitDefaultValue = false)]
        public string ConferenceId { get; set; }

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
            sb.Append("class Play {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Loop: ").Append(Loop).Append("\n");
            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
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
        /// Retrieve the KVP Dictionary for the Play instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("file", File);          
            props.Add("loop", Loop);          
            props.Add("conferenceId", ConferenceId);          
            props.Add("privacyMode", PrivacyMode);          
            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Play",props);
            return command;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Play);
        }

        /// <summary>
        /// Returns true if Play instances are equal
        /// </summary>
        /// <param name="input">Instance of Play to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Play input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.File == input.File ||
                    (this.File != null &&
                    this.File.Equals(input.File))
                ) && base.Equals(input) && 
                (
                    this.Loop == input.Loop ||
                    this.Loop.Equals(input.Loop)
                ) && base.Equals(input) && 
                (
                    this.ConferenceId == input.ConferenceId ||
                    (this.ConferenceId != null &&
                    this.ConferenceId.Equals(input.ConferenceId))
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
                if (this.File != null)
                {
                    hashCode = (hashCode * 59) + this.File.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Loop.GetHashCode();
                if (this.ConferenceId != null)
                {
                    hashCode = (hashCode * 59) + this.ConferenceId.GetHashCode();
                }
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
