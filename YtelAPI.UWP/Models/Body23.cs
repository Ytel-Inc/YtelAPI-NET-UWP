/*
 * YtelAPI.UWP
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using YtelAPI.UWP;
using YtelAPI.UWP.Utilities;


namespace YtelAPI.UWP.Models
{
    public class Body23 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string callSid;
        private bool record;
        private Models.DirectionEnum? direction;
        private int? timeLimit;
        private string callBackUrl;
        private Models.FileformatEnum? fileformat;

        /// <summary>
        /// The unique identifier of each call resource
        /// </summary>
        [JsonProperty("CallSid")]
        public string CallSid 
        { 
            get 
            {
                return this.callSid; 
            } 
            set 
            {
                this.callSid = value;
                onPropertyChanged("CallSid");
            }
        }

        /// <summary>
        /// Set true to initiate recording or false to terminate recording
        /// </summary>
        [JsonProperty("Record")]
        public bool Record 
        { 
            get 
            {
                return this.record; 
            } 
            set 
            {
                this.record = value;
                onPropertyChanged("Record");
            }
        }

        /// <summary>
        /// The leg of the call to record
        /// </summary>
        [JsonProperty("Direction", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.DirectionEnum? Direction 
        { 
            get 
            {
                return this.direction; 
            } 
            set 
            {
                this.direction = value;
                onPropertyChanged("Direction");
            }
        }

        /// <summary>
        /// Time in seconds the recording duration should not exceed
        /// </summary>
        [JsonProperty("TimeLimit")]
        public int? TimeLimit 
        { 
            get 
            {
                return this.timeLimit; 
            } 
            set 
            {
                this.timeLimit = value;
                onPropertyChanged("TimeLimit");
            }
        }

        /// <summary>
        /// URL consulted after the recording completes
        /// </summary>
        [JsonProperty("CallBackUrl")]
        public string CallBackUrl 
        { 
            get 
            {
                return this.callBackUrl; 
            } 
            set 
            {
                this.callBackUrl = value;
                onPropertyChanged("CallBackUrl");
            }
        }

        /// <summary>
        /// Format of the recording file. Can be .mp3 or .wav
        /// </summary>
        [JsonProperty("Fileformat", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.FileformatEnum? Fileformat 
        { 
            get 
            {
                return this.fileformat; 
            } 
            set 
            {
                this.fileformat = value;
                onPropertyChanged("Fileformat");
            }
        }
    }
} 