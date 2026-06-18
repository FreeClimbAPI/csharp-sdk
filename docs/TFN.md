# freeclimb.Model.TFN

TollFree Campaign details for this number
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CampaignId** | **string** | alphanumeric identifier for the TollFree campaign associated with this number | 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"campaignId\":\"string\"}";

// create an instance of TFN from a JSON string
TFN tFN = JsonConvert.DeserializeObject<TFN>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

