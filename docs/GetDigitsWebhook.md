# freeclimb.Model.GetDigitsWebhook

A POST request with the following fields will be sent to the actionUrl provided in your GetDigits command.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestType** | **string** | Context or reason why this request is being made. Will be getDigits - The GetDigits command has completed and its actionUrl is being invoked. | [optional] 
**CallId** | **string** | Unique ID for this Call, generated by FreeClimb. | [optional] 
**AccountId** | **string** | Account ID associated with your account. | [optional] 
**From** | **string** | Phone number of the party that initiated the Call (in E.164 format). | [optional] 
**To** | **string** | Phone number provisioned to you and to which this Call is directed (in E.164 format). | [optional] 
**CallStatus** | **CallStatus** |  | [optional] 
**Direction** | **CallDirection** |  | [optional] 
**ConferenceId** | **string** | Unique ID of the Conference. | [optional] 
**QueueId** | **string** | This is only populated if the request pertains to a Queue. Otherwise, it is set to null. | [optional] 
**Digits** | **string** | tring of digits entered by the Caller, excluding the terminating digit (if used). The string of digits will be replaced by &#39;xxxxx&#39; when privacyMode is set to true | [optional] 
**Reason** | **GetDigitsReason** |  | [optional] 
**ParentCallId** | **string** | ID of the Call that created this leg (child call). | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
