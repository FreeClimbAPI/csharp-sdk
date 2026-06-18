# freeclimb.Model.UpdateConferenceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alias** | **string** | Description for this conference. Maximum 64 characters. | [optional] 
**PlayBeep** | **PlayBeep** |  | [optional] 
**Status** | **UpdateConferenceRequestStatus** |  | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"alias\":\"Customer Conference\",\"playBeep\":\"always\",\"status\":\"empty\"}";

// create an instance of UpdateConferenceRequest from a JSON string
UpdateConferenceRequest updateConferenceRequest = JsonConvert.DeserializeObject<UpdateConferenceRequest>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

