using System;
using System.Globalization;
using System.Runtime.Serialization;
using com.freeclimb.api;

namespace com.freeclimb
{
    /// <summary>
    /// Date only structure.
    /// </summary>
    public struct Date : IComparable, IFormattable, ISerializable, IComparable<Date>, IEquatable<Date>
    {
        private DateTime _dt;

        /// <summary>
        /// Static Maximum Date instance value.
        /// </summary>
        public static readonly Date MaxValue = new Date(DateTime.MaxValue);

        /// <summary>
        /// Static Minimum Date instance value.
        /// </summary>
        public static readonly Date MinValue = new Date(DateTime.MinValue);

        /// <summary>
        /// Creates Date instance.
        /// </summary>
        /// <param name="year">Integer year.</param>
        /// <param name="month">Integer month.</param>
        /// <param name="day">Integer day.</param>
        /// <exception cref="FreeClimbDateException">Thrown upon failed request.</exception>
        public Date(int year, int month, int day)
        {
            try
            {
                this._dt = new DateTime(year, month, day);
            }
            catch (Exception /* e */)
            {
                throw new FreeClimbDateException(year, month, day);
            }
        }

        /// <summary>
        /// Creates Date instance.
        /// </summary>
        /// <param name="dateTime">DateTime instance.</param>
        /// <exception cref="FreeClimbDateException">Thrown upon failed request.</exception>
        public Date(DateTime dateTime)
        {
            try
            {
                this._dt = dateTime.AddTicks(-dateTime.Ticks % TimeSpan.TicksPerDay);
            }
            catch (Exception /* e */)
            {
                throw new FreeClimbDateException(((dateTime != null) ? dateTime.ToLongTimeString() : "Null"));
            }
        }

        /// <summary>
        /// Date substraction operator.
        /// </summary>
        /// <param name="d1">Minuend Date structure.</param>
        /// <param name="d2">Subtrahend Date structure.</param>
        /// <returns>TimeSpan structure difference</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static TimeSpan operator -(Date d1, Date d2)
        {
            try
            {
                return d1._dt - d2._dt;
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Date substraction operator.
        /// </summary>
        /// <param name="d">Date structure.</param>
        /// <param name="t">Subtrahend TimeSpan structure.</param>
        /// <returns>Date structure</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static Date operator -(Date d, TimeSpan t)
        {
            try
            {
                return new Date(d._dt - t);
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }


        /// <summary>
        /// Date inequality operator.
        /// </summary>
        /// <param name="d1">Date structure.</param>
        /// <param name="d2">Date structure.</param>
        /// <returns>true if not equal otherwise false.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static bool operator !=(Date d1, Date d2)
        {
            try
            {
                return d1._dt != d2._dt;
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Date addition operator.
        /// </summary>
        /// <param name="d">Date structure.</param>
        /// <param name="t">Added TimeSpan structure.</param>
        /// <returns>Date structure sum.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static Date operator +(Date d, TimeSpan t)
        {
            try
            {
                return new Date(d._dt + t);
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Date less then operator.
        /// </summary>
        /// <param name="d1">Date structure one.</param>
        /// <param name="d2">Date structure two.</param>
        /// <returns>Bool true if Date one is less then Date two.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static bool operator <(Date d1, Date d2)
        {
            try
            {
                return d1._dt < d2._dt;
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Date less then or equal operator.
        /// </summary>
        /// <param name="d1">Date structure one.</param>
        /// <param name="d2">Date structure two.</param>
        /// <returns>Bool true if Date one is less then or equal to Date two.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static bool operator <=(Date d1, Date d2)
        {
            try
            {
                return d1._dt <= d2._dt;
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Date equality operator.
        /// </summary>
        /// <param name="d1">Date structure.</param>
        /// <param name="d2">Date structure.</param>
        /// <returns>true if equal otherwise false.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static bool operator ==(Date d1, Date d2)
        {
            try
            { 
                return d1._dt == d2._dt;
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Date greater then operator.
        /// </summary>
        /// <param name="d1">Date structure one.</param>
        /// <param name="d2">Date structure two.</param>
        /// <returns>Bool true if Date one greater then Date two.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static bool operator >(Date d1, Date d2)
        {
            try
            {
                return d1._dt > d2._dt;
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Date greater then or equal operator.
        /// </summary>
        /// <param name="d1">Date structure one.</param>
        /// <param name="d2">Date structure two.</param>
        /// <returns>Bool true if Date one greater then or equal to Date two.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static bool operator >=(Date d1, Date d2)
        {
            try
            {
                return d1._dt >= d2._dt;
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Date to DateTime conversion.
        /// </summary>
        /// <param name="d">Date structure.</param>
        /// <returns>DateTime equivalent.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static implicit operator DateTime(Date d)
        {
            try
            {
                return d._dt;
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// DateTime to Date conversion.
        /// </summary>
        /// <param name="d">DateTime structure.</param>
        /// <returns>Date equivalent.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static explicit operator Date(DateTime d)
        {
            try
            {
                return new Date(d);
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Retrieves integer day from instance.
        /// </summary>
        /// <returns>Instance integer day.</returns>
        public int Day
        {
            get
            {
                return this._dt.Day;
            }
        }

        /// <summary>
        /// Retrieves DayOfWeek enumeration from instance.
        /// </summary>
        /// <returns>Instance DayOfWeek enumeration.</returns>
        public DayOfWeek DayOfWeek
        {
            get
            {
                return this._dt.DayOfWeek;
            }
        }

        /// <summary>
        /// Retrieves DayOfYear enumeration from instance.
        /// </summary>
        /// <returns>Instance DayOfYear enumeration.</returns>
        public int DayOfYear
        {
            get
            {
                return this._dt.DayOfYear;
            }
        }

        /// <summary>
        /// Retrieves integer month from instance.
        /// </summary>
        /// <returns>Instance integer month.</returns>
        public int Month
        {
            get
            {
                return this._dt.Month;
            }
        }

        /// <summary>
        /// Creates local current Date instance.
        /// </summary>
        /// <returns>Date instance.</returns>
        public static Date Today
        {
            get
            {
                return new Date(DateTime.Today);
            }
        }

        /// <summary>
        /// Retrieves integer year from instance.
        /// </summary>
        /// <returns>Instance integer year.</returns>
        public int Year
        {
            get
            {
                return this._dt.Year;
            }
        }

        /// <summary>
        /// Creates Date instance from current instance plus parameter days.
        /// </summary>
        /// <param name="value">Integer number of days to add.</param>
        /// <returns>Date instance.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Date AddDays(int value)
        {
            try
            { 
                return new Date(this._dt.AddDays(value));
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Creates Date instance from current instance plus parameter months.
        /// </summary>
        /// <param name="value">Integer number of months to add.</param>
        /// <returns>Date instance.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Date AddMonths(int value)
        {
            try
            {
                return new Date(this._dt.AddMonths(value));
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Creates Date instance from current instance plus parameter years.
        /// </summary>
        /// <param name="value">Integer number of years to add.</param>
        /// <returns>Date instance.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public Date AddYears(int value)
        {
            try
            {
                return new Date(this._dt.AddYears(value));
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Compares two Date instances. 
        /// </summary>
        /// <param name="d1">Date structure one.</param>
        /// <param name="d2">Date structure two.</param>
        /// <returns>Integer where zero indicates equal, less then zero if one is less then two and larger then zero if one is greater then two.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static int Compare(Date d1, Date d2)
        {
            try
            {
                return d1.CompareTo(d2);
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="value">Date structure.</param>
        /// <returns>Integer where zero indicates equal, less then zero if one is less then two and larger then zero if one is greater then two.</returns>
        /// <see>System.IComparable interface.</see>
        public int CompareTo(Date value)
        {
            try
            {
                return this._dt.CompareTo(value._dt);
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="value">Object of type Date structure.</param>
        /// <returns>Integer where zero indicates equal, less then zero if one is less then two and larger then zero if one is greater then two.</returns>
        /// <see>System.IComparable interface.</see>
        public int CompareTo(object value)
        {
            try
            {
                return this._dt.CompareTo(value);
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Calculates number of days in a month and year in local time zone. 
        /// </summary>
        /// <param name="year">Integer year.</param>
        /// <param name="month">Integer month.</param>
        /// <returns>Number of days.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        public static int DaysInMonth(int year, int month)
        {
            try
            { 
                return DateTime.DaysInMonth(year, month);
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="value">Date structure.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public bool Equals(Date value)
        {
            return this._dt.Equals(value._dt);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type.
        /// </summary>
        /// <param name="value">Object of type Date structure.</param>
        /// <returns>true if the current object is equal to the other parameter; otherwise, false.</returns>
        /// <see>System.IEquatable interface.</see>
        public override bool Equals(object value)
        {
            return value is Date && this._dt.Equals(((Date)value)._dt);
        }

        /// <summary>
        /// Serves as the default hash function.
        /// </summary>
        /// <returns>A hash code for the current object.</returns>
        /// <see>System.IEquatable interface.</see>
        public override int GetHashCode()
        {
            return this._dt.GetHashCode();
        }

        /// <summary>
        /// Helper method to deep compare two Recording instances.
        /// </summary>
        /// <param name="a">Recording instance one.</param>
        /// <param name="b">Recording instance two.</param>
        /// <returns>True is a == b, otherwise false.</returns>
        public static bool Equal(Date a, Date b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            return a._dt.Equals(b._dt);
        }

        /// <see cref="ISerializable">ISerializable interface.</see>
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("ticks", this._dt.Ticks);
        }

        /// <summary>
        /// Returns an indication whether the specified year is a leap year.
        /// </summary>
        /// <param name="year">A 4-digit year.</param>
        /// <returns>true if year is a leap year; otherwise, false.</returns>
        /// <see cref="DateTime">DateTime method.</see>
        public static bool IsLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        /// <summary>
        /// Converts the string representation of a date and time to its DateTime equivalent.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert.</param>
        /// <returns>An object that is equivalent to the date and time contained in s.</returns>
        /// <see cref="DateTime">DateTime method.</see>
        public static Date Parse(string s)
        {
            return new Date(DateTime.Parse(s));
        }

        /// <summary>
        /// Converts the string representation of a date and time to its DateTime equivalent by using culture-specific format information.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert.</param>
        /// <param name="provider">An object that supplies culture-specific format information about s.</param>
        /// <returns>An object that is equivalent to the date and time contained in s as specified by provider.</returns>
        /// <see cref="DateTime">DateTime method.</see>
        public static Date Parse(string s, IFormatProvider provider)
        {
            return new Date(DateTime.Parse(s, provider));
        }

        /// <summary>
        /// Converts the string representation of a date and time to its DateTime equivalent by using culture-specific format information and formatting style.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert.</param>
        /// <param name="provider">An object that supplies culture-specific format information about s.</param>
        /// <param name="style">A bitwise combination of the enumeration values that indicates the style elements that can be present in s for the parse operation to succeed, and that defines how to interpret the parsed date in relation to the current time zone or the current date.</param>
        /// <returns>An object that is equivalent to the date and time contained in s, as specified by provider and styles.</returns>
        /// <see cref="DateTime">DateTime method.</see>
        public static Date Parse(string s, IFormatProvider provider, DateTimeStyles style)
        {
            return new Date(DateTime.Parse(s, provider, style));
        }

        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified format and culture-specific format information. The format of the string representation must match the specified format exactly.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert.</param>
        /// <param name="format">A format specifier that defines the required format of s.</param>
        /// <param name="provider">An object that supplies culture-specific format information about s.</param>
        /// <returns>An object that is equivalent to the date and time contained in s, as specified by provider and styles.</returns>
        /// <see cref="DateTime">DateTime method.</see>
        public static Date ParseExact(string s, string format, IFormatProvider provider)
        {
            return new Date(DateTime.ParseExact(s, format, provider));
        }

        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly or an exception is thrown.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert.</param>
        /// <param name="format">A format specifier that defines the required format of s.</param>
        /// <param name="provider">An object that supplies culture-specific format information about s.</param>
        /// <param name="style">A bitwise combination of the enumeration values that provides additional information about s, about style elements that may be present in s, or about the conversion from s to a DateTime value.</param>
        /// <returns>An object that is equivalent to the date and time contained in s, as specified by format, provider, and style.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="DateTime">DateTime method.</see>
        public static Date ParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style)
        {
            try
            {
                return new Date(DateTime.ParseExact(s, format, provider, style));
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified format, culture-specific format information, and style. The format of the string representation must match the specified format exactly or an exception is thrown.
        /// </summary>
        /// <param name="s">A string that contains a date and time to convert.</param>
        /// <param name="formats">An array of allowable formats of s.</param>
        /// <param name="provider">An object that supplies culture-specific format information about s.</param>
        /// <param name="style">A bitwise combination of the enumeration values that provides additional information about s, about style elements that may be present in s, or about the conversion from s to a DateTime value.</param>
        /// <returns>An object that is equivalent to the date and time contained in s, as specified by formats, provider, and style.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="DateTime">DateTime method.</see>
        public static Date ParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style)
        {
            try
            {
                return new Date(DateTime.ParseExact(s, formats, provider, style));
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Date substraction.
        /// </summary>
        /// <param name="value">Subtrahend Date structure.</param>
        /// <returns>TimeSpan structure</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="DateTime">DateTime method.</see>
        public TimeSpan Subtract(Date value)
        {
            try
            {
                return this - value;
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Date TimeSpan substraction.
        /// </summary>
        /// <param name="value">Subtrahend TimeSpan structure.</param>
        /// <returns>Date structure</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="DateTime">DateTime method.</see>
        public Date Subtract(TimeSpan value)
        {
            try
            { 
                return this - value;
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Converts the value of the current DateTime object to its equivalent long time string representation.
        /// </summary>
        /// <returns>A string that contains the long date string representation of the current DateTime object.</returns>
        /// <see cref="DateTime">DateTime method.</see>
        public string ToLongDateString()
        {
            return this._dt.ToLongDateString();
        }

        /// <summary>
        /// Converts the value of the current DateTime object to its equivalent short date string representation.
        /// </summary>
        /// <returns>A string that contains the short date string representation of the current DateTime object.</returns>
        /// <see cref="DateTime">DateTime method.</see>
        public string ToShortDateString()
        {
            return this._dt.ToShortDateString();
        }

        /// <summary>
        /// Converts the value of the current DateTime object to its equivalent string representation using the specified culture-specific format information.
        /// </summary>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>A string representation of value of the current DateTime object as specified by provider.</returns>
        /// <see cref="DateTime">DateTime method.</see>
        public string ToString(IFormatProvider provider)
        {
            return this._dt.ToString(provider);
        }

        /// <summary>
        /// Converts the value of the current DateTime object to its equivalent string representation using the specified format and the formatting conventions of the current culture.
        /// </summary>
        /// <param name="format">A standard or custom date and time format string.</param>
        /// <returns>A string representation of value of the current DateTime object as specified by format.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="DateTime">DateTime method.</see>
        public string ToString(string format)
        {
            try
            {
                if (format == "O" || format == "o" || format == "s")
                {
                    return this.ToString("yyyy-MM-dd");
                }

                return this._dt.ToString(format);
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Converts the value of the current DateTime object to its equivalent string representation using the specified format and culture-specific format information.
        /// </summary>
        /// <param name="format">A standard or custom date and time format string.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <returns>A string representation of value of the current DateTime object as specified by format and provider.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="DateTime">DateTime method.</see>
        public string ToString(string format, IFormatProvider provider)
        {
            try
            {
                return this._dt.ToString(format, provider);
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="result">When this method returns, contains the DateTime value equivalent to the date and time contained in s, if the conversion succeeded, or MinValue if the conversion failed. The conversion fails if the s parameter is null, is an empty string (""), or does not contain a valid string representation of a date and time. This parameter is passed uninitialized.</param>
        /// <returns>true if the s parameter was converted successfully; otherwise, false.</returns>
        /// <see cref="DateTime">DateTime method.</see>
        public static bool TryParse(string s, out Date result)
        {
            DateTime d;
            bool success = DateTime.TryParse(s, out d);
            result = new Date(d);
            return success;
        }

        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified culture-specific format information and formatting style, and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s.</param>
        /// <param name="style">A bitwise combination of enumeration values that defines how to interpret the parsed date in relation to the current time zone or the current date.</param>
        /// <param name="result">When this method returns, contains the DateTime value equivalent to the date and time contained in s, if the conversion succeeded, or MinValue if the conversion failed. The conversion fails if the s parameter is null, is an empty string (""), or does not contain a valid string representation of a date and time. This parameter is passed uninitialized.</param>
        /// <returns>true if the s parameter was converted successfully; otherwise, false.</returns>
        /// <see cref="DateTime">DateTime method.</see>
        public static bool TryParse(string s, IFormatProvider provider, DateTimeStyles style, out Date result)
        {
            DateTime d;
            bool success = DateTime.TryParse(s, provider, style, out d);
            result = new Date(d);
            return success;
        }

        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified culture-specific format information and formatting style, and returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="format">An object that supplies culture-specific formatting information about s.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s.</param>
        /// <param name="style">A bitwise combination of one or more enumeration values that indicate the permitted format of s.</param>
        /// <param name="result">When this method returns, contains the DateTime value equivalent to the date and time contained in s, if the conversion succeeded, or MinValue if the conversion failed. The conversion fails if the s parameter is null, is an empty string (""), or does not contain a valid string representation of a date and time. This parameter is passed uninitialized.</param>
        /// <returns>true if the s parameter was converted successfully; otherwise, false.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="DateTime">DateTime method.</see>
        public static bool TryParseExact(string s, string format, IFormatProvider provider, DateTimeStyles style, out Date result)
        {
            try
            { 
                DateTime d;
                bool success = DateTime.TryParseExact(s, format, provider, style, out d);
                result = new Date(d);
                return success;
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }

        /// <summary>
        /// Converts the specified string representation of a date and time to its DateTime equivalent using the specified array of formats, culture-specific format information, and style. The format of the string representation must match at least one of the specified formats exactly. The method returns a value that indicates whether the conversion succeeded.
        /// </summary>
        /// <param name="s">A string containing a date and time to convert.</param>
        /// <param name="formats">An array of allowable formats of s.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information about s.</param>
        /// <param name="style">A bitwise combination of one or more enumeration values that indicate the permitted format of s.</param>
        /// <param name="result">When this method returns, contains the DateTime value equivalent to the date and time contained in s, if the conversion succeeded, or MinValue if the conversion failed. The conversion fails if the s parameter is null, is an empty string (""), or does not contain a valid string representation of a date and time. This parameter is passed uninitialized.</param>
        /// <returns>true if the s parameter was converted successfully; otherwise, false.</returns>
        /// <exception cref="FreeClimbException">Thrown upon failed request.</exception>
        /// <see cref="DateTime">DateTime method.</see>
        public static bool TryParseExact(string s, string[] formats, IFormatProvider provider, DateTimeStyles style, out Date result)
        {
            try
            {
                DateTime d;
                bool success = DateTime.TryParseExact(s, formats, provider, style, out d);
                result = new Date(d);
                return success;
            }
            catch (Exception e)
            {
                throw new FreeClimbException(e.Message);
            }
        }
    }
}
