# freeclimb.Model.SetTalk

The `SetTalk` command enables or disables the talk privilege for this Conference Participant. If 'true', no audio from that Participant is shared with the other Participants of the Conference.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**Talk** | **bool** | Specifying &#x60;false&#x60; mutes the Participant. | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"command\":\"SetTalk\",\"talk\":false}";

// create an instance of SetTalk from a JSON string
SetTalk setTalk = JsonConvert.DeserializeObject<SetTalk>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

