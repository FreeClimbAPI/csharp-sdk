# freeclimb.Model.CreateWebRTCToken

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**To** | **string** | E.164 formatted phone number to which calls using this token will be made. | 
**From** | **string** | E.164 formatted phone number owned by the reqeusting account from which calls using this token will be made. | 
**Uses** | **int** | number of times this token may be used for a WebRTC call | 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"to\":\"string\",\"from\":\"string\",\"uses\":0}";

// create an instance of CreateWebRTCToken from a JSON string
CreateWebRTCToken createWebRTCToken = JsonConvert.DeserializeObject<CreateWebRTCToken>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

