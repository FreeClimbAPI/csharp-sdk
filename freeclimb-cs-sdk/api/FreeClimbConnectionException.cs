using System;

namespace com.freeclimb.api
{
    /// <summary>
    /// This exception is thrown when the SDK runs into problems with establishing a
    /// connection with the FreeClimb API.
    /// </summary>
    [Serializable]
    public class FreeClimbConnectionException : FreeClimbException
    {
        /// <summary>
        /// Initializes a new instance of the FreeClimbConnectionException class.
        /// </summary>
        public FreeClimbConnectionException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FreeClimbConnectionException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public FreeClimbConnectionException(string message) : base(String.Format("APIConnection::{0}",message))
        {
        }

        /// <summary>
        /// Initializes a new instance of the FreeClimbConnectionException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference if no inner exception is specified. </param>
        public FreeClimbConnectionException(string message, Exception inner) : base(String.Format("APIConnection::{0}", message), 
                                                                                inner)
        {
        }
    }
}
