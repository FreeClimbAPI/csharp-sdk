# freeclimb.Model.ConferenceParticipantResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | The URI for this resource, relative to /apiserver. | [optional] 
**DateCreated** | **string** | The date that this resource was created (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). | [optional] 
**DateUpdated** | **string** | The date that this resource was last updated (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). | [optional] 
**Revision** | **int** | Revision count for the resource. This count is set to 1 on creation and is incremented every time it is updated. | [optional] 
**AccountId** | **string** | ID of the account that created this participant. | [optional] 
**ConferenceId** | **string** | ID of the conference this participant is in. | [optional] 
**CallId** | **string** | ID of the Call associated with this Participant. | [optional] 
**Talk** | **bool?** | True if this Participant has talk privileges in the Conference. False otherwise. | [optional] 
**Listen** | **bool?** | True if this Participant has listen privileges in the Conference. False otherwise. | [optional] 
**DtmfPassThrough** | **bool?** | True if this Participant had dtmfPassThrough privileges in the Conference. False otherwise. | [optional] 
**StartConfOnEnter** | **bool?** | True if this Participant joining the Conference caused the Conference to start (status &#x3D; inProgress). False otherwise. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

