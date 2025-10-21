# freeclimb.Model.BlobResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlobId** | **string** | Identifier which can be used to reference this blob in future interations. | [optional] 
**AccountId** | **string** |  | [optional] 
**Alias** | **string** | Custom identifier for this blob that is unique for the owning account. It will be set to the blobId by default if not provided in the creation request. | [optional] 
**Revision** | **int** |  | [optional] 
**DateCreated** | **DateTime** | An RFC3339 timestamp with millisecond resolution. It represents the time this blob was created. | [optional] 
**DateUpdated** | **DateTime** | An RFC3339 timestamp with millisecond resolution. It represents the time this blob was last modified, which at creation will always equal dateCreated. | [optional] 
**ExpiresAt** | **DateTime** | An RFC3339 timestamp with millisecond resolution. It represents the time at which this blob will expire and self delete. | [optional] 
**Blob** | **Object** | Blob content | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

