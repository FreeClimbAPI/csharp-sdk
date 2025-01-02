# freeclimb.Model.Play

The `Play` command plays an audio file back to the caller. The audio file may be located at any location accessible via a URL. `Play` can exist as a stand-alone command or as a nested command. It does not allow barge-in unless nested within a `GetSpeech` command. The file will always be played to completion unless nested.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**File** | **string** | RL of the audio file to be played to the caller. The URL can be the &#x60;recordingUrl&#x60; generated from the &#x60;RecordUtterance&#x60; or &#x60;StartRecordCall&#x60; PerCL commands.  | 
**Loop** | **int** | Number of times the audio file is played. Specifying &#39;0&#39; causes the Play action to loop until the Call is hung up. | [optional] 
**PrivacyMode** | **bool** | Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

