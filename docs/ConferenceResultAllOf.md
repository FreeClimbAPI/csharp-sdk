# freeclimb.Model.ConferenceResultAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ConferenceId** | **string** | A string that uniquely identifies this Conference resource. | [optional] 
**AccountId** | **string** | ID of the account that created this Conference. | [optional] 
**Alias** | **string** | A description for this Conference. | [optional] 
**PlayBeep** | **string** | Setting that controls when a beep is played. One of: always, never, entryOnly, exitOnly. Defaults to always. | [optional] 
**Record** | **bool?** | Flag indicating whether recording is enabled for this Conference. | [optional] 
**Status** | **string** | The status of the Conference. One of: creating, empty, populated, inProgress, or terminated. | [optional] 
**WaitUrl** | **string** | URL referencing the audio file to be used as default wait music for the Conference when it is in the populated state. | [optional] 
**ActionUrl** | **string** | URL invoked once the Conference is successfully created. | [optional] 
**StatusCallbackUrl** | **string** | URL to inform that the Conference status has changed. | [optional] 
**SubresourceUris** | **Object** | The list of subresources for this Conference. This includes participants and/or recordings. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

