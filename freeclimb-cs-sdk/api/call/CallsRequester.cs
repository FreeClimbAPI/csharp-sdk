﻿using System;

namespace com.freeclimb.api.call
{
    /// <summary>
    /// This class represents the set of wrappers around the FreeClimb Calls API.
    /// It provides methods to handle all the operations supported by the FreeClimb
    /// Calls API.
    /// </summary>
    public sealed class CallsRequester : APIRequester
    {
        private readonly string path;

        /// <summary>
        /// Creates a CallsRequester. For most SDK users CallsRequesters will be
        /// created automatically by the FreeClimbClient but is available for more
        /// users who only require the features in this specific requester and not 
        /// the rest of the features of the FreeClimbClient.
        /// </summary>
        /// <param name="credAccountId">The accountId to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="credApiKey">The apiKey to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="accountId">The accountId to act as. This can be the same as the credAccountId or the accountId of a subaccount of the credAccountId.</param>
        public CallsRequester(string credAccountId, string credApiKey, string accountId) : base(credAccountId, credApiKey)
        {
            this.path = "/Accounts/" + accountId + "/Calls";
        }

        /// <summary>
        /// Retrieve  path object value.
        /// </summary>
        /// <returns>The base path used for the FreeClimb API.</returns>
        public string getPath { get { return this.path; } }

        /// <summary>
        /// Retrieve  accountId object value.
        /// </summary>
        /// <returns>The accountId being used for authentication.</returns>
       public new string getAccountId { get { return base.getAccountId; } }

        /// <summary>
        /// Retrieve  apiKey object value.
        /// </summary>
        /// <returns>The apiKey being used for authentication.</returns>
        public new string getApiKey { get { return base.getApiKey; } }

        /// <summary>
        /// Retrieve  FreeClimb API Url object value.
        /// </summary>
        /// <returns>The url being used for the FreeClimb API.</returns>
        public string getfreeClimbUrl { get { return base.GetFreeClimbUrl; } }

        /// <summary>
        /// Create a new call through the FreeClimb API using a registered
        /// FreeClimb application.
        /// </summary>
        /// <param name="to">The number to call out to (DNIS). This can be any valid phone number formatted in E.164 format.</param>
        /// <param name="from">The number to call from (ANI). This must be a number purchase from FreeClimb or a verified phone number owned by the user.</param>
        /// <param name="applicationId">The applicationId for the registered FreeClimb application which should handle this call.</param>
        /// <param name="callOptions">Optional CallOrigOptions instance to be used when creating a call.</param> 
        /// <returns>A Call object returned by FreeClimb that represents the call that was created.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="CallOrigOptions">CallOrigOptions class.</see>
        public Call create(string to, string from, string applicationId, CallOrigOptions callOptions = null)
        {
            OutboundCall outboundCall = new OutboundCall(callOptions);
            outboundCall.setTo(to);
            outboundCall.setFrom(from);
            outboundCall.setApplicationId(applicationId);

            string json = base.POST(this.path, outboundCall.toJson());

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(string.Format("Failed to connect to {0} from {1}", to ?? string.Empty, from ?? string.Empty));
            }

            return Call.fromJson(json);
        }

        /// <summary>
        /// Retrieve a list of calls associated with the accountId.
        /// </summary>
        /// <param name="filters">Optional CallsSearchFilters instance to filter list of calls.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response.This will be a paginated list 
        /// of call instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="CallsSearchFilters">CallsSearchFilters class.</see>
        public CallList get(CallsSearchFilters filters = null)
        {
            string json = base.GET(this.path, ((filters != null) ? filters.toDict() : null) );

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException("Failed to get call list");
            }

            CallList list = new CallList(this.getAccountId, this.getApiKey, json);

            return list;
        }

        /// <summary>
        /// Retrieve a single call from FreeClimb.
        /// </summary>
        /// <param name="callId">The callId of the target call.</param>
        /// <returns>The call matching the callId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Call get(string callId)
        {
            string json = base.GET(String.Format("{0}/{1}",this.path,callId));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get call {0} information", callId ?? ""));
            }

            return Call.fromJson(json);
        }

        /// <summary>
        /// Update a single call. 
        /// </summary>
        /// <param name="callId">The callId of the target call.</param>
        /// <param name="callOptions">Optional CallTermOptions instance to be used when updating a call.</param>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public void update(string callId, CallTermOptions callOptions = null)
        {
            base.POST(String.Format("{0}/{1}", this.path, callId), ((callOptions != null) ? callOptions.toJson() : null));
        }
    }
}
