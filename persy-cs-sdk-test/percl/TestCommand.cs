using com.persephony.api;
using com.persephony.percl;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace persy_cs_sdk_test
{
    [JsonObject]
    public class TestCommand : PerCLCommand
    {
        [JsonProperty(PropertyName = "testField")]
        public string testField { get; set; }

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

public TestCommand(string testField)
        {
            this.testField = testField;
        }

        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();
            props.Add("testField", this.testField);

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("TestCommand", props);

            return command;
        }
    }
}
