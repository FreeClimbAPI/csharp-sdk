using Newtonsoft.Json;
using System;
using System.IO;
using com.freeclimb.api;

namespace com.freeclimb.webhooks.conference
{
    /// <summary>
    /// A ConferenceActionCallback represents the JSON object that is 
    /// sent to the webhooks of FreeClimb applications.
    /// </summary>
    [JsonObject]
    public sealed class ConferenceCreateActionCallback : VoiceRequest
    {
        /// <summary>
        /// Helper method to build a ConferenceActionCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a ConferenceStatusCallback instance.</param>
        /// <returns>A ConferenceStatusCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public new static ConferenceCreateActionCallback fromJson(string rawJson)
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                return jsonSerializer.Deserialize<ConferenceCreateActionCallback>(new JsonTextReader(new StringReader(rawJson)));
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }
    }
}
