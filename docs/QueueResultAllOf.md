# freeclimb.Model.QueueResultAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | ID of the account that created this Queue. | [optional] 
**QueueId** | **string** | A string that uniquely identifies this Queue resource. | [optional] 
**Alias** | **string** | A description for this Queue. | [optional] 
**MaxSize** | **int?** | The maximum number of Calls permitted in the Queue. Default is 100. Maximum is 1000. | [optional] 
**CurrentSize** | **string** | Count of Calls currently in the Queue. | [optional] 
**AverageWaitTime** | **string** | Average wait time (in seconds) of all Calls in the Queue. | [optional] 
**SubresourceUris** | **Object** | List of subresources for this Queue (which includes Queue members). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

