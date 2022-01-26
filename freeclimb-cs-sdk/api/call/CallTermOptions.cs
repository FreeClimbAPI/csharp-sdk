using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace com.freeclimb.api.call
{
    /// <summary>
    /// The class represents the common optional fields which can be passed terminating a call.
    /// </summary>
    [JsonObject]
    public class CallTermOptions
    {
        [JsonProperty(PropertyName = "status")]
        private ECallStatus status = ECallStatus.NONE;

        /// <summary>
	    /// Helper method to build a CallTermOptions object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a CallTermOptions instance.</param>
        /// <returns>A CallTermOptions object equivalent to the JSON string passed in.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static CallOrigOptions fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<CallOrigOptions>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
	    /// Helper method to build a JSON string from a CallTermOptions instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the CallTermOptions instance.</returns>
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
        /// Retrieve the status value.
        /// </summary>
        /// <returns>The status value of the object.</returns>
        /// <see cref="ECallStatus">Status enumeration.</see>
        public ECallStatus getStatus { get { return this.status; } }

        /// <summary>
        /// Sets the status object value.
        /// </summary>
        /// <param name="val">status value.</param>
        /// <see cref="ECallStatus">Status enumeration.</see>
        public void setStatus(ECallStatus val) { this.status = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the CallTermOptions instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private IDictionary<string, object> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (getStatus != ECallStatus.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getStatus);
                props.Add("status", attr.Value);
            }
            
            return props;
        }
    }
}
