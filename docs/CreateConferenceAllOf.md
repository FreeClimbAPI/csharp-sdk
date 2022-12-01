# freeclimb.Model.CreateConferenceAllOf



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

**ActionUrl** | **string** |  This URL is invoked once the Conference is successfully created. Actions on the Conference, such as adding Participants, can be performed via the PerCL script returned in the response.  | 
**Alias** | **bool** | Descriptive name for the Conference.  | [optional] 
**PlayBeep** | **PlayBeep** |  | [optional] 
**Record** | **bool** | When set to &#x60;true&#x60;, the entire Conference is recorded. The &#x60;statusCallbackUrl&#x60; of the Conference will receive a &#x60;conferenceRecordingEnded&#x60; Webhook when the Conference transitions from the &#x60;inProgress&#x60; to empty state. | [optional] 
**StatusCallbackUrl** | **string** | This URL is invoked when the status of the Conference changes or when a recording of the Conference has become available. | [optional] 
**WaitUrl** | **string** | If specified, this URL provides the custom hold music for the Conference when it is in the populated state. This attribute is always fetched using HTTP GET and is fetched just once – when the Conference is created. The URL must be an audio file that is reachable and readable by FreeClimb. | [optional] 


 [[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)



