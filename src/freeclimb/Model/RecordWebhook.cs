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
using Newtonsoft.Json.Serialization;
using OpenAPIDateConverter = freeclimb.Client.OpenAPIDateConverter;

namespace freeclimb.Model
{
    /// <summary>
    /// The RecordUtterance command has completed and its actionUrl is being invoked.
    /// </summary>
    [DataContract(Name = "RecordWebhook")]
    [JsonConverter(typeof(JsonSubtypes), "RequestType")]
    public partial class RecordWebhook : Webhook, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CallStatus
        /// </summary>
        [DataMember(Name = "callStatus", EmitDefaultValue = true)]
        public CallStatus? CallStatus { get; set; }

        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name = "direction", EmitDefaultValue = true)]
        public CallDirection? Direction { get; set; }

        /// <summary>
        /// Gets or Sets TermReason
        /// </summary>
        [DataMember(Name = "termReason", EmitDefaultValue = false)]
        public RecordUtteranceTermReason? TermReason { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordWebhook" /> class.
        /// </summary>
        /// <param name="requestType">The context or reason why this request is being made. Will be record - The RecordUtterance command has completed and its actionUrl is being invoked. (default to &quot;RecordWebhook&quot;).</param>
        /// <param name="accountId">Account ID associated with your account..</param>
        /// <param name="callId">Unique identifier for this Call, generated by FreeClimb.</param>
        /// <param name="from">Phone number of the party that initiated the Call (in E.164 format)..</param>
        /// <param name="to">Phone number provisioned to the customer and to which this Call is directed (in E.164 format)..</param>
        /// <param name="callStatus">callStatus.</param>
        /// <param name="direction">direction.</param>
        /// <param name="conferenceId">This is only populated if request pertains to a conference. Otherwise, it is set to null..</param>
        /// <param name="queueId">This is only populated if the request pertains to a queue. Otherwise, it is set to null..</param>
        /// <param name="recordingId">ID of the recording..</param>
        /// <param name="recordingUrl">URL of the recorded audio file. This URL can be used as is in a Play command to play the recording (no authentication needed). It can also be used to download a recording file via the REST API..</param>
        /// <param name="recordingSize">Size of the recording in bytes.</param>
        /// <param name="recordingFormat">File type of the recording (audio/wav).</param>
        /// <param name="recordingDurationSec">Duration of the recorded audio rounded up to the nearest second (in seconds).</param>
        /// <param name="termReason">termReason.</param>
        /// <param name="parentCallId">ID of Call that created this leg (child call)..</param>
        /// <param name="privacyMode">If true then it indicates the recording will only be available for download for two minutes prior to it being deleted. This is to minimize risk of anyone else getting access to the url and attempting to access it..</param>
        public RecordWebhook(
            string requestType = @"RecordWebhook",
            string accountId = default(string),
            string callId = default(string),
            string from = default(string),
            string to = default(string),
            CallStatus? callStatus = default(CallStatus?),
            CallDirection? direction = default(CallDirection?),
            string conferenceId = default(string),
            string queueId = default(string),
            string recordingId = default(string),
            string recordingUrl = default(string),
            string recordingSize = default(string),
            string recordingFormat = default(string),
            int recordingDurationSec = default(int),
            RecordUtteranceTermReason? termReason = default(RecordUtteranceTermReason?),
            string parentCallId = default(string),
            bool privacyMode = default(bool)
        )
            : base()
        {
            base.RequestType = requestType;

            this.AccountId = accountId;

            this.CallId = callId;

            this.From = from;

            this.To = to;

            this.CallStatus = callStatus;

            this.Direction = direction;

            this.ConferenceId = conferenceId;

            this.QueueId = queueId;

            this.RecordingId = recordingId;

            this.RecordingUrl = recordingUrl;

            this.RecordingSize = recordingSize;

            this.RecordingFormat = recordingFormat;

            this.RecordingDurationSec = recordingDurationSec;

            this.TermReason = termReason;

            this.ParentCallId = parentCallId;

            this.PrivacyMode = privacyMode;
        }

        private static readonly JsonSerializerSettings _serializerSettings =
            new JsonSerializerSettings
            {
                // OpenAPI generated types generally hide default constructors.
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy { OverrideSpecifiedNames = false },
                },
            };

        /// <summary>
        /// Deserializes json payload into instance RecordWebhook
        /// </summary>
        /// <param name="jsonPayload"></param>
        /// <returns>instanceof RemoveFromQueueNotificationWebhook</returns>
        public static RecordWebhook Deserialize(string jsonPayload)
        {
            return (RecordWebhook)
                JsonConvert.DeserializeObject(
                    jsonPayload,
                    typeof(RecordWebhook),
                    _serializerSettings
                );
        }

        /// <summary>
        /// Account ID associated with your account.
        /// </summary>
        /// <value>Account ID associated with your account.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Unique identifier for this Call, generated by FreeClimb
        /// </summary>
        /// <value>Unique identifier for this Call, generated by FreeClimb</value>
        [DataMember(Name = "callId", EmitDefaultValue = false)]
        public string CallId { get; set; }

        /// <summary>
        /// Phone number of the party that initiated the Call (in E.164 format).
        /// </summary>
        /// <value>Phone number of the party that initiated the Call (in E.164 format).</value>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Phone number provisioned to the customer and to which this Call is directed (in E.164 format).
        /// </summary>
        /// <value>Phone number provisioned to the customer and to which this Call is directed (in E.164 format).</value>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// This is only populated if request pertains to a conference. Otherwise, it is set to null.
        /// </summary>
        /// <value>This is only populated if request pertains to a conference. Otherwise, it is set to null.</value>
        [DataMember(Name = "conferenceId", EmitDefaultValue = true)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// This is only populated if the request pertains to a queue. Otherwise, it is set to null.
        /// </summary>
        /// <value>This is only populated if the request pertains to a queue. Otherwise, it is set to null.</value>
        [DataMember(Name = "queueId", EmitDefaultValue = true)]
        public string QueueId { get; set; }

        /// <summary>
        /// ID of the recording.
        /// </summary>
        /// <value>ID of the recording.</value>
        [DataMember(Name = "recordingId", EmitDefaultValue = false)]
        public string RecordingId { get; set; }

        /// <summary>
        /// URL of the recorded audio file. This URL can be used as is in a Play command to play the recording (no authentication needed). It can also be used to download a recording file via the REST API.
        /// </summary>
        /// <value>URL of the recorded audio file. This URL can be used as is in a Play command to play the recording (no authentication needed). It can also be used to download a recording file via the REST API.</value>
        [DataMember(Name = "recordingUrl", EmitDefaultValue = false)]
        public string RecordingUrl { get; set; }

        /// <summary>
        /// Size of the recording in bytes
        /// </summary>
        /// <value>Size of the recording in bytes</value>
        [DataMember(Name = "recordingSize", EmitDefaultValue = false)]
        public string RecordingSize { get; set; }

        /// <summary>
        /// File type of the recording (audio/wav)
        /// </summary>
        /// <value>File type of the recording (audio/wav)</value>
        [DataMember(Name = "recordingFormat", EmitDefaultValue = false)]
        public string RecordingFormat { get; set; }

        /// <summary>
        /// Duration of the recorded audio rounded up to the nearest second (in seconds)
        /// </summary>
        /// <value>Duration of the recorded audio rounded up to the nearest second (in seconds)</value>
        [DataMember(Name = "recordingDurationSec", EmitDefaultValue = false)]
        public int RecordingDurationSec { get; set; }

        /// <summary>
        /// ID of Call that created this leg (child call).
        /// </summary>
        /// <value>ID of Call that created this leg (child call).</value>
        [DataMember(Name = "parentCallId", EmitDefaultValue = false)]
        public string ParentCallId { get; set; }

        /// <summary>
        /// If true then it indicates the recording will only be available for download for two minutes prior to it being deleted. This is to minimize risk of anyone else getting access to the url and attempting to access it.
        /// </summary>
        /// <value>If true then it indicates the recording will only be available for download for two minutes prior to it being deleted. This is to minimize risk of anyone else getting access to the url and attempting to access it.</value>
        [DataMember(Name = "privacyMode", EmitDefaultValue = true)]
        public bool PrivacyMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecordWebhook {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  CallStatus: ").Append(CallStatus).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
            sb.Append("  RecordingUrl: ").Append(RecordingUrl).Append("\n");
            sb.Append("  RecordingSize: ").Append(RecordingSize).Append("\n");
            sb.Append("  RecordingFormat: ").Append(RecordingFormat).Append("\n");
            sb.Append("  RecordingDurationSec: ").Append(RecordingDurationSec).Append("\n");
            sb.Append("  TermReason: ").Append(TermReason).Append("\n");
            sb.Append("  ParentCallId: ").Append(ParentCallId).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(
                this,
                Newtonsoft.Json.Formatting.Indented
            );
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the RecordWebhook instance.
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("requestType", RequestType);
            props.Add("accountId", AccountId);
            props.Add("callId", CallId);
            props.Add("from", From);
            props.Add("to", To);
            props.Add("callStatus", CallStatus);
            props.Add("direction", Direction);
            props.Add("conferenceId", ConferenceId);
            props.Add("queueId", QueueId);
            props.Add("recordingId", RecordingId);
            props.Add("recordingUrl", RecordingUrl);
            props.Add("recordingSize", RecordingSize);
            props.Add("recordingFormat", RecordingFormat);
            props.Add("recordingDurationSec", RecordingDurationSec);
            props.Add("termReason", TermReason);
            props.Add("parentCallId", ParentCallId);
            props.Add("privacyMode", PrivacyMode);
            return props;
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