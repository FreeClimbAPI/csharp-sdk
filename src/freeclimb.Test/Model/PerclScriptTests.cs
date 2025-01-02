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
using Newtonsoft.Json;
using Xunit;

namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing PerclScript
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PerclScriptTemplateTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PerclScript
        private PerclScript instance;

        public PerclScriptTemplateTests()
        {
            instance = new PerclScript();
            CreateConference create = new CreateConference(
                "",
                false,
                PlayBeep.ALWAYS,
                false,
                "",
                ""
            );
            List<PerclCommand> commands = new List<PerclCommand>();
            commands.Add(create);
            instance = new PerclScript(commands);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PerclScript
        /// </summary>
        [Fact]
        public void PerclScriptInstanceTest()
        {
            Assert.IsType<PerclScript>(instance);
        }

        /// <summary>
        /// Test the property 'PerclScript'
        /// </summary>
        [Fact]
        public void CommandsTest()
        {
            // TODO unit test for the property 'Commands'
            string actualJSONString = instance.ToJson();
            string expectedJSONString =
                "[{\"CreateConference\":{\"actionUrl\":\"\",\"alias\":false,\"playBeep\":\"always\",\"record\":false,\"statusCallbackUrl\":\"\",\"waitUrl\":\"\"}}]";
            Assert.Equal(expectedJSONString, actualJSONString);
        }
    }
}
