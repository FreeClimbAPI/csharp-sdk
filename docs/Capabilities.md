# freeclimb.Model.Capabilities

Details for which features this number may be used.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Voice** | **bool?** | Indicates whether a number can be used for voice calls. Replaces voiceEnabled. | 
**Sms** | **bool?** | Indicates whether a number can be used SMS messaging. Replaces smsEnabled. | 
**TollFree** | **bool?** | Indicates that a number is toll-free and will make toll-free calls, and when enabled, toll-free messages. | 
**TenDLC** | **bool?** | Indicates that a number, if sms is true, will be used for 10DLC messaging | 
**ShortCode** | **bool?** | Indicates that a number is a short code and can be used for short code messaging | 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"voice\":false,\"sms\":false,\"tollFree\":false,\"tenDLC\":false,\"shortCode\":false}";

// create an instance of Capabilities from a JSON string
Capabilities capabilities = JsonConvert.DeserializeObject<Capabilities>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

