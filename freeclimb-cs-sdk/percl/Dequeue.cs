using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.freeclimb.api;

namespace com.freeclimb.percl
{
    /// <summary>
    /// Dequeue PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class Dequeue : PerCLCommand
    {
        /// <summary>
        /// Helper method to build a JSON string from a Dequeue instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the Dequeue instance.</returns>
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
        /// Retrieve the KVP Dictionary for the Dequeue instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Dequeue", props);

            return command;
        }
    }
}
