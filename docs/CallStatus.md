# freeclimb.Enums.CallStatus
* `queued` &ndash; Call is ready and waiting in line before going out. * `ringing` &ndash; Call is currently ringing. * `inProgress` &ndash; Call was answered and is currently in progress. * `canceled` &ndash; Call was hung up while it was queued or ringing. * `completed` &ndash; Call was answered and has ended normally. * `busy` &ndash; Caller received a busy signal. * `failed` &ndash; Call could not be completed as dialed, most likely because the phone number was non-existent. * `noAnswer` &ndash; Call ended without being answered.


## Properties

Name | Value | Notes
------------ | ------------- | -------------

**QUEUED** | queued | Represented in C# as 1, but can be seralized & deserialized using the reflection and extension methods
**RINGING** | ringing | Represented in C# as 2, but can be seralized & deserialized using the reflection and extension methods
**IN_PROGRESS** | inProgress | Represented in C# as 3, but can be seralized & deserialized using the reflection and extension methods
**CANCELED** | canceled | Represented in C# as 4, but can be seralized & deserialized using the reflection and extension methods
**COMPLETED** | completed | Represented in C# as 5, but can be seralized & deserialized using the reflection and extension methods
**FAILED** | failed | Represented in C# as 6, but can be seralized & deserialized using the reflection and extension methods
**BUSY** | busy | Represented in C# as 7, but can be seralized & deserialized using the reflection and extension methods
**NO_ANSWER** | noAnswer | Represented in C# as 8, but can be seralized & deserialized using the reflection and extension methods



[[Link to Serialization/Deserialization]](../README.md#documentation-for-serialization-deserialization) [[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)



