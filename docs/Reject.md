# freeclimb.Model.Reject

The `Reject` command blocks an incoming Call. Using `Reject` is the only way to prevent FreeClimb from answering a Call. Any other response will result in an answered Call and your account will be billed.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**Reason** | **string** | Reason for the rejection. This can be any string value. In general, applications should use a set of enumerated values that are predefined to cover all exit points of the call flows for the given application. | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"command\":\"Reject\",\"reason\":\"string\"}";

// create an instance of Reject from a JSON string
Reject reject = JsonConvert.DeserializeObject<Reject>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

