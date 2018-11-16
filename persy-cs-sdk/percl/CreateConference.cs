using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;

namespace com.persephony.percl
{
    /// <summary>
    /// CreateConference PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class CreateConference : PerCLCommand
    {
        [JsonProperty(PropertyName = "alias")]
        private string alias = string.Empty;

        [JsonProperty(PropertyName = "playBeep")]
        private EPlayBeep playBeep = EPlayBeep.NONE;

        [JsonProperty(PropertyName = "record")]
        private EBool record = EBool.NONE;

        [JsonProperty(PropertyName = "waitUrl")]
        private string waitUrl = string.Empty;

        [JsonProperty(PropertyName = "statusCallbackUrl")]
        private string statusCallbackUrl = string.Empty;

        [JsonProperty(PropertyName = "actionUrl")]
        private string actionUrl = string.Empty;

        /// <summary>
        /// Helper method to build a JSON string from a CreateConference instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the CreateConference instance.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
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
                throw new PersyJSONException(e.Message);
            }
        }

        /// <summary>
        /// Creates CreateConference PerCL with require fields. 
        /// </summary>
        /// <param name="actionUrl">Action Url.</param>
        public CreateConference(string actionUrl)
        {
            this.actionUrl = actionUrl;
        }

        /// <summary>
        /// Retrieve the alias value.
        /// </summary>
        /// <returns>The alias value of the object.</returns>
        public string getAlias { get { return this.alias; } }

        /// <summary>
        /// Set the alias value.
        /// </summary>
        /// <param name="val">alias value.</param>
        public void setAlias(string val) { this.alias = val; }

        /// <summary>
        /// Retrieve the playBeep value.
        /// </summary>
        /// <returns>The playBeep value of the object.</returns>
        public EPlayBeep getPlayBeep { get { return this.playBeep; } }

        /// <summary>
        /// Set the playBeep value.
        /// </summary>
        /// <param name="val">playBeep value.</param>
        public void setPlayBeep(EPlayBeep val) { this.playBeep = val; }

        /// <summary>
        /// Retrieve the record value.
        /// </summary>
        /// <returns>The record value of the object.</returns>
        public EBool getRecord { get { return this.record; } }

        /// <summary>
        /// Set the record value.
        /// </summary>
        /// <param name="val">record value.</param>
        public void setRecord(EBool val) { this.record = val; }

        /// <summary>
        /// Retrieve the waitUrl value.
        /// </summary>
        /// <returns>The waitUrl value of the object.</returns>
        public string getWaitUrl { get { return this.waitUrl; } }

        /// <summary>
        /// Set the waitUrl value.
        /// </summary>
        /// <param name="val">waitUrl value.</param>
        public void setWaitUrl(string val) { this.waitUrl = val; }

        /// <summary>
        /// Retrieve the statusCallbackUrl value.
        /// </summary>
        /// <returns>The statusCallbackUrl value of the object.</returns>
        public string getStatusCallbackUrl { get { return this.statusCallbackUrl; } }

        /// <summary>
        /// Set the statusCallbackUrl value.
        /// </summary>
        /// <param name="val">statusCallbackUrl value.</param>
        public void setStatusCallbackUrl(string val) { this.statusCallbackUrl = val; }

        /// <summary>
        /// Retrieve the actionUrl value.
        /// </summary>
        /// <returns>The actionUrl value of the object.</returns>
        public string getActionUrl { get { return this.actionUrl; } }

        /// <summary>
        /// Set the actionUrl value.
        /// </summary>
        /// <param name="val">actionUrl value.</param>
        public void setActionUrl(string val) { this.actionUrl = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the CreateConference instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (this.actionUrl == string.Empty)
            {
                throw new PersyJSONException("actionUrl is a required parameter");
            }
            props.Add("actionUrl", this.actionUrl);

            if (this.alias == string.Empty)
            {
                props.Add("alias", null);
            }
            else
            {
                props.Add("alias", this.alias);
            }

            if (this.playBeep == EPlayBeep.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(EPlayBeep.Always);
                props.Add("playBeep", attr.Value);
            }
            else
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(this.playBeep);
                props.Add("playBeep", attr.Value);
            }

            if (this.record == EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(EBool.False);
                props.Add("record", bool.Parse(attr.Value));
            }
            else
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(this.record);
                props.Add("record", bool.Parse(attr.Value));
            }

            if (this.waitUrl == string.Empty)
            {
                props.Add("waitUrl", null);
            }
            else
            {
                props.Add("waitUrl", this.waitUrl);
            }

            if (this.statusCallbackUrl == string.Empty)
            {
                props.Add("statusCallbackUrl", null);
            }
            else
            {
                props.Add("statusCallbackUrl", this.statusCallbackUrl);
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("CreateConference", props);

            return command;
        }
    }
}
