# freeclimb.Model.MessageResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Uri** | **string** | The URI for this resource, relative to /apiserver. | [optional] 
**DateCreated** | **string** | The date that this resource was created (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). | [optional] 
**DateUpdated** | **string** | The date that this resource was last updated (GMT) in RFC 1123 format (e.g., Mon, 15 Jun 2009 20:45:30 GMT). | [optional] 
**Revision** | **int** | Revision count for the resource. This count is set to 1 on creation and is incremented every time it is updated. | [optional] 
**AccountId** | **string** | String that uniquely identifies this account resource. | [optional] 
**MessageId** | **string** | String that uniquely identifies this message resource | [optional] 
**Status** | **MessageStatus** |  | [optional] 
**From** | **string** | Phone number in E.164 format that sent the message. | [optional] 
**To** | **string** | Phone number in E.164 format that received the message. | [optional] 
**Text** | **string** | Message contents | [optional] 
**Direction** | **string** | Noting whether the message was inbound or outbound | [optional] 
**NotificationUrl** | **string** | URL invoked when message sent | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

