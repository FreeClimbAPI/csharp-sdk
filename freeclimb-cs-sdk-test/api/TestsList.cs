using com.freeclimb.api;
using Newtonsoft.Json;
using System;

namespace freeclimb_cs_sdk_test
{
    public class TestsList : FreeClimbList
    {
        public TestsList(String accountId, String apiKey, String rawPage) : base(accountId, apiKey, rawPage, "tests")
        { }

        public new Test get(int i)
        {
            return (Test)(base.get(i));
        }

        public new void buildFromJson(string rawPage)
        {
            base.buildFromJson(rawPage);
        }

        protected override IFreeClimbCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Test>(element);
        }


}
}
