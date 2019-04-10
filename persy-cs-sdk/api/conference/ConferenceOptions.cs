using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace com.persephony.api.conference
{
    /// <summary>
    /// The class represents the common conference optional fields.
    /// </summary>
    [JsonObject]
    public class ConferenceOptions:CommonFields
    {
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;
        private bool aliasFlag = false;

        [JsonProperty(PropertyName = "playBeep")]
        private EBool playBeep = EBool.NONE;

        [JsonProperty(PropertyName = "status")]
        private EConferenceStatus status = EConferenceStatus.NONE;

        /// <summary>
        /// Helper method to build a ConferenceOptions object from the JSON string.
        /// </summary>
        /// <param name="rawJson">A JSON string representing a ConferenceOptions instance.</param>
        /// <returns>A ConferenceOptions object equivalent to the JSON string passed in.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static ConferenceCreateOptions fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<ConferenceCreateOptions>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Helper method to build a JSON string from a ConferenceOptions instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the ConferenceOptions instance.</returns>
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
        /// Retrieve the alias value.
        /// </summary>
        /// <returns>The alias value of the object.</returns>
        public string getAlias { get { return this.alias; } }

        /// <summary>
        /// Sets the alias object value.
        /// </summary>
        /// <param name="val">alias value.</param>
        public void setAlias(string val) { this.alias = val; this.aliasFlag = true; }

        /// <summary>
        /// Retrieve the playBeep value.
        /// </summary>
        /// <returns>The playBeep value of the object.</returns>
        /// <see cref="EBool">Boolean enumeration.</see>
        public EBool getPlayBeep { get { return this.playBeep; } }

        /// <summary>
        /// Sets the playBeep object value.
        /// </summary>
        /// <param name="val">playBeep value.</param>
        /// <see cref="EBool">Boolean enumeration.</see>
        public void setPlayBeep(EBool val) { this.playBeep = val; }

        /// <summary>
        /// Retrieve the status value.
        /// </summary>
        /// <returns>The status value of the object.</returns>
        /// <see cref="EConferenceStatus">Econference status enumeration.</see>
        public EConferenceStatus getStatus { get { return this.status; } }

        /// <summary>
        /// Sets the status object value.
        /// </summary>
        /// <param name="val">status value.</param>
        /// <see cref="EConferenceStatus">Boolean enumeration.</see>
        public void setStatus(EConferenceStatus val) { this.status = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the ConferenceOptions instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        private new IDictionary<string, object> toDict()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (aliasFlag == true)
            {
                props.Add("alias", getAlias);
            }

            if (getPlayBeep != EBool.NONE)
            {
                props.Add("playBeep", getPlayBeep);
            }

            if (getStatus != EConferenceStatus.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getStatus);
                props.Add("status", attr.Value);
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
