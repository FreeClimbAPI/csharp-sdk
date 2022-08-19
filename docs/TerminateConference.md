# freeclimb.Model.TerminateConference
The `TerminateConference` command terminates an existing Conference. Any active participants are hung up on by FreeClimb. If this is not the desired behavior, use the `RemoveFromConference` command to unbridge Calls that should not be hung up. Note: The Call requesting TerminateConference must be on the same Conference for this command to execute.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**ConferenceId** | **string** | ID of the conference to terminate. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

