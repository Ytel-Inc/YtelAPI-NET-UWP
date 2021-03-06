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
    public class Body45 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private string phoneNumber;

        /// <summary>
        /// A valid 10-digit number (E.164 format).
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber 
        { 
            get 
            {
                return this.phoneNumber; 
            } 
            set 
            {
                this.phoneNumber = value;
                onPropertyChanged("PhoneNumber");
            }
        }
    }
} 