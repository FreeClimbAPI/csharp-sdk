# freeclimb.Model.CreateConferenceAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionUrl** | **string** |  This URL is invoked once the Conference is successfully created. Actions on the Conference, such as adding Participants, can be performed via the PerCL script returned in the response.  | 
**Alias** | **bool** | Descriptive name for the Conference.  | [optional] 
**PlayBeep** | **string** | Indicates whether to play a beep when a Participant enters or leaves the Conference. either &#x60;always&#x60;, &#x60;never&#x60;, &#x60;entryOnly&#x60;, or &#x60;exitOnly&#x60;. Leaving this unset will make conference default to &#x60;always&#x60;  | [optional] 
**Record** | **bool** | When set to &#x60;true&#x60;, the entire Conference is recorded. The &#x60;statusCallbackUrl&#x60; of the Conference will receive a &#x60;conferenceRecordingEnded&#x60; Webhook when the Conference transitions from the &#x60;inProgress&#x60; to empty state. | [optional] 
**StatusCallbackUrl** | **bool** | This URL is invoked when the status of the Conference changes or when a recording of the Conference has become available. | [optional] 
**WaitUrl** | **string** | If specified, this URL provides the custom hold music for the Conference when it is in the populated state. This attribute is always fetched using HTTP GET and is fetched just once – when the Conference is created. The URL must be an audio file that is reachable and readable by FreeClimb. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

