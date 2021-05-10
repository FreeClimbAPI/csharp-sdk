﻿using com.freeclimb.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.freeclimb.api.log
{
    /// <summary>
    /// Represents a paginated list of FreeClimb Log instances. This object will
    /// be automatically created by LogsRequester.
    /// </summary>
    public sealed class LogList : FreeClimbList
    {
        /// <summary>
        /// Creates a new LogList.
        /// </summary>
        /// <param name="accountId">The accountId to use in requests for subsequent pages.</param>
        /// <param name="apiKey">The apiKey to use in requests for subsequent pages.</param>
        /// <param name="rawPage">The raw JSON string representing a page of a log list from the FreeClimb API.</param>
        public LogList(string accountId, string apiKey, string rawPage) : base(accountId, apiKey, rawPage, "logs")
        { }

        /// <summary>
        /// Used by LogList to create Log objects from the JSON list.
        /// </summary>
        /// <param name="element">A JSON string representing a FreeClimb log instance.</param>
        /// <returns>An equivalent log object to the one represented by the inputted JSON string.</returns>
        protected override IFreeClimbCommon constructElement(string element)
        {
            return JsonConvert.DeserializeObject<Log>(element);
        }
    }
}