# VippsAccessTokenApi.Model.AuthorizationTokenResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TokenType** | **string** | The type for the access token. This will always be &#x60;Bearer&#x60;. | 
**ExpiresIn** | **string** | Token expiry time in seconds. The access token is valid for 1 hour in the test environment and 24 hours in the production environment. | 
**ExtExpiresIn** | **string** | Extra time added to expiry time. Currently disabled. | 
**ExpiresOn** | **string** | Token expiry time in epoch time format. | 
**NotBefore** | **string** | Token creation time in epoch time format. | 
**Resource** | **string** | A common resource object. Not used in token validation. This can be disregarded. | 
**AccessToken** | **string** | The access token itself. It is a base64-encoded string, typically 1000+ characters. It can be decoded on https://jwt.io, and using standard libraries. See the documentation for details. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

