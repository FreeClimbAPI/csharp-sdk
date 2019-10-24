using com.freeclimb.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.freeclimb.api.phonenumber
{
    /// <summary>
    /// This class represents the set of wrappers around the FreeClimb AvailablePhoneNumber API.
    /// It provides methods to handle all the operations supported by the FreeClimb
    /// AvailablePhoneNumber API.
    /// </summary>
    public class AvailablePhoneNumbersRequester : APIRequester
    {
        private readonly string path;
        /// <summary>
        /// Creates an AvailablePhoneNumbersRequester. For most SDK users AvailablePhoneNumbersRequester will be
        /// created automatically by the FreeClimbClient but is available for more
        /// users who only require the features in this specific requester and not 
        /// the rest of the features of the FreeClimbClient.
        /// </summary>
        /// <param name="credAccountId">The accountId to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="credAuthToken">The authToken to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="accountId">The accountId to act as. This can be the same as the credAccountId or the accountId of a subaccount of the credAccountId.</param>
        public AvailablePhoneNumbersRequester(string credAccountId, string credAuthToken, string accountId) : base(credAccountId, credAuthToken)
        {
            // no account for available phone nums
            this.path = "/AvailablePhoneNumbers";
        }

        /// <summary>
        /// Retrieve  path object value.
        /// </summary>
        /// <returns>The base path used for the FreeClimb API.</returns>
        public string getPath { get { return this.path; } }

        /// <summary>
        /// Retrieve a list of AvailablePhoneNumber from FreeClimb.
        /// </summary>
        /// <param name="filters">Optional AvailablePhoneNumbersSearchFilter instance to filter list of AvailablePhoneNumbers.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response.This will be a paginated list 
        /// of AvailablePhoneNumber instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="AvailablePhoneNumbersSearchFilter">AvailablePhoneNumbersSearchFilter class.</see>
        public AvailablePhoneNumberList get(AvailablePhoneNumbersSearchFilter filters = null)
        {
            string json = base.GET(this.path, ((filters != null) ? filters.toDict() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException("Failed to get AvailablePhoneNumber list");
            }

            AvailablePhoneNumberList list = new AvailablePhoneNumberList(this.getAccountId, this.getAuthToken, json);

            return list;
        }
    }
}