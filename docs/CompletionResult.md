# freeclimb.Model.CompletionResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Response** | **string** | The generative response from the KnowledgeBase | 
**Status** | **CompletionResultStatus** |  | 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"response\":\"string\",\"status\":\"success\"}";

// create an instance of CompletionResult from a JSON string
CompletionResult completionResult = JsonConvert.DeserializeObject<CompletionResult>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

