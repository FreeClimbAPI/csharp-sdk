using com.freeclimb.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

[assembly: InternalsVisibleTo("freeclimb-cs-sdk-test")]
namespace com.freeclimb.api.phonenumber
{
    [JsonObject]
    internal class NewIncomingPhoneNumber : IncomingPhoneNumberOptions
    {
        [JsonProperty(PropertyName = "phoneNumber")]
        private string phoneNumber = string.Empty;

        public NewIncomingPhoneNumber(string phoneNumber, IncomingPhoneNumberOptions options) : base()
        {
            if (options != null)
            {
                this.setAlias(options.getAlias);
                this.setApplicationId(options.getApplicationId);
            }
            this.phoneNumber = phoneNumber;
        }

        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static new NewIncomingPhoneNumber fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<NewIncomingPhoneNumber>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
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
                throw new FreeClimbJSONException(e.Message);
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

            if (string.IsNullOrEmpty(getApplicationId) == false)
            {
                props.Add("applicationId", getApplicationId);
            }
            props.Add("phoneNumber", getPhoneNumber);
            return props;
        }
    }
}
