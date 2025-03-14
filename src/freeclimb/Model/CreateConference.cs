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
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using freeclimb.Enums;
using JsonSubTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = freeclimb.Client.OpenAPIDateConverter;

namespace freeclimb.Model
{
    /// <summary>
    /// The &#x60;CreateConference&#x60; command does exactly what its name implies — it creates an unpopulated Conference (one without any Participants). Once created, a Conference remains in FreeClimb until explicitly terminated by a customer. Once a Conference has been terminated, it can no longer be used.
    /// </summary>
    [DataContract(Name = "CreateConference")]
    [JsonConverter(typeof(JsonSubtypes), "Command")]
    public partial class CreateConference : PerclCommand, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets PlayBeep
        /// </summary>
        [DataMember(Name = "playBeep", EmitDefaultValue = true)]
        public PlayBeep? PlayBeep { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConference" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateConference() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConference" /> class.
        /// </summary>
        /// <param name="actionUrl"> This URL is invoked once the Conference is successfully created. Actions on the Conference, such as adding Participants, can be performed via the PerCL script returned in the response.  (required).</param>
        /// <param name="alias">Descriptive name for the Conference. .</param>
        /// <param name="playBeep">playBeep.</param>
        /// <param name="record">When set to &#x60;true&#x60;, the entire Conference is recorded. The &#x60;statusCallbackUrl&#x60; of the Conference will receive a &#x60;conferenceRecordingEnded&#x60; Webhook when the Conference transitions from the &#x60;inProgress&#x60; to empty state..</param>
        /// <param name="statusCallbackUrl">This URL is invoked when the status of the Conference changes or when a recording of the Conference has become available..</param>
        /// <param name="waitUrl">If specified, this URL provides the custom hold music for the Conference when it is in the populated state. This attribute is always fetched using HTTP GET and is fetched just once – when the Conference is created. The URL must be an audio file that is reachable and readable by FreeClimb..</param>
        /// <param name="command">Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) (default to &quot;CreateConference&quot;).</param>
        public CreateConference(
            string actionUrl = default(string),
            bool alias = default(bool),
            PlayBeep? playBeep = default(PlayBeep?),
            bool record = default(bool),
            string statusCallbackUrl = default(string),
            string waitUrl = default(string),
            string command = @"CreateConference"
        )
            : base(command)
        {
            // to ensure "actionUrl" is required (not null)
            if (actionUrl == null)
            {
                throw new ArgumentNullException(
                    "actionUrl is a required property for CreateConference and cannot be null"
                );
            }
            this.ActionUrl = actionUrl;

            this.Alias = alias;

            this.PlayBeep = playBeep;

            this.Record = record;

            this.StatusCallbackUrl = statusCallbackUrl;

            this.WaitUrl = waitUrl;
        }

        /// <summary>
        ///  This URL is invoked once the Conference is successfully created. Actions on the Conference, such as adding Participants, can be performed via the PerCL script returned in the response.
        /// </summary>
        /// <value> This URL is invoked once the Conference is successfully created. Actions on the Conference, such as adding Participants, can be performed via the PerCL script returned in the response. </value>
        [DataMember(Name = "actionUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ActionUrl { get; set; }

        /// <summary>
        /// Descriptive name for the Conference.
        /// </summary>
        /// <value>Descriptive name for the Conference. </value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public bool Alias { get; set; }

        /// <summary>
        /// When set to &#x60;true&#x60;, the entire Conference is recorded. The &#x60;statusCallbackUrl&#x60; of the Conference will receive a &#x60;conferenceRecordingEnded&#x60; Webhook when the Conference transitions from the &#x60;inProgress&#x60; to empty state.
        /// </summary>
        /// <value>When set to &#x60;true&#x60;, the entire Conference is recorded. The &#x60;statusCallbackUrl&#x60; of the Conference will receive a &#x60;conferenceRecordingEnded&#x60; Webhook when the Conference transitions from the &#x60;inProgress&#x60; to empty state.</value>
        [DataMember(Name = "record", EmitDefaultValue = true)]
        public bool Record { get; set; }

        /// <summary>
        /// This URL is invoked when the status of the Conference changes or when a recording of the Conference has become available.
        /// </summary>
        /// <value>This URL is invoked when the status of the Conference changes or when a recording of the Conference has become available.</value>
        [DataMember(Name = "statusCallbackUrl", EmitDefaultValue = false)]
        public string StatusCallbackUrl { get; set; }

        /// <summary>
        /// If specified, this URL provides the custom hold music for the Conference when it is in the populated state. This attribute is always fetched using HTTP GET and is fetched just once – when the Conference is created. The URL must be an audio file that is reachable and readable by FreeClimb.
        /// </summary>
        /// <value>If specified, this URL provides the custom hold music for the Conference when it is in the populated state. This attribute is always fetched using HTTP GET and is fetched just once – when the Conference is created. The URL must be an audio file that is reachable and readable by FreeClimb.</value>
        [DataMember(Name = "waitUrl", EmitDefaultValue = false)]
        public string WaitUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateConference {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ActionUrl: ").Append(ActionUrl).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  PlayBeep: ").Append(PlayBeep).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  StatusCallbackUrl: ").Append(StatusCallbackUrl).Append("\n");
            sb.Append("  WaitUrl: ").Append(WaitUrl).Append("\n");
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
        /// Retrieve the KVP Dictionary for the CreateConference instance.
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("actionUrl", ActionUrl);
            props.Add("alias", Alias);
            props.Add("playBeep", PlayBeep);
            props.Add("record", Record);
            props.Add("statusCallbackUrl", StatusCallbackUrl);
            props.Add("waitUrl", WaitUrl);
            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("CreateConference", props);
            return command;
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext
        )
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            foreach (var x in base.BaseValidate(validationContext))
            {
                yield return x;
            }
            yield break;
        }
    }
}
