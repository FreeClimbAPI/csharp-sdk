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
    /// Defines BargeInReason
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BargeInReason
    {
        /// <summary>
        /// Enum NO_BARGE_IN for value: noBargeIn
        /// </summary>
        [EnumMember(Value = "noBargeIn")]
        NO_BARGE_IN = 1,

        /// <summary>
        /// Enum BARGE_IN_BY_DTMF for value: bargeInByDTMF
        /// </summary>
        [EnumMember(Value = "bargeInByDTMF")]
        BARGE_IN_BY_DTMF = 2,

        /// <summary>
        /// Enum BARGE_IN_BY_ENERGY for value: bargeInByEnergy
        /// </summary>
        [EnumMember(Value = "bargeInByEnergy")]
        BARGE_IN_BY_ENERGY = 3,
    }

    /// <summary>
    /// Converts <see cref="BargeInReason"/> to and from the JSON value
    /// </summary>
    public static class BargeInReasonValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="BargeInReason"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static BargeInReason FromString(string value)
        {
            if (value.Equals("noBargeIn"))
                return BargeInReason.NO_BARGE_IN;

            if (value.Equals("bargeInByDTMF"))
                return BargeInReason.BARGE_IN_BY_DTMF;

            if (value.Equals("bargeInByEnergy"))
                return BargeInReason.BARGE_IN_BY_ENERGY;

            throw new NotImplementedException(
                $"Could not convert value to type BargeInReason: '{value}'"
            );
        }

        /// <summary>
        /// Parses a given value to <see cref="BargeInReason"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static BargeInReason? FromStringOrDefault(string value)
        {
            if (value.Equals("noBargeIn"))
                return BargeInReason.NO_BARGE_IN;

            if (value.Equals("bargeInByDTMF"))
                return BargeInReason.BARGE_IN_BY_DTMF;

            if (value.Equals("bargeInByEnergy"))
                return BargeInReason.BARGE_IN_BY_ENERGY;

            return null;
        }
    }
}