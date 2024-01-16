/*
 * Access token
 *
 * The Access token API is for requesting an access token, which is a JWT (JSON Web Token).  There are two endpoints:  1. `POST:/accesstoken/get`: Used by most APIs, and has been in use for several years. 2. `POST:/miami/v1/token`: Used by some new APIs and roles, from 2023.  For `POST:/accesstoken/get`: The access token must be provided in all API requests, together with the subscription key. The access token is valid for 1 hour in the test environment and 24 hours in the production environment.  For `POST:/miami/v1/token`: The access token must be provided in all API requests (no subscription key needed). The access token is valid for 15 minutes in both the test environment and the production environment.  See the [API Guide](/docs/APIs/access-token-api) for more details.
 *
 * The version of the OpenAPI document: 2.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using VippsAccessTokenApi.Client;
using VippsAccessTokenApi.Api;
// uncomment below to import models
//using VippsAccessTokenApi.Model;

namespace VippsAccessTokenApi.Test.Api
{
    /// <summary>
    ///  Class for testing AuthorizationServiceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AuthorizationServiceApiTests : IDisposable
    {
        private AuthorizationServiceApi instance;

        public AuthorizationServiceApiTests()
        {
            instance = new AuthorizationServiceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AuthorizationServiceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AuthorizationServiceApi
            //Assert.IsType<AuthorizationServiceApi>(instance);
        }

        /// <summary>
        /// Test FetchAuthorizationTokenUsingPost
        /// </summary>
        [Fact]
        public void FetchAuthorizationTokenUsingPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string clientId = null;
            //string clientSecret = null;
            //string ocpApimSubscriptionKey = null;
            //string merchantSerialNumber = null;
            //string vippsSystemName = null;
            //string vippsSystemVersion = null;
            //string vippsSystemPluginName = null;
            //string vippsSystemPluginVersion = null;
            //var response = instance.FetchAuthorizationTokenUsingPost(clientId, clientSecret, ocpApimSubscriptionKey, merchantSerialNumber, vippsSystemName, vippsSystemVersion, vippsSystemPluginName, vippsSystemPluginVersion);
            //Assert.IsType<AuthorizationTokenResponse>(response);
        }
    }
}
