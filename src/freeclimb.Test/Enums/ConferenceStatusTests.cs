/*
 * FreeClimb API
 *
 * FreeClimb is a cloud-based application programming interface (API) that puts the power of the Vail platform in your hands. FreeClimb simplifies the process of creating applications that can use a full range of telephony features without requiring specialized or on-site telephony equipment. Using the FreeClimb REST API to write applications is easy! You have the option to use the language of your choice or hit the API directly. Your application can execute a command by issuing a RESTful request to the FreeClimb API. The base URL to send HTTP requests to the FreeClimb REST API is: /apiserver. FreeClimb authenticates and processes your request.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@freeclimb.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */




using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using freeclimb.Api;
using freeclimb.Model;
using freeclimb.Client;
using System.Reflection;
using Newtonsoft.Json;
using System.Globalization;
using freeclimb.Enums;


namespace freeclimb.Test.Enums
{
    /// <summary>
    ///  Class for testing ConferenceStatus
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ConferenceStatusTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ConferenceStatus
        private ConferenceStatus instance;

        public ConferenceStatusTests()
        {
            instance = ConferenceStatusInstanceValue();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConferenceStatus
        /// </summary>
        [Fact]
        public void ConferenceStatusInstanceTest()
        {
            // TODO uncomment below to test "IsType" ConferenceStatus
            Assert.IsType<ConferenceStatus>(instance);
        }


        [Fact]
        public void EnumToStringValueTest()
        {
            string expectedValue = StringValueConferenceStatusTestValue();
            string calculatedValue = Extensions.GetMemberValue(instance);
            Assert.Equal(expectedValue, calculatedValue);
        }
        [Fact]
        public void StringToEnumValueTest()
        {
            string expectedValue = StringValueConferenceStatusTestValue();
            ConferenceStatus calculatedValue = Reflection.GetEnumByValue<ConferenceStatus>(expectedValue);
            Assert.Equal(instance, calculatedValue);
        }
        private ConferenceStatus ConferenceStatusInstanceValue()
        {
            return Reflection.GetEnumByValue<ConferenceStatus>(StringValueConferenceStatusTestValue());
        }
        private string StringValueAccountStatusTestValue()
        {
            return "active";
        }
        private string StringValueAccountTypeTestValue()
        {
            return "trial";
        }
        private string StringValueAnsweredByTestValue()
        {
            return "human";
        }
        private string StringValueCallDirectionTestValue()
        {
            return "inbound";
        }
        private string StringValueCallStatusTestValue()
        {
            return "queued";
        }
        private string StringValueConferenceStatusTestValue()
        {
            return "populated";
        }
        private string StringValueGetSpeechReasonTestValue()
        {
            return "digit";
        }
        private string StringValueGrammarFileBuiltInTestValue()
        {
            return "ALPHNUM6";
        }
        private string StringValueGrammarTypeTestValue()
        {
            return "URL";
        }
        private string StringValueIfMachineTestValue()
        {
            return "redirect";
        }
        private string StringValueLanguageTestValue()
        {
            return "ca-ES";
        }
        private string StringValueLogLevelTestValue()
        {
            return "info";
        }
        private string StringValueMachineTypeTestValue()
        {
            return "answeringMachine";
        }
        private string StringValueMessageDirectionTestValue()
        {
            return "inbound";
        }
        private string StringValueMessageStatusTestValue()
        {
            return "new";
        }
        private string StringValuePlayBeepTestValue()
        {
            return "always";
        }
        private string StringValueQueueResultStatusTestValue()
        {
            return "queueFull";
        }
        private string StringValueRecordUtteranceTermReasonTestValue()
        {
            return "finishKey";
        }
        private string StringValueRequestTypeTestValue()
        {
            return "inboundCall";
        }
        private string StringValueUpdateCallRequestStatusTestValue()
        {
            return "completed";
        }
        private string StringValueUpdateConferenceRequestStatusTestValue()
        {
            return "empty";
        }
    }
}
