using com.persephony.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace com.persephony.api.message
{
    /// <summary>
    /// This class represents the set of wrappers around the Persephony Message API.
    /// It provides methods to handle all the operations supported by the Persephony
    /// Message API.
    /// </summary>
    public class MessagesRequester : APIRequester
    {
        private readonly string path;
        /// <summary>
        /// Creates a MessageRequester. For most SDK users MessageRequester will be
        /// created automatically by the PersyClient but is available for more
        /// users who only require the features in this specific requester and not 
        /// the rest of the features of the PersyClient.
        /// </summary>
        /// <param name="credAccountId">The accountId to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="credAuthToken">The authToken to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="accountId">The accountId to act as. This can be the same as the credAccountId or the accountId of a subaccount of the credAccountId.</param>
        public MessagesRequester(string credAccountId, string credAuthToken, string accountId) : base(credAccountId, credAuthToken)
        {
            this.path = "/Accounts/" + accountId + "/Messages";
        }

        /// <summary>
        /// Retrieve  path object value.
        /// </summary>
        /// <returns>The base path used for the Persephony API.</returns>
        public string getPath { get { return this.path; } }

        /// <summary>
        /// Retrieve  accountId object value.
        /// </summary>
        /// <returns>The accountId being used for authentication.</returns>
        public new string getAccountId { get { return base.getAccountId; } }

        /// <summary>
        /// Retrieve  authToken object value.
        /// </summary>
        /// <returns>The authToken being used for authentication.</returns>
        public new string getAuthToken { get { return base.getAuthToken; } }

        /// <summary>
        /// Retrieve  Persephony API Url object value.
        /// </summary>
        /// <returns>The url being used for the Persephony API.</returns>
        public new string getPersyUrl { get { return base.getPersyUrl; } }

        /// <summary>
        /// Create a new message through the Persephony API 
        /// </summary>
        /// <param name="from">the phone number the message is being sent from. Formatted in E.164 format. This must be a number purchase from Persephony or a verified phone number owned by the user.</param> 
        /// <param name="to">the phone number the message is being sent to. Formatted in E.164 format.</param> 
        /// <param name="text">The text of the message. Should be 254 chars or less</param> 
        /// <param name="options">optional parameters used when creating a message. </param> 
        /// <returns>A Message object returned by Persephony that represents the message that was created.</returns>
        /// <exception cref="PersyException">Thrown upon failed request.</exception>
        public Message create(string from, string to, string text, MessageOptions options = null)
        {
            if (string.IsNullOrEmpty(from) || string.IsNullOrEmpty(to) || string.IsNullOrEmpty(text))
            {
                throw new PersyException("Failed to create message because all required fields, from, to and text, are not specified");
            }
            NewMessage newMsg = new NewMessage(from, to, text, options);
            string json = base.POST(this.path, newMsg.toJson());

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new PersyException(String.Format("Failed to create Message with options {0}. from: {1} to: {2} text: {3}", ((options != null) ? options.toJson() : string.Empty), from, to, text));
            }

            return Message.fromJson(json);
        }

        /// <summary>
        /// Retrieve a single message from Persephony.
        /// </summary>
        /// <param name="messageId">The messageId of the target message.</param>
        /// <returns>The message matching the messageId provided.</returns>
        /// <exception cref="PersyException">Thrown upon failed request.</exception>
        public Message get(string messageId)
        {
            string json = base.GET(String.Format("{0}/{1}", this.path, messageId));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new PersyException(String.Format("Failed to get message {0} information", messageId ?? ""));
            }

            return Message.fromJson(json);
        }

        /// <summary>
        /// Retrieve a list of messages from Persephony.
        /// </summary>
        /// <param name="filters">Optional MessagesSearchFilter instance to filter list of messages.</param>
        /// <returns>
        /// An in-language representation of Persephony's paginated list response.This will be a paginated list 
        /// of message instances as returned by the Persephony API. 
        /// </returns>
        /// <exception cref="PersyException">Thrown upon failed request.</exception>
        /// <see cref="MessagesSearchFilter">MessagesSearchFilter class.</see>
        public MessageList get(MessagesSearchFilter filters = null)
        {
            string json = base.GET(this.path, ((filters != null) ? filters.toDict() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new PersyException("Failed to get message list");
            }

            MessageList list = new MessageList(this.getAccountId, this.getAuthToken, json);

            return list;
        }

    }
}