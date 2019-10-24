using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.freeclimb.api.queue
{
    /// <summary>
    /// The class represents the common queue optional fields.
    /// </summary>
    [JsonObject]
    public class QueueMemberOptions:CommonFields
    {

        /// <summary>
        /// Helper method to build a JSON string from a QueueMemberOptions instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the QueueMemberOptions instance.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public virtual string toJson()
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                StringBuilder strb = new StringBuilder();
                jsonSerializer.Serialize(new StringWriter(strb), toDict());

                return strb.ToString();
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the QueueMemberOptions instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private new IDictionary<string, object> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();
            // add all non-common properties

            IDictionary<string, object> baseDict = base.toDict();
            foreach (string key in baseDict.Keys)
            {
                props.Add(key, baseDict[key]);
            }
            return props;
        }
    }
}
