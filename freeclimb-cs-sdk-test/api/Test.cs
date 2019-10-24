using com.freeclimb.api;
using Newtonsoft.Json;
using System;

namespace freeclimb_cs_sdk_test
{
    [JsonObject]
    public class Test : FreeClimbCommon
    {
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public static Test fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Test>(rawJson);
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }


        [JsonProperty(PropertyName = "testValue")]
        public string testValue { get; set; }

        public string toString()
        {
            return "!!!atESToBJECT:::" + this.getUri + "!!!" + this.testValue + "!!!";
        }
    }
}
