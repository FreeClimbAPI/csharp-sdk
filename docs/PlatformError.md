# freeclimb.Model.PlatformError

Standard error structure returned by platform.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **int** |  | [optional] 
**Call** | **string** |  | [optional] 
**Url** | **string** |  | [optional] 
**Details** | **Object** |  | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"code\":0,\"call\":\"Internal Failure\",\"url\":\"https://docs.freeclimb.com/reference/error-and-warning-dictionary#0\"}";

// create an instance of PlatformError from a JSON string
PlatformError platformError = JsonConvert.DeserializeObject<PlatformError>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

