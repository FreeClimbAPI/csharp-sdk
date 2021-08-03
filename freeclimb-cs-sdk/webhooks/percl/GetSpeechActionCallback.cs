using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization;
using com.freeclimb.api;

namespace com.freeclimb.webhooks.percl
{
    /// <summary>
    /// A GetSpeechActionCallback represents the JSON object that is 
    /// sent to the webhooks of FreeClimb applications.
    /// </summary>
    [JsonObject]
    public sealed class GetSpeechActionCallback : StatusCallback
    {
 #pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "reason")]
        private readonly ESpeechTermReason reason;

        [JsonProperty(PropertyName = "recognitionResult")]
        private readonly string recognitionResult;

        [JsonProperty(PropertyName = "confidence")]
        private readonly int confidence;

        [JsonProperty(PropertyName = "completionReason")]
        private readonly string completionReason;

        [JsonProperty(PropertyName = "completionCause")]
        private readonly string completionCause;

        [JsonProperty(PropertyName = "mrcpCode")]
        private readonly int mrcpCode;

        [JsonProperty(PropertyName = "mrcpDiagnostic")]
        private readonly string mrcpDiagnostic;
#pragma warning restore 0649

        /// <summary>
        /// Helper method to build a GetSpeechActionCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a GetSpeechActionCallback instance.</param>
        /// <returns>A GetSpeechStatusCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static new GetSpeechActionCallback fromJson(string rawJson)
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                return jsonSerializer.Deserialize<GetSpeechActionCallback>(new JsonTextReader(new StringReader(rawJson)));
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve reason value from the object.
        /// </summary>
        /// <returns>The reason value.</returns>
        ///<see cref="ESpeechTermReason">SpeechTermReason enumeration.</see>
        public ESpeechTermReason getReason { get { return this.reason; } }

        /// <summary>
        /// Retrieve recognitionResult value from the object.
        /// </summary>
        /// <returns>The recognitionResult value.</returns>
        public string getRecognitionResult { get { return this.recognitionResult; } }

        /// <summary>
        /// Retrieve confidence value from the object.
        /// </summary>
        /// <returns>The confidence value.</returns>
        public int getConfidence { get { return this.confidence; } }

        /// <summary>
        /// Retrieve completionReason value from the object.
        /// </summary>
        /// <returns>The completionReason value.</returns>
        public string getCompletionReason { get { return this.completionReason; } }

        /// <summary>
        /// Retrieve completionCause value from the object.
        /// </summary>
        /// <returns>The completionCause value.</returns>
        public string getCompletionCause { get { return this.completionCause; } }

        /// <summary>
        /// Retrieve mrcpCode value from the object.
        /// </summary>
        /// <returns>The mrcpCode value.</returns>
        public int getMrcpCode { get { return this.mrcpCode; } }

        /// <summary>
        /// Retrieve mrcpDiagnostic value from the object.
        /// </summary>
        /// <returns>The mrcpDiagnostic value.</returns>
        public string getMrcpDiagnostic { get { return this.mrcpDiagnostic; } }
    }
}
