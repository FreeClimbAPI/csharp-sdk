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

namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing PerclScript
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PerclScriptTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PerclScript
        //private PerclScript instance;

        public PerclScriptTests()
        {
            // TODO uncomment below to create an instance of PerclScript
            //instance = new PerclScript();
            PerclScript getSpeechScript = new PerclScript();
            GetSpeech getSpeech = new GetSpeech("www.test.com", 0, "grammar.xml");
            Say sayHello = new Say("Hello, Freeclimb");
            Say sayFoo = new Say("Foo you");
            List<PerclCommand> getSpeechCommands = new List<PerclCommand>();
            getSpeechCommands.Add(sayHello);
            getSpeechCommands.Add(sayFoo);
            getSpeech.Prompts = getSpeechCommands;
            List<PerclCommand> commands = new List<PerclCommand>();
            commands.Add(getSpeech);
            getSpeechScript.Commands = commands;
            Console.WriteLine(getSpeechScript.ToJson());
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
            // TODO uncomment below to test "IsType" PerclScript
            //Assert.IsType<PerclScript>(instance);
        }


        /// <summary>
        /// Test the property 'Commands'
        /// </summary>
        [Fact]
        public void CommandsTest()
        {
            // TODO unit test for the property 'Commands'
        }

    }

}
