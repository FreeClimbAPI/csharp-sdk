using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class StartRecordCallTest
    {
        [TestMethod]
        public void RecordCallCommandToJsonTest()
        {
            StartRecordCall recordCall = new StartRecordCall();

            string json = recordCall.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"StartRecordCall\":{}}");
        }
    }
}
