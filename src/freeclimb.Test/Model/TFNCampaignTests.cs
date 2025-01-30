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

namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing TFNCampaign
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>

    public class TFNCampaignTests : IDisposable
    {
        private TFNCampaign instance;

        public TFNCampaignTests()
        {
            instance = new TFNCampaign(
                accountId: (string)TestHelpers.getTestValue(typeof(string)),
                campaignId: (string)TestHelpers.getTestValue(typeof(string)),
                useCase: (string)TestHelpers.getTestValue(typeof(string)),
                registrationStatus: (SMSTollFreeCampaignRegistrationStatus)
                    TestHelpers.getTestValue(typeof(SMSTollFreeCampaignRegistrationStatus)),
                dateCreated: (string)TestHelpers.getTestValue(typeof(string)),
                dateUpdated: (string)TestHelpers.getTestValue(typeof(string)),
                dateCreatedISO: (string)TestHelpers.getTestValue(typeof(string)),
                dateUpdatedISO: (string)TestHelpers.getTestValue(typeof(string)),
                revision: (int)TestHelpers.getTestValue(typeof(int))
            );
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of TFNCampaign
        /// </summary>
        [Fact]
        public void TFNCampaignInstanceTest()
        {
            Assert.IsType<TFNCampaign>(instance);
        }

        /// <summary>
        /// Test the property 'AccountId'
        /// </summary>
        [Fact]
        public void AccountIdTest()
        {
            instance.AccountId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.AccountId);
        }

        /// <summary>
        /// Test the property 'CampaignId'
        /// </summary>
        [Fact]
        public void CampaignIdTest()
        {
            instance.CampaignId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CampaignId);
        }

        /// <summary>
        /// Test the property 'UseCase'
        /// </summary>
        [Fact]
        public void UseCaseTest()
        {
            instance.UseCase = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.UseCase);
        }

        /// <summary>
        /// Test the property 'RegistrationStatus'
        /// </summary>
        [Fact]
        public void RegistrationStatusTest()
        {
            instance.RegistrationStatus = SMSTollFreeCampaignRegistrationStatus.UNREGISTERED;
            Assert.Equal(
                SMSTollFreeCampaignRegistrationStatus.UNREGISTERED,
                instance.RegistrationStatus
            );
            instance.RegistrationStatus = SMSTollFreeCampaignRegistrationStatus.INITIATED;
            Assert.Equal(
                SMSTollFreeCampaignRegistrationStatus.INITIATED,
                instance.RegistrationStatus
            );
            instance.RegistrationStatus = SMSTollFreeCampaignRegistrationStatus.PENDING;
            Assert.Equal(
                SMSTollFreeCampaignRegistrationStatus.PENDING,
                instance.RegistrationStatus
            );
            instance.RegistrationStatus = SMSTollFreeCampaignRegistrationStatus.DECLINED;
            Assert.Equal(
                SMSTollFreeCampaignRegistrationStatus.DECLINED,
                instance.RegistrationStatus
            );
            instance.RegistrationStatus = SMSTollFreeCampaignRegistrationStatus.REGISTERED;
            Assert.Equal(
                SMSTollFreeCampaignRegistrationStatus.REGISTERED,
                instance.RegistrationStatus
            );
        }

        /// <summary>
        /// Test the property 'DateCreated'
        /// </summary>
        [Fact]
        public void DateCreatedTest()
        {
            instance.DateCreated = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DateCreated);
        }

        /// <summary>
        /// Test the property 'DateUpdated'
        /// </summary>
        [Fact]
        public void DateUpdatedTest()
        {
            instance.DateUpdated = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DateUpdated);
        }

        /// <summary>
        /// Test the property 'DateCreatedISO'
        /// </summary>
        [Fact]
        public void DateCreatedISOTest()
        {
            instance.DateCreatedISO = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DateCreatedISO);
        }

        /// <summary>
        /// Test the property 'DateUpdatedISO'
        /// </summary>
        [Fact]
        public void DateUpdatedISOTest()
        {
            instance.DateUpdatedISO = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DateUpdatedISO);
        }

        /// <summary>
        /// Test the property 'Revision'
        /// </summary>
        [Fact]
        public void RevisionTest()
        {
            instance.Revision = 1;
            Assert.Equal(1, (int)instance.Revision);
        }
    }
}
