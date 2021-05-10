using com.freeclimb.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.freeclimb.api.message
{
    /// <summary>
    /// Represents a paginated list of FreeClimb Message instances. This object will
    /// be automatically created by MessageRequester.
    /// </summary>
    public sealed class MessageList : FreeClimbList
    {
        /// <summary>
        /// Creates a new MessageList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="apiKey">The apiKey to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a messages list from the FreeClimb API.</param>
        public MessageList(string accountId, string apiKey, string rawPage) : base(accountId, apiKey, rawPage, "messages")
        { }

        /// <summary>
        /// Used by MessageList to create Message objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a FreeClimb Message instance.</param>
        /// <returns>An equivalent Message object to the one represented by the inputted JSON string.</returns>
        protected override IFreeClimbCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Message>(element);
        }
    }
}