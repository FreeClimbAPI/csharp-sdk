using com.freeclimb.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.freeclimb.api.phonenumber
{
    /// <summary>
    /// This class represents the set of wrappers around the FreeClimb CallingNumber API.
    /// It provides methods to handle all the operations supported by the FreeClimb
    /// CallingNumber API.
    /// </summary>
    public class CallingNumbersRequester : APIRequester
    {
        private readonly string path;
        /// <summary>
        /// Creates a CallingNumbersRequester. For most SDK users CallingNumbersRequester will be
        /// created automatically by the FreeClimbClient but is available for more
        /// users who only require the features in this specific requester and not 
        /// the rest of the features of the FreeClimbClient.
        /// </summary>
        /// <param name="credAccountId">The accountId to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="credApiKey">The apiKey to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="accountId">The accountId to act as. This can be the same as the credAccountId or the accountId of a subaccount of the credAccountId.</param>
        public CallingNumbersRequester(string credAccountId, string credApiKey, string accountId) : base(credAccountId, credApiKey)
        {
            this.path = "/Accounts/" + accountId + "/CallingNumbers";
        }

        /// <summary>
        /// Retrieve  path object value.
        /// </summary>
        /// <returns>The base path used for the FreeClimb API.</returns>
        public string getPath { get { return this.path; } }

        /// <summary>
        /// Retrieve a single CallingNumber from FreeClimb.
        /// </summary>
        /// <param name="id">The callingNumberId of the target resource.</param>
        /// <returns>The CallingNumber matching the id provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public CallingNumber get(string id)
        {
            string json = base.GET(String.Format("{0}/{1}", this.path, id));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get CallingNumber {0} information", id ?? ""));
            }

            return CallingNumber.fromJson(json);
        }

        /// <summary>
        /// Retrieve a list of CallingNumbers from FreeClimb.
        /// </summary>
        /// <param name="filters">Optional CallingNumbersSearchFilter instance to filter list of CallingNumbers.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response.This will be a paginated list 
        /// of CallingNumber instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="CallingNumbersSearchFilter">CallingNumbersSearchFilter class.</see>
        public CallingNumberList get(CallingNumbersSearchFilter filters = null)
        {
            string json = base.GET(this.path, ((filters != null) ? filters.toDict() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException("Failed to get CallingNumber list");
            }

            CallingNumberList list = new CallingNumberList(this.getAccountId, this.getApiKey, json);

            return list;
        }

        /// <summary>
        /// Update a single callingNumber. 
        /// </summary>
        /// <param name="callingNumberId">The callingNumberId of the target callingNumber.</param>
        /// <param name="options">Optional CallingNumberOptions instance to be used when updating an callingNumber.</param>
        /// <returns>The updated callingNumber matching the callingNumberId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public CallingNumber update(string callingNumberId, CallingNumberOptions options)
        {
            string json = base.POST(String.Format("{0}/{1}", this.path, callingNumberId), options.toJson());

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to update CallingNumber {0} information", callingNumberId));
            }

            return CallingNumber.fromJson(json);
        }

        /// <summary>
        /// Create a new CallingNumber through the FreeClimb API 
        /// </summary>
        /// <param name="options">Optional CallingNumberOptions instance to be used when creating an CallingNumber.</param> 
        /// <param name="phoneNumber">The phoneNumber of the CallingNumber to create.</param> 
        /// <returns>A CallingNumber object returned by FreeClimb that represents the CallingNumber that was created.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="CallingNumberOptions">CallingNumberOptions class.</see>
        public CallingNumber create(string phoneNumber, CallingNumberOptions options = null)
        {
            NewCallingNumber newPhone = new NewCallingNumber(phoneNumber, options);
            string json = base.POST(this.path, newPhone.toJson());

            if (string.IsNullOrEmpty(json) == true)
            {

                throw new FreeClimbException(String.Format("Failed to create CallingNumber with options {0}. PhoneNumber: {1}", ((options != null) ? options.toJson() : string.Empty), phoneNumber));
            }

            return CallingNumber.fromJson(json);
        }

        /// <summary>
        /// Delete a FreeClimb CallingNumber.
        /// </summary>
        /// <param name="callingNumberId">The callingNumberId of the target CallingNumber.</param>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public void delete(string callingNumberId)
        {
            base.DELETE(String.Format("{0}/{1}", this.path, callingNumberId));
        }
    }
}