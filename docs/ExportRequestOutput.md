# freeclimb.Model.ExportRequestOutput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **ExportOutputType** |  | 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"type\":\"csv\"}";

// create an instance of ExportRequestOutput from a JSON string
ExportRequestOutput exportRequestOutput = JsonConvert.DeserializeObject<ExportRequestOutput>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

