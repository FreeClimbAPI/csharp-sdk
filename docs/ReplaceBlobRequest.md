# freeclimb.Model.ReplaceBlobRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Blob** | **Object** |  | 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"blob\":{\"firstName\":\"John\",\"lastName\":\"Doe\"}}";

// create an instance of ReplaceBlobRequest from a JSON string
ReplaceBlobRequest replaceBlobRequest = JsonConvert.DeserializeObject<ReplaceBlobRequest>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

