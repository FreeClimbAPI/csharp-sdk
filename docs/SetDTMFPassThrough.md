# freeclimb.Model.SetDTMFPassThrough

The `SetDTMFPassThrough` command enables or disables the dtmfPassThrough privilege for this Conference Participant. If 'true', DTMFs will be passed through from this Participant to all other Participants in the Conference
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**DtmfPassThrough** | **bool** | Specifying &#x60;false&#x60; mutes the Participant&#39;s dtmf audio. | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"command\":\"SetDTMFPassThrough\",\"dtmfPassThrough\":false}";

// create an instance of SetDTMFPassThrough from a JSON string
SetDTMFPassThrough setDTMFPassThrough = JsonConvert.DeserializeObject<SetDTMFPassThrough>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

