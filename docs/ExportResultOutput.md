# freeclimb.Model.ExportResultOutput

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **ExportOutputType** |  | 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"type\":\"csv\"}";

// create an instance of ExportResultOutput from a JSON string
ExportResultOutput exportResultOutput = JsonConvert.DeserializeObject<ExportResultOutput>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

