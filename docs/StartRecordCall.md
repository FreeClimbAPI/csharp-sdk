# freeclimb.Model.StartRecordCall

The `StartRecordCall` command records the current call and returns the URL of a file containing the audio recording when recording completes. `StartRecordCall` is non-blocking. After recording of the current call begins, control of the call moves to the PerCL command that follows `StartRecordCall` in the current PerCL script.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"command\":\"StartRecordCall\"}";

// create an instance of StartRecordCall from a JSON string
StartRecordCall startRecordCall = JsonConvert.DeserializeObject<StartRecordCall>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

