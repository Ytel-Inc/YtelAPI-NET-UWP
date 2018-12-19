/*
 * YtelAPI.Tests
 *
 * This file was automatically generated by APIMATIC v2.0 ( https://apimatic.io ).
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using YtelAPI.UWP;
using YtelAPI.UWP.Utilities; 
using YtelAPI.UWP.Http.Client;
using YtelAPI.UWP.Http.Response;
using YtelAPI.Tests.Helpers;
using Microsoft.VisualStudio.TestPlatform.UnitTestFramework;
using YtelAPI.UWP;
using YtelAPI.UWP.Controllers;
using YtelAPI.UWP.Exceptions;

namespace YtelAPI.Tests
{
    [TestClass]
    public class DedicatedShortCodeControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static DedicatedShortCodeController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [TestInitialize]
        public void SetUpClass()
        {
            controller = GetClient().DedicatedShortCode;
        }

        /// <summary>
        /// Retrieve a list of Short Code assignment associated with your Ytel account. 
        /// </summary>
        [TestMethod]
        public async Task TestTestListShortcodes() 
        {
            // Parameters for the API call
            string shortcode = null;
            string page = null;
            string pagesize = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListShortcodesAsync(shortcode, page, pagesize);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

        }

        /// <summary>
        /// Retrive a list of inbound Sms Short Code messages associated with your Ytel account. 
        /// </summary>
        [TestMethod]
        public async Task TestTestListInboundSMS() 
        {
            // Parameters for the API call
            int? page = null;
            int? pagesize = null;
            string mfrom = null;
            string shortcode = null;
            string datecreated = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListInboundSMSAsync(page, pagesize, mfrom, shortcode, datecreated);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

        }

        /// <summary>
        /// Retrieve a list of Short Code messages. 
        /// </summary>
        [TestMethod]
        public async Task TestTestListSMS() 
        {
            // Parameters for the API call
            string shortcode = null;
            string to = null;
            string dateSent = null;
            int? page = null;
            int? pageSize = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListSMSAsync(shortcode, to, dateSent, page, pageSize);
            }
            catch(APIException) {};

            // Test response code
            Assert.AreEqual(200, httpCallBackHandler.Response.StatusCode,
                    "Status should be 200");

            // Test headers
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            Assert.IsTrue(TestHelper.AreHeadersProperSubsetOf (
                    headers, httpCallBackHandler.Response.Headers),
                    "Headers should match");

        }

    }
}