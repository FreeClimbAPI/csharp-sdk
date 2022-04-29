# freeclimb.Model.RemoveFromConference
The `RemoveFromConference` command removes a Participant from a Conference but does not hang up. Instead, the Call is simply unbridged and what happens next with the Call is determined by the PerCL returned in response to the `leaveConferenceUrl` attribute.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**CallId** | **string** | ID of the Call leg to be removed from the Conference. The Call must be in a Conference or an error will be triggered. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

