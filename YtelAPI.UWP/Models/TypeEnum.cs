/*
 * YtelAPI.UWP
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YtelAPI.UWP;
using YtelAPI.UWP.Utilities;

namespace YtelAPI.UWP.Models
{
    [JsonConverter(typeof(StringValuedEnumConverter))]
    public enum TypeEnum
    {
        TEXT, //TODO: Write general description for this method
        HTML, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type TypeEnum
    /// </summary>
    public static class TypeEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "text", "html" };

        /// <summary>
        /// Converts a TypeEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The TypeEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(TypeEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case TypeEnum.TEXT:
                case TypeEnum.HTML:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of TypeEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of TypeEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<TypeEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into TypeEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed TypeEnum value</returns>
        public static TypeEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type TypeEnum", value));

            return (TypeEnum) index;
        }
    }
} 