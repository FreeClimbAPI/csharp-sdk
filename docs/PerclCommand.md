# freeclimb.Model.PerclCommand

An individual command used in a PerCLScript.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"command\":\"string\"}";

// create an instance of PerclCommand from a JSON string
PerclCommand perclCommand = JsonConvert.DeserializeObject<PerclCommand>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

