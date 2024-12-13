# freeclimb.Model.MessageDeliveryWebhook

An SMS has been received by the platform and is being delivered to the smsUrl of the customer application that is associated with the destination number. A PerCL response will be ignored.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestType** | **string** | Value will be messageDelivery - An SMS message has been received by the platform and is being delivered to the customer application associated with the destination number. | [optional] 
**AccountId** | **string** | Account ID associated with your account. | [optional] 
**From** | **string** | Phone number of the party that initiated the Call (in E.164 format). | [optional] 
**To** | **string** | Phone number provisioned to you and to which this Call is directed (in E.164 format). | [optional] 
**Text** | **string** | Body of the SMS message. | [optional] 
**Direction** | **string** | Value will be inbound to indicate the receipt of a message into the FreeClimb platform. | [optional] 
**ApplicationId** | **string** | ID of the application to which the destination number is assigned. | [optional] 
**Status** | **string** | Value will be received to indicate that the platform has successfully received the incoming message. | [optional] 
**PhoneNumberId** | **string** | ID of the destination phone number. | [optional] 
**Uri** | **string** | The URI for this resource, relative to the API base URL | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

