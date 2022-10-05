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
    /// CreateConferenceRequest
    /// </summary>
    [DataContract(Name = "CreateConferenceRequest")]
    public partial class CreateConferenceRequest : IEquatable<CreateConferenceRequest>, IValidatableObject
    {
        /// <summary>
        /// Controls when a beep is played. Valid values: &#x60;always&#x60;, &#x60;never&#x60;, &#x60;entryOnly&#x60;, &#x60;exitOnly&#x60;.
        /// </summary>
        /// <value>Controls when a beep is played. Valid values: &#x60;always&#x60;, &#x60;never&#x60;, &#x60;entryOnly&#x60;, &#x60;exitOnly&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PlayBeepEnum
        {
            /// <summary>
            /// Enum ALWAYS for value: always
            /// </summary>
            [EnumMember(Value = "always")]
            ALWAYS = 1,

            /// <summary>
            /// Enum NEVER for value: never
            /// </summary>
            [EnumMember(Value = "never")]
            NEVER = 2,

            /// <summary>
            /// Enum ENTRY_ONLY for value: entryOnly
            /// </summary>
            [EnumMember(Value = "entryOnly")]
            ENTRY_ONLY = 3,

            /// <summary>
            /// Enum EXIT_ONLY for value: exitOnly
            /// </summary>
            [EnumMember(Value = "exitOnly")]
            EXIT_ONLY = 4

        }


        /// <summary>
        /// Controls when a beep is played. Valid values: &#x60;always&#x60;, &#x60;never&#x60;, &#x60;entryOnly&#x60;, &#x60;exitOnly&#x60;.
        /// </summary>
        /// <value>Controls when a beep is played. Valid values: &#x60;always&#x60;, &#x60;never&#x60;, &#x60;entryOnly&#x60;, &#x60;exitOnly&#x60;.</value>
        [DataMember(Name = "playBeep", EmitDefaultValue = false)]
        public PlayBeepEnum? PlayBeep { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConferenceRequest" /> class.
        /// </summary>
        /// <param name="alias">A description for this Conference. Maximum 64 characters..</param>
        /// <param name="playBeep">Controls when a beep is played. Valid values: &#x60;always&#x60;, &#x60;never&#x60;, &#x60;entryOnly&#x60;, &#x60;exitOnly&#x60;. (default to PlayBeepEnum.ALWAYS).</param>
        /// <param name="record">Setting to &#x60;true&#x60; records the entire Conference..</param>
        /// <param name="waitUrl">If specified, a URL for the audio file that provides custom hold music for the Conference when it is in the populated state. Otherwise, FreeClimb uses a system default audio file. This is always fetched using HTTP GET and is fetched just once &amp;mdash; when the Conference is created..</param>
        /// <param name="statusCallbackUrl">This URL is invoked when the status of the Conference changes. For more information, see **statusCallbackUrl** (below)..</param>
        public CreateConferenceRequest(string alias = default(string), PlayBeepEnum? playBeep = PlayBeepEnum.ALWAYS, bool record = default(bool), string waitUrl = default(string), string statusCallbackUrl = default(string))
        {
            this.Alias = alias;
            this.PlayBeep = playBeep;
            this.Record = record;
            this.WaitUrl = waitUrl;
            this.StatusCallbackUrl = statusCallbackUrl;
        }

        /// <summary>
        /// A description for this Conference. Maximum 64 characters.
        /// </summary>
        /// <value>A description for this Conference. Maximum 64 characters.</value>
        [DataMember(Name = "alias", EmitDefaultValue = false)]
        public string Alias { get; set; }

        /// <summary>
        /// Setting to &#x60;true&#x60; records the entire Conference.
        /// </summary>
        /// <value>Setting to &#x60;true&#x60; records the entire Conference.</value>
        [DataMember(Name = "record", EmitDefaultValue = true)]
        public bool Record { get; set; }

        /// <summary>
        /// If specified, a URL for the audio file that provides custom hold music for the Conference when it is in the populated state. Otherwise, FreeClimb uses a system default audio file. This is always fetched using HTTP GET and is fetched just once &amp;mdash; when the Conference is created.
        /// </summary>
        /// <value>If specified, a URL for the audio file that provides custom hold music for the Conference when it is in the populated state. Otherwise, FreeClimb uses a system default audio file. This is always fetched using HTTP GET and is fetched just once &amp;mdash; when the Conference is created.</value>
        [DataMember(Name = "waitUrl", EmitDefaultValue = false)]
        public string WaitUrl { get; set; }

        /// <summary>
        /// This URL is invoked when the status of the Conference changes. For more information, see **statusCallbackUrl** (below).
        /// </summary>
        /// <value>This URL is invoked when the status of the Conference changes. For more information, see **statusCallbackUrl** (below).</value>
        [DataMember(Name = "statusCallbackUrl", EmitDefaultValue = false)]
        public string StatusCallbackUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateConferenceRequest {\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  PlayBeep: ").Append(PlayBeep).Append("\n");
            sb.Append("  Record: ").Append(Record).Append("\n");
            sb.Append("  WaitUrl: ").Append(WaitUrl).Append("\n");
            sb.Append("  StatusCallbackUrl: ").Append(StatusCallbackUrl).Append("\n");
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
        /// Retrieve the KVP Dictionary for the CreateConferenceRequest instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public virtual IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("alias", Alias);          
            props.Add("playBeep", PlayBeep);          
            props.Add("record", Record);          
            props.Add("waitUrl", WaitUrl);          
            props.Add("statusCallbackUrl", StatusCallbackUrl);          
            return props;
        }
        
        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as CreateConferenceRequest);
        }

        /// <summary>
        /// Returns true if CreateConferenceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateConferenceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateConferenceRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.PlayBeep == input.PlayBeep ||
                    this.PlayBeep.Equals(input.PlayBeep)
                ) && 
                (
                    this.Record == input.Record ||
                    this.Record.Equals(input.Record)
                ) && 
                (
                    this.WaitUrl == input.WaitUrl ||
                    (this.WaitUrl != null &&
                    this.WaitUrl.Equals(input.WaitUrl))
                ) && 
                (
                    this.StatusCallbackUrl == input.StatusCallbackUrl ||
                    (this.StatusCallbackUrl != null &&
                    this.StatusCallbackUrl.Equals(input.StatusCallbackUrl))
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
                if (this.Alias != null)
                {
                    hashCode = (hashCode * 59) + this.Alias.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PlayBeep.GetHashCode();
                hashCode = (hashCode * 59) + this.Record.GetHashCode();
                if (this.WaitUrl != null)
                {
                    hashCode = (hashCode * 59) + this.WaitUrl.GetHashCode();
                }
                if (this.StatusCallbackUrl != null)
                {
                    hashCode = (hashCode * 59) + this.StatusCallbackUrl.GetHashCode();
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
