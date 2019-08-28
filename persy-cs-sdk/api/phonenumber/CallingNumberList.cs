using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.persephony.api.phonenumber
{
    /// <summary>
    /// Represents a paginated list of Persephony CallingNumber instances. This object will
    /// be automatically created by CallingNumbersRequester.
    /// </summary>
    public sealed class CallingNumberList : PersyList
    {
        /// <summary>
        /// Creates a new CallingNumberList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="authToken">The authToken to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of an AvailablePhoneNumber list from the Persephony API.</param>
        public CallingNumberList(string accountId, string authToken, string rawPage) : base(accountId, authToken, rawPage, "callingNumbers")
        { }

        /// <summary>
        /// Used by CallingNumberList to create CallingNumber objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a Persephony CallingNumber instance.</param>
        /// <returns>An equivalent CallingNumber object to the one represented by the inputted JSON string.</returns>
        protected override IPersyCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<CallingNumber>(element);
        }
    }
}