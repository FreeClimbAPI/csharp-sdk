# freeclimb.Model.PaginationModel

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


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"total\":0,\"start\":0,\"end\":0,\"page\":0,\"numPages\":0,\"pageSize\":0,\"nextPageUri\":\"string\"}";

// create an instance of PaginationModel from a JSON string
PaginationModel paginationModel = JsonConvert.DeserializeObject<PaginationModel>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

