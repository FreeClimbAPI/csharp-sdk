# freeclimb.Model.UpdateCallRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **UpdateCallRequestStatus** |  | 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"status\":\"canceled\"}";

// create an instance of UpdateCallRequest from a JSON string
UpdateCallRequest updateCallRequest = JsonConvert.DeserializeObject<UpdateCallRequest>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

