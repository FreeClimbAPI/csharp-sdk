# freeclimb.Model.ExportRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResourceType** | **ExportResourceType** |  | 
**Format** | **List&lt;string&gt;** |  | [optional] 
**Output** | [**ExportRequestOutput**](ExportRequestOutput.md) |  | 
**Query** | **Object** |  | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"resourceType\":\"Messages\",\"format\":[\"messageId\",\"dateUpdated\",\"status\"],\"output\":{\"type\":\"csv\"},\"query\":{\"direction\":\"inbound\"}}";

// create an instance of ExportRequest from a JSON string
ExportRequest exportRequest = JsonConvert.DeserializeObject<ExportRequest>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

