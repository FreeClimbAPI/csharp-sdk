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
    /// The &#x60;Hangup&#x60; command terminates a Call. If &#x60;Hangup&#x60; is used as the first action in a PerCL response, it does not prevent FreeClimb from answering the Call and billing your account. See the &#x60;Reject&#x60; command to hang up at no charge.
    /// </summary>
    [DataContract(Name = "Hangup")]
    [JsonConverter(typeof(JsonSubtypes), "Command")]
    [JsonSubtypes.KnownSubType(typeof(AddToConference), "AddToConference")]
    [JsonSubtypes.KnownSubType(typeof(CreateConference), "CreateConference")]
    [JsonSubtypes.KnownSubType(typeof(Dequeue), "Dequeue")]
    [JsonSubtypes.KnownSubType(typeof(Enqueue), "Enqueue")]
    [JsonSubtypes.KnownSubType(typeof(GetDigits), "GetDigits")]
    [JsonSubtypes.KnownSubType(typeof(GetSpeech), "GetSpeech")]
    [JsonSubtypes.KnownSubType(typeof(Hangup), "Hangup")]
    [JsonSubtypes.KnownSubType(typeof(OutDial), "OutDial")]
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
    public partial class Hangup : PerclCommand, IEquatable<Hangup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hangup" /> class.
        /// </summary>
        /// <param name="reason">The user defined reason for the hangup. In general, applications should use a set of enumerated values that are predefined to cover all exit points of the Call flows for the given application..</param>
        /// <param name="command">Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) (default to &quot;Hangup&quot;).</param>
        public Hangup(string reason = default(string), string command = "Hangup") : base(command)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// The user defined reason for the hangup. In general, applications should use a set of enumerated values that are predefined to cover all exit points of the Call flows for the given application.
        /// </summary>
        /// <value>The user defined reason for the hangup. In general, applications should use a set of enumerated values that are predefined to cover all exit points of the Call flows for the given application.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Hangup {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
        /// Retrieve the KVP Dictionary for the Hangup instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("reason", Reason);          
            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Hangup",props);
            return command;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Hangup);
        }

        /// <summary>
        /// Returns true if Hangup instances are equal
        /// </summary>
        /// <param name="input">Instance of Hangup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Hangup input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                }
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
