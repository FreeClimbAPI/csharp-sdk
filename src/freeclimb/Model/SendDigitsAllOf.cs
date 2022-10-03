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
    /// SendDigitsAllOf
    /// </summary>
    [DataContract(Name = "SendDigits_allOf")]
    public partial class SendDigitsAllOf : IEquatable<SendDigitsAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SendDigitsAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SendDigitsAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendDigitsAllOf" /> class.
        /// </summary>
        /// <param name="digits">String containing the digits to be played. The string cannot be empty and can include any digit, plus &#x60;#&#x60;, or &#x60;*&#x60;, and allows embedding specification for delay or pause between the output of individual digits. (required).</param>
        /// <param name="pauseMs">Pause between digits in milliseconds. Valid values are 100-1000 milliseconds and will be adjusted by FreeClimb to satisfy the constraint..</param>
        /// <param name="privacyMode">Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance..</param>
        public SendDigitsAllOf(string digits = default(string), int pauseMs = default(int), bool privacyMode = default(bool))
        {
            // to ensure "digits" is required (not null)
            if (digits == null) {
                throw new ArgumentNullException("digits is a required property for SendDigitsAllOf and cannot be null");
            }
            this.Digits = digits;
            this.PauseMs = pauseMs;
            this.PrivacyMode = privacyMode;
        }

        /// <summary>
        /// String containing the digits to be played. The string cannot be empty and can include any digit, plus &#x60;#&#x60;, or &#x60;*&#x60;, and allows embedding specification for delay or pause between the output of individual digits.
        /// </summary>
        /// <value>String containing the digits to be played. The string cannot be empty and can include any digit, plus &#x60;#&#x60;, or &#x60;*&#x60;, and allows embedding specification for delay or pause between the output of individual digits.</value>
        [DataMember(Name = "digits", IsRequired = true, EmitDefaultValue = false)]
        public string Digits { get; set; }

        /// <summary>
        /// Pause between digits in milliseconds. Valid values are 100-1000 milliseconds and will be adjusted by FreeClimb to satisfy the constraint.
        /// </summary>
        /// <value>Pause between digits in milliseconds. Valid values are 100-1000 milliseconds and will be adjusted by FreeClimb to satisfy the constraint.</value>
        [DataMember(Name = "pauseMs", EmitDefaultValue = false)]
        public int PauseMs { get; set; }

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
            sb.Append("class SendDigitsAllOf {\n");
            sb.Append("  Digits: ").Append(Digits).Append("\n");
            sb.Append("  PauseMs: ").Append(PauseMs).Append("\n");
            sb.Append("  PrivacyMode: ").Append(PrivacyMode).Append("\n");
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
        /// Retrieve the KVP Dictionary for the SendDigitsAllOf instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("digits", Digits);          
            props.Add("pauseMs", PauseMs);          
            props.Add("privacyMode", PrivacyMode);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SendDigitsAllOf);
        }

        /// <summary>
        /// Returns true if SendDigitsAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of SendDigitsAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendDigitsAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Digits == input.Digits ||
                    (this.Digits != null &&
                    this.Digits.Equals(input.Digits))
                ) && 
                (
                    this.PauseMs == input.PauseMs ||
                    this.PauseMs.Equals(input.PauseMs)
                ) && 
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
                int hashCode = 41;
                if (this.Digits != null)
                {
                    hashCode = (hashCode * 59) + this.Digits.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PauseMs.GetHashCode();
                hashCode = (hashCode * 59) + this.PrivacyMode.GetHashCode();
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