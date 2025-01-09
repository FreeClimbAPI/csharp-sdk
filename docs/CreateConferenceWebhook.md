# freeclimb.Model.CreateConferenceWebhook

A Conference has been created and its statusCallbackUrl or actionUrl is being invoked. A PerCL response is expected if the actionUrl is being invoked.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestType** | **string** | Context or reason why this request is being made. Will be createConference - A Conference has been created and its statusCallbackUrl or actionUrl is being invoked. | [optional] 
**CallId** | **string** | Unique ID for this Call, generated by FreeClimb. | [optional] 
**AccountId** | **string** | Account ID associated with your account. | [optional] 
**From** | **string** | Phone number of the party that initiated the Call (in E.164 format). | [optional] 
**To** | **string** | Phone number provisioned to you and to which this Call is directed (in E.164 format). | [optional] 
**CallStatus** | **CallStatus** |  | [optional] 
**Direction** | **CallDirection** |  | [optional] 
**ConferenceId** | **string** | Unique ID of the Conference. | [optional] 
**QueueId** | **string** | This is only populated if the request pertains to a Queue. Otherwise, it is set to null. | [optional] 
**Status** | **ConferenceStatus** |  | [optional] 
**RecordingUrl** | **string** | The URL of the Conference’s recorded audio. Populated only if a Recording exists and the Conference was emptied. Present only if statusCallbackUrl is being invoked. | [optional] 
**RecordingId** | **string** | The unique ID of the Recording from this Conference. Populated only if a Recording exists and the Conference was emptied. Present only if statusCallbackUrl is being invoked. | [optional] 
**RecordingDurationSec** | **int?** | The duration of the recorded audio rounded up to the nearest second (in seconds). Populated only if a Recording exists and the Conference was emptied. Present only if statusCallbackUrl is being invoked. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
