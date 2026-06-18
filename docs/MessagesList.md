# freeclimb.Model.MessagesList

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
**Messages** | [**List&lt;MessageResult&gt;**](MessageResult.md) | Array of messages | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"total\":0,\"start\":0,\"end\":0,\"page\":0,\"numPages\":0,\"pageSize\":0,\"nextPageUri\":\"string\",\"messages\":[{\"uri\":\"string\",\"dateCreated\":\"string\",\"dateUpdated\":\"string\",\"revision\":0,\"accountId\":\"string\",\"messageId\":\"string\",\"status\":\"new\",\"from\":\"string\",\"to\":\"string\",\"text\":\"string\",\"direction\":\"string\",\"notificationUrl\":\"https://www.example.com\",\"brandId\":\"string\",\"campaignId\":\"string\",\"segmentCount\":0,\"mediaUrls\":[\"https://www.example.com\"],\"tfn\":{\"campaignId\":\"string\"},\"phoneNumberId\":\"string\",\"applicationId\":\"string\"}]}";

// create an instance of MessagesList from a JSON string
MessagesList messagesList = JsonConvert.DeserializeObject<MessagesList>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

