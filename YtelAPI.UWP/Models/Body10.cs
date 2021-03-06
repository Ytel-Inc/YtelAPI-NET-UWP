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
    public class Body10 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string recordingSid;

        /// <summary>
        /// The unique identifier for a recording object.
        /// </summary>
        [JsonProperty("recordingSid")]
        public string RecordingSid 
        { 
            get 
            {
                return this.recordingSid; 
            } 
            set 
            {
                this.recordingSid = value;
                onPropertyChanged("RecordingSid");
            }
        }
    }
} 