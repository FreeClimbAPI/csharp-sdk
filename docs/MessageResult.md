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
**BrandId** | **string** | The unique identifier for the brand associated with the message | [optional] 
**CampaignId** | **string** | The unique identifier for the campaign associated with the message | [optional] 
**SegmentCount** | **decimal?** | The number of segments into which the message was split | [optional] 
**MediaUrls** | **List&lt;string&gt;** | an array of HTTP URLs which were attached this this message | [optional] 
**Tfn** | [**TFN**](TFN.md) |  | [optional] 
**PhoneNumberId** | **string** | String that uniquely identifies the phoneNumber resource used to send this Message | [optional] 
**ApplicationId** | **string** | String that uniquely identifies the Application resource used to send this Message | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

