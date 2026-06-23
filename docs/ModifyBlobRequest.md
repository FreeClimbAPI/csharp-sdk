# freeclimb.Model.ModifyBlobRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Blob** | **Object** |  | 
**Alias** | **string** | Custom identifier for this blob that is unique for the owning account. It will be set to the blobId by default if not provided. | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"blob\":{\"firstName\":\"John\",\"lastName\":\"Doe\"},\"alias\":\"customer-profile\"}";

// create an instance of ModifyBlobRequest from a JSON string
ModifyBlobRequest modifyBlobRequest = JsonConvert.DeserializeObject<ModifyBlobRequest>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

