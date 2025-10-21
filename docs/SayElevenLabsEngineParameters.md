# freeclimb.Model.SayElevenLabsEngineParameters

The parameters to use for the TTS. The complete list of valid values for the parameters attribute is shown below.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelId** | **string** | The ID of the ElevenLabs model to use for the TTS. The complete list of valid values for the model_id attribute is shown below. | [optional] [default to "eleven_turbo_v2_5"]
**VoiceId** | **string** | The ID of the ElevenLabs voice to use for the TTS. The complete list of valid values for the voice_id attribute is shown below. | [optional] 
**LanguageCode** | **string** | The language code to use for the TTS. The complete list of valid values for the language_code attribute is shown below. | [optional] [default to "en"]
**VoiceSettings** | [**SayElevenLabsEngineParametersVoiceSettings**](SayElevenLabsEngineParametersVoiceSettings.md) |  | [optional] 
**PronunciationDictionary** | [**List&lt;SayElevenLabsEngineParametersPronunciationDictionaryInner&gt;**](SayElevenLabsEngineParametersPronunciationDictionaryInner.md) |  | [optional] 
**Seed** | **int** |  | [optional] 
**PreviousText** | **string** |  | [optional] 
**NextText** | **string** |  | [optional] 
**PreviousRequestIds** | **List&lt;string&gt;** |  | [optional] 
**NextRequestIds** | **List&lt;string&gt;** |  | [optional] 
**ApplyLanguageTextNormalization** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

