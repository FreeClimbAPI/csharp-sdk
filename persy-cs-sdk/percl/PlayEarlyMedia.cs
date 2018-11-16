using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace com.persephony.percl
{
    /// <summary>
    /// PlayEarlyMedia PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class PlayEarlyMedia : PerCLCommand
    {
        [JsonProperty(PropertyName = "file")]
        private string file = string.Empty;

        /// <summary>
	    /// Helper method to build a JSON string from a PlayEarlyMedia instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the PlayEarlyMedia instance.</returns>
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
        /// Creates PlayEarlyMedia PerCL with require fields. 
        /// </summary>
        /// <param name="file">File to play.</param>
        public PlayEarlyMedia(string file)
        {
            this.file = file;
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the PlayEarlyMedia instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (String.IsNullOrEmpty(getFile) == true)
            {
                throw new PersyJSONException("file is a required parameter");
            }

            props.Add("file", getFile);

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("PlayEarlyMedia", props);

            return command;
        }
    }
}
