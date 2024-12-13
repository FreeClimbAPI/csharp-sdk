# freeclimb.Model.SMSTenDLCBrand

A brand is a business identity behind the campaign.
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | ID of the account that created this Queue. | [optional] 
**EntityType** | **SMSTenDLCBrandEntityType** |  | 
**CspId** | **string** | Unique identifier assigned to the csp by the registry. | [optional] [readonly] 
**BrandId** | **string** | Unique identifier assigned to the brand by the registry. | [optional] [readonly] 
**FirstName** | **string** | First or given name.  | [optional] 
**LastName** | **string** | Last or Surname. | [optional] 
**DisplayName** | **string** | Display or marketing name of the brand. | 
**CompanyName** | **string** | (Required for Non-profit/private/public) Legal company name. | [optional] 
**Ein** | **string** | (Required for Non-profit) Government assigned corporate tax ID. EIN is 9-digits in U.S. | [optional] 
**EinIssuingCountry** | **string** | ISO2 2 characters country code. Example: US - United States | [optional] 
**Phone** | **string** | Valid phone number in e.164 international format. | 
**Street** | **string** | Street number and name. | [optional] 
**City** | **string** | City name | [optional] 
**State** | **string** | State. Must be 2 letters code for United States. | [optional] 
**PostalCode** | **string** | Postal codes. Use 5 digit zipcode for United States | [optional] 
**Country** | **string** | ISO2 2 characters country code. Example: US - United States | 
**Email** | **string** | Valid email address of brand support contact. | 
**StockSymbol** | **string** | (Required for public company) stock symbol. | [optional] 
**StockExchange** | **SMSTenDLCBrandStockExchange** |  | [optional] 
**IpAddress** | **string** | IP address of the browser requesting to create brand identity. | [optional] 
**Website** | **string** | Brand website URL. | [optional] 
**BrandRelationship** | **SMSTenDLCBrandRelationship** |  | 
**Vertical** | **string** | Vertical or industry segment of the brand. | 
**AltBusinessId** | **string** | Alternate business identifier such as DUNS, LEI, or GIIN | [optional] 
**AltBusinessIdType** | **SMSTenDLCBrandAltBusinessIdType** |  | [optional] 
**UniversalEin** | **string** | Universal EIN of Brand, Read Only. | [optional] [readonly] 
**ReferenceId** | **string** | Caller supplied brand reference ID. If supplied, the value must be unique across all submitted brands. Can be used to prevent duplicate brand registrations. | [optional] 
**OptionalAttributes** | **Dictionary&lt;string, Object&gt;** | Optional brand attributes. Please refer to GET /enum/optionalAttributeNames for dictionary of optional attribute names. | [optional] 
**Mock** | **bool** | Test brand. | 
**IdentityStatus** | **SMSTenDLCBrandIdentityStatus** |  | 
**CreateDate** | **DateTime** | Unix timestamp when brand was created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

