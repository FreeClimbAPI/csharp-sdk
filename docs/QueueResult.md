# freeclimb.Model.QueueResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | The URI for this resource, relative to /apiserver. | [optional] 
**DateCreated** | **string** | The date that this resource was created (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). | [optional] 
**DateUpdated** | **string** | The date that this resource was last updated (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). | [optional] 
**Revision** | **int** | Revision count for the resource. This count is set to 1 on creation and is incremented every time it is updated. | [optional] 
**AccountId** | **string** | ID of the account that created this Queue. | [optional] 
**QueueId** | **string** | A string that uniquely identifies this Queue resource. | [optional] 
**Alias** | **string** | A description for this Queue. | [optional] 
**MaxSize** | **int?** | The maximum number of Calls permitted in the Queue. Default is 100. Maximum is 1000. | [optional] 
**CurrentSize** | **int?** | Count of Calls currently in the Queue. | [optional] 
**AverageQueueRemovalTime** | **int?** | The average amount of time (in seconds) for a call to be removed from the queue. | [optional] 
**SubresourceUris** | **Object** | List of subresources for this Queue (which includes Queue members). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

