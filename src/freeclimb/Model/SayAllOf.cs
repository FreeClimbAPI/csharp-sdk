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
    /// SayAllOf
    /// </summary>
    [DataContract(Name = "Say_allOf")]
    public partial class SayAllOf : IEquatable<SayAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SayAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SayAllOf() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SayAllOf" /> class.
        /// </summary>
        /// <param name="text">The message to be played to the caller using TTS. The size of the string is limited to 4 KB (or 4,096 bytes). An empty string will cause the command to be skipped. (required).</param>
        /// <param name="language">Language and (by implication) the locale to use. This implies the accent and pronunciations to be usde for the TTS. The complete list of valid values for the language attribute is shown below..</param>
        /// <param name="loop">Number of times the text is said. Specifying &#39;0&#39; causes the &#x60;Say&#x60; action to loop until the Call is hung up. (default to 1).</param>
        /// <param name="privacyMode">Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance..</param>
        public SayAllOf(string text = default(string), string language = default(string), int loop = 1, bool privacyMode = default(bool))
        {
            // to ensure "text" is required (not null)
            if (text == null) {
                throw new ArgumentNullException("text is a required property for SayAllOf and cannot be null");
            }
            this.Text = text;
            this.Language = language;
            this.Loop = loop;
            this.PrivacyMode = privacyMode;
        }

        /// <summary>
        /// The message to be played to the caller using TTS. The size of the string is limited to 4 KB (or 4,096 bytes). An empty string will cause the command to be skipped.
        /// </summary>
        /// <value>The message to be played to the caller using TTS. The size of the string is limited to 4 KB (or 4,096 bytes). An empty string will cause the command to be skipped.</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = false)]
        public string Text { get; set; }

        /// <summary>
        /// Language and (by implication) the locale to use. This implies the accent and pronunciations to be usde for the TTS. The complete list of valid values for the language attribute is shown below.
        /// </summary>
        /// <value>Language and (by implication) the locale to use. This implies the accent and pronunciations to be usde for the TTS. The complete list of valid values for the language attribute is shown below.</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string Language { get; set; }

        /// <summary>
        /// Number of times the text is said. Specifying &#39;0&#39; causes the &#x60;Say&#x60; action to loop until the Call is hung up.
        /// </summary>
        /// <value>Number of times the text is said. Specifying &#39;0&#39; causes the &#x60;Say&#x60; action to loop until the Call is hung up.</value>
        [DataMember(Name = "loop", EmitDefaultValue = false)]
        public int Loop { get; set; }

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
            sb.Append("class SayAllOf {\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Loop: ").Append(Loop).Append("\n");
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
        /// Retrieve the KVP Dictionary for the SayAllOf instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("text", Text);          
            props.Add("language", Language);          
            props.Add("loop", Loop);          
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
            return this.Equals(input as SayAllOf);
        }

        /// <summary>
        /// Returns true if SayAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of SayAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SayAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Loop == input.Loop ||
                    this.Loop.Equals(input.Loop)
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
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.Language != null)
                {
                    hashCode = (hashCode * 59) + this.Language.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Loop.GetHashCode();
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
