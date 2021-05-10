using com.freeclimb.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.freeclimb.api.account
{
    /// <summary>
    /// This class represents the set of wrappers around the FreeClimb Account API.
    /// It provides methods to handle all the operations supported by the FreeClimb
    /// Account API.
    /// </summary>
    public class AccountsRequester : APIRequester
    {
        private readonly string path;
        /// <summary>
        /// Creates an AccountRequester. For most SDK users AccountRequester will be
        /// created automatically by the FreeClimbClient but is available for more
        /// users who only require the features in this specific requester and not 
        /// the rest of the features of the FreeClimbClient.
        /// </summary>
        /// <param name="credAccountId">The accountId to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="credApiKey">The apiKey to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        public AccountsRequester(string credAccountId, string credApiKey) : base(credAccountId, credApiKey)
        {
            this.path = "/Accounts";
        }

        /// <summary>
        /// Retrieve  path object value.
        /// </summary>
        /// <returns>The base path used for the FreeClimb API.</returns>
        public string getPath { get { return this.path; } }

        /// <summary>
        /// Retrieve a single account from FreeClimb.
        /// </summary>
        /// <param name="accountId">The accountId of the target account.</param>
        /// <returns>The account matching the accountId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Account get(string accountId)
        {
            string json = base.GET(String.Format("{0}/{1}", this.path, accountId));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get account {0} information", accountId ?? ""));
            }

            return Account.fromJson(json);
        }

        /// <summary>
        /// Update a single account. 
        /// </summary>
        /// <param name="accountId">The accountId of the target account.</param>
        /// <param name="options">Optional AccountOptions instance to be used when updating an account.</param>
        /// <returns>The updated account matching the accountId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Account update(string accountId, AccountOptions options = null)
        {
            string json = base.POST(String.Format("{0}/{1}", this.path, accountId), ((options != null) ? options.toJson() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to update account {0} information", accountId ?? ""));
            }

            return Account.fromJson(json);
        }

        /// <summary>
        /// Delete a FreeClimb account.
        /// </summary>
        /// <param name="accountId">The accountId of the target account.</param>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public void delete(string accountId)
        {
            base.DELETE(String.Format("{0}/{1}", this.path, accountId));
        }

    }
}