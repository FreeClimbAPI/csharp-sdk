using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.IO;

namespace com.persephony.webhooks.call
{
    /// <summary>
    /// An OutDialIfMachineCallback represents the JSON object that is 
    /// sent to the webhooks of Persephony applications.
    /// </summary>
    [JsonObject]
    public sealed class OutDialIfMachineCallback : VoiceRequest
    {
#pragma warning disable 0649 // default value compiler warning  EMachineType
        [JsonProperty(PropertyName = "machineType")]
        private readonly EMachineType machineType;
#pragma warning restore 0649 

        /// <summary>
        /// Helper method to build an OutDialIfMachineCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing an OutDialIfMachineCallback instance.</param>
        /// <returns>An OutDialIfMachineCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static new OutDialIfMachineCallback fromJson(string rawJson)
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                return jsonSerializer.Deserialize<OutDialIfMachineCallback>(new JsonTextReader(new StringReader(rawJson)));
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve machineType value from the object.
        /// </summary>
        /// <returns>The machineType value.</returns>
        ///<see cref="ERecordTermReason">RecordTermReason enumeration.</see>
        public EMachineType getMachineType { get { return this.machineType; } }
    }
}
