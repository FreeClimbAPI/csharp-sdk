using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.percl;

namespace freeclimb_cs_sdk_test.percl
{
    [TestClass]
    public class DequeueTest
    {
        [TestMethod]
        public void DequeueCommandToJsonTest()
        {
            Dequeue dequeue = new Dequeue();

            string json = dequeue.toJson();

            Assert.IsNotNull(json);
            Assert.AreEqual(json, "{\"Dequeue\":{}}");
        }
    }
}
