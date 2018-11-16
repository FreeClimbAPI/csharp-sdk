using System;

namespace com.persephony.api
{
    /// <summary>
    /// This exception is thrown when the SDK runs into problems parse a date string.
    /// </summary>
    [Serializable]
    public class PersyDateException : PersyException
    {
        /// <summary>
        /// Initializes a new instance of the PersyDateException class with a specified date string.
        /// </summary>
        /// <param name="date">The offending date string.</param>
        public PersyDateException(string date) : base(String.Format("Poorly formatted date::`{0}`",date))
        { 
        }

        /// <summary>
        /// Initializes a new instance of the PersyDateException class with a specified year, month and day string.
        /// </summary>
        /// <param name="year">Year</param>
        /// <param name="month">Month</param>
        /// <param name="day">Day</param>
        public PersyDateException(int year, int month, int day) : base(String.Format("Poorly formatted date::`{0}:{1}:{2}`", 
                                                                                     year.ToString(), 
                                                                                     month.ToString(), 
                                                                                     day.ToString()))
        {
        }
    }
}
