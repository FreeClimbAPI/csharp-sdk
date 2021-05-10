using Microsoft.VisualStudio.TestTools.UnitTesting;
using com.freeclimb.api;
using System.Reflection;
using System;
using System.Net;
using System.Collections.Generic;

namespace freeclimb_cs_sdk_test
{
    [TestClass]
    public class APIRequesterTest
    {
        [TestMethod]
        public void MakeADefaultAPIRequesterTest()
        {
            try
            {
                TestRequester req = new TestRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");

                Assert.AreEqual(req.getAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
                Assert.AreEqual(req.getApiKey, "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeAnAPIRequesterTest()
        {
            try
            {
                TestRequester req = new TestRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");
                req.setfreeClimbUrl("http://freeclimb.com");

                Assert.AreEqual(req.getAccountId, "AC736ca2078721a9a41fb47f07bf40d9e21cb304da");
                Assert.AreEqual(req.getApiKey, "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");
                Assert.AreEqual(req.getfreeClimbUrl, "http://freeclimb.com");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeASuccessfulGETRequestNoQueryStringTest()
        {
            try
            {

                TestRequester testRequester = new TestRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(testRequester, "http://MakeASuccessfulGETRequestNoQueryStringTest:3000");
                }

                WebRequest.RegisterPrefix("http://MakeASuccessfulGETRequestNoQueryStringTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"value\":\"EXAMPLE\"}");

                string result = testRequester.GET("/getSuccess");
                Assert.AreEqual(result, "{\"value\":\"EXAMPLE\"}");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeASuccessfulGETRequestQueryStringTest()
        {
            try
            {
                TestRequester testRequester = new TestRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(testRequester, "http://MakeASuccessfulGETRequestQueryStringTest:3000");
                }

                WebRequest.RegisterPrefix("http://MakeASuccessfulGETRequestQueryStringTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"value\":\"EXAMPLE\"}");

                Dictionary<String, String> realQuery = new Dictionary<String, String>();
                realQuery.Add("a", "1");
                realQuery.Add("b", "2");
                realQuery.Add("c", "3");

                string result = testRequester.GET("/getSuccess", realQuery);
                Assert.AreEqual(result, "{\"value\":\"EXAMPLE\"}");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeAUnSuccessfulGETRequestQueryStringTest()
        {
            try
            {
                TestRequester testRequester = new TestRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(testRequester, "http://MakeAUnSuccessfulGETRequestQueryStringTest:3000");
                }

                WebRequest.RegisterPrefix("http://MakeAUnSuccessfulGETRequestQueryStringTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.BadRequest);

                Dictionary<String, String> realQuery = new Dictionary<String, String>();
                realQuery.Add("a", "1");
                realQuery.Add("b", "2");
                realQuery.Add("c", "3");

                string result = testRequester.GET("/getSuccessFail", realQuery);
                Assert.Fail("Excepection should have been thrown");
            }
            catch (FreeClimbErrorResponseException pe)
            {
                Assert.IsNotNull(pe.getError);
                Assert.AreEqual(pe.getError.getStatus, 400);
                Assert.AreEqual(pe.getError.getMessage, "BadRequest");
            }
        }

        [TestMethod]
        public void MakeASuccessfulPOSTRequestTest()
        {
            try
            {
                TestRequester testRequester = new TestRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(testRequester, "http://MakeASuccessfulPOSTRequestTest:3000");
                }

                WebRequest.RegisterPrefix("http://MakeASuccessfulPOSTRequestTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK,
                                                                             "{\"value\":\"EXAMPLE\"}");

                string result = testRequester.POST("/postSuccess", "{ }");
                Assert.AreEqual(result, "{\"value\":\"EXAMPLE\"}");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeAUnSuccessfulPOSTRequestTest()
        {
            try
            {
                TestRequester testRequester = new TestRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(testRequester, "http://MakeAUnSuccessfulPOSTRequestTest:3000");
                }

                WebRequest.RegisterPrefix("http://MakeAUnSuccessfulPOSTRequestTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.BadRequest);

                string result = testRequester.POST("/postSuccessFail", "{ }");
                Assert.Fail("Excepection should have been thrown");
            }
            catch (FreeClimbErrorResponseException pe)
            {
                Assert.IsNotNull(pe.getError);
                Assert.AreEqual(pe.getError.getStatus, 400);
                Assert.AreEqual(pe.getError.getMessage, "BadRequest");
            }
        }

        [TestMethod]
        public void MakeASuccessfulDELETERequestTest()
        {
            try
            {
                TestRequester testRequester = new TestRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(testRequester, "http://MakeASuccessfulDELETERequestTest:3000");
                }

                WebRequest.RegisterPrefix("http://MakeASuccessfulDELETERequestTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.OK);

                testRequester.DELETE("/deleteSuccess");
            }
            catch (FreeClimbException pe)
            {
                Assert.Fail(pe.Message);
            }
        }

        [TestMethod]
        public void MakeAUnSuccessfulDELETERequestTest()
        {
            try
            {
                TestRequester testRequester = new TestRequester("AC736ca2078721a9a41fb47f07bf40d9e21cb304da", "8e3d1c1c519fc761856f8cc825bcfea94d8c58b5");

                Type type = typeof(APIRequester);
                FieldInfo fieldInfo = type.GetField("freeClimbUrl", BindingFlags.NonPublic | BindingFlags.Instance);
                if (fieldInfo != null)
                {
                    fieldInfo.SetValue(testRequester, "http://MakeAUnSuccessfulDELETERequestTest:3000");
                }

                WebRequest.RegisterPrefix("http://MakeAUnSuccessfulDELETERequestTest:3000", new TestWebRequestCreate());

                TestWebRequestCreate.MockHttpWebRequestWithGivenResponseCode(HttpStatusCode.BadRequest);

                testRequester.DELETE("/deleteSuccessFail");
                Assert.Fail("Excepection should have been thrown");
            }
            catch (FreeClimbErrorResponseException pe)
            {
                Assert.IsNotNull(pe.getError);
                Assert.AreEqual(pe.getError.getStatus, 400);
                Assert.AreEqual(pe.getError.getMessage, "BadRequest");
            }
        }
    }
}
