using com.freeclimb.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.freeclimb.api.application
{
    /// <summary>
    /// This class represents the set of wrappers around the FreeClimb Application API.
    /// It provides methods to handle all the operations supported by the FreeClimb
    /// Application API.
    /// </summary>
    public class ApplicationsRequester : APIRequester
    {
        private readonly string path;
        /// <summary>
        /// Creates an ApplicationsRequester. For most SDK users ApplicationsRequester will be
        /// created automatically by the FreeClimbClient but is available for more
        /// users who only require the features in this specific requester and not 
        /// the rest of the features of the FreeClimbClient.
        /// </summary>
        /// <param name="credAccountId">The accountId to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="credAuthToken">The authToken to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="accountId">The accountId to act as. This can be the same as the credAccountId or the accountId of a subaccount of the credAccountId.</param>
        public ApplicationsRequester(string credAccountId, string credAuthToken, string accountId) : base(credAccountId, credAuthToken)
        {
            this.path = "/Accounts/" + accountId + "/Applications";
        }

        /// <summary>
        /// Retrieve  path object value.
        /// </summary>
        /// <returns>The base path used for the FreeClimb API.</returns>
        public string getPath { get { return this.path; } }

        /// <summary>
        /// Retrieve a single application from FreeClimb.
        /// </summary>
        /// <param name="appId">The applicationId of the target application.</param>
        /// <returns>The application matching the appId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Application get(string appId)
        {
            string json = base.GET(String.Format("{0}/{1}", this.path, appId));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get application {0} information", appId ?? ""));
            }

            return Application.fromJson(json);
        }

        /// <summary>
        /// Retrieve a list of applications from FreeClimb.
        /// </summary>
        /// <param name="filters">Optional ApplicationsSearchFilters instance to filter list of applications.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response.This will be a paginated list 
        /// of application instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="ApplicationsSearchFilters">ApplicationsSearchFilters class.</see>
        public ApplicationList get(ApplicationsSearchFilters filters = null)
        {
            string json = base.GET(this.path, ((filters != null) ? filters.toDict() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException("Failed to get application list");
            }

            ApplicationList list = new ApplicationList(this.getAccountId, this.getAuthToken, json);

            return list;
        }

        /// <summary>
        /// Create a new application through the FreeClimb API 
        /// </summary>
        /// <param name="options">Optional ApplicationOptions instance to be used when creating an application.</param> 
        /// <returns>An Application object returned by FreeClimb that represents the application that was created.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="ApplicationOptions">ApplicationOptions class.</see>
        public Application create(ApplicationOptions options = null)
        {
            string json = base.POST(this.path, ((options != null) ? options.toJson() : null));

            if (string.IsNullOrEmpty(json) == true)
            {

                throw new FreeClimbException(String.Format("Failed to create application with options {0}", ((options != null) ? options.toJson() : string.Empty)));
            }

            return Application.fromJson(json);
        }

        /// <summary>
        /// Update a single application. 
        /// </summary>
        /// <param name="applicationId">The applicationId of the target application.</param>
        /// <param name="options">Optional ApplicationOptions instance to be used when updating an application.</param>
        /// <returns>The updated application matching the applicationId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Application update(string applicationId, ApplicationOptions options = null)
        {
            string json = base.POST(String.Format("{0}/{1}", this.path, applicationId), ((options != null) ? options.toJson() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to update application {0} information", applicationId ?? ""));
            }

            return Application.fromJson(json);
        }

        /// <summary>
        /// Delete a FreeClimb application.
        /// </summary>
        /// <param name="applicationId">The applicationId of the target application.</param>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public void delete(string applicationId)
        {
            base.DELETE(String.Format("{0}/{1}", this.path, applicationId));
        }

    }
}