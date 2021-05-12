using com.freeclimb.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.freeclimb.api.phonenumber
{
    /// <summary>
    /// This class represents the set of wrappers around the FreeClimb IncomingPhoneNumber API.
    /// It provides methods to handle all the operations supported by the FreeClimb
    /// IncomingPhoneNumber API.
    /// </summary>
    public class IncomingPhoneNumbersRequester : APIRequester
    {
        private readonly string path;
        /// <summary>
        /// Creates an IncomingPhoneNumbersRequester. For most SDK users IncomingPhoneNumbersRequester will be
        /// created automatically by the FreeClimbClient but is available for more
        /// users who only require the features in this specific requester and not 
        /// the rest of the features of the FreeClimbClient.
        /// </summary>
        /// <param name="credAccountId">The accountId to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="credApiKey">The apiKey to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="accountId">The accountId to act as. This can be the same as the credAccountId or the accountId of a subaccount of the credAccountId.</param>
        public IncomingPhoneNumbersRequester(string credAccountId, string credApiKey, string accountId) : base(credAccountId, credApiKey)
        {
            this.path = "/Accounts/" + accountId + "/IncomingPhoneNumbers";
        }

        /// <summary>
        /// Retrieve  path object value.
        /// </summary>
        /// <returns>The base path used for the FreeClimb API.</returns>
        public string getPath { get { return this.path; } }

        /// <summary>
        /// Retrieve a single IncomingPhoneNumber from FreeClimb.
        /// </summary>
        /// <param name="id">The phoneNumberId of the target resource.</param>
        /// <returns>The IncomingPhoneNumber matching the id provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public IncomingPhoneNumber get(string id)
        {
            string json = base.GET(String.Format("{0}/{1}", this.path, id));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get incomingPhoneNumber {0} information", id ?? ""));
            }

            return IncomingPhoneNumber.fromJson(json);
        }

        /// <summary>
        /// Retrieve a list of IncomingPhoneNumbers from FreeClimb.
        /// </summary>
        /// <param name="filters">Optional IncomingPhoneNumbersSearchFilter instance to filter list of IncomingPhoneNumbers.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response.This will be a paginated list 
        /// of IncomingPhoneNumber instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="IncomingPhoneNumbersSearchFilter">IncomingPhoneNumbersSearchFilter class.</see>
        public IncomingPhoneNumberList get(IncomingPhoneNumbersSearchFilter filters = null)
        {
            string json = base.GET(this.path, ((filters != null) ? filters.toDict() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException("Failed to get incomingPhoneNumber list");
            }

            IncomingPhoneNumberList list = new IncomingPhoneNumberList(this.getAccountId, this.getApiKey, json);

            return list;
        }

        /// <summary>
        /// Update a single incomingPhoneNumber. 
        /// </summary>
        /// <param name="phoneNumberId">The phoneNumberId of the target incomingPhoneNumber.</param>
        /// <param name="options">Optional IncomingPhoneNumberOptions instance to be used when updating an IncomingPhoneNumber.</param>
        /// <returns>The updated IncomingPhoneNumber matching the phoneNumberId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public IncomingPhoneNumber update(string phoneNumberId, IncomingPhoneNumberOptions options)
        {
            string json = base.POST(String.Format("{0}/{1}", this.path, phoneNumberId), options.toJson());

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to update incomingphonenumber {0} information", phoneNumberId));
            }

            return IncomingPhoneNumber.fromJson(json);
        }

        /// <summary>
        /// Create a new incomingPhoneNumber through the FreeClimb API 
        /// </summary>
        /// <param name="phoneNumber">the phone number of the incomingPhoneNumber to be created.</param> 
        /// <param name="options">Optional IncomingPhoneNumberOptions instance to be used when creating an incomingPhoneNumber.</param> 
        /// <returns>An IncomingPhoneNumber object returned by FreeClimb that represents the incomingPhoneNumber that was created.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="IncomingPhoneNumberOptions">IncomingPhoneNumberOptions class.</see>
        public IncomingPhoneNumber create(string phoneNumber, IncomingPhoneNumberOptions options = null)
        {
            NewIncomingPhoneNumber newPhone = new NewIncomingPhoneNumber(phoneNumber, options);
            string json = base.POST(this.path, newPhone.toJson());

            if (string.IsNullOrEmpty(json) == true)
            {

                throw new FreeClimbException(String.Format("Failed to create IncomingPhoneNumber with options {0}. PhoneNumber: {1}", ((options != null) ? options.toJson() : string.Empty), phoneNumber));
            }

            return IncomingPhoneNumber.fromJson(json);
        }

        /// <summary>
        /// Delete a FreeClimb IncomingPhoneNumber.
        /// </summary>
        /// <param name="phoneNumberId">The phoneNumberId of the target incomingPhoneNumber.</param>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public void delete(string phoneNumberId)
        {
            base.DELETE(String.Format("{0}/{1}", this.path, phoneNumberId));
        }


    }
}