using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.persephony.api.message
{
    /// <summary>
    /// Represents a paginated list of Persephony Message instances. This object will
    /// be automatically created by MessageRequester.
    /// </summary>
    public sealed class MessageList : PersyList
    {
        /// <summary>
        /// Creates a new MessageList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="authToken">The authToken to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a messages list from the Persephony API.</param>
        public MessageList(string accountId, string authToken, string rawPage) : base(accountId, authToken, rawPage, "messages")
        { }

        /// <summary>
        /// Used by MessageList to create Message objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a Persephony Message instance.</param>
        /// <returns>A equivalent Message object to the one represented by the inputted JSON string.</returns>
        protected override IPersyCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Message>(element);
        }
    }
}