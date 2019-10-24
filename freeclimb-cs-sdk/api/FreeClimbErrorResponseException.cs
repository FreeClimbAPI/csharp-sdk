using System;

namespace com.freeclimb.api
{
    /// <summary>
    /// This exception is thrown when the FreeClimb API responds with and HTTP error code to some user request.
    /// </summary>
    [Serializable]
    public class FreeClimbErrorResponseException : FreeClimbException
    {
        private readonly FreeClimbError pe;

        /// <summary>
        /// Initializes a new instance of the FreeClimbErrorResponseException class with a specified string contents.
        /// </summary>
        /// <param name="status">Response status code</param>
        /// <param name="message">Response status description</param>
        /// <param name="code">Code</param>
        /// <param name="info">Message</param>
        public FreeClimbErrorResponseException(int status, String message, int code, String info) : base(String.Format("ErrorResponse ({0})::{1}:{2}",status,code,message))
        {
            this.pe = new FreeClimbError(status, message, code, info);
        }

        /// <summary>
        /// Initializes a new instance of the FreeClimbErrorResponseException class with a specified string contents.
        /// </summary>
        /// <param name="pe">FreeClimbError object.</param>
        /// <see cref="DateTime">FreeClimbError method.</see>
        public FreeClimbErrorResponseException(FreeClimbError pe) : base(String.Format("ErrorResponse ({0})::{1}:{2}",pe.getStatus,pe.getCode,pe.getMessage))
        {
            this.pe = pe;
        }

        /// <summary>
        /// Returns intenral FreeClimbError object.
        /// </summary>
        /// <returns>Object representing the error payload returned from the FreeClimb API.</returns>
        public FreeClimbError getError { get { return this.pe; } }
    }
}
