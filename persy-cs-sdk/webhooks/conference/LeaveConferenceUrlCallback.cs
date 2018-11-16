using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.IO;

namespace com.persephony.webhooks.conference
{
    /// <summary>
    /// A LeaveConferenceUrlCallback represents the JSON object that is 
    /// sent to the webhooks of Persephony applications.
    /// </summary>
    [JsonObject]
    public sealed class LeaveConferenceUrlCallback : VoiceRequest
    {
        /// <summary>
        /// Helper method to build a LeaveConferenceUrlCallback object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a LeaveConferenceUrlCallback instance.</param>
        /// <returns>A LeaveConferenceUrlCallback object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public new static LeaveConferenceUrlCallback fromJson(string rawJson)
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                return jsonSerializer.Deserialize<LeaveConferenceUrlCallback>(new JsonTextReader(new StringReader(rawJson)));
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }
    }
}
