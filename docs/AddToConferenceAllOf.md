# freeclimb.Model.AddToConferenceAllOf


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowCallControl** | **bool** | If &#x60;true&#x60;, Call control will be enabled for this Participant&#39;s Call leg. | [optional] 
**CallControlSequence** | **string** | Defines a sequence of digits that, when entered by this caller, invokes the &#x60;callControlUrl&#x60;. Only digits plus &#39;*&#39;, and &#39;#&#39; may be used. | [optional] 
**CallControlUrl** | **string** | URL to be invoked when this Participant enters the digit sequence defined in the &#x60;callControlSequence&#x60; attribute. | [optional] 
**ConferenceId** | **string** | ID of the Conference to which to add the Participant (Call leg). Conference must exist or an error will result. | 
**CallId** | **string** | ID of the Call that will be added to the specified Conference. The Call must be in progress or an error will result. If the Call is part of an existing Conference, it is first removed from that Conference and is then moved to the new one. | [optional] 
**LeaveConferenceUrl** | **string** | URL to be invoked when the Participant leaves the Conference.  | [optional] 
**Listen** | **bool** | If &#x60;true&#x60;, the Participant joins the Conference with listen privileges. This may be modified later via the REST API or &#x60;SetListen&#x60; PerCL command. | [optional] 
**NotificationUrl** | **string** | When the Participant enters the Conference, this URL will be invoked using an HTTP POST request with the standard request parameters. | [optional] 
**StartConfOnEnter** | **bool** | Flag that indicates whether a Conference starts upon entry of this particular Participant. This is usually set to &#x60;true&#x60; for moderators and &#x60;false&#x60; for all other Participants. | [optional] 
**Talk** | **bool** | If &#x60;true&#x60;, the Participant joins the Conference with talk privileges. This may be modified later via the REST API or &#x60;SetTalk&#x60; PerCL command.  | [optional] 

[[Link to Serialization/Deserialization]](../README.md#documentation-for-serialization-deserialization)<br /> 
[[Back to Enum list]](../README.md#documentation-for-enums)<br /> 
[[Back to Model list]](../README.md#documentation-for-models)<br /> 
[[Back to API list]](../README.md#documentation-for-api-endpoints) <br /> 
[[Back to README]](../README.md) <br /> 
