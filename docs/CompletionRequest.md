# freeclimb.Model.CompletionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Query** | **string** | Question to ask the Knowledge Base | 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"query\":\"What are your business hours?\"}";

// create an instance of CompletionRequest from a JSON string
CompletionRequest completionRequest = JsonConvert.DeserializeObject<CompletionRequest>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

