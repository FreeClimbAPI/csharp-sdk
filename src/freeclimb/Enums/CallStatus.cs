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
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = freeclimb.Client.OpenAPIDateConverter;
using freeclimb.Enums;

namespace freeclimb.Enums
{
    /// <summary>
    /// * &#x60;queued&#x60; &amp;ndash; Call is ready and waiting in line before going out. * &#x60;ringing&#x60; &amp;ndash; Call is currently ringing. * &#x60;inProgress&#x60; &amp;ndash; Call was answered and is currently in progress. * &#x60;canceled&#x60; &amp;ndash; Call was hung up while it was queued or ringing. * &#x60;completed&#x60; &amp;ndash; Call was answered and has ended normally. * &#x60;busy&#x60; &amp;ndash; Caller received a busy signal. * &#x60;failed&#x60; &amp;ndash; Call could not be completed as dialed, most likely because the phone number was non-existent. * &#x60;noAnswer&#x60; &amp;ndash; Call ended without being answered.
    /// </summary>
    /// <value>* &#x60;queued&#x60; &amp;ndash; Call is ready and waiting in line before going out. * &#x60;ringing&#x60; &amp;ndash; Call is currently ringing. * &#x60;inProgress&#x60; &amp;ndash; Call was answered and is currently in progress. * &#x60;canceled&#x60; &amp;ndash; Call was hung up while it was queued or ringing. * &#x60;completed&#x60; &amp;ndash; Call was answered and has ended normally. * &#x60;busy&#x60; &amp;ndash; Caller received a busy signal. * &#x60;failed&#x60; &amp;ndash; Call could not be completed as dialed, most likely because the phone number was non-existent. * &#x60;noAnswer&#x60; &amp;ndash; Call ended without being answered.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CallStatus
    {
        /// <summary>
        /// Enum QUEUED for value: queued
        /// </summary>
        [EnumMember(Value = "queued")]
        QUEUED = 1,

        /// <summary>
        /// Enum RINGING for value: ringing
        /// </summary>
        [EnumMember(Value = "ringing")]
        RINGING = 2,

        /// <summary>
        /// Enum IN_PROGRESS for value: inProgress
        /// </summary>
        [EnumMember(Value = "inProgress")]
        IN_PROGRESS = 3,

        /// <summary>
        /// Enum CANCELED for value: canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        CANCELED = 4,

        /// <summary>
        /// Enum COMPLETED for value: completed
        /// </summary>
        [EnumMember(Value = "completed")]
        COMPLETED = 5,

        /// <summary>
        /// Enum FAILED for value: failed
        /// </summary>
        [EnumMember(Value = "failed")]
        FAILED = 6,

        /// <summary>
        /// Enum BUSY for value: busy
        /// </summary>
        [EnumMember(Value = "busy")]
        BUSY = 7,

        /// <summary>
        /// Enum NO_ANSWER for value: noAnswer
        /// </summary>
        [EnumMember(Value = "noAnswer")]
        NO_ANSWER = 8

    }

}
