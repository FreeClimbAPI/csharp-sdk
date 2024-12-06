# freeclimb.Model.GetDigitsReason
This field explains how the GetDigits action ended. The value is one of the below: •finishKey - The finish key as specified had been pressed by the caller. Digit string has all keys up to, but not including, the finish key.  •timeout - The timeout limit was reached prior to any other criteria being met. If any digits were collected, they will be included.  •maxDigits - The maximum number of digits was reached and digit collection ended.  •tone - Answering machine or fax tone detection occurred, interrupting digit collection. Any digits received up to this point are included in this webhook.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

