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
    public class Body33 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string offset;
        private string limit;

        /// <summary>
        /// The starting point of the list of blocked emails that should be returned.
        /// </summary>
        [JsonProperty("Offset")]
        public string Offset 
        { 
            get 
            {
                return this.offset; 
            } 
            set 
            {
                this.offset = value;
                onPropertyChanged("Offset");
            }
        }

        /// <summary>
        /// The count of results that should be returned.
        /// </summary>
        [JsonProperty("Limit")]
        public string Limit 
        { 
            get 
            {
                return this.limit; 
            } 
            set 
            {
                this.limit = value;
                onPropertyChanged("Limit");
            }
        }
    }
} 