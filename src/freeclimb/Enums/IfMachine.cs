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
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using freeclimb.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = freeclimb.Client.OpenAPIDateConverter;

namespace freeclimb.Enums
{
    /// <summary>
    /// Specifies how FreeClimb should handle this OutDial if an answering machine answers the Call. Valid values: &#x60;redirect&#x60; invokes the ifMachineUrl for instructions. &#x60;hangup&#x60; hangs up the Call. The ifMachineUrl will not be invoked.
    /// </summary>
    /// <value>Specifies how FreeClimb should handle this OutDial if an answering machine answers the Call. Valid values: &#x60;redirect&#x60; invokes the ifMachineUrl for instructions. &#x60;hangup&#x60; hangs up the Call. The ifMachineUrl will not be invoked.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum IfMachine
    {
        /// <summary>
        /// Enum REDIRECT for value: redirect
        /// </summary>
        [EnumMember(Value = "redirect")]
        REDIRECT = 1,

        /// <summary>
        /// Enum HANGUP for value: hangup
        /// </summary>
        [EnumMember(Value = "hangup")]
        HANGUP = 2,
    }

    /// <summary>
    /// Converts <see cref="IfMachine"/> to and from the JSON value
    /// </summary>
    public static class IfMachineValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="IfMachine"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IfMachine FromString(string value)
        {
            if (value.Equals("redirect"))
                return IfMachine.REDIRECT;

            if (value.Equals("hangup"))
                return IfMachine.HANGUP;

            throw new NotImplementedException(
                $"Could not convert value to type IfMachine: '{value}'"
            );
        }

        /// <summary>
        /// Parses a given value to <see cref="IfMachine"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static IfMachine? FromStringOrDefault(string value)
        {
            if (value.Equals("redirect"))
                return IfMachine.REDIRECT;

            if (value.Equals("hangup"))
                return IfMachine.HANGUP;

            return null;
        }
    }
}
