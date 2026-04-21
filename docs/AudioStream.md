# freeclimb.Model.AudioStream

The `AudioStream` command transfers control of the call to a gRPC session.  Upon completion of the gRPC session, if the actionUrl is specified, control can be returned to percl usage or the call will simply be hung up if the actionUrl is not specified.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Command** | **string** | Name of PerCL Command (this is automatically derived from mapping configuration and should not be manually supplied in any arguments) | [optional] 
**Location** | **string** | The gRPC server location that will receive the grpc stream as a uri and must be port 80 or 443. | 
**ActionUrl** | **string** | A request is made to this URL when the gRPC session is concluded. The PerCL script returned in response to the actionUrl will be executed on the call. | [optional] 
**ContentType** | **string** | The type and sample rate of the audio being received over the channel must match the environmental sample rate. | [optional] 
**MetaData** | **List&lt;string&gt;** | An arbitrary array of strings passed through FC to the GRPC server can be used to pass state or other information about the call. | [optional] 
**PrivacyMode** | **bool** | Enables audio redaction with full call recording while gRPC session is running and blocks logging of any DTMFs received by FreeClimb. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

