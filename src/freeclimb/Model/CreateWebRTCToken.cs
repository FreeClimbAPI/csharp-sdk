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
    /// CreateWebRTCToken
    /// </summary>
    [DataContract(Name = "CreateWebRTCToken")]
    public partial class CreateWebRTCToken : IEquatable<CreateWebRTCToken>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebRTCToken" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWebRTCToken() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebRTCToken" /> class.
        /// </summary>
        /// <param name="to">E.164 formatted phone number to which calls using this token will be made. (required).</param>
        /// <param name="from">E.164 formatted phone number owned by the reqeusting account from which calls using this token will be made. (required).</param>
        /// <param name="uses">number of times this token may be used for a WebRTC call (required).</param>
        public CreateWebRTCToken(string to = default(string), string from = default(string), int uses = default(int))
        {
            // to ensure "to" is required (not null)
            if (to == null) {
                throw new ArgumentNullException("to is a required property for CreateWebRTCToken and cannot be null");
            }
            this.To = to;
            // to ensure "from" is required (not null)
            if (from == null) {
                throw new ArgumentNullException("from is a required property for CreateWebRTCToken and cannot be null");
            }
            this.From = from;
            this.Uses = uses;
        }

        /// <summary>
        /// E.164 formatted phone number to which calls using this token will be made.
        /// </summary>
        /// <value>E.164 formatted phone number to which calls using this token will be made.</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// E.164 formatted phone number owned by the reqeusting account from which calls using this token will be made.
        /// </summary>
        /// <value>E.164 formatted phone number owned by the reqeusting account from which calls using this token will be made.</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// number of times this token may be used for a WebRTC call
        /// </summary>
        /// <value>number of times this token may be used for a WebRTC call</value>
        [DataMember(Name = "uses", IsRequired = true, EmitDefaultValue = false)]
        public int Uses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateWebRTCToken {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Uses: ").Append(Uses).Append("\n");
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
        /// Retrieve the KVP Dictionary for the CreateWebRTCToken instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("to", To);          
            props.Add("from", From);          
            props.Add("uses", Uses);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateWebRTCToken);
        }

        /// <summary>
        /// Returns true if CreateWebRTCToken instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWebRTCToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebRTCToken input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Uses == input.Uses ||
                    this.Uses.Equals(input.Uses)
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
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Uses.GetHashCode();
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
            // Uses (int) minimum
            if (this.Uses < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Uses, must be a value greater than or equal to 1.", new [] { "Uses" });
            }

            yield break;
        }
    }

}
