using com.persephony.api;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace com.persephony.api.log
{
    /// <summary>
    /// This class represents the set of wrappers around the Persephony Log API.
    /// It provides methods to handle all the operations supported by the Persephony
    /// Log API.
    /// </summary>
    public class LogsRequester : APIRequester
    {
        private readonly string path;
        /// <summary>
        /// Creates a LogsRequester. For most SDK users LogsRequester will be
        /// created automatically by the PersyClient but is available for more
        /// users who only require the features in this specific requester and not 
        /// the rest of the features of the PersyClient.
        /// </summary>
        /// <param name="credAccountId">The accountId to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="credAuthToken">The authToken to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="accountId">The accountId to act as. This can be the same as the credAccountId or the accountId of a subaccount of the credAccountId.</param>
        public LogsRequester(string credAccountId, string credAuthToken, string accountId) : base(credAccountId, credAuthToken)
        {
            this.path = "/Accounts/" + accountId + "/Logs";
        }

        /// <summary>
        /// Retrieve  path object value.
        /// </summary>
        /// <returns>The base path used for the Persephony API.</returns>
        public string getPath { get { return this.path; } }

        /// <summary>
        /// Retrieve a list of Logs from Persephony.
        /// </summary>
        /// <param name="filters">Optional query written in PQL (Persy Query Language) .</param>
        /// <returns>
        /// An in-language representation of Persephony's paginated list response.This will be a paginated list 
        /// of Log instances as returned by the Persephony API. 
        /// </returns>
        /// <exception cref="PersyException">Thrown upon failed request.</exception>
        public LogList get(LogSearchFilters filters = null)
        {
            // if persyQuery is not null, we do a post, passing the PQL in the body. Else we just do a normal get with no search params
            string json = null;
            
            if (filters != null)
            {
                json = base.POST(this.path, filters.toJson());
            }
            else
            {
                json = base.GET(this.path, null);
            }

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new PersyException("Failed to get Log list");
            }

            LogList list = new LogList(this.getAccountId, this.getAuthToken, json);

            return list;
        }

        /// <summary>
        /// Helper method to build a JSON string from a dictionary
        /// </summary>
        /// <param name="dict">dictionary to convert to json.</param>
        /// <returns>A JSON string equivalent to the dictionary passed.</returns>
        /// <exception cref="PersyJSONException">Thrown upon deserialize failure.</exception>
        public virtual string toJson(IDictionary<string, object> dict)
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                StringBuilder strb = new StringBuilder();
                jsonSerializer.Serialize(new StringWriter(strb), dict);

                return strb.ToString();
            }
            catch (Exception e)
            {
                throw new PersyJSONException(e.Message);
            }
        }
    }
}