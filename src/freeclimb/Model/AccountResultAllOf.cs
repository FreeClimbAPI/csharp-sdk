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

namespace freeclimb.Model
{
    /// <summary>
    /// AccountResultAllOf
    /// </summary>
    [DataContract(Name = "AccountResult_allOf")]
    public partial class AccountResultAllOf : IEquatable<AccountResultAllOf>, IValidatableObject
    {
        /// <summary>
        /// The type of this account. It is one of: trial or full.
        /// </summary>
        /// <value>The type of this account. It is one of: trial or full.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum TRIAL for value: trial
            /// </summary>
            [EnumMember(Value = "trial")]
            TRIAL = 1,

            /// <summary>
            /// Enum FULL for value: full
            /// </summary>
            [EnumMember(Value = "full")]
            FULL = 2

        }


        /// <summary>
        /// The type of this account. It is one of: trial or full.
        /// </summary>
        /// <value>The type of this account. It is one of: trial or full.</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// The status of this account. It is one of: active, suspended, or closed.
        /// </summary>
        /// <value>The status of this account. It is one of: active, suspended, or closed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            ACTIVE = 1,

            /// <summary>
            /// Enum SUSPENDED for value: suspended
            /// </summary>
            [EnumMember(Value = "suspended")]
            SUSPENDED = 2,

            /// <summary>
            /// Enum CLOSED for value: closed
            /// </summary>
            [EnumMember(Value = "closed")]
            CLOSED = 3

        }


        /// <summary>
        /// The status of this account. It is one of: active, suspended, or closed.
        /// </summary>
        /// <value>The status of this account. It is one of: active, suspended, or closed.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountResultAllOf" /> class.
        /// </summary>
        /// <param name="accountId">String that uniquely identifies this account resource..</param>
        /// <param name="apiKey">The API key assigned to this account. This key must be kept a secret by the customer..</param>
        /// <param name="alias">A description for this account..</param>
        /// <param name="label">A string that identifies a category or group to which the account belongs..</param>
        /// <param name="type">The type of this account. It is one of: trial or full..</param>
        /// <param name="status">The status of this account. It is one of: active, suspended, or closed..</param>
        /// <param name="subresourceUris">The list of subresources for this account..</param>
        public AccountResultAllOf(string accountId = default(string), string apiKey = default(string), string alias = default(string), string label = default(string), TypeEnum? type = default(TypeEnum?), StatusEnum? status = default(StatusEnum?), Object subresourceUris = default(Object))
        {
            this.AccountId = accountId;
            this.ApiKey = apiKey;
            this.Alias = alias;
            this.Label = label;
            this.Type = type;
            this.Status = status;
            this.SubresourceUris = subresourceUris;
        }

        /// <summary>
        /// String that uniquely identifies this account resource.
        /// </summary>
        /// <value>String that uniquely identifies this account resource.</value>
        [DataMember(Name = "accountId", EmitDefaultValue = true)]
        public string AccountId { get; set; }

        /// <summary>
        /// The API key assigned to this account. This key must be kept a secret by the customer.
        /// </summary>
        /// <value>The API key assigned to this account. This key must be kept a secret by the customer.</value>
        [DataMember(Name = "apiKey", EmitDefaultValue = true)]
        public string ApiKey { get; set; }

        /// <summary>
        /// A description for this account.
        /// </summary>
        /// <value>A description for this account.</value>
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// A string that identifies a category or group to which the account belongs.
        /// </summary>
        /// <value>A string that identifies a category or group to which the account belongs.</value>
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// The list of subresources for this account.
        /// </summary>
        /// <value>The list of subresources for this account.</value>
        [DataMember(Name = "subresourceUris", EmitDefaultValue = true)]
        public Object SubresourceUris { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountResultAllOf {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubresourceUris: ").Append(SubresourceUris).Append("\n");
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
        /// Retrieve the KVP Dictionary for the AccountResultAllOf instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("accountId", AccountId);          
            props.Add("apiKey", ApiKey);          
            props.Add("alias", Alias);          
            props.Add("label", Label);          
            props.Add("type", Type);          
            props.Add("status", Status);          
            props.Add("subresourceUris", SubresourceUris);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccountResultAllOf);
        }

        /// <summary>
        /// Returns true if AccountResultAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountResultAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountResultAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.SubresourceUris == input.SubresourceUris ||
                    (this.SubresourceUris != null &&
                    this.SubresourceUris.Equals(input.SubresourceUris))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.ApiKey != null)
                {
                    hashCode = (hashCode * 59) + this.ApiKey.GetHashCode();
                }
                if (this.Alias != null)
                {
                    hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                }
                if (this.Label != null)
                {
                    hashCode = (hashCode * 59) + this.Label.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.SubresourceUris != null)
                {
                    hashCode = (hashCode * 59) + this.SubresourceUris.GetHashCode();
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
