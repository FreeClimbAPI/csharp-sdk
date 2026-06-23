# freeclimb.Model.CallResultAllOfSubresourceUris

The list of subresources for this Call. These include things like logs and recordings associated with the Call.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Logs** | **string** | The URI for the logs associated with this Call. | [optional] 
**Recordings** | **string** | The URI for the recordings associated with this Call. | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"logs\":\"string\",\"recordings\":\"string\"}";

// create an instance of CallResultAllOfSubresourceUris from a JSON string
CallResultAllOfSubresourceUris callResultAllOfSubresourceUris = JsonConvert.DeserializeObject<CallResultAllOfSubresourceUris>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

