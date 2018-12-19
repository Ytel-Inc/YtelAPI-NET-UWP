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
    public class Body5 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Models.Numbertype1Enum numbertype;
        private string areacode;
        private int? pagesize;

        /// <summary>
        /// Number type either SMS,Voice or all
        /// </summary>
        [JsonProperty("numbertype", ItemConverterType = typeof(StringValuedEnumConverter))]
        public Models.Numbertype1Enum Numbertype 
        { 
            get 
            {
                return this.numbertype; 
            } 
            set 
            {
                this.numbertype = value;
                onPropertyChanged("Numbertype");
            }
        }

        /// <summary>
        /// Specifies the area code for the returned list of available numbers. Only available for North American numbers.
        /// </summary>
        [JsonProperty("areacode")]
        public string Areacode 
        { 
            get 
            {
                return this.areacode; 
            } 
            set 
            {
                this.areacode = value;
                onPropertyChanged("Areacode");
            }
        }

        /// <summary>
        /// The count of objects to return.
        /// </summary>
        [JsonProperty("pagesize")]
        public int? Pagesize 
        { 
            get 
            {
                return this.pagesize; 
            } 
            set 
            {
                this.pagesize = value;
                onPropertyChanged("Pagesize");
            }
        }
    }
} 