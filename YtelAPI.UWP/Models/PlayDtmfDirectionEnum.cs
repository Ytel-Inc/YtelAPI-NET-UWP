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
    public enum PlayDtmfDirectionEnum
    {
        ENUM_IN, //TODO: Write general description for this method
        ENUM_OUT, //TODO: Write general description for this method
        BOTH, //TODO: Write general description for this method
    }

    /// <summary>
    /// Helper for the enum type PlayDtmfDirectionEnum
    /// </summary>
    public static class PlayDtmfDirectionEnumHelper
    {
        //string values corresponding the enum elements
        private static List<string> stringValues = new List<string> { "in", "out", "both" };

        /// <summary>
        /// Converts a PlayDtmfDirectionEnum value to a corresponding string value
        /// </summary>
        /// <param name="enumValue">The PlayDtmfDirectionEnum value to convert</param>
        /// <returns>The representative string value</returns>
        public static string ToValue(PlayDtmfDirectionEnum enumValue)
        {
            switch(enumValue)
            {
                //only valid enum elements can be used
                //this is necessary to avoid errors
                case PlayDtmfDirectionEnum.ENUM_IN:
                case PlayDtmfDirectionEnum.ENUM_OUT:
                case PlayDtmfDirectionEnum.BOTH:
                    return stringValues[(int)enumValue];

                //an invalid enum value was requested
                default:
                    return null;
            }
        }

        /// <summary>
        /// Convert a list of PlayDtmfDirectionEnum values to a list of strings
        /// </summary>
        /// <param name="enumValues">The list of PlayDtmfDirectionEnum values to convert</param>
        /// <returns>The list of representative string values</returns>
        public static List<string> ToValue(List<PlayDtmfDirectionEnum> enumValues)
        {
            if (null == enumValues)
                return null;

            return enumValues.Select(eVal => ToValue(eVal)).ToList();
        }

        /// <summary>
        /// Converts a string value into PlayDtmfDirectionEnum value
        /// </summary>
        /// <param name="value">The string value to parse</param>
        /// <returns>The parsed PlayDtmfDirectionEnum value</returns>
        public static PlayDtmfDirectionEnum ParseString(string value)
        {
            int index = stringValues.IndexOf(value);
            if(index < 0)
                throw new InvalidCastException(string.Format("Unable to cast value: {0} to type PlayDtmfDirectionEnum", value));

            return (PlayDtmfDirectionEnum) index;
        }
    }
} 