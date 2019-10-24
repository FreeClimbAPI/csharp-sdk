using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using com.freeclimb.api.recording;

namespace com.freeclimb.api.conference
{
    /// <summary>
    /// This class represents the set of wrappers around the FreeClimb Conference API.
    /// It provides methods to handle all the operations supported by the FreeClimb
    /// Conference API.
    /// </summary>
    public sealed class ConferencesRequester : APIRequester
    {
        private readonly string path;

        /// <summary>
        /// Creates a ConferenceRequester. For most SDK users ConferenceRequester will be
        /// created automatically by the FreeClimbClient but is available for more
        /// users who only require the features in this specific requester and not 
        /// the rest of the features of the FreeClimbClient.
        /// </summary>
        /// <param name="credAccountId">The accountId to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="credAuthToken">The authToken to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="accountId">The accountId to act as. This can be the same as the credAccountId or the accountId of a subaccount of the credAccountId.</param>
        public ConferencesRequester(string credAccountId, string credAuthToken, string accountId) : base(credAccountId, credAuthToken)
        {
            this.path = "/Accounts/" + accountId + "/Conferences";
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
        /// Create a new conference through the FreeClimb API using a registered
        /// FreeClimb application.
        /// </summary>
        /// <param name="conferenceOptions">Optional ConferenceOptions instance to be used when creating a queue.</param> 
        /// <returns>A Queue object returned by FreeClimb that represents the queue that was created.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="ConferenceCreateOptions">ConferenceCreateOptions class.</see>
        public Conference create(ConferenceCreateOptions conferenceOptions = null)
        {
            string json = base.POST(this.path, ((conferenceOptions != null) ? conferenceOptions.toJson() : null));

            if (string.IsNullOrEmpty(json) == true)
            {

                throw new FreeClimbException(String.Format("Failed to create conference with options {0}", ((conferenceOptions != null) ? conferenceOptions.toJson() : string.Empty)));
            }

            return Conference.fromJson(json);
        }

        /// <summary>
        /// Retrieve a list of conferences from FreeClimb.
        /// </summary>
        /// <param name="filters">Optional ConferenceSearchFilters instance to filter list of queues.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response.This will be a paginated list 
        /// of conference instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="ConferenceSearchFilters">ConferenceSearchFilters class.</see>
        public ConferenceList getConferences(ConferenceSearchFilters filters = null)
        {
            string json = base.GET(this.path, ((filters != null) ? filters.toDict() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException("Failed to get conference list");
            }

            ConferenceList list = new ConferenceList(this.getAccountId, this.getAuthToken, json);

            return list;
        }

        /// <summary>
        /// Retrieve a single conference from FreeClimb.
        /// </summary>
        /// <param name="conferenceId">Target conference to retrieve information.</param> 
        /// <returns>A Conference object returned by FreeClimb that represents the queue that was retrieved.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Conference getConference(string conferenceId)
        {
            string json = base.GET(String.Format("{0}/{1}", this.path, conferenceId));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get conference {0} information", conferenceId ?? ""));
            }

            return Conference.fromJson(json);
        }

        /// <summary>
        /// Update a single conference. 
        /// </summary>
        /// <param name="conferenceId">The conferenceId of the target conference.</param>
        /// <param name="conferenceOptions">Optional ConferenceOptions instance to be used when updating a conference.</param>
        /// <returns>The conference matching the conferenceId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Conference update(string conferenceId, ConferenceOptions conferenceOptions = null)
        {
            string json = base.POST(String.Format("{0}/{1}", this.path, conferenceId), ((conferenceOptions != null) ? conferenceOptions.toJson() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to update conference {0} information", conferenceId ?? ""));
            }

            return Conference.fromJson(json);
        }

        /// <summary>
        /// Update a single participant. 
        /// </summary>
        /// <param name="conferenceId">The conferenceId of the target conference.</param>
        /// <param name="callId">The callId of the target conference.</param>
        /// <param name="participantOptions">Optional ParticipantOptions instance to be used when updating a conference participant.</param>
        /// <returns>The Participant matching the conferenceId and callId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Participant update(string conferenceId, string callId, ParticipantOptions participantOptions = null)
        {
            string json = base.POST(String.Format("{0}/{1}/Participants/{2}", this.path, conferenceId, callId), ((participantOptions != null) ? participantOptions.toJson() : null));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to update conference {0} participant {1} information", conferenceId ?? "", callId ?? ""));
            }

            return Participant.fromJson(json);
        }

        /// <summary>
        /// Retrieve a list of recordings data associated with the conferenceId.
        /// </summary>
        /// <param name="conferenceId">The conferenceId of the target conference.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response. This will be a paginated list 
        /// of recording instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public RecordingList getRecordings(string conferenceId)
        {
            string json = base.GET(String.Format("{0}/{1}/Recordings", this.path, conferenceId));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get recording list information for conference {0}", conferenceId ?? ""));
            }

            return new RecordingList(this.getAccountId, this.getAuthToken, json);
        }

        /// <summary>
        /// Retrieve a list of participant data associated with the conferenceId.
        /// </summary>
        /// <param name="conferenceId">The conferenceId of the target conference.</param>
        /// <param name="talk">Retrieves talk enabled participants of the target conference.</param>
        /// <param name="listen">Retrieves listen enabled participants of the target conference.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response. This will be a paginated list 
        /// of participant instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public ParticipantList getParticipants(string conferenceId, bool talk, bool listen)
        {
            IDictionary<string, string> query = new Dictionary<string, string>();

            query.Add("talk", talk.ToString().ToLower());
            query.Add("listen", listen.ToString().ToLower());

            string json = base.GET(String.Format("{0}/{1}/Participants", this.path, conferenceId), query);

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get participant list information for conference {0}", conferenceId ?? ""));
            }

            return new ParticipantList(this.getAccountId, this.getAuthToken, json);
        }

        /// <summary>
        /// Retrieve a list of participant data associated with the conferenceId.
        /// </summary>
        /// <param name="conferenceId">The conferenceId of the target conference.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response. This will be a paginated list 
        /// of participant instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public ParticipantList getParticipants(string conferenceId)
        {
            string json = base.GET(String.Format("{0}/{1}/Participants", this.path, conferenceId));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get participant list information for conference {0}", conferenceId ?? ""));
            }

            return new ParticipantList(this.getAccountId, this.getAuthToken, json);
        }

        /// <summary>
        /// Retrieve a given participant associated with the conferenceId.
        /// </summary>
        /// <param name="conferenceId">The conferenceId of the target conference.</param>
        /// <param name="participantId">The participantId of the target conference.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response. This will be a paginated list 
        /// of participant instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Participant getParticipant(string conferenceId, string participantId)
        {
            string json = base.GET(String.Format("{0}/{1}/Participants/{2}", this.path, conferenceId, participantId));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get participant list information for conference {0}", conferenceId ?? ""));
            }

            return Participant.fromJson(json);
        }

        /// <summary>
        /// Delete a FreeClimb participant from a conference.
        /// </summary>
        /// <param name="conferenceId">The conferenceId of the target conference.</param>
        /// <param name="participantId">The participantId of the target participant in the conference.</param>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public void deleteParticipant(string conferenceId, string participantId)
        {
            base.DELETE(String.Format("{0}/{1}/Participants/{2}", this.path, conferenceId, participantId));
        }

        /// <summary>
        /// Delete a FreeClimb conference.
        /// </summary>
        /// <param name="conferenceId">The conferenceId of the target conference.</param>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public void deleteConference(string conferenceId)
        {
            base.DELETE(String.Format("{0}/{1}", this.path, conferenceId));
        }
    }
}
