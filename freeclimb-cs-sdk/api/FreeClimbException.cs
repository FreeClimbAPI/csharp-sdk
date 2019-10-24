using System;

namespace com.freeclimb.api
{
    /// <summary>
    /// Base FreeClimb exception class off of which all other exceptions in the SDK are based.
    /// </summary>
    [Serializable]
    public class FreeClimbException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the FreeClimbException class.
        /// </summary>
        public FreeClimbException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FreeClimbException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public FreeClimbException(string message) : base(String.Format("FreeClimbException::{0}", message))
        {
        }

        /// <summary>
        /// Initializes a new instance of the FreeClimbException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference if no inner exception is specified. </param>
        public FreeClimbException(string message, Exception inner) : base(String.Format("FreeClimbException::{0}",message), 
                                                                      inner)
        {
        }
    }
}
