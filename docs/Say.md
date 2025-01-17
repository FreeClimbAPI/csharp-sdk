# freeclimb.Model.Say

The `Say` command provides Text-To-Speech (TTS) support. It converts text to speech and then renders it in a female voice back to the caller. `Say` is useful in cases where it's difficult to pre-record a prompt for any reason. `Say` does not allow barge-in unless nested within a `GetSpeech` command. The file will always be played to completion unless nested.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**Text** | **string** | The message to be played to the caller using TTS. The size of the string is limited to 4 KB (or 4,096 bytes). An empty string will cause the command to be skipped. | 
**Language** | **string** | Language and (by implication) the locale to use. This implies the accent and pronunciations to be usde for the TTS. The complete list of valid values for the language attribute is shown below. | [optional] 
**Loop** | **int** | Number of times the text is said. Specifying &#39;0&#39; causes the &#x60;Say&#x60; action to loop until the Call is hung up. | [optional] [default to 1]
**PrivacyMode** | **bool** | Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

