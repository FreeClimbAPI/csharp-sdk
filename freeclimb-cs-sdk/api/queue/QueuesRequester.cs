using System;

namespace com.freeclimb.api.queue
{
    /// <summary>
    /// This class represents the set of wrappers around the FreeClimb Queues API.
    /// It provides methods to handle all the operations supported by the FreeClimb
    /// Queues API.
    /// </summary>
    public sealed class QueuesRequester : APIRequester
    {
        private readonly string path;

        /// <summary>
        /// Creates a QueuesRequester. For most SDK users QueuesRequester will be
        /// created automatically by the FreeClimbClient but is available for more
        /// users who only require the features in this specific requester and not 
        /// the rest of the features of the FreeClimbClient.
        /// </summary>
        /// <param name="credAccountId">The accountId to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="credAuthToken">The authToken to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="accountId">The accountId to act as. This can be the same as the credAccountId or the accountId of a subaccount of the credAccountId.</param>
        public QueuesRequester(string credAccountId, string credAuthToken, string accountId) : base(credAccountId, credAuthToken)
        {
            this.path = "/Accounts/" + accountId + "/Queues";
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
        /// Retrieve  authToken object value.
        /// </summary>
        /// <returns>The authToken being used for authentication.</returns>
        public new string getAuthToken { get { return base.getAuthToken; } }

        /// <summary>
        /// Retrieve  FreeClimb API Url object value.
        /// </summary>
        /// <returns>The url being used for the FreeClimb API.</returns>
        public new string getfreeClimbUrl { get { return base.GetFreeClimbUrl; } }

        /// <summary>
        /// Create a new queue through the FreeClimb API using a registered
        /// FreeClimb application.
        /// </summary>
        /// <param name="queueOptions">Optional QueueOptions instance to be used when creating a queue.</param> 
        /// <returns>A Queue object returned by FreeClimb that represents the queue that was created.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="QueueOptions">QueueOptions class.</see>
        public Queue create(QueueOptions queueOptions = null)
        {
            string json = base.POST(this.path, ((queueOptions != null) ? queueOptions.toJson() : null));

            if (string.IsNullOrEmpty(json) == true)
            {

                throw new FreeClimbException(String.Format("Failed to create queue with options {0}", ((queueOptions != null) ? queueOptions.toJson() : string.Empty)));
            }

            return Queue.fromJson(json);
        }

        /// <summary>
        /// Retrieve a single queue member from FreeClimb.
        /// </summary>
        /// <param name="queueId">Target queue to retrieve information.</param> 
        /// <param name="callId">Optional callId of the queue member to retrieve. If not provided the 'Front' is returned.</param>
        /// <returns>A QueueMember object returned by FreeClimb that represents the queue member that was retrieved.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public QueueMember getQueueMember(string queueId, string callId = null)
        {
            string json = base.GET(String.Format("{0}/{1}/Members/{2}", this.path, queueId, ((callId == null) ? "Front" : callId)));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get queue {0} member", queueId ?? ""));
            }

            return QueueMember.fromJson(json);
        }

        /// <summary>
        /// Retrieve a list of queue members from FreeClimb.
        /// </summary>
        /// <param name="queueId">Target queue to retrieve information.</param> 
        /// <returns>A QueueMemberList object returned by FreeClimb that represents the list of queue members.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public QueueMemberList getMembers(string queueId)
        {
            string json = base.GET(String.Format("{0}/{1}/Members", this.path, queueId));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get queue {0} member list", queueId ?? ""));
            }

            QueueMemberList list = new QueueMemberList(this.getAccountId, this.getAuthToken, json);

            // load initial page if not done by API
            if ((list.getLocalSize <= 0) &&
                (list.getTotalSize > 0)) { list.loadNextPage(); }

            return list;
        }

        /// <summary>
        /// Retrieve a list of queues from FreeClimb.
        /// </summary>
        /// <param name="filters">Optional QueuesSearchFilters instance to filter list of queues.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response.This will be a paginated list 
        /// of queue instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="QueuesSearchFilters">QueuesSearchFilters class.</see>
        public QueueList get(QueuesSearchFilters filters = null)
        {
            string json = base.GET(this.path, ((filters != null) ? filters.toDict() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException("Failed to get queue list");
            }

            QueueList list = new QueueList(this.getAccountId, this.getAuthToken, json);

            return list;
        }

        /// <summary>
        /// Retrieve a single queue from FreeClimb.
        /// </summary>
        /// <param name="queueId">Target queue to retrieve information.</param> 
        /// <returns>A Queue object returned by FreeClimb that represents the queue that was retrieved.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Queue get(string queueId)
        {
            string json = base.GET(String.Format("{0}/{1}", this.path, queueId));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get queue {0} information", queueId ?? ""));
            }

            return Queue.fromJson(json);
        }

        /// <summary>
        /// Update a single queue. 
        /// </summary>
        /// <param name="queueId">The queueId of the target queueId.</param>
        /// <param name="queueOptions">Optional QueueOptions instance to be used when updating a queue.</param>
        /// <returns>The queue matching the queueId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Queue update(string queueId, QueueOptions queueOptions = null)
        {
            string json = base.POST(String.Format("{0}/{1}", this.path, queueId), ((queueOptions != null) ? queueOptions.toJson() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to update queue {0} information", queueId ?? ""));
            }

            return Queue.fromJson(json);
        }

        /// <summary>
        /// Update a single queue member. 
        /// </summary>
        /// <param name="queueId">The queueId of the target queueId.</param>
        /// <param name="callId">Optional callId of the queue member to retrieve. If not provided the 'Front' is returned.</param>
        /// <returns>The queue member matching the queueId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public QueueMember updateQueueMember(string queueId, string callId = null)
        {
            string json = base.POST(String.Format("{0}/{1}/Members/{2}", this.path, queueId, ((callId == null) ? "Front" : callId)), null);

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to update queue {0} member", queueId ?? ""));
            }

            return QueueMember.fromJson(json);
        }
    }
}
