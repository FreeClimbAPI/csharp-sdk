# freeclimb.Model.RecordUtteranceAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActionUrl** | **string** | URL to which information on the completed recording is submitted. The PerCL received in response is then used to continue with Call processing. | 
**SilenceTimeoutMs** | **int** | Interval of silence that should elapse before ending the recording. | [optional] 
**FinishOnKey** | **string** | Key that triggers the end of the recording. any digit, &#39;#&#39;, or &#39;*&#39; | [optional] 
**MaxLengthSec** | **int** | Maximum length for the command execution in seconds. | [optional] 
**PlayBeep** | **bool** | Indicates whether to play a beep sound before the start of the recording. If set to &#x60;false&#x60;, no beep is played. | [optional] 
**AutoStart** | **bool** | If &#x60;false&#x60;, recording begins immediately after the RecordUtterance command is processed. If &#x60;true&#x60;, recording begins when audio is present and if audio begins before the &#x60;maxLengthSec&#x60; timeout. If no audio begins before &#x60;maxLengthSec&#x60;, no recording is generated. | [optional] 
**PrivacyMode** | **bool** | Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

