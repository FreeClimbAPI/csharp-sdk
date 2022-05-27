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
    /// RecordingListAllOf
    /// </summary>
    [DataContract(Name = "RecordingList_allOf")]
    public partial class RecordingListAllOf : IEquatable<RecordingListAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingListAllOf" /> class.
        /// </summary>
        /// <param name="recordings">recordings.</param>
        public RecordingListAllOf(List<RecordingResult> recordings = default(List<RecordingResult>))
        {
            this.Recordings = recordings;
        }

        /// <summary>
        /// Gets or Sets Recordings
        /// </summary>
        [DataMember(Name = "recordings", EmitDefaultValue = true)]
        public List<RecordingResult> Recordings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecordingListAllOf {\n");
            sb.Append("  Recordings: ").Append(Recordings).Append("\n");
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
        /// Retrieve the KVP Dictionary for the RecordingListAllOf instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            List<object> nested = new List<object>();
            foreach (var item in Recordings)
            {
                nested.Add(item.ToKvp());
            }
            props.Add("recordings", nested); 
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecordingListAllOf);
        }

        /// <summary>
        /// Returns true if RecordingListAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of RecordingListAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecordingListAllOf input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Recordings == input.Recordings ||
                    this.Recordings != null &&
                    input.Recordings != null &&
                    this.Recordings.SequenceEqual(input.Recordings)
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
                if (this.Recordings != null)
                {
                    hashCode = (hashCode * 59) + this.Recordings.GetHashCode();
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
