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
    public class SMSControllerTest : ControllerTestBase
    {
        /// <summary>
        /// Controller instance (for all tests)
        /// </summary>
        private static SMSController controller;

        /// <summary>
        /// Setup test class
        /// </summary>
        [TestInitialize]
        public void SetUpClass()
        {
            controller = GetClient().SMS;
        }

        /// <summary>
        /// Retrieve a list of Outbound SMS message objects. 
        /// </summary>
        [TestMethod]
        public async Task TestTestListSMS() 
        {
            // Parameters for the API call
            int? page = null;
            int? pageSize = null;
            string mfrom = null;
            string to = null;
            string dateSent = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListSMSAsync(page, pageSize, mfrom, to, dateSent);
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
        /// Retrieve a list of Inbound SMS message objects. 
        /// </summary>
        [TestMethod]
        public async Task TestTestListInboundSMS() 
        {
            // Parameters for the API call
            int? page = null;
            int? pageSize = null;
            string mfrom = null;
            string to = null;
            string dateSent = null;

            // Perform API call
            string result = null;

            try
            {
                result = await controller.CreateListInboundSMSAsync(page, pageSize, mfrom, to, dateSent);
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