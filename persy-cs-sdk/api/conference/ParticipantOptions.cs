using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace com.persephony.api.conference
{
    /// <summary>
    /// The class represents the common participant optional fields.
    /// </summary>
    [JsonObject]
    public class ParticipantOptions:CommonFields
    {
        [JsonProperty(PropertyName = "talk")]
        private EBool talk = EBool.NONE;

        [JsonProperty(PropertyName = "listen")]
        private EBool listen = EBool.NONE;

        /// <summary>
        /// Helper method to build a ParticipantOptions object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a ParticipantOptions instance.</param>
        /// <returns>A ParticipantOptions object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static ParticipantOptions fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<ParticipantOptions>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from a ParticipantOptions instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the ParticipantOptions instance.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
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
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the talk value.
        /// </summary>
        /// <returns>The talk value of the object.</returns>
        /// <see cref="EBool">Boolean enumeration.</see>
        public EBool getTalk { get { return this.talk; } }

        /// <summary>
        /// Sets the talk object value.
        /// </summary>
        /// <param name="val">talk value.</param>
        /// <see cref="EBool">Boolean enumeration.</see>
        public void setTalk(EBool val) { this.talk = val; }

        /// <summary>
        /// Retrieve the listen value.
        /// </summary>
        /// <returns>The listen value of the object.</returns>
        /// <see cref="EBool">Boolean enumeration.</see>
        public EBool getListen { get { return this.listen; } }

        /// <summary>
        /// Sets the listen object value.
        /// </summary>
        /// <param name="val">listen value.</param>
        /// <see cref="EBool">Boolean enumeration.</see>
        public void setListen(EBool val) { this.listen = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the ConferenceOptions instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private new IDictionary<string, object> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (getTalk != EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getTalk);
                props.Add("talk", attr.Value);
            }

            if (getListen != EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getListen);
                props.Add("listen", attr.Value);
            }
            IDictionary<string, object> baseDict = base.toDict();
            foreach (string key in baseDict.Keys)
            {
                props.Add(key, baseDict[key]);
            }
            return props;
        }
    }
}
