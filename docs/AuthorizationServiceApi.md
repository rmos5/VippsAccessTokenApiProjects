# VippsAccessTokenApi.Api.AuthorizationServiceApi

All URIs are relative to *https://api.vipps.no*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FetchAuthorizationTokenUsingPost**](AuthorizationServiceApi.md#fetchauthorizationtokenusingpost) | **POST** /accesstoken/get | Request an access token (JWT bearer token) |

<a id="fetchauthorizationtokenusingpost"></a>
# **FetchAuthorizationTokenUsingPost**
> AuthorizationTokenResponse FetchAuthorizationTokenUsingPost (string clientId, string clientSecret, string ocpApimSubscriptionKey, string merchantSerialNumber = null, string vippsSystemName = null, string vippsSystemVersion = null, string vippsSystemPluginName = null, string vippsSystemPluginVersion = null)

Request an access token (JWT bearer token)

This is an authentication endpoint for merchant use. The access token endpoint is used to get the JWT (JSON Web Token) that must be passed in every API request in the `Authorization` header. The access token is a base64-encoded string value that must be acquired first before making any Vipps MobilePay API calls. The access token is valid for 1 hour in the test environment and 24 hours in the production environment. See: https://developer.vippsmobilepay.com/docs/APIs/access-token-api/

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VippsAccessTokenApi.Api;
using VippsAccessTokenApi.Client;
using VippsAccessTokenApi.Model;

namespace Example
{
    public class FetchAuthorizationTokenUsingPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vipps.no";
            var apiInstance = new AuthorizationServiceApi(config);
            var clientId = fb492b5e-7907-4d83-ba20-c7fb60ca35de;  // string | The `client_id` is available on portal.vipps.no, under the *Developer* section. Think of it as the \"username\".
            var clientSecret = Y8Kteew6GE2ZmeycEt6egg==;  // string | The `client_secret` is available on portal.vipps.no, under the *Developer* section. Think of it as the \"password\". Keep it secret. We will never ask for it, and we don't need it for anything.
            var ocpApimSubscriptionKey = da7d5b0e18a84aeda961c0c31b75c2a9;  // string | The subscription key for a sales unit. See [API keys](/docs/knowledge-base/api-keys/).
            var merchantSerialNumber = 123456;  // string | The merchant serial number (MSN) for the sales unit. The Merchant-Serial-Number header can be used with all API keys, and can speed up any trouble-shooting of API problems quite a bit. (optional) 
            var vippsSystemName = WooCommerce;  // string | The name of the ecommerce solution. One word in lowercase letters is good. See [http-headers](/docs/knowledge-base/http-headers). (optional) 
            var vippsSystemVersion = 5.4.0;  // string | The version number of the ecommerce solution. See [http-headers](/docs/knowledge-base/http-headers). (optional) 
            var vippsSystemPluginName = woocommerce-payment;  // string | The name of the ecommerce plugin (if applicable). One word in lowercase letters is good. See [http-headers](/docs/knowledge-base/http-headers). (optional) 
            var vippsSystemPluginVersion = 1.4.1;  // string | The version number of the ecommerce plugin (if applicable). See [http-headers](/docs/knowledge-base/http-headers). (optional) 

            try
            {
                // Request an access token (JWT bearer token)
                AuthorizationTokenResponse result = apiInstance.FetchAuthorizationTokenUsingPost(clientId, clientSecret, ocpApimSubscriptionKey, merchantSerialNumber, vippsSystemName, vippsSystemVersion, vippsSystemPluginName, vippsSystemPluginVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthorizationServiceApi.FetchAuthorizationTokenUsingPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchAuthorizationTokenUsingPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request an access token (JWT bearer token)
    ApiResponse<AuthorizationTokenResponse> response = apiInstance.FetchAuthorizationTokenUsingPostWithHttpInfo(clientId, clientSecret, ocpApimSubscriptionKey, merchantSerialNumber, vippsSystemName, vippsSystemVersion, vippsSystemPluginName, vippsSystemPluginVersion);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthorizationServiceApi.FetchAuthorizationTokenUsingPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **clientId** | **string** | The &#x60;client_id&#x60; is available on portal.vipps.no, under the *Developer* section. Think of it as the \&quot;username\&quot;. |  |
| **clientSecret** | **string** | The &#x60;client_secret&#x60; is available on portal.vipps.no, under the *Developer* section. Think of it as the \&quot;password\&quot;. Keep it secret. We will never ask for it, and we don&#39;t need it for anything. |  |
| **ocpApimSubscriptionKey** | **string** | The subscription key for a sales unit. See [API keys](/docs/knowledge-base/api-keys/). |  |
| **merchantSerialNumber** | **string** | The merchant serial number (MSN) for the sales unit. The Merchant-Serial-Number header can be used with all API keys, and can speed up any trouble-shooting of API problems quite a bit. | [optional]  |
| **vippsSystemName** | **string** | The name of the ecommerce solution. One word in lowercase letters is good. See [http-headers](/docs/knowledge-base/http-headers). | [optional]  |
| **vippsSystemVersion** | **string** | The version number of the ecommerce solution. See [http-headers](/docs/knowledge-base/http-headers). | [optional]  |
| **vippsSystemPluginName** | **string** | The name of the ecommerce plugin (if applicable). One word in lowercase letters is good. See [http-headers](/docs/knowledge-base/http-headers). | [optional]  |
| **vippsSystemPluginVersion** | **string** | The version number of the ecommerce plugin (if applicable). See [http-headers](/docs/knowledge-base/http-headers). | [optional]  |

### Return type

[**AuthorizationTokenResponse**](AuthorizationTokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

