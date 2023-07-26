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
    ///  Class for testing CreateConference
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateConferenceTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateConference
        private CreateConference instance;

        public CreateConferenceTests()
        {
            instance = new CreateConference("https://a.com");
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateConference
        /// </summary>
        [Fact]
        public void CreateConferenceInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateConference
            Assert.IsType<CreateConference>(instance);
        }


        /// <summary>
        /// Test the property 'ActionUrl'
        /// </summary>
        [Fact]
        public void ActionUrlTest()
        {
            
            try {
                Uri uri = new Uri("https://a.com");
                instance.ActionUrl = uri.ToString();
                Assert.Equal(uri.ToString(), instance.ActionUrl);
            } catch (Exception ) {
                Console.WriteLine("Something went wrong.");
            }
        }
        /// <summary>
        /// Test the property 'Alias'
        /// </summary>
        [Fact]
        public void AliasTest()
        {
            instance.Alias = false;
            Assert.Equal(false, instance.Alias);       
            
        }
        /// <summary>
        /// Test the property 'PlayBeep'
        /// </summary>
        [Fact]
        public void PlayBeepTest()
        {
            //model.setPlayBeep(PlayBeep.ALWAYS);
            //Assert.assertEquals(model.getPlayBeep(),PlayBeep.ALWAYS);
            //model.setPlayBeep(PlayBeep.NEVER);
            //Assert.assertEquals(model.getPlayBeep(),PlayBeep.NEVER);
            //model.setPlayBeep(PlayBeep.ENTRY_ONLY);
            //Assert.assertEquals(model.getPlayBeep(),PlayBeep.ENTRY_ONLY);
            //model.setPlayBeep(PlayBeep.EXIT_ONLY);
            //Assert.assertEquals(model.getPlayBeep(),PlayBeep.EXIT_ONLY);
            
            //model.setPlayBeep(CreateConference.PlayBeep.ALWAYS);
            //Assert.assertEquals(model.getPlayBeep(),CreateConference.PlayBeep.ALWAYS);
            
            //model.setPlayBeep(CreateConference.PlayBeep.NEVER);
            //Assert.assertEquals(model.getPlayBeep(),CreateConference.PlayBeep.NEVER);
            
            //model.setPlayBeep(CreateConference.PlayBeep.ENTRY_ONLY);
            //Assert.assertEquals(model.getPlayBeep(),CreateConference.PlayBeep.ENTRY_ONLY);
            
            //model.setPlayBeep(CreateConference.PlayBeep.EXIT_ONLY);
            //Assert.assertEquals(model.getPlayBeep(),CreateConference.PlayBeep.EXIT_ONLY);
            
        }
        /// <summary>
        /// Test the property 'Record'
        /// </summary>
        [Fact]
        public void RecordTest()
        {
            instance.Record = false;
            Assert.Equal(false, instance.Record);       
            
        }
        /// <summary>
        /// Test the property 'StatusCallbackUrl'
        /// </summary>
        [Fact]
        public void StatusCallbackUrlTest()
        {
            instance.StatusCallbackUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.StatusCallbackUrl);
            
        }
        /// <summary>
        /// Test the property 'WaitUrl'
        /// </summary>
        [Fact]
        public void WaitUrlTest()
        {
            instance.WaitUrl = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.WaitUrl);
            
        }
    }
}
