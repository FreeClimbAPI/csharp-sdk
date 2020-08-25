using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.freeclimb.api;
using System.Runtime.Serialization;

namespace com.freeclimb.percl
{
    /// <summary>
    /// Play PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class Play : PerCLCommand, IGetDigitsNestable, IGetSpeechNestable
    {
        [JsonProperty(PropertyName = "file")]
        private string file = string.Empty;

        [JsonProperty(PropertyName = "loop")]
        private int loop = int.MinValue;

        [JsonProperty(PropertyName = "conferenceId")]
        private string conferenceId;

        [JsonProperty(PropertyName = "privacyMode")]
        private EBool privacyMode = EBool.NONE;

        /// <summary>
	    /// Helper method to build a JSON string from a Play instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the Play instance.</returns>
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
        /// Retrieve the file value.
        /// </summary>
        /// <returns>The file value of the object.</returns>
        public string getFile { get { return this.file; } }

        /// <summary>
        /// Set the file value.
        /// </summary>
        /// <param name="val">file value.</param>
        public void setFile(string val) { this.file = val; }

        /// <summary>
        /// Retrieve the loop value.
        /// </summary>
        /// <returns>The loop value of the object.</returns>
        public int getLoop { get { return this.loop; } }

        /// <summary>
        /// Set the loop value.
        /// </summary>
        /// <param name="val">loop value.</param>
        public void setLoop(int val) { this.loop = val; }

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
        /// Retrieve the privacyMode value.
        /// </summary>
        /// <returns>The privacyMode value of the object.</returns>
        /// <see cref="EBool">Bool enumeration.</see>
        public EBool getPrivacyMode { get { return this.privacyMode; } }

        /// <summary>
        /// Set the privacyMode value.
        /// </summary>
        /// <param name="val">privacyMode value.</param>
        /// <see cref="EBool">Bool enumeration.</see>
        public void setPrivacyMode(EBool val) { this.privacyMode = val; }

        /// <summary>
        /// Creates Play PerCL with require fields. 
        /// </summary>
        /// <param name="file">File to play.</param>
        public Play(string file)
        {
            this.file = file;
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the Play instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (String.IsNullOrEmpty(getFile) == true)
            {
                throw new FreeClimbJSONException("file is a required parameter");
            }

            props.Add("file", getFile);

            if (String.IsNullOrEmpty(getConferenceId) == false)
            {
                props.Add("conferenceId", getConferenceId);
            }

            if (getLoop != int.MinValue)
            {
                props.Add("loop", getLoop);
            }

            if (getPrivacyMode != EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getPrivacyMode);
                props.Add("privacyMode", bool.Parse(attr.Value));
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("Play", props);

            return command;
        }
    }
}
