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
    /// The &#x60;GetDigits&#x60; command collects DTMF inputs from the caller. It is only supported only when there is a single party on the Call. &#x60;GetDigits&#x60; is a Terminal Command — any actions following it are never executed. When the Caller is done entering the digits, FreeClimb submits that data to the provided &#x60;actionUrl&#x60; using an HTTP POST request. Your server will be required to respond to the FreeClimb Webhook with PerCL to continue handling the call.
    /// </summary>
    [DataContract(Name = "GetDigits")]
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
    [JsonSubtypes.KnownSubType(typeof(TranscribeUtterance), "TranscribeUtterance")]
    [JsonSubtypes.KnownSubType(typeof(Unpark), "Unpark")]
    public partial class GetDigits : PerclCommand, IEquatable<GetDigits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDigits" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetDigits() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetDigits" /> class.
        /// </summary>
        /// <param name="actionUrl">When the Caller has finished entering digits, FreeClimb will make an HTTP POST request to this URL. A PerCL response is expected to continue handling the Call. Make sure to keep “http://“ in the URL. (required).</param>
        /// <param name="digitTimeoutMs"> Maximum time in milliseconds that FreeClimb will wait for the Caller to press any digit after the last digit entered, before making a determination that a &#x60;timeout&#x60; has occurred and moving on to make the request to the actionUrl to submit the results of the &#x60;GetDigits&#x60; command. This timeout interval begins and resets after each digit entered..</param>
        /// <param name="finishOnKey">Digit that causes the input sequence to be deemed complete. This attribute defers to the &#x60;timeout&#x60; attribute – so, if a &#x60;timeout&#x60; occurs, then the command terminates regardless of the value of &#x60;finishOnKey&#x60;..</param>
        /// <param name="flushBuffer">If set to true, the FreeClimb platform starts with an empty DTMF buffer to store the digits entered by the caller. If set to false, FreeClimb will append the user inputs to the end of the existing digits buffer and will return digits from the start of the digits buffer..</param>
        /// <param name="initialTimeoutMs">Maximum time in milliseconds that FreeClimb will wait for the Caller to press the first digit before making a determination that a &#x60;timeout&#x60; has occurred and moving on to make the request to the &#x60;actionUrl&#x60; to submit the results of the &#x60;GetDigits&#x60; command. This timeout interval begins when all nested commands have been fully executed..</param>
        /// <param name="maxDigits">Maximum number of digits expected in the input. If the terminating digit is not entered and the caller has entered the maximum number of digits allowed, the &#x60;GetDigits&#x60; command terminates regardless of the value of &#x60;finishOnKey&#x60;..</param>
        /// <param name="minDigits">Minimum number of digits expected in the input. If specified, FreeClimb will return the collected digits only if the Caller has entered at least that many digits..</param>
        /// <param name="prompts">JSON array of PerCL commands to nest within the &#x60;GetDigits&#x60; command. The &#x60;Say&#x60;, &#x60;Play&#x60;, and &#x60;Pause&#x60; commands can be used. The nested actions are executed while FreeClimb is waiting for input from the Caller..</param>
        /// <param name="privacyMode">Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance..</param>
        /// <param name="command">Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) (default to &quot;GetDigits&quot;).</param>
        public GetDigits(string actionUrl = default(string), int digitTimeoutMs = default(int), string finishOnKey = default(string), bool flushBuffer = default(bool), int initialTimeoutMs = default(int), int maxDigits = default(int), int minDigits = default(int), List<PerclCommand> prompts = default(List<PerclCommand>), bool privacyMode = default(bool), string command = "GetDigits") : base(command)
        {
            // to ensure "actionUrl" is required (not null)
            if (actionUrl == null) {
                throw new ArgumentNullException("actionUrl is a required property for GetDigits and cannot be null");
            }
            this.ActionUrl = actionUrl;
            this.DigitTimeoutMs = digitTimeoutMs;
            this.FinishOnKey = finishOnKey;
            this.FlushBuffer = flushBuffer;
            this.InitialTimeoutMs = initialTimeoutMs;
            this.MaxDigits = maxDigits;
            this.MinDigits = minDigits;
            this.Prompts = prompts;
            this.PrivacyMode = privacyMode;
        }

        /// <summary>
        /// When the Caller has finished entering digits, FreeClimb will make an HTTP POST request to this URL. A PerCL response is expected to continue handling the Call. Make sure to keep “http://“ in the URL.
        /// </summary>
        /// <value>When the Caller has finished entering digits, FreeClimb will make an HTTP POST request to this URL. A PerCL response is expected to continue handling the Call. Make sure to keep “http://“ in the URL.</value>
        [DataMember(Name = "actionUrl", IsRequired = true, EmitDefaultValue = false)]
        public string ActionUrl { get; set; }

        /// <summary>
        ///  Maximum time in milliseconds that FreeClimb will wait for the Caller to press any digit after the last digit entered, before making a determination that a &#x60;timeout&#x60; has occurred and moving on to make the request to the actionUrl to submit the results of the &#x60;GetDigits&#x60; command. This timeout interval begins and resets after each digit entered.
        /// </summary>
        /// <value> Maximum time in milliseconds that FreeClimb will wait for the Caller to press any digit after the last digit entered, before making a determination that a &#x60;timeout&#x60; has occurred and moving on to make the request to the actionUrl to submit the results of the &#x60;GetDigits&#x60; command. This timeout interval begins and resets after each digit entered.</value>
        [DataMember(Name = "digitTimeoutMs", EmitDefaultValue = false)]
        public int DigitTimeoutMs { get; set; }

        /// <summary>
        /// Digit that causes the input sequence to be deemed complete. This attribute defers to the &#x60;timeout&#x60; attribute – so, if a &#x60;timeout&#x60; occurs, then the command terminates regardless of the value of &#x60;finishOnKey&#x60;.
        /// </summary>
        /// <value>Digit that causes the input sequence to be deemed complete. This attribute defers to the &#x60;timeout&#x60; attribute – so, if a &#x60;timeout&#x60; occurs, then the command terminates regardless of the value of &#x60;finishOnKey&#x60;.</value>
        [DataMember(Name = "finishOnKey", EmitDefaultValue = false)]
        public string FinishOnKey { get; set; }

        /// <summary>
        /// If set to true, the FreeClimb platform starts with an empty DTMF buffer to store the digits entered by the caller. If set to false, FreeClimb will append the user inputs to the end of the existing digits buffer and will return digits from the start of the digits buffer.
        /// </summary>
        /// <value>If set to true, the FreeClimb platform starts with an empty DTMF buffer to store the digits entered by the caller. If set to false, FreeClimb will append the user inputs to the end of the existing digits buffer and will return digits from the start of the digits buffer.</value>
        [DataMember(Name = "flushBuffer", EmitDefaultValue = true)]
        public bool FlushBuffer { get; set; }

        /// <summary>
        /// Maximum time in milliseconds that FreeClimb will wait for the Caller to press the first digit before making a determination that a &#x60;timeout&#x60; has occurred and moving on to make the request to the &#x60;actionUrl&#x60; to submit the results of the &#x60;GetDigits&#x60; command. This timeout interval begins when all nested commands have been fully executed.
        /// </summary>
        /// <value>Maximum time in milliseconds that FreeClimb will wait for the Caller to press the first digit before making a determination that a &#x60;timeout&#x60; has occurred and moving on to make the request to the &#x60;actionUrl&#x60; to submit the results of the &#x60;GetDigits&#x60; command. This timeout interval begins when all nested commands have been fully executed.</value>
        [DataMember(Name = "initialTimeoutMs", EmitDefaultValue = false)]
        public int InitialTimeoutMs { get; set; }

        /// <summary>
        /// Maximum number of digits expected in the input. If the terminating digit is not entered and the caller has entered the maximum number of digits allowed, the &#x60;GetDigits&#x60; command terminates regardless of the value of &#x60;finishOnKey&#x60;.
        /// </summary>
        /// <value>Maximum number of digits expected in the input. If the terminating digit is not entered and the caller has entered the maximum number of digits allowed, the &#x60;GetDigits&#x60; command terminates regardless of the value of &#x60;finishOnKey&#x60;.</value>
        [DataMember(Name = "maxDigits", EmitDefaultValue = false)]
        public int MaxDigits { get; set; }

        /// <summary>
        /// Minimum number of digits expected in the input. If specified, FreeClimb will return the collected digits only if the Caller has entered at least that many digits.
        /// </summary>
        /// <value>Minimum number of digits expected in the input. If specified, FreeClimb will return the collected digits only if the Caller has entered at least that many digits.</value>
        [DataMember(Name = "minDigits", EmitDefaultValue = false)]
        public int MinDigits { get; set; }

        /// <summary>
        /// JSON array of PerCL commands to nest within the &#x60;GetDigits&#x60; command. The &#x60;Say&#x60;, &#x60;Play&#x60;, and &#x60;Pause&#x60; commands can be used. The nested actions are executed while FreeClimb is waiting for input from the Caller.
        /// </summary>
        /// <value>JSON array of PerCL commands to nest within the &#x60;GetDigits&#x60; command. The &#x60;Say&#x60;, &#x60;Play&#x60;, and &#x60;Pause&#x60; commands can be used. The nested actions are executed while FreeClimb is waiting for input from the Caller.</value>
        [DataMember(Name = "prompts", EmitDefaultValue = false)]
        public List<PerclCommand> Prompts { get; set; }

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
            sb.Append("class GetDigits {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ActionUrl: ").Append(ActionUrl).Append("\n");
            sb.Append("  DigitTimeoutMs: ").Append(DigitTimeoutMs).Append("\n");
            sb.Append("  FinishOnKey: ").Append(FinishOnKey).Append("\n");
            sb.Append("  FlushBuffer: ").Append(FlushBuffer).Append("\n");
            sb.Append("  InitialTimeoutMs: ").Append(InitialTimeoutMs).Append("\n");
            sb.Append("  MaxDigits: ").Append(MaxDigits).Append("\n");
            sb.Append("  MinDigits: ").Append(MinDigits).Append("\n");
            sb.Append("  Prompts: ").Append(Prompts).Append("\n");
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
        /// Retrieve the KVP Dictionary for the GetDigits instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("actionUrl", ActionUrl);          
            props.Add("digitTimeoutMs", DigitTimeoutMs);          
            props.Add("finishOnKey", FinishOnKey);          
            props.Add("flushBuffer", FlushBuffer);          
            props.Add("initialTimeoutMs", InitialTimeoutMs);          
            props.Add("maxDigits", MaxDigits);          
            props.Add("minDigits", MinDigits);          
            List<object> nested = new List<object>();
            foreach (var item in Prompts)
            {
                nested.Add(item);
            }
            props.Add("prompts", nested); 
            props.Add("privacyMode", PrivacyMode);          
            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("GetDigits",props);
            return command;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetDigits);
        }

        /// <summary>
        /// Returns true if GetDigits instances are equal
        /// </summary>
        /// <param name="input">Instance of GetDigits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetDigits input)
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
                    this.DigitTimeoutMs == input.DigitTimeoutMs ||
                    this.DigitTimeoutMs.Equals(input.DigitTimeoutMs)
                ) && base.Equals(input) && 
                (
                    this.FinishOnKey == input.FinishOnKey ||
                    (this.FinishOnKey != null &&
                    this.FinishOnKey.Equals(input.FinishOnKey))
                ) && base.Equals(input) && 
                (
                    this.FlushBuffer == input.FlushBuffer ||
                    this.FlushBuffer.Equals(input.FlushBuffer)
                ) && base.Equals(input) && 
                (
                    this.InitialTimeoutMs == input.InitialTimeoutMs ||
                    this.InitialTimeoutMs.Equals(input.InitialTimeoutMs)
                ) && base.Equals(input) && 
                (
                    this.MaxDigits == input.MaxDigits ||
                    this.MaxDigits.Equals(input.MaxDigits)
                ) && base.Equals(input) && 
                (
                    this.MinDigits == input.MinDigits ||
                    this.MinDigits.Equals(input.MinDigits)
                ) && base.Equals(input) && 
                (
                    this.Prompts == input.Prompts ||
                    this.Prompts != null &&
                    input.Prompts != null &&
                    this.Prompts.SequenceEqual(input.Prompts)
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
                hashCode = (hashCode * 59) + this.DigitTimeoutMs.GetHashCode();
                if (this.FinishOnKey != null)
                {
                    hashCode = (hashCode * 59) + this.FinishOnKey.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FlushBuffer.GetHashCode();
                hashCode = (hashCode * 59) + this.InitialTimeoutMs.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxDigits.GetHashCode();
                hashCode = (hashCode * 59) + this.MinDigits.GetHashCode();
                if (this.Prompts != null)
                {
                    hashCode = (hashCode * 59) + this.Prompts.GetHashCode();
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
