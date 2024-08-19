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
using System.Text;
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
    ///  Class for testing QueueMemberListAllOf
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class QueueMemberListAllOfTests
    {
        private QueueMemberListAllOf instance;

        public QueueMemberListAllOfTests()
        {
            instance = new QueueMemberListAllOf(new List<QueueMember>());
        }

        /// <summary>
        /// Test an instance of QueueMemberListAllOf
        /// </summary>
        [Fact]
        public void QueueMemberListAllOfInstanceTest()
        {
            Assert.IsType<QueueMemberListAllOf>(instance);
        }


        /// <summary>
        /// Test the property 'QueueMembers'
        /// </summary>
        [Fact]
        public void QueueMembersTest()
        {
            
            List<QueueMember> testList = new List<QueueMember>();
            instance.QueueMembers = testList;
            Assert.Equal(testList, instance.QueueMembers); 
        }
        
        
        /// <summary>
        /// Test the method 'equalsTrue'
        /// </summary>
        
        [Fact]
        public void equalsTrueTest() {
        QueueMemberListAllOf test1 = new QueueMemberListAllOf(new List<QueueMember>());
         List<QueueMember> testList = new List<QueueMember>();
         test1.QueueMembers = testList;

        QueueMemberListAllOf test2 = new QueueMemberListAllOf(new List<QueueMember>());
         List<QueueMember> testList2 = new List<QueueMember>();
         test2.QueueMembers = testList2;

        Assert.Equal(test1,test2);
        }

        /// <summary>
        /// Test the method 'equalsFalse'
        /// </summary>
        
        [Fact]
        public void equalsFalseTest() {
        QueueMemberListAllOf test1 = new QueueMemberListAllOf(new List<QueueMember>());
         List<QueueMember> testList = new List<QueueMember>();
         test1.QueueMembers = testList;

        QueueMemberListAllOf test2 = new QueueMemberListAllOf(new List<QueueMember>());
         List<QueueMember> testList2 = null;
         test2.QueueMembers = testList2;

        Assert.NotEqual(test1,test2);
        }

        /// <summary>
        /// Test the method 'hashCodeType'
        /// </summary>
        
        [Fact]
        public void hashCodeTypeTest() {
        QueueMemberListAllOf test1 = new QueueMemberListAllOf(new List<QueueMember>());
         List<QueueMember> testList = new List<QueueMember>();
         test1.QueueMembers = testList;

        int hashCode1 = test1.GetHashCode();
        Assert.True(hashCode1.GetType() == typeof(int));

        }

        /// <summary>
        /// Test the method 'ToStringType'
        /// </summary>
        
        [Fact]
        public void ToStringTypeTest() {
        QueueMemberListAllOf test1 = new QueueMemberListAllOf(new List<QueueMember>());
         List<QueueMember> testList = new List<QueueMember>();
         test1.QueueMembers = testList;

        string toString1 = test1.ToString();
        Assert.True(toString1.GetType() == typeof(string));

        }

        /// <summary>
        /// Test the method 'ToStringEquals'
        /// </summary>
        
        [Fact]
        public void ToStringEqualsTest() {
        QueueMemberListAllOf test1 = new QueueMemberListAllOf(new List<QueueMember>());
         List<QueueMember> testList = new List<QueueMember>();
         test1.QueueMembers = testList;

        QueueMemberListAllOf test2 = new QueueMemberListAllOf(new List<QueueMember>());
         List<QueueMember> testList2 = new List<QueueMember>();
         test2.QueueMembers = testList2;

        string toString1 = test1.ToString();
        string toString2 = test2.ToString();
        Assert.Equal(toString1, toString2);

        }

        /// <summary>
        /// Test the method 'equals'
        /// </summary>
        
        [Fact]
        public void equalsTest() {
        QueueMemberListAllOf test1 = new QueueMemberListAllOf(new List<QueueMember>());
         List<QueueMember> testList = new List<QueueMember>();
         test1.QueueMembers = testList;

        QueueMemberListAllOf test2 = new QueueMemberListAllOf(new List<QueueMember>());
         List<QueueMember> testList2 = new List<QueueMember>();
         test2.QueueMembers = testList2;

        Assert.True(test1.Equals(test2));
        }

        /// <summary>
        /// Test the method 'ToJson'
        /// </summary>
        
        [Fact]
        public void ToJsonTest() {
        QueueMemberListAllOf test1 = new QueueMemberListAllOf(new List<QueueMember>());
         List<QueueMember> testList = new List<QueueMember>();
         test1.QueueMembers = testList;
        JsonSerializer jsonSerializer = JsonSerializer.Create();
        jsonSerializer.NullValueHandling = NullValueHandling.Ignore;
        StringBuilder strb = new StringBuilder();
        jsonSerializer.Serialize(new StringWriter(strb), test1);

        QueueMemberListAllOf test2 = new QueueMemberListAllOf(new List<QueueMember>());
         List<QueueMember> testList2 = new List<QueueMember>();
         test2.QueueMembers = testList2;

        Assert.True(strb.Equals(JsonConvert.SerializeObject(test2)));
        }
    }
}
