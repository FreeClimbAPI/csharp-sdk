using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.persephony.api.phonenumber
{
    /// <summary>
    /// Represents a paginated list of Persephony AvailablePhoneNumber instances. This object will
    /// be automatically created by AvailablePhoneNumbersRequester.
    /// </summary>
    public sealed class AvailablePhoneNumberList : PersyList
    {
        /// <summary>
        /// Creates a new AvailablePhoneNumberList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="authToken">The authToken to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of an AvailablePhoneNumber list from the Persephony API.</param>
        public AvailablePhoneNumberList(string accountId, string authToken, string rawPage) : base(accountId, authToken, rawPage, "availablePhoneNumbers")
        { }

        /// <summary>
        /// Used by AvailablePhoneNumberList to create AvailablePhoneNumber objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a Persephony AvailablePhoneNumber instance.</param>
        /// <returns>An equivalent AvailablePhoneNumber object to the one represented by the inputted JSON string.</returns>
        protected override IPersyCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<AvailablePhoneNumber>(element);
        }
    }
}