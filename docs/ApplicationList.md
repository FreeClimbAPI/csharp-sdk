# freeclimb.Model.ApplicationList

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
**Applications** | [**List&lt;ApplicationResult&gt;**](ApplicationResult.md) |  | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"total\":0,\"start\":0,\"end\":0,\"page\":0,\"numPages\":0,\"pageSize\":0,\"nextPageUri\":\"string\",\"applications\":[{\"uri\":\"string\",\"dateCreated\":\"string\",\"dateUpdated\":\"string\",\"revision\":0,\"accountId\":\"string\",\"applicationId\":\"string\",\"alias\":\"string\",\"voiceUrl\":\"https://www.example.com\",\"voiceFallbackUrl\":\"https://www.example.com\",\"callConnectUrl\":\"https://www.example.com\",\"statusCallbackUrl\":\"https://www.example.com\",\"smsUrl\":\"https://www.example.com\",\"smsFallbackUrl\":\"https://www.example.com\"}]}";

// create an instance of ApplicationList from a JSON string
ApplicationList applicationList = JsonConvert.DeserializeObject<ApplicationList>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

