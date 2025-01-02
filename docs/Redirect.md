# freeclimb.Model.Redirect

The `Redirect` command transfers control of a Call to the PerCL at a different URL. `Redirect` is a terminal command, so any actions following it are never executed. The maximum number of redirections allowed during the life time of a Call is 256. This is intended to prevent a Call from possibly looping infinitely due to errors in PerCL being generated.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**ActionUrl** | **string** | URL to request a new PerCL script to continue with the current Call&#39;s processing. When &#x60;Redirect&#x60; invokes the &#x60;actionUrl&#x60;, an &#x60;inbound&#x60; Webhook is sent. This request therefore looks identical to the initial request (made to the &#x60;voiceUrl&#x60; of the number that was called) for an inbound Call. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

