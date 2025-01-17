# freeclimb.Model.AddToQueueNotificationWebhook

A Call has been added to a Queue and the Enqueue command’s notificationUrl is being invoked. This is a notification only; any PerCL returned will be ignored.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestType** | **string** | Context or reason why this request is being made. Will be addToQueueNotification - A call has been added to a queue and the Enqueue command’s notificationUrl is being invoked. | [optional] 
**CallId** | **string** | Unique ID for this Call, generated by FreeClimb. | [optional] 
**AccountId** | **string** | Account ID associated with your account. | [optional] 
**From** | **string** | Phone number of the party that initiated the Call (in E.164 format). | [optional] 
**To** | **string** | Phone number provisioned to you and to which this Call is directed (in E.164 format). | [optional] 
**CallStatus** | **CallStatus** |  | [optional] 
**Direction** | **CallDirection** |  | [optional] 
**ConferenceId** | **string** | Unique ID of the Conference. | [optional] 
**QueueId** | **string** | This is only populated if the request pertains to a Queue. Otherwise, it is set to null. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

