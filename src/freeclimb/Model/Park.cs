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
    /// The &#x60;Park&#x60; command allows a caller to be put on hold.  You can provide hold music,messages,etc until ready to resume the call. Park is a terminal command.  Actions performed on the Call while on hold are provided in a PerCL script in response to the waitUrl property. Actions performed on the Call after it has been unparked (resumed) will be provided in a PerCL script in response to the actionUrl provided. A Call can be resumed in two ways - - REST API invocation or the Unpark percl command. No actions can be nested within Park and Park cannot be nested in any other actions. 
    /// </summary>
    [DataContract(Name = "Park")]
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
    public partial class Park : PerclCommand, IEquatable<Park>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Park" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Park() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Park" /> class.
        /// </summary>
        /// <param name="waitUrl">Specifies a URL pointing to a PerCL script containing actions to be executed while the caller is Parked. Once the script returned by the waitUrl runs out of commands to execute, FreeClimb will re-request the waitUrl and start over, essentially looping the script requests indefinitely. (required).</param>
        /// <param name="actionUrl">A request is made to this URL when the Call is resumed, which can occur if the Call is resumed via the Unpark command, the REST API (POST to Call resource), or the caller hangs up. The PerCL script returned in response to the actionUrl will be executed on the resumed call. (required).</param>
        /// <param name="notificationUrl">URL to be invoked when the Call is parked. The request to the URL contains the standard request parameters..</param>
        /// <param name="command">Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) (default to &quot;Park&quot;).</param>
        public Park(string waitUrl = default(string), string actionUrl = default(string), string notificationUrl = default(string), string command = "Park") : base(command)
        {
            // to ensure "waitUrl" is required (not null)
            if (waitUrl == null) {
                throw new ArgumentNullException("waitUrl is a required property for Park and cannot be null");
            }
            this.WaitUrl = waitUrl;
            // to ensure "actionUrl" is required (not null)
            if (actionUrl == null) {
                throw new ArgumentNullException("actionUrl is a required property for Park and cannot be null");
            }
            this.ActionUrl = actionUrl;
            this.NotificationUrl = notificationUrl;
        }

        /// <summary>
        /// Specifies a URL pointing to a PerCL script containing actions to be executed while the caller is Parked. Once the script returned by the waitUrl runs out of commands to execute, FreeClimb will re-request the waitUrl and start over, essentially looping the script requests indefinitely.
        /// </summary>
        /// <value>Specifies a URL pointing to a PerCL script containing actions to be executed while the caller is Parked. Once the script returned by the waitUrl runs out of commands to execute, FreeClimb will re-request the waitUrl and start over, essentially looping the script requests indefinitely.</value>
        [DataMember(Name = "waitUrl", IsRequired = true, EmitDefaultValue = false)]
        public string WaitUrl { get; set; }

        /// <summary>
        /// A request is made to this URL when the Call is resumed, which can occur if the Call is resumed via the Unpark command, the REST API (POST to Call resource), or the caller hangs up. The PerCL script returned in response to the actionUrl will be executed on the resumed call.
        /// </summary>
        /// <value>A request is made to this URL when the Call is resumed, which can occur if the Call is resumed via the Unpark command, the REST API (POST to Call resource), or the caller hangs up. The PerCL script returned in response to the actionUrl will be executed on the resumed call.</value>
        [DataMember(Name = "actionUrl", IsRequired = true, EmitDefaultValue = false)]
        public string ActionUrl { get; set; }

        /// <summary>
        /// URL to be invoked when the Call is parked. The request to the URL contains the standard request parameters.
        /// </summary>
        /// <value>URL to be invoked when the Call is parked. The request to the URL contains the standard request parameters.</value>
        [DataMember(Name = "notificationUrl", EmitDefaultValue = false)]
        public string NotificationUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Park {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  WaitUrl: ").Append(WaitUrl).Append("\n");
            sb.Append("  ActionUrl: ").Append(ActionUrl).Append("\n");
            sb.Append("  NotificationUrl: ").Append(NotificationUrl).Append("\n");
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
        /// Retrieve the KVP Dictionary for the Park instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("waitUrl", WaitUrl);          
            props.Add("actionUrl", ActionUrl);          
            props.Add("notificationUrl", NotificationUrl);          
            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Park",props);
            return command;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Park);
        }

        /// <summary>
        /// Returns true if Park instances are equal
        /// </summary>
        /// <param name="input">Instance of Park to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Park input)
        {
            if (input == null)
            {
                return false;
            }
            return base.Equals(input) && 
                (
                    this.WaitUrl == input.WaitUrl ||
                    (this.WaitUrl != null &&
                    this.WaitUrl.Equals(input.WaitUrl))
                ) && base.Equals(input) && 
                (
                    this.ActionUrl == input.ActionUrl ||
                    (this.ActionUrl != null &&
                    this.ActionUrl.Equals(input.ActionUrl))
                ) && base.Equals(input) && 
                (
                    this.NotificationUrl == input.NotificationUrl ||
                    (this.NotificationUrl != null &&
                    this.NotificationUrl.Equals(input.NotificationUrl))
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
                if (this.WaitUrl != null)
                {
                    hashCode = (hashCode * 59) + this.WaitUrl.GetHashCode();
                }
                if (this.ActionUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ActionUrl.GetHashCode();
                }
                if (this.NotificationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NotificationUrl.GetHashCode();
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
