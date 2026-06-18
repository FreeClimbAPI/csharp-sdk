# freeclimb.Model.TranscribeUtteranceRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SaveRecording** | **bool** |  | [optional] [default to false]
**MaxLengthSec** | **int** |  | [optional] [default to 60]
**RcrdTerminationSilenceTimeMs** | **int** |  | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"saveRecording\":false,\"maxLengthSec\":60,\"rcrdTerminationSilenceTimeMs\":0}";

// create an instance of TranscribeUtteranceRecord from a JSON string
TranscribeUtteranceRecord transcribeUtteranceRecord = JsonConvert.DeserializeObject<TranscribeUtteranceRecord>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

