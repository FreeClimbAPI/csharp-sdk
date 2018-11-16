using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.IO;

namespace com.persephony.webhooks.call
{
    /// <summary>
    /// A CallStatusCallback represents the JSON object that is 
    /// sent to the webhooks of Persephony applications.
    /// </summary>
    [JsonObject]
    public sealed class CallStatusCallback : StatusCallback
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "dialCallStatus")]
        private readonly ECallStatus dialCallStatus;

        [JsonProperty(PropertyName = "answeredBy")]
        private readonly EAnsweredBy answeredBy;
#pragma warning restore 0649 

        /// <summary>
        /// Helper method to build a CallStatusCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a CallStatusCallback instance.</param>
        /// <returns>A CallStatusCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static new CallStatusCallback fromJson(string rawJson)
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                return jsonSerializer.Deserialize<CallStatusCallback>(new JsonTextReader(new StringReader(rawJson)));
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve answeredBy value from the object.
        /// </summary>
        /// <returns>The answeredBy value.</returns>
        ///<see cref="EAnsweredBy">AnsweredBy enumeration.</see>
        public EAnsweredBy getAnsweredBy { get { return this.answeredBy; } }

        /// <summary>
        /// Retrieve dialCallStatus value from the object.
        /// </summary>
        /// <returns>The dialCallStatus value.</returns>
        ///<see cref="ECallStatus">Status enumeration.</see>
        public ECallStatus getDialCallStatus { get { return this.dialCallStatus; } }
    }
}
