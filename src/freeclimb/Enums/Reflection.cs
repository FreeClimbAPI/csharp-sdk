using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace freeclimb.Enums {

    public static class Reflection {
          /// <summary>
        /// Retrieves an enum item from a specified string by matching the string to the EnumMemberAttribute
        /// elements assigned to each enum item
        /// </summary>
        /// <typeparam name="TEnum">The enum type that should be returned</typeparam>
        /// <param name="value">The value that should be searched</param>
        /// <param name="ignoreCase">Whether string comparison of values should be case-sensitive or not</param>
        /// <returns>The matched enum item</returns>
        /// <exception cref="ArgumentException">Thrown if no enum item could be found with the corresponding value</exception>
        public static TEnum GetEnumByValue<TEnum>(string value, bool ignoreCase = false) 
            // Add a condition to the generic type
            where TEnum : Enum
        {
            // Loop through all the items in the specified enum
            foreach (var item in typeof(TEnum).GetFields())
            {
                // Check to see if the enum item has a value attribute
                if (Attribute.GetCustomAttribute(item, typeof(EnumMemberAttribute)) is
                    EnumMemberAttribute attribute)
                {
                    // If the enum item has a value attribute, then check if
                    // the value matches the given value parameter
                    if (string.Equals(attribute.Value, value,
                        ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal))
                        return (TEnum) item.GetValue(null);
                }
            }

            // If no enum item was found with the specified value , throw an
            // exception
            throw new ArgumentException($"Enum item with value \"{value}\" could not be found",
                nameof(value));
        }

        /// <summary>
        /// Tries to retrieve an enum item from the specified string by matching the string to the EnumMemberAttribute 
        /// elements assigned to each enum item
        /// </summary>
        /// <typeparam name="TEnum">The enum type that should be retrieved</typeparam>
        /// <param name="value">The value that should be searched</param>
        /// <param name="ignoreCase">Whether string comparison of values should be case-sensitive or not</param>
        /// <param name="result">The matched enum item if it was found</param>
        /// <returns>Whether or not the enum item was found or not</returns>
        public static bool TryGetEnumByValue<TEnum>(string value, bool ignoreCase, out TEnum result)
            where TEnum : Enum
        {
            try
            {
                // We try to get the enum using our original method
                result = GetEnumByValue<TEnum>(value, ignoreCase);
                return true;
            }
            catch (ArgumentException)
            {
                // If we cannot retrieve the enum item, set it to the default and
                // return false
                result = default(TEnum);
                return false;
            }
        }

        /// <summary>
        /// Tries to retrieve an enum item from the specified string by matching the string to the EnumMemberAttribute
        /// elements assigned to each enum item
        /// </summary>
        /// <typeparam name="TEnum">The enum type that should be retrieved</typeparam>
        /// <param name="value">The value that should be searched</param>
        /// <param name="result">The matched enum item if it was found</param>
        /// <returns>Whether or not the enum item was found or not</returns>
        public static bool TryGetEnumByValue<TEnum>(string value, out TEnum result)
            where TEnum : Enum
        {
            return TryGetEnumByValue(value, false, out result);
        }
    }

}