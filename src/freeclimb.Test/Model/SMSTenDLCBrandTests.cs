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


namespace freeclimb.Test.Model
{
    /// <summary>
    ///  Class for testing SMSTenDLCBrand
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class SMSTenDLCBrandTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for SMSTenDLCBrand
        private SMSTenDLCBrand instance;

        public SMSTenDLCBrandTests()
        {
            string jsonData = @"
            {
                ""accountId"":""TEST_STRING"",
                ""entityType"":""PRIVATE_PROFIT"",
                ""cspId"": ""TEST_STRING"",
                ""brandId"": ""TEST_STRING"",
                ""universalEin"": ""TEST_STRING"",
                ""brandRelationship"":""BASIC_ACCOUNT"",
                ""identityStatus"":""SELF_DECLARED"",
                ""displayName"":""TEST_STRING"",
                ""phone"":""TEST_STRING"",
                ""country"":""TEST_STRING"",
                ""email"":""TEST_STRING"",
                ""vertical"":""TEST_STRING"",
                ""mock"":""false"",
            }
            ";
            instance = JsonConvert.DeserializeObject<SMSTenDLCBrand>(jsonData);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SMSTenDLCBrand
        /// </summary>
        [Fact]
        public void SMSTenDLCBrandInstanceTest()
        {
            // TODO uncomment below to test "IsType" SMSTenDLCBrand
            Assert.IsType<SMSTenDLCBrand>(instance);
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
        /// Test the property 'EntityType'
        /// </summary>
        [Fact]
        public void EntityTypeTest()
        {
            
            instance.EntityType = SMSTenDLCBrand.EntityTypeEnum.PRIVATE_PROFIT;
            Assert.Equal(instance.EntityType,SMSTenDLCBrand.EntityTypeEnum.PRIVATE_PROFIT);
            
            instance.EntityType = SMSTenDLCBrand.EntityTypeEnum.PUBLIC_PROFIT;
            Assert.Equal(instance.EntityType,SMSTenDLCBrand.EntityTypeEnum.PUBLIC_PROFIT);
            
            instance.EntityType = SMSTenDLCBrand.EntityTypeEnum.NON_PROFIT;
            Assert.Equal(instance.EntityType,SMSTenDLCBrand.EntityTypeEnum.NON_PROFIT);
            
            instance.EntityType = SMSTenDLCBrand.EntityTypeEnum.GOVERNMENT;
            Assert.Equal(instance.EntityType,SMSTenDLCBrand.EntityTypeEnum.GOVERNMENT);
            
            instance.EntityType = SMSTenDLCBrand.EntityTypeEnum.SOLE_PROPRIETOR;
            Assert.Equal(instance.EntityType,SMSTenDLCBrand.EntityTypeEnum.SOLE_PROPRIETOR);
            
        }
        /// <summary>
        /// Test the property 'CspId'
        /// </summary>
        [Fact]
        public void CspIdTest()
        {

            Assert.Equal("TEST_STRING", instance.CspId);
            
        }
        /// <summary>
        /// Test the property 'BrandId'
        /// </summary>
        [Fact]
        public void BrandIdTest()
        {

            Assert.Equal("TEST_STRING", instance.BrandId);
            
        }
        /// <summary>
        /// Test the property 'FirstName'
        /// </summary>
        [Fact]
        public void FirstNameTest()
        {
            instance.FirstName = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.FirstName);
            
        }
        /// <summary>
        /// Test the property 'LastName'
        /// </summary>
        [Fact]
        public void LastNameTest()
        {
            instance.LastName = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.LastName);
            
        }
        /// <summary>
        /// Test the property 'DisplayName'
        /// </summary>
        [Fact]
        public void DisplayNameTest()
        {
            instance.DisplayName = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.DisplayName);
            
        }
        /// <summary>
        /// Test the property 'CompanyName'
        /// </summary>
        [Fact]
        public void CompanyNameTest()
        {
            instance.CompanyName = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.CompanyName);
            
        }
        /// <summary>
        /// Test the property 'Ein'
        /// </summary>
        [Fact]
        public void EinTest()
        {
            instance.Ein = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Ein);
            
        }
        /// <summary>
        /// Test the property 'EinIssuingCountry'
        /// </summary>
        [Fact]
        public void EinIssuingCountryTest()
        {
            instance.EinIssuingCountry = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.EinIssuingCountry);
            
        }
        /// <summary>
        /// Test the property 'Phone'
        /// </summary>
        [Fact]
        public void PhoneTest()
        {
            instance.Phone = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Phone);
            
        }
        /// <summary>
        /// Test the property 'Street'
        /// </summary>
        [Fact]
        public void StreetTest()
        {
            instance.Street = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Street);
            
        }
        /// <summary>
        /// Test the property 'City'
        /// </summary>
        [Fact]
        public void CityTest()
        {
            instance.City = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.City);
            
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Fact]
        public void StateTest()
        {
            instance.State = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.State);
            
        }
        /// <summary>
        /// Test the property 'PostalCode'
        /// </summary>
        [Fact]
        public void PostalCodeTest()
        {
            instance.PostalCode = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.PostalCode);
            
        }
        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            instance.Country = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Country);
            
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            instance.Email = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Email);
            
        }
        /// <summary>
        /// Test the property 'StockSymbol'
        /// </summary>
        [Fact]
        public void StockSymbolTest()
        {
            instance.StockSymbol = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.StockSymbol);
            
        }
        /// <summary>
        /// Test the property 'StockExchange'
        /// </summary>
        [Fact]
        public void StockExchangeTest()
        {
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.NONE;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.NONE);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.NASDAQ;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.NASDAQ);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.NYSE;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.NYSE);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.AMEX;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.AMEX);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.AMX;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.AMX);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.ASX;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.ASX);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.B3;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.B3);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.BME;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.BME);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.BSE;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.BSE);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.FRA;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.FRA);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.ICEX;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.ICEX);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.JPX;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.JPX);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.JSE;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.JSE);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.KRX;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.KRX);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.LON;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.LON);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.NSE;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.NSE);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.OMX;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.OMX);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.SEHK;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.SEHK);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.SGX;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.SGX);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.SSE;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.SSE);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.STO;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.STO);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.SWX;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.SWX);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.SZSE;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.SZSE);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.TSX;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.TSX);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.TWSE;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.TWSE);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.VSE;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.VSE);
            
            instance.StockExchange = SMSTenDLCBrand.StockExchangeEnum.OTHER;
            Assert.Equal(instance.StockExchange,SMSTenDLCBrand.StockExchangeEnum.OTHER);
            
        }
        /// <summary>
        /// Test the property 'IpAddress'
        /// </summary>
        [Fact]
        public void IpAddressTest()
        {
            instance.IpAddress = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.IpAddress);
            
        }
        /// <summary>
        /// Test the property 'Website'
        /// </summary>
        [Fact]
        public void WebsiteTest()
        {
            instance.Website = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Website);
            
        }
        /// <summary>
        /// Test the property 'BrandRelationship'
        /// </summary>
        [Fact]
        public void BrandRelationshipTest()
        {
            
            instance.BrandRelationship = SMSTenDLCBrand.BrandRelationshipEnum.BASIC_ACCOUNT;
            Assert.Equal(instance.BrandRelationship,SMSTenDLCBrand.BrandRelationshipEnum.BASIC_ACCOUNT);
            
            instance.BrandRelationship = SMSTenDLCBrand.BrandRelationshipEnum.SMALL_ACCOUNT;
            Assert.Equal(instance.BrandRelationship,SMSTenDLCBrand.BrandRelationshipEnum.SMALL_ACCOUNT);
            
            instance.BrandRelationship = SMSTenDLCBrand.BrandRelationshipEnum.MEDIUM_ACCOUNT;
            Assert.Equal(instance.BrandRelationship,SMSTenDLCBrand.BrandRelationshipEnum.MEDIUM_ACCOUNT);
            
            instance.BrandRelationship = SMSTenDLCBrand.BrandRelationshipEnum.LARGE_ACCOUNT;
            Assert.Equal(instance.BrandRelationship,SMSTenDLCBrand.BrandRelationshipEnum.LARGE_ACCOUNT);
            
            instance.BrandRelationship = SMSTenDLCBrand.BrandRelationshipEnum.KEY_ACCOUNT;
            Assert.Equal(instance.BrandRelationship,SMSTenDLCBrand.BrandRelationshipEnum.KEY_ACCOUNT);
            
        }
        /// <summary>
        /// Test the property 'Vertical'
        /// </summary>
        [Fact]
        public void VerticalTest()
        {
            instance.Vertical = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.Vertical);
            
        }
        /// <summary>
        /// Test the property 'AltBusinessId'
        /// </summary>
        [Fact]
        public void AltBusinessIdTest()
        {
            instance.AltBusinessId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.AltBusinessId);
            
        }
        /// <summary>
        /// Test the property 'AltBusinessIdType'
        /// </summary>
        [Fact]
        public void AltBusinessIdTypeTest()
        {
            
            instance.AltBusinessIdType = SMSTenDLCBrand.AltBusinessIdTypeEnum.NONE;
            Assert.Equal(instance.AltBusinessIdType,SMSTenDLCBrand.AltBusinessIdTypeEnum.NONE);
            
            instance.AltBusinessIdType = SMSTenDLCBrand.AltBusinessIdTypeEnum.DUNS;
            Assert.Equal(instance.AltBusinessIdType,SMSTenDLCBrand.AltBusinessIdTypeEnum.DUNS);
            
            instance.AltBusinessIdType = SMSTenDLCBrand.AltBusinessIdTypeEnum.GIIN;
            Assert.Equal(instance.AltBusinessIdType,SMSTenDLCBrand.AltBusinessIdTypeEnum.GIIN);
            
            instance.AltBusinessIdType = SMSTenDLCBrand.AltBusinessIdTypeEnum.LEI;
            Assert.Equal(instance.AltBusinessIdType,SMSTenDLCBrand.AltBusinessIdTypeEnum.LEI);
            
        }
        /// <summary>
        /// Test the property 'UniversalEin'
        /// </summary>
        [Fact]
        public void UniversalEinTest()
        {

            Assert.Equal("TEST_STRING", instance.UniversalEin);
            
        }
        /// <summary>
        /// Test the property 'ReferenceId'
        /// </summary>
        [Fact]
        public void ReferenceIdTest()
        {
            instance.ReferenceId = "TEST_STRING";
            Assert.Equal("TEST_STRING", instance.ReferenceId);
            
        }
        /// <summary>
        /// Test the property 'OptionalAttributes'
        /// </summary>
        [Fact]
        public void OptionalAttributesTest()
        {
            
            Dictionary<string, Object> testDictionary = new Dictionary<string, object>();
            instance.OptionalAttributes = testDictionary;
            Assert.Equal(testDictionary, instance.OptionalAttributes); 
        }
        /// <summary>
        /// Test the property 'Mock'
        /// </summary>
        [Fact]
        public void MockTest()
        {
            instance.Mock = false;
            Assert.Equal(false, instance.Mock);       
            
        }
        /// <summary>
        /// Test the property 'IdentityStatus'
        /// </summary>
        [Fact]
        public void IdentityStatusTest()
        {
            
            instance.IdentityStatus = SMSTenDLCBrand.IdentityStatusEnum.SELF_DECLARED;
            Assert.Equal(instance.IdentityStatus,SMSTenDLCBrand.IdentityStatusEnum.SELF_DECLARED);
            
            instance.IdentityStatus = SMSTenDLCBrand.IdentityStatusEnum.UNVERIFIED;
            Assert.Equal(instance.IdentityStatus,SMSTenDLCBrand.IdentityStatusEnum.UNVERIFIED);
            
            instance.IdentityStatus = SMSTenDLCBrand.IdentityStatusEnum.VERIFIED;
            Assert.Equal(instance.IdentityStatus,SMSTenDLCBrand.IdentityStatusEnum.VERIFIED);
            
            instance.IdentityStatus = SMSTenDLCBrand.IdentityStatusEnum.VETTED_VERIFIED;
            Assert.Equal(instance.IdentityStatus,SMSTenDLCBrand.IdentityStatusEnum.VETTED_VERIFIED);
            
        }
        /// <summary>
        /// Test the property 'CreateDate'
        /// </summary>
        [Fact]
        public void CreateDateTest()
        {
            instance.CreateDate = DateTime.Parse("2022-07-05T15:17:05+00:00");
            Assert.Equal(DateTime.Parse("2022-07-05T15:17:05+00:00"), instance.CreateDate);
            
        }
    }
}
