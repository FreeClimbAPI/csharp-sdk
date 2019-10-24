using Newtonsoft.Json;
using System;
using System.IO;
using com.freeclimb.api;

namespace com.freeclimb.webhooks.call
{
    /// <summary>
    /// A RecordingUtteranceActionCallback represents the JSON object that is 
    /// sent to the webhooks of FreeClimb applications.
    /// </summary>
    [JsonObject]
    public sealed class RecordingUtteranceActionCallback : StatusCallback
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "recordingSize")]
        private readonly int recordingSize;

        [JsonProperty(PropertyName = "recordingFormat")]
        private readonly string recordingFormat;

        [JsonProperty(PropertyName = "termReason")]
        private readonly ERecordTermReason termReason;
#pragma warning restore 0649 

        /// <summary>
        /// Helper method to build a RecordingUtteranceActionCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a RecordingUtteranceActionCallback instance.</param>
        /// <returns>A RecordingUtteranceStatusCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static new RecordingUtteranceActionCallback fromJson(string rawJson)
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                return jsonSerializer.Deserialize<RecordingUtteranceActionCallback>(new JsonTextReader(new StringReader(rawJson)));
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve recordingSize value from the object.
        /// </summary>
        /// <returns>The recordingSize value.</returns>
        public int getRecordingSize { get { return this.recordingSize; } }

        /// <summary>
        /// Retrieve recordingFormat value from the object.
        /// </summary>
        /// <returns>The recordingFormat value.</returns>
        public string getRecordingFormat { get { return this.recordingFormat; } }

        /// <summary>
        /// Retrieve termReason value from the object.
        /// </summary>
        /// <returns>The termReason value.</returns>
        ///<see cref="ERecordTermReason">RecordTermReason enumeration.</see>
        public ERecordTermReason getTermReason { get { return this.termReason; } }
    }
}
