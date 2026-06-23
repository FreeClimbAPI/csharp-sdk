# freeclimb.Model.BuyIncomingNumberRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PhoneNumber** | **string** | Phone number to purchase in E.164 format (as returned in the list of Available Phone Numbers). | 
**Alias** | **string** | Description for this new incoming phone number (max 64 characters). | [optional] 
**ApplicationId** | **string** | ID of the application that should handle phone calls to the number. | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"phoneNumber\":\"+12025551234\",\"alias\":\"Main Office Line\",\"applicationId\":\"AP0123456789abcdefABCDEF0123456789abcdef03\"}";

// create an instance of BuyIncomingNumberRequest from a JSON string
BuyIncomingNumberRequest buyIncomingNumberRequest = JsonConvert.DeserializeObject<BuyIncomingNumberRequest>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

