# freeclimb.Model.MakeCallRequest


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **string** | Phone number to use as the caller ID. This can be: (a) The To or From number provided in FreeClimb&#39;s initial request to your app or (b) Any incoming phone number you have purchased from FreeClimb. | 
**To** | **string** | Phone number to place the Call to. | 
**ApplicationId** | **string** | Required if no &#x60;parentCallId&#x60; or &#x60;callConnectUrl&#x60; has been provided. ID of the application FreeClimb should use to handle this phone call. FreeClimb will use the &#x60;callConnectUrl&#x60; and &#x60;statusCallbackUrl&#x60; set on the application unless the &#x60;callConnectUrl&#x60; attribute is also provided with the request. In this case, the URL specified in that &#x60;callConnectUrl&#x60; attribute will be used as a replacement of the &#x60;callConnectUrl&#x60; originally assigned in the application. If the &#x60;callConnectUrl&#x60; is not set as either an attribute of the request or as part of the specified application, an error will be provided. The application’s voiceUrl parameter is not used for outbound calls. | [optional] 
**SendDigits** | **string** | String of digits to dial after connecting to the number. It can include digits &#x60;0-9&#x60;, &#x60;*&#x60;, and &#x60;#&#x60;, and allows embedding a pause between the output of individual digits. The default pause is 500 milliseconds. So, a string such as *1234#* will be played in 2 seconds because of the 4 standard pauses implied within the string. A custom pause is specified by including a positive integer wrapped in curly braces: {n}. For more information, see **sendDigits examples** below. | [optional] 
**IfMachine** | **string** | Specifies how FreeClimb should handle this Call if an answering machine answers it. | [optional] 
**IfMachineUrl** | **string** | This attribute specifies a URL to which FreeClimb will make a POST request when an answering machine or a fax machine is detected. This URL is required if the ifMachine flag is set to redirect. When ifMachine is set to hangup, ifMachineUrl must not be included in the request. For more information, see **ifMachineUrl example** below. | [optional] 
**Timeout** | **int** | Number of seconds that FreeClimb should allow the phone to ring before assuming there is no answer. Default is 30 seconds. Maximum allowed ring-time is determined by the target phone&#39;s provider. Note that most providers limit ring-time to 120 seconds. | [optional] [default to 30]
**ParentCallId** | **string** | Required if no &#x60;applicationId&#x60; or &#x60;callConnectUrl&#x60; has been provided. The ID of the parent Call in the case that this new Call is meant to be treated as a child of an existing Call. This attribute should be included when possible to reduce latency when adding child calls to Conferences containing the parent Call. A call can only be used as a parent once the call is in progress or as an inbound call that is still ringing. An outbound call is considered to be in progress once the &#x60;outdialConnect&#x60; or &#x60;outdialApiConnect&#x60; webhook is invoked. An inbound call is ringing when the inbound webhook is invoked. If a &#x60;callConnectUrl&#x60; attribute is also included with the &#x60;parentCallId&#x60; in the request, this URL will be used as a replacement of the &#x60;callConnectUrl&#x60; originally assigned in the parent call. | [optional] 
**PrivacyMode** | **bool** | Activate privacy mode in order to obscure log data that can potentially expose private information. | [optional] 
**CallConnectUrl** | **string** | The URL that FreeClimb should use to handle this phone call. If an applicationId or parentCallId have already been provided, this callConnectUrl attribute will be used as a replacement of the callConnectUrl originally assigned in the application or parent call. | [optional] 

[[Link to Serialization/Deserialization]](../README.md#documentation-for-serialization-deserialization)<br /> 
[[Back to Enum list]](../README.md#documentation-for-enums)<br /> 
[[Back to Model list]](../README.md#documentation-for-models)<br /> 
[[Back to API list]](../README.md#documentation-for-api-endpoints) <br /> 
[[Back to README]](../README.md) <br /> 
