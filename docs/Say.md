# freeclimb.Model.Say


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**Text** | **string** | The message to be played to the caller using TTS. The size of the string is limited to 4 KB (or 4,096 bytes). An empty string will cause the command to be skipped. | 
**Language** | **string** | Language and (by implication) the locale to use. This implies the accent and pronunciations to be usde for the TTS. The complete list of valid values for the language attribute is shown below. | [optional] 
**Loop** | **int** | Number of times the text is said. Specifying &#39;0&#39; causes the &#x60;Say&#x60; action to loop until the Call is hung up. | [optional] [default to 1]
**PrivacyMode** | **bool** | Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance. | [optional] 

[[Link to Serialization/Deserialization]](../README.md#documentation-for-serialization-deserialization)<br /> 
[[Back to Enum list]](../README.md#documentation-for-enums)<br /> 
[[Back to Model list]](../README.md#documentation-for-models)<br /> 
[[Back to API list]](../README.md#documentation-for-api-endpoints) <br /> 
[[Back to README]](../README.md) <br /> 
