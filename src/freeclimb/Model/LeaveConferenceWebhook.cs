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
    /// A Call has been unbridged from a Conference and its leaveConferenceUrl is being invoked. A PerCL response is expected — unless the URL is invoked due to the participant hanging up.
    /// </summary>
    [DataContract(Name = "LeaveConferenceWebhook")]
    [JsonConverter(typeof(JsonSubtypes), "RequestType")]
    public partial class LeaveConferenceWebhook : Webhook, IValidatableObject
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
        /// Initializes a new instance of the <see cref="LeaveConferenceWebhook" /> class.
        /// </summary>
        /// <param name="requestType">Context or reason why this request is being made. Will be leaveConference - Call has been unbridged from a Conference and its leaveConferenceUrl is being invoked. (default to &quot;LeaveConferenceWebhook&quot;).</param>
        /// <param name="callId">Unique ID for this Call, generated by FreeClimb. This is the call leg which has left the Conference.</param>
        /// <param name="accountId">Account ID associated with your account..</param>
        /// <param name="from">Phone number of the party that initiated the Call (in E.164 format)..</param>
        /// <param name="to">Phone number provisioned to you and to which this Call is directed (in E.164 format)..</param>
        /// <param name="callStatus">callStatus.</param>
        /// <param name="direction">direction.</param>
        /// <param name="conferenceId">This is only populated if request pertains to a Conference. Otherwise, it is set to null..</param>
        /// <param name="queueId">This is only populated if the request pertains to a Queue. Otherwise, it is set to null..</param>
        public LeaveConferenceWebhook(
            string requestType = @"LeaveConferenceWebhook",
            string callId = default(string),
            string accountId = default(string),
            string from = default(string),
            string to = default(string),
            CallStatus? callStatus = default(CallStatus?),
            CallDirection? direction = default(CallDirection?),
            string conferenceId = default(string),
            string queueId = default(string)
        )
            : base()
        {
            base.RequestType = requestType;

            this.CallId = callId;

            this.AccountId = accountId;

            this.From = from;

            this.To = to;

            this.CallStatus = callStatus;

            this.Direction = direction;

            this.ConferenceId = conferenceId;

            this.QueueId = queueId;
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
        /// Deserializes json payload into instance LeaveConferenceWebhook
        /// </summary>
        /// <param name="jsonPayload"></param>
        /// <returns>instanceof RemoveFromQueueNotificationWebhook</returns>
        public static LeaveConferenceWebhook Deserialize(string jsonPayload)
        {
            return (LeaveConferenceWebhook)
                JsonConvert.DeserializeObject(
                    jsonPayload,
                    typeof(LeaveConferenceWebhook),
                    _serializerSettings
                );
        }

        /// <summary>
        /// Unique ID for this Call, generated by FreeClimb. This is the call leg which has left the Conference
        /// </summary>
        /// <value>Unique ID for this Call, generated by FreeClimb. This is the call leg which has left the Conference</value>
        [DataMember(Name = "callId", EmitDefaultValue = false)]
        public string CallId { get; set; }

        /// <summary>
        /// Account ID associated with your account.
        /// </summary>
        /// <value>Account ID associated with your account.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// Phone number of the party that initiated the Call (in E.164 format).
        /// </summary>
        /// <value>Phone number of the party that initiated the Call (in E.164 format).</value>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Phone number provisioned to you and to which this Call is directed (in E.164 format).
        /// </summary>
        /// <value>Phone number provisioned to you and to which this Call is directed (in E.164 format).</value>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// This is only populated if request pertains to a Conference. Otherwise, it is set to null.
        /// </summary>
        /// <value>This is only populated if request pertains to a Conference. Otherwise, it is set to null.</value>
        [DataMember(Name = "conferenceId", EmitDefaultValue = true)]
        public string ConferenceId { get; set; }

        /// <summary>
        /// This is only populated if the request pertains to a Queue. Otherwise, it is set to null.
        /// </summary>
        /// <value>This is only populated if the request pertains to a Queue. Otherwise, it is set to null.</value>
        [DataMember(Name = "queueId", EmitDefaultValue = true)]
        public string QueueId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LeaveConferenceWebhook {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  CallStatus: ").Append(CallStatus).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  ConferenceId: ").Append(ConferenceId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
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
        /// Retrieve the KVP Dictionary for the LeaveConferenceWebhook instance.
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("requestType", RequestType);
            props.Add("callId", CallId);
            props.Add("accountId", AccountId);
            props.Add("from", From);
            props.Add("to", To);
            props.Add("callStatus", CallStatus);
            props.Add("direction", Direction);
            props.Add("conferenceId", ConferenceId);
            props.Add("queueId", QueueId);
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