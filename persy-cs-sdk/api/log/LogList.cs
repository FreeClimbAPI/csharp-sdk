using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.persephony.api.log
{
    /// <summary>
    /// Represents a paginated list of Persephony Log instances. This object will
    /// be automatically created by LogsRequester.
    /// </summary>
    public sealed class LogList : PersyList
    {
        /// <summary>
        /// Creates a new LogList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="authToken">The authToken to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a log list from the Persephony API.</param>
        public LogList(string accountId, string authToken, string rawPage) : base(accountId, authToken, rawPage, "logs")
        { }

        /// <summary>
        /// Used by LogList to create Log objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a Persephony log instance.</param>
        /// <returns>A equivalent log object to the one represented by the inputted JSON string.</returns>
        protected override IPersyCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Log>(element);
        }
    }
}