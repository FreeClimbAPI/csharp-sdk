# freeclimb.Model.SMSTenDLCCampaignsListResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Total** | **int?** | Total amount of requested resource. | [optional] 
**Start** | **int?** | Resource index at start of current page | [optional] 
**End** | **int?** | Resource index at end of current page | [optional] 
**Page** | **int?** | Current page | [optional] 
**NumPages** | **int?** | Total number of pages | [optional] 
**PageSize** | **int?** | Number of items per page | [optional] 
**NextPageUri** | **string** | Uri to retrieve the next page of items | [optional] 
**Campaigns** | [**List&lt;SMSTenDLCCampaign&gt;**](SMSTenDLCCampaign.md) |  | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"total\":0,\"start\":0,\"end\":0,\"page\":0,\"numPages\":0,\"pageSize\":0,\"nextPageUri\":\"string\",\"campaigns\":[{\"campaignId\":\"CX56XX4\",\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef05\",\"cspId\":\"SX56XX4\",\"brandId\":\"BX56XX4\",\"usecase\":\"2FA\",\"description\":\"mock campaign.\",\"subUsecases\":[],\"resellerId\":null,\"sample1\":\"Your verification code from FreeClimb is 000000. It expires in 10 minutes.\",\"sample2\":null,\"sample3\":null,\"sample4\":null,\"sample5\":null,\"messageFlow\":null,\"helpMessage\":null,\"referenceId\":null,\"status\":\"EXPIRED\",\"mock\":true,\"autoRenewal\":false,\"embeddedLink\":false,\"embeddedPhone\":false,\"affiliateMarketing\":false,\"numberPool\":false,\"ageGated\":false,\"directLending\":false,\"subscriberOptin\":true,\"subscriberOptout\":false,\"subscriberHelp\":true,\"createDate\":\"2022-07-05T15:17:05Z\",\"billedDate\":\"2022-07-05T00:00:00Z\",\"nextRenewalOrExpirationDate\":null}]}";

// create an instance of SMSTenDLCCampaignsListResult from a JSON string
SMSTenDLCCampaignsListResult sMSTenDLCCampaignsListResult = JsonConvert.DeserializeObject<SMSTenDLCCampaignsListResult>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

