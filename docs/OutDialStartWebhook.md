# freeclimb.Model.OutDialStartWebhook

The OutDial command has started and the actionUrl is being invoked. This request is made in the context of the parent call (Call leg that invoked). A PerCL response is expected.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestType** | **string** | Context or reason why this request is being made. Will be outDialStart - The OutDial command has started and the actionUrl is being invoked. | [optional] 
**AccountId** | **string** | Account ID associated with your account. | [optional] 
**CallId** | **string** | Unique identifier for this Call, generated by FreeClimb | [optional] 
**From** | **string** | Phone number of the party that initiated the Call (in E.164 format). | [optional] 
**To** | **string** | Phone number provisioned to the customer and to which this Call is directed (in E.164 format). | [optional] 
**CallStatus** | **CallStatus** |  | [optional] 
**Direction** | **CallDirection** |  | [optional] 
**ConferenceId** | **string** | This is only populated if request pertains to a conference. Otherwise, it is set to null. | [optional] 
**QueueId** | **string** | This is only populated if the request pertains to a queue. Otherwise, it is set to null. | [optional] 
**DialCallId** | **string** | ID of the child call that was generated as a result of the Outdial. | [optional] 
**ParentCallId** | **string** | ID of the Call that created this leg (child call). If this was an inbound call or call created via REST API with no parent, this field will be null. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

