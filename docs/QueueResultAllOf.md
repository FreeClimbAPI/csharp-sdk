# freeclimb.Model.QueueResultAllOf


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | ID of the account that created this Queue. | [optional] 
**QueueId** | **string** | A string that uniquely identifies this Queue resource. | [optional] 
**Alias** | **string** | A description for this Queue. | [optional] 
**MaxSize** | **int?** | The maximum number of Calls permitted in the Queue. Default is 100. Maximum is 1000. | [optional] 
**CurrentSize** | **int?** | Count of Calls currently in the Queue. | [optional] 
**AverageQueueRemovalTime** | **int?** | The average amount of time (in seconds) for a call to be removed from the queue. | [optional] 
**SubresourceUris** | **Object** | List of subresources for this Queue (which includes Queue members). | [optional] 

[[Link to Serialization/Deserialization]](../README.md#documentation-for-serialization-deserialization)<br /> 
[[Back to Enum list]](../README.md#documentation-for-enums)<br /> 
[[Back to Model list]](../README.md#documentation-for-models)<br /> 
[[Back to API list]](../README.md#documentation-for-api-endpoints) <br /> 
[[Back to README]](../README.md) <br /> 
