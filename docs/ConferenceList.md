# freeclimb.Model.ConferenceList

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
**Conferences** | [**List&lt;ConferenceResult&gt;**](ConferenceResult.md) |  | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"total\":0,\"start\":0,\"end\":0,\"page\":0,\"numPages\":0,\"pageSize\":0,\"nextPageUri\":\"string\",\"conferences\":[{\"uri\":\"string\",\"dateCreated\":\"string\",\"dateUpdated\":\"string\",\"revision\":0,\"conferenceId\":\"string\",\"accountId\":\"string\",\"alias\":\"string\",\"record\":false,\"status\":\"empty\",\"waitUrl\":\"https://www.example.com\",\"actionUrl\":\"https://www.example.com\",\"statusCallbackUrl\":\"https://www.example.com\"}]}";

// create an instance of ConferenceList from a JSON string
ConferenceList conferenceList = JsonConvert.DeserializeObject<ConferenceList>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

