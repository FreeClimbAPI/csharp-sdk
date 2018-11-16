using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.persephony.percl;

namespace persy_cs_sdk_test
{
    [TestClass]
    public class PerCLScriptTest
    {
        private long getUnixTime()
        {
            DateTime epochStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return (DateTime.UtcNow - epochStart).Ticks * 100;
        }

        [TestMethod]
        public void MakeAddACommandToTheScriptTest()
        {
            PerCLScript script = new PerCLScript();

            int len = script.size();

            TestCommand command = new TestCommand(String.Format("COMMAND::{0}::COMMAND",getUnixTime().ToString()));

            script.Add(command);

            Assert.AreEqual(script.size(), (len + 1));
            Assert.AreEqual(script.get(len), command);
        }

        [TestMethod]
        public void MakeAddACommandToTheScriptAndConvertToJsonTest()
        {
            PerCLScript script = new PerCLScript();

            script.Add(new TestCommand("COMMAND::SIMPLE::COMMAND"));
            script.Add(new TestCommand("COMMAND::SIMPLE::COMMAND"));
            script.Add(new TestCommand("COMMAND::SIMPLE::COMMAND"));
            script.Add(new TestCommand("COMMAND::SIMPLE::COMMAND"));

            string json = script.toJson();

            Assert.AreEqual(json, "[{\"TestCommand\":{\"testField\":\"COMMAND::SIMPLE::COMMAND\"}},{\"TestCommand\":{\"testField\":\"COMMAND::SIMPLE::COMMAND\"}},{\"TestCommand\":{\"testField\":\"COMMAND::SIMPLE::COMMAND\"}},{\"TestCommand\":{\"testField\":\"COMMAND::SIMPLE::COMMAND\"}}]");
        }
    }
}
