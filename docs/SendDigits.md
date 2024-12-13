# freeclimb.Model.SendDigits

The `SendDigits` command plays DTMF tones on a live Call. This is useful for navigating through IVR menus or dialing extensions.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**Digits** | **string** | String containing the digits to be played. The string cannot be empty and can include any digit, plus &#x60;#&#x60;, or &#x60;*&#x60;, and allows embedding specification for delay or pause between the output of individual digits. | 
**PauseMs** | **int** | Pause between digits in milliseconds. Valid values are 100-1000 milliseconds and will be adjusted by FreeClimb to satisfy the constraint. | [optional] 
**PrivacyMode** | **bool** | Parameter &#x60;privacyMode&#x60; will not log the &#x60;text&#x60; as required by PCI compliance. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

