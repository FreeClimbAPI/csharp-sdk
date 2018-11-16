using System;

namespace com.persephony.api
{
    /// <summary>
    /// This exception is thrown when the Persephony API responds with and HTTP error code to some user request.
    /// </summary>
    [Serializable]
    public class PersyErrorResponseException : PersyException
    {
        private readonly PersyError pe;

        /// <summary>
        /// Initializes a new instance of the PersyErrorResponseException class with a specified string contents.
        /// </summary>
        /// <param name="status">Response status code</param>
        /// <param name="message">Response status description</param>
        /// <param name="code">Code</param>
        /// <param name="info">Message</param>
        public PersyErrorResponseException(int status, String message, int code, String info) : base(String.Format("ErrorResponse ({0})::{1}:{2}",status,code,message))
        {
            this.pe = new PersyError(status, message, code, info);
        }

        /// <summary>
        /// Initializes a new instance of the PersyErrorResponseException class with a specified string contents.
        /// </summary>
        /// <param name="pe">PersyError object.</param>
        /// <see cref="DateTime">PersyError method.</see>
        public PersyErrorResponseException(PersyError pe) : base(String.Format("ErrorResponse ({0})::{1}:{2}",pe.getStatus,pe.getCode,pe.getMessage))
        {
            this.pe = pe;
        }

        /// <summary>
        /// Returns intenral PersyError object.
        /// </summary>
        /// <returns>Object representing the error payload returned from the Persephony API.</returns>
        public PersyError getError { get { return this.pe; } }
    }
}
