using com.persephony.api;
using Newtonsoft.Json;
using System;

namespace persy_cs_sdk_test
{
    [JsonObject]
    public class Test : PersyCommon
    {
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public static Test fromJson(string rawJson)
        {
            try
            {
                return JsonConvert.DeserializeObject<Test>(rawJson);
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
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
