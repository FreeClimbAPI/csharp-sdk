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
    /// The &#x60;GetSpeech&#x60; command enables the Caller to respond to the application using a supported language. Unlike DTMF entry, which implicitly restricts the user to using the available buttons on the phone key pad, speech input allows for flexible audio inputs based on grammar. FreeClimb supports grammars written using GRXML compatible with the Microsoft Speech Platform. &#x60;GetSpeech&#x60; is only supported on a single call leg. It is not supported when there are two or more call legs connected (as in within a Conference).
    /// </summary>
    [DataContract(Name = "GetSpeech")]
    [JsonConverter(typeof(JsonSubtypes), "Command")]
    public partial class GetSpeech : PerclCommand, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets GrammarType
        /// </summary>
        [DataMember(Name = "grammarType", EmitDefaultValue = true)]
        public GrammarType? GrammarType { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpeech" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSpeech() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetSpeech" /> class.
        /// </summary>
        /// <param name="actionUrl">When the caller has finished speaking or the command has timed out, FreeClimb will make a POST request to this URL. A PerCL response is expected to continue handling the call. (required).</param>
        /// <param name="grammarType">grammarType.</param>
        /// <param name="grammarFile">The grammar file to use for speech recognition. If grammarType is set to URL, this attribute is specified as a download URL. (required).</param>
        /// <param name="grammarRule">The grammar rule within the specified grammar file to use for speech recognition. This attribute is optional if &#x60;grammarType&#x60; is &#x60;URL&#x60; and ignored if &#x60;grammarType&#x60; is &#x60;BUILTIN&#x60;..</param>
        /// <param name="playBeep">Indicates whether a beep should be played just before speech recognition is initiated so that the speaker can start to speak..</param>
        /// <param name="prompts">The JSON array of PerCL commands to nest within the &#x60;GetSpeech&#x60; command. The &#x60;Say&#x60;, &#x60;Play&#x60;, and &#x60;Pause&#x60; commands can be used. The nested actions are executed while FreeClimb is waiting for input from the caller. This allows for playing menu options to the caller and to prompt for the expected input. These commands stop executing when the caller begins to input speech..</param>
        /// <param name="noInputTimeoutMs">When recognition is started and there is no speech detected for &#x60;noInputTimeoutMs&#x60; milliseconds, the recognizer will terminate the recognition operation..</param>
        /// <param name="recognitionTimeoutMs">When playback of prompts ends and there is no match for &#x60;recognitionTimeoutMs&#x60; milliseconds, the recognizer will terminate the recognition operation..</param>
        /// <param name="confidenceThreshold">When a recognition resource recognizes a spoken phrase, it associates a confidence level with that match. Parameter &#x60;confidenceThreshold&#x60; specifies what confidence level is considered a successful match. Values are between 0.0 and 1.0..</param>
        /// <param name="sensitivityLevel">The speech recognizer supports a variable level of sound sensitivity. The sensitivityLevel attribute allows for filtering out background noise, so it is not mistaken for speech. Values are between 0.0 and 1.0 .</param>
        /// <param name="speechCompleteTimeoutMs">Parameter &#x60;speechCompleteTimeoutMs&#x60; specifies the length of silence required following user speech before the speech recognizer finalizes a result. This timeout applies when the recognizer currently has a complete match against an active grammar. Reasonable speech complete timeout values are typically in the range of 0.3 seconds to 1.0 seconds..</param>
        /// <param name="speechIncompleteTimeoutMs">Parameter &#x60;speechIncompleteTimeoutMs&#x60; specifies the length of silence following user speech after which a recognizer finalizes a result. This timeout applies when the speech prior to the silence is an incomplete match of all active grammars. Timeout &#x60;speechIncompleteTimeoutMs&#x60; is usually longer than &#x60;speechCompleteTimeoutMs&#x60; to allow users to pause mid-utterance..</param>
        /// <param name="privacyMode">Parameter privacyMode will not log the &#x60;text&#x60; as required by PCI compliance..</param>
        /// <param name="command">Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) (default to &quot;GetSpeech&quot;).</param>
        public GetSpeech(
            string actionUrl = default(string),
            GrammarType? grammarType = default(GrammarType?),
            string grammarFile = default(string),
            string grammarRule = default(string),
            bool playBeep = default(bool),
            List<PerclCommand> prompts = default(List<PerclCommand>),
            int noInputTimeoutMs = default(int),
            int recognitionTimeoutMs = default(int),
            decimal confidenceThreshold = default(decimal),
            decimal sensitivityLevel = default(decimal),
            int speechCompleteTimeoutMs = default(int),
            int speechIncompleteTimeoutMs = default(int),
            bool privacyMode = default(bool),
            string command = @"GetSpeech"
        )
            : base(command)
        {
            // to ensure "actionUrl" is required (not null)
            if (actionUrl == null)
            {
                throw new ArgumentNullException(
                    "actionUrl is a required property for GetSpeech and cannot be null"
                );
            }
            this.ActionUrl = actionUrl;

            // to ensure "grammarFile" is required (not null)
            if (grammarFile == null)
            {
                throw new ArgumentNullException(
                    "grammarFile is a required property for GetSpeech and cannot be null"
                );
            }
            this.GrammarFile = grammarFile;

            this.GrammarType = grammarType;

            this.GrammarRule = grammarRule;

            this.PlayBeep = playBeep;

            this.Prompts = prompts;

            this.NoInputTimeoutMs = noInputTimeoutMs;

            this.RecognitionTimeoutMs = recognitionTimeoutMs;

            this.ConfidenceThreshold = confidenceThreshold;

            this.SensitivityLevel = sensitivityLevel;

            this.SpeechCompleteTimeoutMs = speechCompleteTimeoutMs;

            this.SpeechIncompleteTimeoutMs = speechIncompleteTimeoutMs;

            this.PrivacyMode = privacyMode;
        }

        /// <summary>
        /// When the caller has finished speaking or the command has timed out, FreeClimb will make a POST request to this URL. A PerCL response is expected to continue handling the call.
        /// </summary>
        /// <value>When the caller has finished speaking or the command has timed out, FreeClimb will make a POST request to this URL. A PerCL response is expected to continue handling the call.</value>
        [DataMember(Name = "actionUrl", IsRequired = true, EmitDefaultValue = true)]
        public string ActionUrl { get; set; }

        /// <summary>
        /// The grammar file to use for speech recognition. If grammarType is set to URL, this attribute is specified as a download URL.
        /// </summary>
        /// <value>The grammar file to use for speech recognition. If grammarType is set to URL, this attribute is specified as a download URL.</value>
        [DataMember(Name = "grammarFile", IsRequired = true, EmitDefaultValue = true)]
        public string GrammarFile { get; set; }

        /// <summary>
        /// The grammar rule within the specified grammar file to use for speech recognition. This attribute is optional if &#x60;grammarType&#x60; is &#x60;URL&#x60; and ignored if &#x60;grammarType&#x60; is &#x60;BUILTIN&#x60;.
        /// </summary>
        /// <value>The grammar rule within the specified grammar file to use for speech recognition. This attribute is optional if &#x60;grammarType&#x60; is &#x60;URL&#x60; and ignored if &#x60;grammarType&#x60; is &#x60;BUILTIN&#x60;.</value>
        [DataMember(Name = "grammarRule", EmitDefaultValue = false)]
        public string GrammarRule { get; set; }

        /// <summary>
        /// Indicates whether a beep should be played just before speech recognition is initiated so that the speaker can start to speak.
        /// </summary>
        /// <value>Indicates whether a beep should be played just before speech recognition is initiated so that the speaker can start to speak.</value>
        [DataMember(Name = "playBeep", EmitDefaultValue = true)]
        public bool PlayBeep { get; set; }

        /// <summary>
        /// The JSON array of PerCL commands to nest within the &#x60;GetSpeech&#x60; command. The &#x60;Say&#x60;, &#x60;Play&#x60;, and &#x60;Pause&#x60; commands can be used. The nested actions are executed while FreeClimb is waiting for input from the caller. This allows for playing menu options to the caller and to prompt for the expected input. These commands stop executing when the caller begins to input speech.
        /// </summary>
        /// <value>The JSON array of PerCL commands to nest within the &#x60;GetSpeech&#x60; command. The &#x60;Say&#x60;, &#x60;Play&#x60;, and &#x60;Pause&#x60; commands can be used. The nested actions are executed while FreeClimb is waiting for input from the caller. This allows for playing menu options to the caller and to prompt for the expected input. These commands stop executing when the caller begins to input speech.</value>
        [DataMember(Name = "prompts", EmitDefaultValue = false)]
        public List<PerclCommand> Prompts { get; set; }

        /// <summary>
        /// When recognition is started and there is no speech detected for &#x60;noInputTimeoutMs&#x60; milliseconds, the recognizer will terminate the recognition operation.
        /// </summary>
        /// <value>When recognition is started and there is no speech detected for &#x60;noInputTimeoutMs&#x60; milliseconds, the recognizer will terminate the recognition operation.</value>
        [DataMember(Name = "noInputTimeoutMs", EmitDefaultValue = false)]
        public int NoInputTimeoutMs { get; set; }

        /// <summary>
        /// When playback of prompts ends and there is no match for &#x60;recognitionTimeoutMs&#x60; milliseconds, the recognizer will terminate the recognition operation.
        /// </summary>
        /// <value>When playback of prompts ends and there is no match for &#x60;recognitionTimeoutMs&#x60; milliseconds, the recognizer will terminate the recognition operation.</value>
        [DataMember(Name = "recognitionTimeoutMs", EmitDefaultValue = false)]
        public int RecognitionTimeoutMs { get; set; }

        /// <summary>
        /// When a recognition resource recognizes a spoken phrase, it associates a confidence level with that match. Parameter &#x60;confidenceThreshold&#x60; specifies what confidence level is considered a successful match. Values are between 0.0 and 1.0.
        /// </summary>
        /// <value>When a recognition resource recognizes a spoken phrase, it associates a confidence level with that match. Parameter &#x60;confidenceThreshold&#x60; specifies what confidence level is considered a successful match. Values are between 0.0 and 1.0.</value>
        [DataMember(Name = "confidenceThreshold", EmitDefaultValue = false)]
        public decimal ConfidenceThreshold { get; set; }

        /// <summary>
        /// The speech recognizer supports a variable level of sound sensitivity. The sensitivityLevel attribute allows for filtering out background noise, so it is not mistaken for speech. Values are between 0.0 and 1.0
        /// </summary>
        /// <value>The speech recognizer supports a variable level of sound sensitivity. The sensitivityLevel attribute allows for filtering out background noise, so it is not mistaken for speech. Values are between 0.0 and 1.0 </value>
        [DataMember(Name = "sensitivityLevel", EmitDefaultValue = false)]
        public decimal SensitivityLevel { get; set; }

        /// <summary>
        /// Parameter &#x60;speechCompleteTimeoutMs&#x60; specifies the length of silence required following user speech before the speech recognizer finalizes a result. This timeout applies when the recognizer currently has a complete match against an active grammar. Reasonable speech complete timeout values are typically in the range of 0.3 seconds to 1.0 seconds.
        /// </summary>
        /// <value>Parameter &#x60;speechCompleteTimeoutMs&#x60; specifies the length of silence required following user speech before the speech recognizer finalizes a result. This timeout applies when the recognizer currently has a complete match against an active grammar. Reasonable speech complete timeout values are typically in the range of 0.3 seconds to 1.0 seconds.</value>
        [DataMember(Name = "speechCompleteTimeoutMs", EmitDefaultValue = false)]
        public int SpeechCompleteTimeoutMs { get; set; }

        /// <summary>
        /// Parameter &#x60;speechIncompleteTimeoutMs&#x60; specifies the length of silence following user speech after which a recognizer finalizes a result. This timeout applies when the speech prior to the silence is an incomplete match of all active grammars. Timeout &#x60;speechIncompleteTimeoutMs&#x60; is usually longer than &#x60;speechCompleteTimeoutMs&#x60; to allow users to pause mid-utterance.
        /// </summary>
        /// <value>Parameter &#x60;speechIncompleteTimeoutMs&#x60; specifies the length of silence following user speech after which a recognizer finalizes a result. This timeout applies when the speech prior to the silence is an incomplete match of all active grammars. Timeout &#x60;speechIncompleteTimeoutMs&#x60; is usually longer than &#x60;speechCompleteTimeoutMs&#x60; to allow users to pause mid-utterance.</value>
        [DataMember(Name = "speechIncompleteTimeoutMs", EmitDefaultValue = false)]
        public int SpeechIncompleteTimeoutMs { get; set; }

        /// <summary>
        /// Parameter privacyMode will not log the &#x60;text&#x60; as required by PCI compliance.
        /// </summary>
        /// <value>Parameter privacyMode will not log the &#x60;text&#x60; as required by PCI compliance.</value>
        [DataMember(Name = "privacyMode", EmitDefaultValue = true)]
        public bool PrivacyMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSpeech {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  ActionUrl: ").Append(ActionUrl).Append("\n");
            sb.Append("  GrammarType: ").Append(GrammarType).Append("\n");
            sb.Append("  GrammarFile: ").Append(GrammarFile).Append("\n");
            sb.Append("  GrammarRule: ").Append(GrammarRule).Append("\n");
            sb.Append("  PlayBeep: ").Append(PlayBeep).Append("\n");
            sb.Append("  Prompts: ").Append(Prompts).Append("\n");
            sb.Append("  NoInputTimeoutMs: ").Append(NoInputTimeoutMs).Append("\n");
            sb.Append("  RecognitionTimeoutMs: ").Append(RecognitionTimeoutMs).Append("\n");
            sb.Append("  ConfidenceThreshold: ").Append(ConfidenceThreshold).Append("\n");
            sb.Append("  SensitivityLevel: ").Append(SensitivityLevel).Append("\n");
            sb.Append("  SpeechCompleteTimeoutMs: ").Append(SpeechCompleteTimeoutMs).Append("\n");
            sb.Append("  SpeechIncompleteTimeoutMs: ")
                .Append(SpeechIncompleteTimeoutMs)
                .Append("\n");
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
            JsonSerializer jsonSerializer = JsonSerializer.Create();
            jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

            StringBuilder strb = new StringBuilder();
            jsonSerializer.Serialize(new StringWriter(strb), ToKvp());

            return strb.ToString();
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the GetSpeech instance.
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> ToKvp()
        {
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("actionUrl", ActionUrl);
            props.Add("grammarType", GrammarType);
            props.Add("grammarFile", GrammarFile);
            props.Add("grammarRule", GrammarRule);
            props.Add("playBeep", PlayBeep);
            List<object> nested = new List<object>();
            foreach (var item in Prompts)
            {
                nested.Add(item);
            }
            props.Add("prompts", nested);
            props.Add("noInputTimeoutMs", NoInputTimeoutMs);
            props.Add("recognitionTimeoutMs", RecognitionTimeoutMs);
            props.Add("confidenceThreshold", ConfidenceThreshold);
            props.Add("sensitivityLevel", SensitivityLevel);
            props.Add("speechCompleteTimeoutMs", SpeechCompleteTimeoutMs);
            props.Add("speechIncompleteTimeoutMs", SpeechIncompleteTimeoutMs);
            props.Add("privacyMode", PrivacyMode);
            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("GetSpeech", props);
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
