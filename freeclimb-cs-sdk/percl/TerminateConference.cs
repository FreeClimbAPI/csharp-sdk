using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.freeclimb.api;

namespace com.freeclimb.percl
{
    /// <summary>
    /// TerminateConference PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class TerminateConference : PerCLCommand
    {
        [JsonProperty(PropertyName = "conferenceId")]
        private string conferenceId = string.Empty;

        /// <summary>
        /// Helper method to build a JSON string from a TerminateConference instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the TerminateConference instance.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public override string toJson()
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                StringBuilder strb = new StringBuilder();
                jsonSerializer.Serialize(new StringWriter(strb), toKvp());

                return strb.ToString();
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Creates TerminateConference PerCL with require fields. 
        /// </summary>
        /// <param name="conferenceId">Conference Id.</param>
        public TerminateConference(string conferenceId)
        {
            this.conferenceId = conferenceId;
        }

        /// <summary>
        /// Retrieve the conferenceId value.
        /// </summary>
        /// <returns>The conferenceId value of the object.</returns>
        public string getConferenceId { get { return this.conferenceId; } }

        /// <summary>
        /// Set the conferenceId value.
        /// </summary>
        /// <param name="val">conferenceId value.</param>
        public void setConferenceId(string val) { this.conferenceId = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the TerminateConference instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (this.conferenceId == string.Empty)
            {
                throw new FreeClimbJSONException("conferenceId is a required parameter");
            }
            props.Add("conferenceId", this.conferenceId);

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("TerminateConference", props);

            return command;
        }
    }
}
