using com.freeclimb.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.freeclimb.api.message
{
    /// <summary>
    /// This class represents the set of wrappers around the FreeClimb Message API.
    /// It provides methods to handle all the operations supported by the FreeClimb
    /// Message API.
    /// </summary>
    public class MessagesRequester : APIRequester
    {
        private readonly string path;
        /// <summary>
        /// Creates a MessageRequester. For most SDK users MessageRequester will be
        /// created automatically by the FreeClimbClient but is available for more
        /// users who only require the features in this specific requester and not 
        /// the rest of the features of the FreeClimbClient.
        /// </summary>
        /// <param name="credAccountId">The accountId to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="credApiKey">The apiKey to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="accountId">The accountId to act as. This can be the same as the credAccountId or the accountId of a subaccount of the credAccountId.</param>
        public MessagesRequester(string credAccountId, string credApiKey, string accountId) : base(credAccountId, credApiKey)
        {
            this.path = "/Accounts/" + accountId + "/Messages";
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
        public new string getfreeClimbUrl { get { return base.GetFreeClimbUrl; } }

        /// <summary>
        /// Create a new message through the FreeClimb API 
        /// </summary>
        /// <param name="from">the phone number the message is being sent from. Formatted in E.164 format. This must be a number purchase from FreeClimb or a verified phone number owned by the user.</param> 
        /// <param name="to">the phone number the message is being sent to. Formatted in E.164 format.</param> 
        /// <param name="text">The text of the message. Should be 254 chars or less</param> 
        /// <param name="options">optional parameters used when creating a message. </param> 
        /// <returns>A Message object returned by FreeClimb that represents the message that was created.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Message create(string from, string to, string text, MessageOptions options = null)
        {
            if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to) || string.IsNullOrEmpty(text))
            {
                throw new FreeClimbException("Failed to create message because all required fields, from, to and text, are not specified");
            }
            NewMessage newMsg = new NewMessage(from, to, text, options);
            string json = base.POST(this.path, newMsg.toJson());

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to create Message with options {0}. from: {1} to: {2} text: {3}", ((options != null) ? options.toJson() : string.Empty), from, to, text));
            }

            return Message.fromJson(json);
        }

        /// <summary>
        /// Retrieve a single message from FreeClimb.
        /// </summary>
        /// <param name="messageId">The messageId of the target message.</param>
        /// <returns>The message matching the messageId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Message get(string messageId)
        {
            string json = base.GET(String.Format("{0}/{1}", this.path, messageId));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get message {0} information", messageId ?? ""));
            }

            return Message.fromJson(json);
        }

        /// <summary>
        /// Retrieve a list of messages from FreeClimb.
        /// </summary>
        /// <param name="filters">Optional MessagesSearchFilter instance to filter list of messages.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response.This will be a paginated list 
        /// of message instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="MessagesSearchFilter">MessagesSearchFilter class.</see>
        public MessageList get(MessagesSearchFilter filters = null)
        {
            string json = base.GET(this.path, ((filters != null) ? filters.toDict() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException("Failed to get message list");
            }

            MessageList list = new MessageList(this.getAccountId, this.getApiKey, json);

            return list;
        }

    }
}