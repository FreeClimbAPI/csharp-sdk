# freeclimb.Model.ExportList

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
**Exports** | [**List&lt;ExportResult&gt;**](ExportResult.md) |  | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"total\":0,\"start\":0,\"end\":0,\"page\":0,\"numPages\":0,\"pageSize\":0,\"nextPageUri\":\"string\",\"exports\":[{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef07\",\"uri\":\"/Accounts/AC0123456789abcdefABCDEF0123456789abcdef07/Exports/EX0123456789abcdefABCDEF0123456789abcdef08\",\"dateCreated\":\"Wed, 26 Jun 2024 15:45:06 UTC\",\"dateUpdated\":\"Wed, 26 Jun 2024 15:45:06 UTC\",\"revision\":1,\"exportId\":\"EX0123456789abcdefABCDEF0123456789abcdef08\",\"status\":\"completed\",\"size\":12893786,\"resourceType\":\"Messages\",\"query\":{\"direction\":\"inbound\"},\"format\":[\"messageId\",\"dateUpdated\",\"segmentCount\",\"status\"],\"output\":{\"type\":\"csv\"}}]}";

// create an instance of ExportList from a JSON string
ExportList exportList = JsonConvert.DeserializeObject<ExportList>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

