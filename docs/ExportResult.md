# freeclimb.Model.ExportResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | String that uniquely identifies this account resource. | 
**Uri** | **string** |  | 
**DateCreated** | **string** |  | 
**DateUpdated** | **string** |  | 
**Revision** | **int** |  | 
**ExportId** | **string** | String that uniquely identifies this export resource | 
**Status** | **ExportStatus** |  | 
**Size** | **int** |  | 
**ResourceType** | **ExportResourceType** |  | 
**Query** | **Object** | Query params used to filter exported documents | 
**Format** | **List&lt;string&gt;** | Desired fields of exported documents | 
**Output** | [**ExportResultOutput**](ExportResultOutput.md) |  | 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef07\",\"uri\":\"/Accounts/AC0123456789abcdefABCDEF0123456789abcdef07/Exports/EX0123456789abcdefABCDEF0123456789abcdef08\",\"dateCreated\":\"Wed, 26 Jun 2024 15:45:06 UTC\",\"dateUpdated\":\"Wed, 26 Jun 2024 15:45:06 UTC\",\"revision\":1,\"exportId\":\"EX0123456789abcdefABCDEF0123456789abcdef08\",\"status\":\"completed\",\"size\":12893786,\"resourceType\":\"Messages\",\"query\":{\"direction\":\"inbound\"},\"format\":[\"messageId\",\"dateUpdated\",\"segmentCount\",\"status\"],\"output\":{\"type\":\"csv\"}}";

// create an instance of ExportResult from a JSON string
ExportResult exportResult = JsonConvert.DeserializeObject<ExportResult>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

