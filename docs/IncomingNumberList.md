# freeclimb.Model.IncomingNumberList

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
**IncomingPhoneNumbers** | [**List&lt;IncomingNumberResult&gt;**](IncomingNumberResult.md) |  | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"total\":0,\"start\":0,\"end\":0,\"page\":0,\"numPages\":0,\"pageSize\":0,\"nextPageUri\":\"string\",\"incomingPhoneNumbers\":[{\"uri\":\"string\",\"dateCreated\":\"string\",\"dateUpdated\":\"string\",\"revision\":0,\"capabilities\":{\"voice\":false,\"sms\":false,\"tollFree\":false,\"tenDLC\":false,\"shortCode\":false},\"campaignId\":\"string\",\"phoneNumberId\":\"string\",\"accountId\":\"string\",\"applicationId\":\"string\",\"phoneNumber\":\"string\",\"alias\":\"string\",\"region\":\"string\",\"country\":\"string\",\"offnet\":false,\"tfn\":{\"campaignId\":\"string\"}}]}";

// create an instance of IncomingNumberList from a JSON string
IncomingNumberList incomingNumberList = JsonConvert.DeserializeObject<IncomingNumberList>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

