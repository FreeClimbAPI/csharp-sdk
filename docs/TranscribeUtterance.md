# freeclimb.Model.TranscribeUtterance

The `TranscribeUtterance` command transcribes the caller’s voice and returns transcription of the audio and optionally returns the recording of the audio transcribed.  `TranscribeUtterance` is blocking and is a terminal command. As such, the actionUrl property is required, and control of the Call picks up using the `PerCL` returned in response of the `actionUrl`. Recording and Transcription information is returned in the actionUrl request. If the reason this command ended was due to the call hanging up, any PerCL returned will not execute.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**ActionUrl** | **string** |  | 
**PlayBeep** | **bool** |  | [optional] [default to false]
**Record** | [**TranscribeUtteranceRecord**](TranscribeUtteranceRecord.md) |  | [optional] 
**PrivacyForLogging** | **bool** |  | [optional] [default to false]
**PrivacyForRecording** | **bool** |  | [optional] [default to false]
**Prompts** | [**List&lt;PerclCommand&gt;**](PerclCommand.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

