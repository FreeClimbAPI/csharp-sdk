# freeclimb.Model.SMSTenDLCBrandsListResult

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
**Brands** | [**List&lt;SMSTenDLCBrand&gt;**](SMSTenDLCBrand.md) |  | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"total\":0,\"start\":0,\"end\":0,\"page\":0,\"numPages\":0,\"pageSize\":0,\"nextPageUri\":\"string\",\"brands\":[{\"mock\":true,\"optionalAttributes\":{},\"accountId\":\"AC0123456789abcdefABCDEF0123456789abcdef06\",\"brandId\":\"BVCEBIJ\",\"cspId\":\"SKGC6G0\",\"firstName\":\"\",\"lastName\":\"\",\"displayName\":\"FreeClimb LLC(mock)\",\"companyName\":\"FreeClimb LLC\",\"ein\":\"843793747\",\"einIssuingCountry\":\"US\",\"phone\":\"+18475722071\",\"street\":\"570 Lake Cook Rd Ste 400\",\"city\":\"Deerfield\",\"state\":\"IL\",\"postalCode\":\"60015\",\"country\":\"US\",\"email\":\"bmabry@vailsys.com\",\"stockSymbol\":\"\",\"stockExchange\":\"NASDAQ\",\"ipAddress\":\"127.0.0.1\",\"website\":\"https://www.freeclimb.com/\",\"vertical\":\"TECHNOLOGY\",\"universalEin\":\"US_843793747\",\"referenceId\":\"ACdeadbeef\",\"entityType\":\"PRIVATE_PROFIT\",\"brandRelationship\":\"SMALL_ACCOUNT\",\"identityStatus\":\"VERIFIED\",\"createDate\":\"2022-07-01T20:29:23Z\"}]}";

// create an instance of SMSTenDLCBrandsListResult from a JSON string
SMSTenDLCBrandsListResult sMSTenDLCBrandsListResult = JsonConvert.DeserializeObject<SMSTenDLCBrandsListResult>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

