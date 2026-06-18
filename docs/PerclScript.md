# freeclimb.Model.PerclScript

A PerCL script to be returned to the FreeClimb servers in FreeClimb applications
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Commands** | [**List&lt;PerclCommand&gt;**](PerclCommand.md) | A JSON array of PerCL commands | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"commands\":[{\"command\":\"string\"}]}";

// create an instance of PerclScript from a JSON string
PerclScript perclScript = JsonConvert.DeserializeObject<PerclScript>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

