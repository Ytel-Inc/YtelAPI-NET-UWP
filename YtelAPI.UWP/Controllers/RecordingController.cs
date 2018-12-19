/*
 * YtelAPI.UWP
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using YtelAPI.UWP;
using YtelAPI.UWP.Utilities;
using YtelAPI.UWP.Http.Request;
using YtelAPI.UWP.Http.Response;
using YtelAPI.UWP.Http.Client;
using YtelAPI.UWP.Exceptions;

namespace YtelAPI.UWP.Controllers
{
    public partial class RecordingController: BaseController
    {
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static RecordingController instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        internal static RecordingController Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (null == instance)
                    {
                        instance = new RecordingController();
                    }
                }
                return instance;
            }
        }

        #endregion Singleton Pattern

        /// <summary>
        /// Remove a recording from your Ytel account.
        /// </summary>
        /// <param name="recordingsid">Required parameter: The unique identifier for a recording.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateDeleteRecording(string recordingsid)
        {
            Task<string> t = CreateDeleteRecordingAsync(recordingsid);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Remove a recording from your Ytel account.
        /// </summary>
        /// <param name="recordingsid">Required parameter: The unique identifier for a recording.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateDeleteRecordingAsync(string recordingsid)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/recording/deleterecording.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "recordingsid", recordingsid )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve a list of recording objects.
        /// </summary>
        /// <param name="page">Optional parameter: The page count to retrieve from the total results in the collection. Page indexing starts at 1.</param>
        /// <param name="pagesize">Optional parameter: The count of objects to return per page.</param>
        /// <param name="datecreated">Optional parameter: Filter results by creation date</param>
        /// <param name="callsid">Optional parameter: The unique identifier for a call.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateListRecordings(
                int? page = null,
                int? pagesize = null,
                string datecreated = null,
                string callsid = null)
        {
            Task<string> t = CreateListRecordingsAsync(page, pagesize, datecreated, callsid);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve a list of recording objects.
        /// </summary>
        /// <param name="page">Optional parameter: The page count to retrieve from the total results in the collection. Page indexing starts at 1.</param>
        /// <param name="pagesize">Optional parameter: The count of objects to return per page.</param>
        /// <param name="datecreated">Optional parameter: Filter results by creation date</param>
        /// <param name="callsid">Optional parameter: The unique identifier for a call.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateListRecordingsAsync(
                int? page = null,
                int? pagesize = null,
                string datecreated = null,
                string callsid = null)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/recording/listrecording.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "page", page ),
                new KeyValuePair<string, object>( "pagesize", pagesize ),
                new KeyValuePair<string, object>( "Datecreated", datecreated ),
                new KeyValuePair<string, object>( "callsid", callsid )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

        /// <summary>
        /// Retrieve the recording of a call by its RecordingSid. This resource will return information regarding the call such as start time, end time, duration, and so forth.
        /// </summary>
        /// <param name="recordingsid">Required parameter: The unique identifier for the recording.</param>
        /// <return>Returns the string response from the API call</return>
        public string CreateViewRecording(string recordingsid)
        {
            Task<string> t = CreateViewRecordingAsync(recordingsid);
            APIHelper.RunTaskSynchronously(t);
            return t.Result;
        }

        /// <summary>
        /// Retrieve the recording of a call by its RecordingSid. This resource will return information regarding the call such as start time, end time, duration, and so forth.
        /// </summary>
        /// <param name="recordingsid">Required parameter: The unique identifier for the recording.</param>
        /// <return>Returns the string response from the API call</return>
        public async Task<string> CreateViewRecordingAsync(string recordingsid)
        {
            //the base uri for api requests
            string _baseUri = Configuration.BaseUri;

            //prepare query string for API call
            StringBuilder _queryBuilder = new StringBuilder(_baseUri);
            _queryBuilder.Append("/recording/viewrecording.json");


            //validate and preprocess url
            string _queryUrl = APIHelper.CleanUrl(_queryBuilder);

            //append request with appropriate headers and parameters
            var _headers = new Dictionary<string,string>()
            {
                { "user-agent", "APIMATIC 2.0" }
            };

            //append form/field parameters
            var _fields = new List<KeyValuePair<string, Object>>()
            {
                new KeyValuePair<string, object>( "recordingsid", recordingsid )
            };
            //remove null parameters
            _fields = _fields.Where(kvp => kvp.Value != null).ToList();

            //prepare the API call request to fetch the response
            HttpRequest _request = ClientInstance.Post(_queryUrl, _headers, _fields, Configuration.BasicAuthUserName, Configuration.BasicAuthPassword);

            //invoke request and get response
            HttpStringResponse _response = (HttpStringResponse) await ClientInstance.ExecuteAsStringAsync(_request).ConfigureAwait(false);
            HttpContext _context = new HttpContext(_request,_response);
            //handle errors defined at the API level
            base.ValidateResponse(_response, _context);

            try
            {
                return _response.Body;
            }
            catch (Exception _ex)
            {
                throw new APIException("Failed to parse the response: " + _ex.Message, _context);
            }
        }

    }
} 