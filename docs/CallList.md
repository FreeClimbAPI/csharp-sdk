# freeclimb.Model.CallList

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
**Calls** | [**List&lt;CallResult&gt;**](CallResult.md) |  | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"total\":0,\"start\":0,\"end\":0,\"page\":0,\"numPages\":0,\"pageSize\":0,\"nextPageUri\":\"string\",\"calls\":[{\"uri\":\"string\",\"dateCreated\":\"string\",\"dateUpdated\":\"string\",\"revision\":0,\"dateCreatedISO\":\"2022-01-01T00:00:00Z\",\"dateUpdatedISO\":\"2022-01-01T00:00:00Z\",\"callId\":\"string\",\"parentCallId\":\"string\",\"accountId\":\"string\",\"from\":\"string\",\"to\":\"string\",\"phoneNumberId\":\"string\",\"status\":\"queued\",\"startTime\":\"string\",\"startTimeISO\":\"2022-01-01T00:00:00Z\",\"connectTime\":\"string\",\"connectTimeISO\":\"2022-01-01T00:00:00Z\",\"endTime\":\"string\",\"endTimeISO\":\"2022-01-01T00:00:00Z\",\"duration\":0,\"connectDuration\":0,\"audioStreamDuration\":0,\"direction\":\"inbound\",\"answeredBy\":\"human\",\"callerName\":\"string\",\"webRTC\":false,\"subresourceUris\":{\"logs\":\"string\",\"recordings\":\"string\"},\"applicationId\":\"string\"}]}";

// create an instance of CallList from a JSON string
CallList callList = JsonConvert.DeserializeObject<CallList>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

