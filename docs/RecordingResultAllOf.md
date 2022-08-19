# freeclimb.Model.RecordingResultAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecordingId** | **string** | String that uniquely identifies this recording resource. | [optional] 
**AccountId** | **string** | ID of the account that created this recording. | [optional] 
**CallId** | **string** | ID of the Call that was recorded. If a Conference was recorded, this value is empty and the conferenceId property is populated. | [optional] 
**DurationSec** | **int?** | Length of the recording in seconds. | [optional] 
**ConferenceId** | **string** | ID of the Conference that was recorded. If a Call was recorded, this value is empty and the callId property is populated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

