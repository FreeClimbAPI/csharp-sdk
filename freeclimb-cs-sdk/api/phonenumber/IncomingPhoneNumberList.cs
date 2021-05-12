using com.freeclimb.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.freeclimb.api.phonenumber
{
    /// <summary>
    /// Represents a paginated list of FreeClimb IncomingPhoneNumber instances. This object will
    /// be automatically created by IncomingPhoneNumbersRequester.
    /// </summary>
    public sealed class IncomingPhoneNumberList : FreeClimbList
    {
        /// <summary>
        /// Creates a new IncomingPhoneNumberList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="apiKey">The apiKey to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of an incoming phone number list from the FreeClimb API.</param>
        public IncomingPhoneNumberList(string accountId, string apiKey, string rawPage) : base(accountId, apiKey, rawPage, "incomingPhoneNumbers")
        { }

        /// <summary>
        /// Used by IncomingPhoneNumberList to create IncomingPhoneNumber objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a FreeClimb incomingPhoneNumber instance.</param>
        /// <returns>An equivalent IncomingPhoneNumber object to the one represented by the inputted JSON string.</returns>
        protected override IFreeClimbCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<IncomingPhoneNumber>(element);
        }
    }
}