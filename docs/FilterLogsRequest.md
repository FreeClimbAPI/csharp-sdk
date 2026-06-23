# freeclimb.Model.FilterLogsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Pql** | **string** | The filter query for retrieving logs. See **Performance Query Language** below. | 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"pql\":\"2020-06-22T19:42:53.376Z < timestamp < 2020-06-23T19:42:53.376Z\"}";

// create an instance of FilterLogsRequest from a JSON string
FilterLogsRequest filterLogsRequest = JsonConvert.DeserializeObject<FilterLogsRequest>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

