# freeclimb.Model.PlayAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**File** | **string** | RL of the audio file to be played to the caller. The URL can be the &#x60;recordingUrl&#x60; generated from the &#x60;RecordUtterance&#x60; or &#x60;StartRecordCall&#x60; PerCL commands.  | 
**Loop** | **int** | Number of times the audio file is played. Specifying &#39;0&#39; causes the Play action to loop until the Call is hung up. | [optional] 
**ConferenceId** | **string** | ID of the Conference the audio should be rendered to. If this is not specified, the audio is by default rendered to the caller associated with the call leg that corresponds to the current PerCL execution context. The call leg associated with this command must be in the specified Conference or the command will return an error. | [optional] 
**PrivacyMode** | **bool** | Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

