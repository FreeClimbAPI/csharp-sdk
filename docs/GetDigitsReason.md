# freeclimb.Enums.GetDigitsReason

This field explains how the GetDigits action ended. The value is one of the below: •finishKey - The finish key as specified had been pressed by the caller. Digit string has all keys up to, but not including, the finish key.  •timeout - The timeout limit was reached prior to any other criteria being met. If any digits were collected, they will be included.  •maxDigits - The maximum number of digits was reached and digit collection ended.  •tone - Answering machine or fax tone detection occurred, interrupting digit collection. Any digits received up to this point are included in this webhook.
## Properties

Name | Value | Notes
------------ | ------------- | -------------
**FINISH_KEY** | finishKey | Represented in C# as 1
**TIMEOUT** | timeout | Represented in C# as 2
**MAX_DIGITS** | maxDigits | Represented in C# as 3
**TONE** | tone | Represented in C# as 4

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

