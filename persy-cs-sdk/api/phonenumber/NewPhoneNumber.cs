using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

[assembly: InternalsVisibleTo("persy-cs-sdk-test")]
namespace com.persephony.api.phonenumber
{
    [JsonObject]
    internal class NewCallingNumber : CallingNumberOptions
    {
        [JsonProperty(PropertyName = "phoneNumber")]
        private string phoneNumber = string.Empty;

        public NewCallingNumber(string phoneNumber, CallingNumberOptions options) : base()
        {
            if (options != null)
            {
                this.setAlias(options.getAlias);
            }
            this.phoneNumber = phoneNumber;
        }

        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static new NewCallingNumber fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<NewCallingNumber>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }

        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public override string toJson()
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

        public string getPhoneNumber { get { return this.phoneNumber; } }


        private new IDictionary<string, object> toDict() 
        {
            // change all properties with settings to a dictionary. Start off with optional params. Then add the required phoneNumber
            IDictionary<string, object> props = new Dictionary<string, object>();
            if (string.IsNullOrEmpty(getAlias) == false)
            {
                props.Add("alias", getAlias);
            }

            props.Add("phoneNumber", getPhoneNumber);
            return props;
        }
    }
}
