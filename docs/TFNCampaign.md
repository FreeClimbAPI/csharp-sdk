# freeclimb.Model.TFNCampaign

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | ID of the account that created this participant. | 
**CampaignId** | **string** | TFNCampaignId | 
**UseCase** | **string** |  | 
**RegistrationStatus** | **SMSTollFreeCampaignRegistrationStatus** |  | 
**DateCreated** | **string** |  | 
**DateUpdated** | **string** |  | 
**DateCreatedISO** | **string** |  | 
**DateUpdatedISO** | **string** |  | 
**Revision** | **int** |  | 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"accountId\":\"string\",\"campaignId\":\"cmptfn_387ec3f6e03b340553f35f29c8f118cdf3eae08a\",\"useCase\":\"string\",\"registrationStatus\":\"UNREGISTERED\",\"dateCreated\":\"string\",\"dateUpdated\":\"string\",\"dateCreatedISO\":\"string\",\"dateUpdatedISO\":\"string\",\"revision\":0}";

// create an instance of TFNCampaign from a JSON string
TFNCampaign tFNCampaign = JsonConvert.DeserializeObject<TFNCampaign>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

