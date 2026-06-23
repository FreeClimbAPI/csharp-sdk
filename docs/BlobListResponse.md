# freeclimb.Model.BlobListResponse

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
**Blobs** | [**List&lt;BlobResult&gt;**](BlobResult.md) |  | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"total\":0,\"start\":0,\"end\":0,\"page\":0,\"numPages\":0,\"pageSize\":0,\"nextPageUri\":\"string\",\"blobs\":[{\"blobId\":\"BL0123456789abcdefABCDEF0123456789abcdef02\",\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef01\",\"alias\":\"string\",\"revision\":0,\"dateCreated\":\"2022-01-01T00:00:00Z\",\"dateUpdated\":\"2022-01-01T00:00:00Z\",\"expiresAt\":\"2022-01-01T00:00:00Z\"}]}";

// create an instance of BlobListResponse from a JSON string
BlobListResponse blobListResponse = JsonConvert.DeserializeObject<BlobListResponse>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

