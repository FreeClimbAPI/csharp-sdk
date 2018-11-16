using com.persephony.api;
using Newtonsoft.Json;
using System;

namespace persy_cs_sdk_test
{
    public class TestsList : PersyList
    {
        public TestsList(String accountId, String authToken, String rawPage) : base(accountId, authToken, rawPage, "tests")
        { }

        public new Test get(int i)
        {
            return (Test)(base.get(i));
        }

        public new void buildFromJson(string rawPage)
        {
            base.buildFromJson(rawPage);
        }

        protected override IPersyCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Test>(element);
        }


}
}
