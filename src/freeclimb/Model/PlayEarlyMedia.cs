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
    /// &#x60;PlayEarlyMedia&#x60; is relevant only when present as the very first command in the PerCL script returned for an incoming Call. In such cases, the command is executed before FreeClimb attempts to connect the call. The audio file it uses can be stored in any location that is accessible via URL.
    /// </summary>
    [DataContract(Name = "PlayEarlyMedia")]
    [JsonConverter(typeof(JsonSubtypes), "Command")]
    public partial class PlayEarlyMedia : PerclCommand, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayEarlyMedia" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PlayEarlyMedia() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="PlayEarlyMedia" /> class.
        /// </summary>
        /// <param name="file">RL of the audio file to be played to the caller. The URL can be the &#x60;recordingUrl&#x60; generated from the &#x60;RecordUtterance&#x60; or &#x60;StartRecordCall&#x60; PerCL commands or any accessible URL. FreeClimb will respect Cache-Control headers for this file. Use these to limit repeated requests for unchanged audio. If no Cache-Control header is provided, the file will be cached for seven days by default. (required).</param>
        /// <param name="command">Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) (default to &quot;PlayEarlyMedia&quot;).</param>
        public PlayEarlyMedia(string file = default(string), string command = @"PlayEarlyMedia")
            : base(command)
        {
            // to ensure "file" is required (not null)
            if (file == null)
            {
                throw new ArgumentNullException(
                    "file is a required property for PlayEarlyMedia and cannot be null"
                );
            }
            this.File = file;
        }

        /// <summary>
        /// RL of the audio file to be played to the caller. The URL can be the &#x60;recordingUrl&#x60; generated from the &#x60;RecordUtterance&#x60; or &#x60;StartRecordCall&#x60; PerCL commands or any accessible URL. FreeClimb will respect Cache-Control headers for this file. Use these to limit repeated requests for unchanged audio. If no Cache-Control header is provided, the file will be cached for seven days by default.
        /// </summary>
        /// <value>RL of the audio file to be played to the caller. The URL can be the &#x60;recordingUrl&#x60; generated from the &#x60;RecordUtterance&#x60; or &#x60;StartRecordCall&#x60; PerCL commands or any accessible URL. FreeClimb will respect Cache-Control headers for this file. Use these to limit repeated requests for unchanged audio. If no Cache-Control header is provided, the file will be cached for seven days by default.</value>
        [DataMember(Name = "file", IsRequired = true, EmitDefaultValue = true)]
        public string File { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PlayEarlyMedia {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
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
        /// Retrieve the KVP Dictionary for the PlayEarlyMedia instance.
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("file", File);
            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("PlayEarlyMedia", props);
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
