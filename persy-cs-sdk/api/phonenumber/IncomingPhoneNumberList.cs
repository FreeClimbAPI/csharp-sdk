using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.persephony.api.phonenumber
{
    /// <summary>
    /// Represents a paginated list of Persephony IncomingPhoneNumber instances. This object will
    /// be automatically created by IncomingPhoneNumbersRequester.
    /// </summary>
    public sealed class IncomingPhoneNumberList : PersyList
    {
        /// <summary>
        /// Creates a new IncomingPhoneNumberList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="authToken">The authToken to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of an incoming phone number list from the Persephony API.</param>
        public IncomingPhoneNumberList(string accountId, string authToken, string rawPage) : base(accountId, authToken, rawPage, "incomingPhoneNumbers")
        { }

        /// <summary>
        /// Used by IncomingPhoneNumberList to create IncomingPhoneNumber objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a Persephony incomingPhoneNumber instance.</param>
        /// <returns>An equivalent IncomingPhoneNumber object to the one represented by the inputted JSON string.</returns>
        protected override IPersyCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<IncomingPhoneNumber>(element);
        }
    }
}