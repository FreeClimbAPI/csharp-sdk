using com.freeclimb.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.freeclimb.api.phonenumber
{
    /// <summary>
    /// Represents a paginated list of FreeClimb AvailablePhoneNumber instances. This object will
    /// be automatically created by AvailablePhoneNumbersRequester.
    /// </summary>
    public sealed class AvailablePhoneNumberList : FreeClimbList
    {
        /// <summary>
        /// Creates a new AvailablePhoneNumberList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="apiKey">The apiKey to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of an AvailablePhoneNumber list from the FreeClimb API.</param>
        public AvailablePhoneNumberList(string accountId, string apiKey, string rawPage) : base(accountId, apiKey, rawPage, "availablePhoneNumbers")
        { }

        /// <summary>
        /// Used by AvailablePhoneNumberList to create AvailablePhoneNumber objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a FreeClimb AvailablePhoneNumber instance.</param>
        /// <returns>An equivalent AvailablePhoneNumber object to the one represented by the inputted JSON string.</returns>
        protected override IFreeClimbCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<AvailablePhoneNumber>(element);
        }
    }
}