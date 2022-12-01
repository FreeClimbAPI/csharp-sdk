# freeclimb.Model.Pause
The `Pause` command halts execution of the current PerCL script for a specified number of milliseconds. If `Pause` is the first command in a PerCL document, FreeClimb will wait for the specified time to elapse before picking up the call.



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**Length** | **int** | Length in milliseconds. FreeClimb will wait silently before continuing on. | 


 [[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)



