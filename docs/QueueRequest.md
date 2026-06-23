# freeclimb.Model.QueueRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Alias** | **string** | Description for this Queue. Max length is 64 characters. | [optional] 
**MaxSize** | **int** | Maximum number of calls this queue can hold. Default is 100. Maximum is 1000. **Note:** Reducing the maxSize of a Queue causes the Queue to reject incoming requests until it shrinks below the new value of maxSize. | [optional] [default to 100]


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"alias\":\"Support Queue\",\"maxSize\":100}";

// create an instance of QueueRequest from a JSON string
QueueRequest queueRequest = JsonConvert.DeserializeObject<QueueRequest>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

