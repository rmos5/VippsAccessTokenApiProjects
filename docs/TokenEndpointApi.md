# VippsAccessTokenApi.Api.TokenEndpointApi

All URIs are relative to *https://api.vipps.no*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FetchToken**](TokenEndpointApi.md#fetchtoken) | **POST** /miami/v1/token | Request an access token. |

<a id="fetchtoken"></a>
# **FetchToken**
> TokenResponse FetchToken (string authorization, string grantType = null)

Request an access token.

This is a token endpoint for partners in certain roles. This is based on OAuth (Open Authorization) and requires only `client_id` and `client_secret`. The `Ocp-Apim-Subscription-Key` is not used. *Important:* This endpoint will be renamed to `/authentication/v1/token` later, when the internal technical dependencies are resolved.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VippsAccessTokenApi.Api;
using VippsAccessTokenApi.Client;
using VippsAccessTokenApi.Model;

namespace Example
{
    public class FetchTokenExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.vipps.no";
            var apiInstance = new TokenEndpointApi(config);
            var authorization = Basic OTY1OGY0ZTItMjZhOC00MzQzLTliNzUtNjdhZTkzODAyMzJkOlk4S3RlZXc2R0UyWm1leWNFdDZlZ2c9PQ==;  // string | The string 'client_id:client_secret' encoded to Base64 with Basic in front
            var grantType = "client_credentials";  // string |  (optional) 

            try
            {
                // Request an access token.
                TokenResponse result = apiInstance.FetchToken(authorization, grantType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenEndpointApi.FetchToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FetchTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Request an access token.
    ApiResponse<TokenResponse> response = apiInstance.FetchTokenWithHttpInfo(authorization, grantType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TokenEndpointApi.FetchTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **authorization** | **string** | The string &#39;client_id:client_secret&#39; encoded to Base64 with Basic in front |  |
| **grantType** | **string** |  | [optional]  |

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded; charset=utf-8
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad request |  -  |
| **401** | Unauthorized |  -  |
| **500** | Server error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

