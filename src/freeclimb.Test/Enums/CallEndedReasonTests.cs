/*
 * FreeClimb API
 *
 * FreeClimb is a cloud-based application programming interface (API) that puts the power of the Vail platform in your hands. FreeClimb simplifies the process of creating applications that can use a full range of telephony features without requiring specialized or on-site telephony equipment. Using the FreeClimb REST API to write applications is easy! You have the option to use the language of your choice or hit the API directly. Your application can execute a command by issuing a RESTful request to the FreeClimb API. The base URL to send HTTP requests to the FreeClimb REST API is: /apiserver. FreeClimb authenticates and processes your request.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@freeclimb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using freeclimb.Client;
using freeclimb.Enums;
using freeclimb.Model;
using freeclimb.Test;
using Newtonsoft.Json;
using Xunit;

namespace freeclimb.Test.Enums
{
    /// <summary>
    ///  Class for testing CallEndedReason
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class CallEndedReasonTests : IDisposable
    {
        private CallEndedReason instance;

        public CallEndedReasonTests()
        {
            instance = new CallEndedReason();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CallEndedReason
        /// </summary>
        [Fact]
        public void CallEndedReasonInstanceTest()
        {
            Assert.IsType<CallEndedReason>(instance);
        }

        [Fact]
        public void TestBUSYShouldWork()
        {
            CallEndedReason test = CallEndedReason.BUSY;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestBUSYShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.BUSY;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "BUSY");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestBUSYShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.BUSY;
            string expectedValue = "BUSY";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFAILEDShouldWork()
        {
            CallEndedReason test = CallEndedReason.FAILED;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestFAILEDShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.FAILED;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "FAILED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFAILEDShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.FAILED;
            string expectedValue = "FAILED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestNO_ANSWERShouldWork()
        {
            CallEndedReason test = CallEndedReason.NO_ANSWER;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestNO_ANSWERShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.NO_ANSWER;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "NO_ANSWER");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestNO_ANSWERShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.NO_ANSWER;
            string expectedValue = "NO_ANSWER";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCALL_CANCELEDShouldWork()
        {
            CallEndedReason test = CallEndedReason.CALL_CANCELED;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestCALL_CANCELEDShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.CALL_CANCELED;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "CALL_CANCELED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCALL_CANCELEDShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.CALL_CANCELED;
            string expectedValue = "CALL_CANCELED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFAR_END_HANGUPShouldWork()
        {
            CallEndedReason test = CallEndedReason.FAR_END_HANGUP;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestFAR_END_HANGUPShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.FAR_END_HANGUP;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "FAR_END_HANGUP");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestFAR_END_HANGUPShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.FAR_END_HANGUP;
            string expectedValue = "FAR_END_HANGUP";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestAPP_HANGUPShouldWork()
        {
            CallEndedReason test = CallEndedReason.APP_HANGUP;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestAPP_HANGUPShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.APP_HANGUP;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "APP_HANGUP");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestAPP_HANGUPShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.APP_HANGUP;
            string expectedValue = "APP_HANGUP";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestAPP_REJECTShouldWork()
        {
            CallEndedReason test = CallEndedReason.APP_REJECT;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestAPP_REJECTShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.APP_REJECT;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "APP_REJECT");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestAPP_REJECTShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.APP_REJECT;
            string expectedValue = "APP_REJECT";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestAPP_NO_PERCLShouldWork()
        {
            CallEndedReason test = CallEndedReason.APP_NO_PERCL;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestAPP_NO_PERCLShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.APP_NO_PERCL;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "APP_NO_PERCL");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestAPP_NO_PERCLShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.APP_NO_PERCL;
            string expectedValue = "APP_NO_PERCL";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestAPP_INVALID_PERCLShouldWork()
        {
            CallEndedReason test = CallEndedReason.APP_INVALID_PERCL;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestAPP_INVALID_PERCLShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.APP_INVALID_PERCL;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "APP_INVALID_PERCL");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestAPP_INVALID_PERCLShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.APP_INVALID_PERCL;
            string expectedValue = "APP_INVALID_PERCL";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCONFERENCE_TERMINATEDShouldWork()
        {
            CallEndedReason test = CallEndedReason.CONFERENCE_TERMINATED;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestCONFERENCE_TERMINATEDShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.CONFERENCE_TERMINATED;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "CONFERENCE_TERMINATED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCONFERENCE_TERMINATEDShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.CONFERENCE_TERMINATED;
            string expectedValue = "CONFERENCE_TERMINATED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCONFERENCE_EMPTIEDShouldWork()
        {
            CallEndedReason test = CallEndedReason.CONFERENCE_EMPTIED;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestCONFERENCE_EMPTIEDShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.CONFERENCE_EMPTIED;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "CONFERENCE_EMPTIED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCONFERENCE_EMPTIEDShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.CONFERENCE_EMPTIED;
            string expectedValue = "CONFERENCE_EMPTIED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestREMOVED_FROM_CONFERENCEShouldWork()
        {
            CallEndedReason test = CallEndedReason.REMOVED_FROM_CONFERENCE;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestREMOVED_FROM_CONFERENCEShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.REMOVED_FROM_CONFERENCE;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "REMOVED_FROM_CONFERENCE");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestREMOVED_FROM_CONFERENCEShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.REMOVED_FROM_CONFERENCE;
            string expectedValue = "REMOVED_FROM_CONFERENCE";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestMACHINE_DETECTEDShouldWork()
        {
            CallEndedReason test = CallEndedReason.MACHINE_DETECTED;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestMACHINE_DETECTEDShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.MACHINE_DETECTED;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "MACHINE_DETECTED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestMACHINE_DETECTEDShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.MACHINE_DETECTED;
            string expectedValue = "MACHINE_DETECTED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestWEBHOOK_FAILEDShouldWork()
        {
            CallEndedReason test = CallEndedReason.WEBHOOK_FAILED;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestWEBHOOK_FAILEDShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.WEBHOOK_FAILED;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "WEBHOOK_FAILED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestWEBHOOK_FAILEDShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.WEBHOOK_FAILED;
            string expectedValue = "WEBHOOK_FAILED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestWEBHOOK_INVALID_RESPONSEShouldWork()
        {
            CallEndedReason test = CallEndedReason.WEBHOOK_INVALID_RESPONSE;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestWEBHOOK_INVALID_RESPONSEShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.WEBHOOK_INVALID_RESPONSE;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "WEBHOOK_INVALID_RESPONSE");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestWEBHOOK_INVALID_RESPONSEShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.WEBHOOK_INVALID_RESPONSE;
            string expectedValue = "WEBHOOK_INVALID_RESPONSE";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestVOICE_DISABLEDShouldWork()
        {
            CallEndedReason test = CallEndedReason.VOICE_DISABLED;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestVOICE_DISABLEDShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.VOICE_DISABLED;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "VOICE_DISABLED");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestVOICE_DISABLEDShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.VOICE_DISABLED;
            string expectedValue = "VOICE_DISABLED";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCONFIG_ERROR_NO_APPLICATIONShouldWork()
        {
            CallEndedReason test = CallEndedReason.CONFIG_ERROR_NO_APPLICATION;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestCONFIG_ERROR_NO_APPLICATIONShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.CONFIG_ERROR_NO_APPLICATION;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "CONFIG_ERROR_NO_APPLICATION");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCONFIG_ERROR_NO_APPLICATIONShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.CONFIG_ERROR_NO_APPLICATION;
            string expectedValue = "CONFIG_ERROR_NO_APPLICATION";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCONFIG_ERROR_NO_VOICE_URLShouldWork()
        {
            CallEndedReason test = CallEndedReason.CONFIG_ERROR_NO_VOICE_URL;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestCONFIG_ERROR_NO_VOICE_URLShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.CONFIG_ERROR_NO_VOICE_URL;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "CONFIG_ERROR_NO_VOICE_URL");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestCONFIG_ERROR_NO_VOICE_URLShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.CONFIG_ERROR_NO_VOICE_URL;
            string expectedValue = "CONFIG_ERROR_NO_VOICE_URL";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestMAX_REDIRECTS_ERRORShouldWork()
        {
            CallEndedReason test = CallEndedReason.MAX_REDIRECTS_ERROR;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestMAX_REDIRECTS_ERRORShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.MAX_REDIRECTS_ERROR;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "MAX_REDIRECTS_ERROR");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestMAX_REDIRECTS_ERRORShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.MAX_REDIRECTS_ERROR;
            string expectedValue = "MAX_REDIRECTS_ERROR";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPERCL_PROCESSING_ERRORShouldWork()
        {
            CallEndedReason test = CallEndedReason.PERCL_PROCESSING_ERROR;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestPERCL_PROCESSING_ERRORShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.PERCL_PROCESSING_ERROR;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "PERCL_PROCESSING_ERROR");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestPERCL_PROCESSING_ERRORShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.PERCL_PROCESSING_ERROR;
            string expectedValue = "PERCL_PROCESSING_ERROR";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestINTERNAL_ERRORShouldWork()
        {
            CallEndedReason test = CallEndedReason.INTERNAL_ERROR;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestINTERNAL_ERRORShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.INTERNAL_ERROR;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "INTERNAL_ERROR");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestINTERNAL_ERRORShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.INTERNAL_ERROR;
            string expectedValue = "INTERNAL_ERROR";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestGRPC_HANGUPShouldWork()
        {
            CallEndedReason test = CallEndedReason.GRPC_HANGUP;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestGRPC_HANGUPShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.GRPC_HANGUP;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "GRPC_HANGUP");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestGRPC_HANGUPShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.GRPC_HANGUP;
            string expectedValue = "GRPC_HANGUP";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestMAX_DURATIONShouldWork()
        {
            CallEndedReason test = CallEndedReason.MAX_DURATION;
            Assert.Equal(typeof(CallEndedReason), test.GetType());
        }

        [Fact]
        public void TestMAX_DURATIONShouldSerializeToEnum()
        {
            CallEndedReason expectedValue = CallEndedReason.MAX_DURATION;
            CallEndedReason calculatedValue = (CallEndedReason)
                Enum.Parse(typeof(CallEndedReason), "MAX_DURATION");
            Assert.Equal(expectedValue, calculatedValue);
        }

        [Fact]
        public void TestMAX_DURATIONShouldDeserializeToString()
        {
            CallEndedReason test = CallEndedReason.MAX_DURATION;
            string expectedValue = "MAX_DURATION";
            string calculatedValue = test.ToString();
            Assert.Equal(expectedValue, calculatedValue);
        }
    }
}
