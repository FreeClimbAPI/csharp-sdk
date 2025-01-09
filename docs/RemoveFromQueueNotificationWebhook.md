# freeclimb.Model.RemoveFromQueueNotificationWebhook

A call has been removed from a queue and the Enqueue command’s actionUrl is being invoked. A PerCL response is expected except if reason is hangup.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestType** | **string** | Context or reason why this request is being made. Will be removeFromQueueNotification - A Call has been removed from a Queue and the Enqueue command’s actionUrl is being invoked. | [optional] 
**AccountId** | **string** | Account ID associated with your account. | [optional] 
**CallId** | **string** | Unique identifier for this Call, generated by FreeClimb | [optional] 
**From** | **string** | Phone number of the party that initiated the Call (in E.164 format). | [optional] 
**To** | **string** | Phone number provisioned to the customer and to which this Call is directed (in E.164 format). | [optional] 
**CallStatus** | **CallStatus** |  | [optional] 
**Direction** | **CallDirection** |  | [optional] 
**ConferenceId** | **string** | This is only populated if request pertains to a conference. Otherwise, it is set to null. | [optional] 
**QueueId** | **string** | This is only populated if the request pertains to a queue. Otherwise, it is set to null. | [optional] 
**QueueResult** | **QueueResultStatus** |  | [optional] 
**QueueTime** | **int** | Time (in seconds) the Call spent in the Queue. This is only available if the Call was actually enqueued. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
