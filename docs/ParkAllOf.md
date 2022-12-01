# freeclimb.Model.ParkAllOf



## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

**WaitUrl** | **string** | Specifies a URL pointing to a PerCL script containing actions to be executed while the caller is Parked. Once the script returned by the waitUrl runs out of commands to execute, FreeClimb will re-request the waitUrl and start over, essentially looping the script requests indefinitely. | 
**ActionUrl** | **string** | A request is made to this URL when the Call is resumed, which can occur if the Call is resumed via the Unpark command, the REST API (POST to Call resource), or the caller hangs up. The PerCL script returned in response to the actionUrl will be executed on the resumed call. | 
**NotificationUrl** | **string** | URL to be invoked when the Call is parked. The request to the URL contains the standard request parameters. | [optional] 


 [[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)



