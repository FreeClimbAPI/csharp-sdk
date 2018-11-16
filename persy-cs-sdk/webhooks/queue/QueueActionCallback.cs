using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.IO;

namespace com.persephony.webhooks.queue
{
    /// <summary>
    /// A QueueActionCallback represents the JSON object that is 
    /// sent to the webhooks of Persephony applications.
    /// </summary>
    [JsonObject]
    public sealed class QueueActionCallback : StatusCallback
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "queueResult")]
        private readonly EResults queueResult;

        [JsonProperty(PropertyName = "queueTime")]
        private readonly int queueTime;
#pragma warning restore 0649 

        /// <summary>
        /// Helper method to build a QueueActionCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a QueueActionCallback instance.</param>
        /// <returns>A QueueActionCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static new QueueActionCallback fromJson(string rawJson)
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                return jsonSerializer.Deserialize<QueueActionCallback>(new JsonTextReader(new StringReader(rawJson)));
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve queueResult value from the object.
        /// </summary>
        /// <returns>The queueResult value.</returns>
        /// <see cref="EResults">Results enumeration.</see>
        public EResults getQueueResult { get { return this.queueResult; } }

        /// <summary>
        /// Retrieve queueTime value from the object.
        /// </summary>
        /// <returns>The queueTime value.</returns>
        public int getQueueTime { get { return this.queueTime; } }
    }
}
