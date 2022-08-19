# freeclimb.Model.SetTalk
The `SetTalk` command enables or disables the talk privilege for a Participant in a Conference provided both calls are in the same conference. If 'true', no audio from that Participant is shared with the other Participants of the Conference.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**CallId** | **string** | ID of the call leg that is to be muted or unmuted. The Call must be in a Conference or an error will be triggered. | 
**Talk** | **bool** | Specifying &#x60;false&#x60; mutes the Participant. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

