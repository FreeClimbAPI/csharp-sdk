# freeclimb.Model.AccountRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alias** | **string** | Description for this account. | [optional] 
**Label** | **string** | Group to which this account belongs. | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"alias\":\"My Account\",\"label\":\"My Label\"}";

// create an instance of AccountRequest from a JSON string
AccountRequest accountRequest = JsonConvert.DeserializeObject<AccountRequest>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

