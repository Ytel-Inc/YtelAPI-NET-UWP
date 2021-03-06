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
    public class Body2 : BaseModel 
    {
        // These fields hold the values for the public properties.
        private Guid templateId;

        /// <summary>
        /// The unique identifier for a template object
        /// </summary>
        [JsonProperty("TemplateId")]
        public Guid TemplateId 
        { 
            get 
            {
                return this.templateId; 
            } 
            set 
            {
                this.templateId = value;
                onPropertyChanged("TemplateId");
            }
        }
    }
} 