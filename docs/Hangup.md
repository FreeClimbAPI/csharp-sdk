# freeclimb.Model.Hangup

The `Hangup` command terminates a Call. If `Hangup` is used as the first action in a PerCL response, it does not prevent FreeClimb from answering the Call and billing your account. See the `Reject` command to hang up at no charge.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**Reason** | **string** | The user defined reason for the hangup. In general, applications should use a set of enumerated values that are predefined to cover all exit points of the Call flows for the given application. | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"command\":\"Hangup\",\"reason\":\"string\"}";

// create an instance of Hangup from a JSON string
Hangup hangup = JsonConvert.DeserializeObject<Hangup>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

