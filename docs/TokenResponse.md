# VippsAccessTokenApi.Model.TokenResponse
This _new_ accesstoken endpoint is used to get the JWT (JSON Web Token) that must be passed in every API request in the `Authorization` header. The access token is a base64-encoded string value that must be acquired first before making any Vipps MobilePay API calls. The access token is valid for 15 minutes both in the test environment and in the production environment. See: https://developer.vippsmobilepay.com/docs/APIs/access-token-api/

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenType** | **string** | The type for the access token. This will always be &#x60;Bearer&#x60;. | 
**ExpiresIn** | **string** | Token expiry time in seconds. The token is currently valid for 15 minutes. | 
**AccessToken** | **byte[]** | The access token itself. It is a base64-encoded string, typically 1000+ characters. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

