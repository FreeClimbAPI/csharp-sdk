# freeclimb.Model.Say
The `Say` command provides Text-To-Speech (TTS) support. It converts text to speech and then renders it in a female voice back to the caller. `Say` is useful in cases where it's difficult to pre-record a prompt for any reason. `Say` does not allow barge-in unless nested within a `GetSpeech` command. The file will always be played to completion unless nested.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**Text** | **string** | The message to be played to the caller using TTS. The size of the string is limited to 4 KB (or 4,096 bytes). An empty string will cause the command to be skipped. | 
**Language** | **string** | Language and (by implication) the locale to use. This implies the accent and pronunciations to be usde for the TTS. The complete list of valid values for the language attribute is shown below. | [optional] 
**Loop** | **int** | Number of times the text is said. Specifying &#39;0&#39; causes the &#x60;Say&#x60; action to loop until the Call is hung up. | [optional] [default to 1]
**ConferenceId** | **string** | D of the Conference the speech should be rendered to. If this is not specified, the speech is by default rendered to the Caller associated with the call leg that corresponds to the current PerCL execution context. The call leg associated with this command must be in the specified Conference or the command will return an error. | [optional] 
**PrivacyMode** | **bool** | Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

