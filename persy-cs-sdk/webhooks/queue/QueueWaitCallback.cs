using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.IO;

namespace com.persephony.webhooks.queue
{
    /// <summary>
    /// A QueueWaitCallback represents the JSON object that is 
    /// sent to the webhooks of Persephony applications.
    /// </summary>
    [JsonObject]
    public sealed class QueueWaitCallback : StatusCallback
    {
#pragma warning disable 0649 // default value compiler warning
        [JsonProperty(PropertyName = "queuePosition")]
        private readonly int queuePosition;

        [JsonProperty(PropertyName = "queueTime")]
        private readonly int queueTime;

        [JsonProperty(PropertyName = "averageQueueTime")]
        private readonly int averageQueueTime;

        [JsonProperty(PropertyName = "currentQueueSize")]
        private readonly int currentQueueSize;
#pragma warning restore 0649 

        /// <summary>
        /// Helper method to build a QueueWaitCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a QueueWaitCallback instance.</param>
        /// <returns>A QueueWaitStatusCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static new QueueWaitCallback fromJson(string rawJson)
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                return jsonSerializer.Deserialize<QueueWaitCallback>(new JsonTextReader(new StringReader(rawJson)));
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve queuePosition value from the object.
        /// </summary>
        /// <returns>The queuePosition value.</returns>
        public int getQueuePosition { get { return this.queuePosition; } }

        /// <summary>
        /// Retrieve queueTime value from the object.
        /// </summary>
        /// <returns>The queueTime value.</returns>
        public int getQueueTime { get { return this.queueTime; } }

        /// <summary>
        /// Retrieve averageQueueTime value from the object.
        /// </summary>
        /// <returns>The averageQueueTime value.</returns>
        public int getAverageQueueTime { get { return this.averageQueueTime; } }

        /// <summary>
        /// Retrieve currentQueueSize value from the object.
        /// </summary>
        /// <returns>The currentQueueSize value.</returns>
        public int getCurrentQueueSize { get { return this.currentQueueSize; } }
    }
}
