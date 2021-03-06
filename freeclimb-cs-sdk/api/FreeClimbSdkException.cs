﻿using System;
using com.freeclimb.api;

namespace com.freeclimb
{
    /// <summary>
    /// This exception is thrown when something internal is broken in the SDK. If an
    /// SDK user recieves this exception it means somthing in the SDK itself is broken.
    /// User actions should never trigger this exception. It is only raised by an
    /// SDK developer breaking something within the SDK.
    /// </summary>
    [Serializable]
    public class FreeClimbSdkException : FreeClimbException
    {
        /// <summary>
        /// Initializes a new instance of the FreeClimbSdkException class.
        /// </summary>
        public FreeClimbSdkException() : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the FreeClimbSdkException class with a specified error message.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public FreeClimbSdkException(string message) : base(String.Format("SDKInternal::{0}. If receieving this error, please file a bug report.",message))
        {
        }

        /// <summary>
        /// Initializes a new instance of the FreeClimbSdkException class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="inner">The exception that is the cause of the current exception, or a null reference if no inner exception is specified. </param>
        public FreeClimbSdkException(string message, Exception inner) : base(String.Format("SDKInternal::{0}. If receieving this error, please file a bug report.", message), 
                                                                         inner)
        {
        }
    }
}
