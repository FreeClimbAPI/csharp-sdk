# freeclimb.Model.UpdateConferenceParticipantRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Talk** | **bool** | (Optional) Default is &#x60;true&#x60;. Setting to &#x60;false&#x60; mutes the Participant. FreeClimb returns an error and ignores any other value. | [optional] 
**Listen** | **bool** | (Optional) Default is &#x60;true&#x60;. Setting to &#x60;false&#x60; silences the Conference for this Participant. FreeClimb returns an error and ignores any other value. | [optional] 
**DtmfPassThrough** | **bool** | (Optional) Default is &#x60;true&#x60;. Setting to &#x60;false&#x60; mutes dtmf audio for this Participant. FreeClimb returns an error and ignores any other value. | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"talk\":true,\"listen\":true,\"dtmfPassThrough\":true}";

// create an instance of UpdateConferenceParticipantRequest from a JSON string
UpdateConferenceParticipantRequest updateConferenceParticipantRequest = JsonConvert.DeserializeObject<UpdateConferenceParticipantRequest>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

