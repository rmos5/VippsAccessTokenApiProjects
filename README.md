# VippsAccessTokenApi - the C# library for the Access token

The Access token API is for requesting an access token, which is a JWT (JSON Web Token).

There are two endpoints:

1. `POST:/accesstoken/get`: Used by most APIs, and has been in use for several years.
2. `POST:/miami/v1/token`: Used by some new APIs and roles, from 2023.

For `POST:/accesstoken/get`:
The access token must be provided in all API requests, together with the subscription key.
The access token is valid for 1 hour in the test environment and
24 hours in the production environment.

For `POST:/miami/v1/token`:
The access token must be provided in all API requests (no subscription key needed).
The access token is valid for 15 minutes in both the test environment and the production environment.

See the [API Guide](/docs/APIs/access-token-api) for more details.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 2.0.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using VippsAccessTokenApi.Api;
using VippsAccessTokenApi.Client;
using VippsAccessTokenApi.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out VippsAccessTokenApi.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using VippsAccessTokenApi.Api;
using VippsAccessTokenApi.Client;
using VippsAccessTokenApi.Model;

namespace Example
{
    public class Example
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
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AuthorizationServiceApi.FetchAuthorizationTokenUsingPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.vipps.no*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AuthorizationServiceApi* | [**FetchAuthorizationTokenUsingPost**](docs/AuthorizationServiceApi.md#fetchauthorizationtokenusingpost) | **POST** /accesstoken/get | Request an access token (JWT bearer token)
*TokenEndpointApi* | [**FetchToken**](docs/TokenEndpointApi.md#fetchtoken) | **POST** /miami/v1/token | Request an access token.


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.AuthorizationTokenResponse](docs/AuthorizationTokenResponse.md)
 - [Model.FetchTokenRequest](docs/FetchTokenRequest.md)
 - [Model.TokenResponse](docs/TokenResponse.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization

Endpoints do not require authorization.

