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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = freeclimb.Client.OpenAPIDateConverter;
using freeclimb.Enums;

namespace freeclimb.Model
{
    /// <summary>
    /// LogResult
    /// </summary>
    [DataContract(Name = "LogResult")]
    public partial class LogResult : IEquatable<LogResult>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name = "level", EmitDefaultValue = true)]
        public LogLevel? Level { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="LogResult" /> class.
        /// </summary>
        /// <param name="timestamp">Time that the log was generated. The time is represented as microseconds since the Unix Epoch..</param>
        /// <param name="level">level.</param>
        /// <param name="requestId">ID of the request associated with the log. The requestId is propagated across all logs generated by FreeClimb when processing a request..</param>
        /// <param name="accountId">ID of the account that this log was generated under..</param>
        /// <param name="callId">ID of the Call associated with the log. Can be set to null if the log was generated without regard to a specific Call..</param>
        /// <param name="message">A simple string describing the event being logged..</param>
        /// <param name="metadata">JSON document containing metadata about the event. Some log messages may include request and response header content in this field..</param>
        public LogResult(int? timestamp = default(int?), LogLevel? level = default(LogLevel?), string requestId = default(string), string accountId = default(string), string callId = default(string), string message = default(string), Object metadata = default(Object))
        {
            this.Timestamp = timestamp;
            this.Level = level;
            this.RequestId = requestId;
            this.AccountId = accountId;
            this.CallId = callId;
            this.Message = message;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Time that the log was generated. The time is represented as microseconds since the Unix Epoch.
        /// </summary>
        /// <value>Time that the log was generated. The time is represented as microseconds since the Unix Epoch.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = true)]
        public int? Timestamp { get; set; }

        /// <summary>
        /// ID of the request associated with the log. The requestId is propagated across all logs generated by FreeClimb when processing a request.
        /// </summary>
        /// <value>ID of the request associated with the log. The requestId is propagated across all logs generated by FreeClimb when processing a request.</value>
        [DataMember(Name = "requestId", EmitDefaultValue = true)]
        public string RequestId { get; set; }

        /// <summary>
        /// ID of the account that this log was generated under.
        /// </summary>
        /// <value>ID of the account that this log was generated under.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// ID of the Call associated with the log. Can be set to null if the log was generated without regard to a specific Call.
        /// </summary>
        /// <value>ID of the Call associated with the log. Can be set to null if the log was generated without regard to a specific Call.</value>
        [DataMember(Name = "callId", EmitDefaultValue = true)]
        public string CallId { get; set; }

        /// <summary>
        /// A simple string describing the event being logged.
        /// </summary>
        /// <value>A simple string describing the event being logged.</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// JSON document containing metadata about the event. Some log messages may include request and response header content in this field.
        /// </summary>
        /// <value>JSON document containing metadata about the event. Some log messages may include request and response header content in this field.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = true)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogResult {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  CallId: ").Append(CallId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the LogResult instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("timestamp", Timestamp);          
            props.Add("level", Level);          
            props.Add("requestId", RequestId);          
            props.Add("accountId", AccountId);          
            props.Add("callId", CallId);          
            props.Add("message", Message);          
            props.Add("metadata", Metadata);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as LogResult);
        }

        /// <summary>
        /// Returns true if LogResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LogResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Level == input.Level ||
                    this.Level.Equals(input.Level)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.CallId == input.CallId ||
                    (this.CallId != null &&
                    this.CallId.Equals(input.CallId))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
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
                int hashCode = 41;
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Level.GetHashCode();
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.CallId != null)
                {
                    hashCode = (hashCode * 59) + this.CallId.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
