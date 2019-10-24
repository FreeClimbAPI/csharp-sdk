using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using com.freeclimb.api;

namespace com.freeclimb.percl
{
    /// <summary>
    /// SendDigits PerCL command.
    /// </summary>
    [JsonObject]
    public sealed class SendDigits : PerCLCommand
    {
        [JsonProperty(PropertyName = "digits")]
        private string digits = string.Empty;

        [JsonProperty(PropertyName = "pauseMs")]
        private int pauseMs = int.MinValue;

        /// <summary>
	    /// Helper method to build a JSON string from a SendDigits instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the SendDigits instance.</returns>
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
        /// Retrieve the digits value.
        /// </summary>
        /// <returns>The digits value of the object.</returns>
        public string getDigits { get { return this.digits; } }

        /// <summary>
        /// Set the digits value.
        /// </summary>
        /// <param name="val">digits value.</param>
        /// <param name="append">Append digits to existing instance digits value.</param>
        public void setDigits(string val, bool append = false)
        {
            if (append == true)
            {
                StringBuilder sbDigits = new StringBuilder(this.digits);
                sbDigits.Append(val);

                this.digits = sbDigits.ToString();
            }
            else
            {
                this.digits = val;
            }
        }

        /// <summary>
        /// Retrieve the pauseMs value.
        /// </summary>
        /// <returns>The pauseMs value of the object.</returns>
        public int getPauseMs { get { return this.pauseMs; } }

        /// <summary>
        /// Set the pauseMs value.
        /// </summary>
        /// <param name="val">pauseMs value.</param>
        public void setPauseMs(int val) { this.pauseMs = val; }

        /// <summary>
        /// Retrieve the KVP Dictionary for the Say instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            props.Add("digits", this.digits);

            if (this.pauseMs != int.MinValue)
            {
                props.Add("pauseMs", this.pauseMs);
            }

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("SendDigits", props);

            return command;
        }
    }
}
