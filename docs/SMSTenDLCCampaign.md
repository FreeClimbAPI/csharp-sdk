# freeclimb.Model.SMSTenDLCCampaign


## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | **string** | ID of the account that created this Queue. | [optional] 
**CampaignId** | **string** | Alphanumeric identifier assigned by the registry for a campaign. This identifier is required by the NetNumber OSR SMS enabling process of 10DLC. | 
**CspId** | **string** | Alphanumeric identifier of the CSP associated with this campaign. | 
**ResellerId** | **string** | Alphanumeric identifier of the reseller that you want to associate with this campaign. | [optional] 
**Status** | **string** | Current campaign status. Possible values: ACTIVE, EXPIRED. A newly created campaign defaults to ACTIVE status.  | [optional] 
**CreateDate** | **DateTime** | Unix timestamp when campaign was created. | [optional] 
**AutoRenewal** | **bool** | Campaign subscription auto-renewal status. | [optional] 
**BilledDate** | **DateTime?** | Campaign recent billed date. | [optional] 
**BrandId** | **string** | Alphanumeric identifier of the brand associated with this campaign. | 
**Usecase** | **string** | Campaign usecase. Must be of defined valid types. Use &#x60;/registry/enum/usecase&#x60; operation to retrieve usecases available for given brand. | 
**SubUsecases** | **List&lt;string&gt;** | Campaign sub-usecases. Must be of defined valid sub-usecase types. Use &#x60;/registry/enum/usecase&#x60; operation to retrieve list of valid sub-usecases | 
**Description** | **string** | Summary description of this campaign. | 
**EmbeddedLink** | **bool** | Does message generated by the campaign include URL link in SMS? | [optional] [default to false]
**EmbeddedPhone** | **bool** | Does message generated by the campaign include phone number in SMS? | [optional] [default to false]
**AffiliateMarketing** | **bool** | Does message content controlled by affiliate marketing other than the brand? | [optional] 
**NumberPool** | **bool** | Does campaign utilize pool of phone nubers? | [optional] [default to false]
**AgeGated** | **bool** | Age gated content in campaign. | [optional] 
**DirectLending** | **bool** |  | [optional] 
**SubscriberOptin** | **bool** | Does campaign require subscriber to opt-in before SMS is sent to subscriber? | [optional] [default to false]
**SubscriberOptout** | **bool** | Does campaign support subscriber opt-out keyword(s)? | [optional] [default to false]
**SubscriberHelp** | **bool** | Does campaign responds to help keyword(s)? | [optional] [default to false]
**Sample1** | **string** | Message sample. Some campaign tiers require 1 or more message samples. | [optional] 
**Sample2** | **string** | Message sample. Some campaign tiers require 2 or more message samples. | [optional] 
**Sample3** | **string** | Message sample. Some campaign tiers require 3 or more message samples. | [optional] 
**Sample4** | **string** | Message sample. Some campaign tiers require 4 or more message samples. | [optional] 
**Sample5** | **string** | Message sample. Some campaign tiers require 5 or more message samples. | [optional] 
**MessageFlow** | **string** | Message flow description. | [optional] 
**HelpMessage** | **string** | Help message of the campaign. | [optional] 
**ReferenceId** | **string** | Caller supplied campaign reference ID. If supplied, the value must be unique across all submitted campaigns. Can be used to prevent duplicate campaign registrations. | [optional] 
**Mock** | **bool** | Campaign created from mock brand. Mocked campaign cannot be shared with an upstream CNP. | 
**NextRenewalOrExpirationDate** | **DateTime?** | When the campaign would be due for its next renew/bill date. | [optional] 

[[Link to Serialization/Deserialization]](../README.md#documentation-for-serialization-deserialization)<br /> 
[[Back to Enum list]](../README.md#documentation-for-enums)<br /> 
[[Back to Model list]](../README.md#documentation-for-models)<br /> 
[[Back to API list]](../README.md#documentation-for-api-endpoints) <br /> 
[[Back to README]](../README.md) <br /> 