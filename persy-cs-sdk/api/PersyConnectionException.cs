using System;

namespace com.persephony.api
{
    /// <summary>
    /// This exception is thrown when the SDK runs into problems with establishing a
    /// connection with the Persephony API.
    /// </summary>
    [Serializable]
    public class PersyConnectionException : PersyException
    {
        /// <summary>
        /// Initializes a new instance of the PersyConnectionException class.
        /// </summary>
        public PersyConnectionException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the PersyConnectionException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public PersyConnectionException(string message) : base(String.Format("APIConnection::{0}",message))
        {
        }

        /// <summary>
        /// Initializes a new instance of the PersyConnectionException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference if no inner exception is specified. </param>
        public PersyConnectionException(string message, Exception inner) : base(String.Format("APIConnection::{0}", message), 
                                                                                inner)
        {
        }
    }
}
