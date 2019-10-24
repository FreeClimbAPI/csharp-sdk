using System;
using System.IO;
using System.Runtime.Serialization;

namespace com.freeclimb.api.recording
{
    /// <summary>
    /// This class represents the set of wrappers around the FreeClimb Recordings API.
    /// It provides methods to handle all the operations supported by the FreeClimb
    /// Recordings API.
    /// </summary>
    public sealed class RecordingsRequester : APIRequester
    {
        private readonly string path;

        private enum AudioReturn
        {
            [EnumMember(Value = "Download")]
            Download = 0,
            [EnumMember(Value = "Stream")]
            Stream
        }

        /// <summary>
        /// Creates a RecordingsRequester. For most SDK users RecordingsRequester will be
        /// created automatically by the FreeClimbClient but is available for more
        /// users who only require the features in this specific requester and not 
        /// the rest of the features of the FreeClimbClient.
        /// </summary>
        /// <param name="credAccountId">The accountId to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="credAuthToken">The authToken to use as authentication credentials in the HTTP Basic Auth header for requests made by this requester.</param>
        /// <param name="accountId">The accountId to act as. This can be the same as the credAccountId or the accountId of a subaccount of the credAccountId.</param>
        public RecordingsRequester(string credAccountId, string credAuthToken, string accountId) : base(credAccountId, credAuthToken)
        {
            this.path = "/Accounts/" + accountId + "/Recordings";
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
        /// Retrieve a list of recordings meta data associated with the accountId.
        /// </summary>
        /// <param name="filters">Optional RecordingsSearchFilters instance to filter list of recordings.</param>
        /// <returns>
        /// An in-language representation of FreeClimb's paginated list response. This will be a paginated list 
        /// of recording instances as returned by the FreeClimb API. 
        /// </returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="RecordingsSearchFilters">RecordingsSearchFilters class.</see>
        public RecordingList getMeta(RecordingsSearchFilters filters = null)
        {
            string json = base.GET(this.path, ((filters != null) ? filters.toDict() : null) );

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException("Failed to get recording list information");
            }

            return new RecordingList(this.getAccountId, this.getAuthToken, json);
        }

        /// <summary>
        /// Retrieve a single recording meta data from FreeClimb.
        /// </summary>
        /// <param name="recordingId">The recordingId of the target recording meta data.</param>
        /// <returns>The recording matching the recordingId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Recording getMetaByRecordingId(string recordingId)
        {
            string json = base.GET(String.Format("{0}/{1}", this.path, recordingId));

            if (string.IsNullOrEmpty(json) == true)
            {
                throw new FreeClimbException(String.Format("Failed to get recording {0} information", recordingId ?? ""));
            }

            return Recording.fromJson(json);
        }

        /// <summary>
        /// Retrieve a single recording from FreeClimb.
        /// </summary>
        /// <param name="recordingId">The recordingId of the target recording.</param>
        /// <returns>A recording btye arrary matching the recordingId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public byte[] download(string recordingId)
        {
            MemoryStream memoryStream = new MemoryStream();
            try
            {
                using (BinaryReader reader = new BinaryReader(base.GETStream(String.Format("{0}/{1}/{2}", this.path, recordingId, EnumHelper.GetEnumMemberValue(AudioReturn.Download)))))
                {
                    reader.BaseStream.CopyTo(memoryStream);
                }
            }
            catch (Exception /* e */)
            {
                throw new FreeClimbException(String.Format("Failed to download recording {0}", recordingId ?? ""));
            }

            return memoryStream.ToArray();
        }

        /// <summary>
        /// Stream a single recording from FreeClimb.
        /// </summary>
        /// <param name="recordingId">The recordingId of the target recording.</param>
        /// <returns>A recording stream matching the recordingId provided.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Stream stream(string recordingId)
        {
            Stream stream = base.GETStream(String.Format("{0}/{1}/{2}", this.path, recordingId, EnumHelper.GetEnumMemberValue(AudioReturn.Stream)));

            if (stream == null)
            {
                throw new FreeClimbException(String.Format("Failed to get recording {0} stream", recordingId ?? ""));
            }

            return stream; 
        }

        /// <summary>
        /// Delete a FreeClimb recording and its associated meta data.
        /// </summary>
        /// <param name="recordingId">The recordingId of the target recording and meta data.</param>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public void delete(string recordingId)
        {
            base.DELETE(String.Format("{0}/{1}", this.path, recordingId));
        }
    }
}
