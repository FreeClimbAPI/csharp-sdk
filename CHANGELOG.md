# C-Sharp SDK Changelog

All notable changes to this project will be documented in this file.

The format of this changelog is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).
This project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [Unreleased]

None

<a name="5.3.0"></a>

## [5.3.0] - 2025-10-21

### Added

- Add models for new TTS models and engine setup
- Add models and default api methods for Blob API

### Removed

- Deprecated query params when searching incoming phone numbers

<a name="5.2.0"></a>

## [5.2.0] - 2025-09-24

### Added

- Add models for ExportResult and ExportRequest

### Changed

- CallResult.callStatus -> CallResult.status
- CreateConference now includes parentCallId

<a name="5.1.2"></a>

## [5.1.2] - 2025-07-10

### Changed

- Remove null values when serializing models to JSON

<a name="5.1.1"></a>

## [5.1.1] - 2025-02-18

### Changed

- Make statusCallbackURL property mandatory for CreateConference

<a name="5.1.0"></a>

## [5.1.0] - 2025-02-05

### Added

- CampaignTFN and MessageResultsAllOfTfn models

<a name="5.0.0"></a>

## [5.0.0] - 2025-01-08

### Added

- Webhook classes
- More idiomated Enum management

### Changed

- Use upgraded openapi generator

### Removed

- \*AllOf model files

<a name="4.10.0"></a>

## [4.10.0] - 2024-12-16

### Added

- Add DtmfPassThrough property to certain models
- Make mediaUrls property nullable

<a name="4.9.0"></a>

## [4.9.0] - 2024-10-08

### Added

- Add KnowledgeBase API to SDK

<a name="4.8.0"></a>

## [4.8.0] - 2024-09-12

### Added

- GetNextPage method to DefaultApi

<a name="4.7.1"></a>

## [4.7.1] - 2024-08-01

### Changed

- Fix test file format and some value updates, also fix SDK file auto-generation issue

<a name="4.7.0"></a>

## [4.7.0] - 2024-07-05

### Changed

- GetDigit initialTimeoutMS property type change from string to integer

### Removed

- Deprecated percl fields

<a name="4.6.3"></a>

## [4.6.3] - 2024-04-09

### Added

- Fix for Signature Information class method bug

<a name="4.6.2"></a>

## [4.6.2] - 2023-09-06

### Changed

- TranscribeUtterance into a PerCL command

<a name="4.6.1"></a>

## [4.6.1] - 2023-09-01

### Added

- MIT License

<a name="4.6.0"></a>

## [4.6.0] - 2023-08-15

### Added

- Transcribe Utterance Feature

<a name="4.5.2"></a>

## [4.5.2] 2023-08-07

### Changed

- Added Unit Testing for C# SDK

<a name="4.5.1"></a>

## [4.5.1] 2023-07-26

### Changed

- Changed AddToConference CallId property type from boolean to string

<a name="4.5.0"></a>

## [4.5.0] 2023-06-07

### Added

- Number management feature for csharp sdk including methods, properties, and testing

<a name="4.4.0"></a>

## [4.4.0] 2023-04-27

### Changed

- Introduce application ID filtering for list calls method

<a name="4.3.0"></a>

## [4.3.0] 2023-04-03

### Added

- Introduce signing secret verification class (RequestVerifier) - https://docs.freeclimb.com/docs/validating-requests-from-freeclimb#how-to-verify-requests-manually

<a name="4.2.3"></a>

## [4.2.3] 2023-03-13

### Changed

- callStatus variable of CallResult is now processing and returning correct data back

<a name="4.2.2"></a>

## [4.2.2] 2023-02-21

### Changed

- OutDial PerCL command callingNumber and destination types fixed

<a name="4.2.1"></a>

## [4.2.1] 2023-02-14

### Changed

- Application Request model allows for null values

<a name="4.2.0"></a>

## [4.2.0] 2023-01-06

### Changed

- Enums have been implemented in the csharp sdk
- Updated README for enum implementation and testing

<a name="4.1.1"></a>

## [4.1.1] 2022-12-01

### Changed

- Changed `QueueResult` property `currentSize` from string to int
- Renamed `QueueResult` property `averageWaitTime` to `averageQueueRemovalTime`

<a name="4.1.0"></a>

## [4.1.0] 2022-11-02

### Changed

- Account ID is no longer needed for every api request/model creation
- Updated README for accountId and apiKey setting

<a name="4.0.2"></a>

## [4.0.2] 2022-11-01

### Added

- Add `offnet` property in IncomingNumber resource
- Add `offnet` query parameter for listIncomingNumbers

<a name="4.0.1"></a>

## [4.0.1] 2022-08-19

### Added

- Add `Park` PerCL command
- Add `Unpark` PerCL command

<a name="3.0.5"></a>

## [3.0.5] 2021-12-6

### Changed

- Replaced Auth Token -> API Key

<a name="3.0.4"></a>

## [3.0.4] 2021-11-2

### Added

- Added `applicationId`, `country`, `hasApplication`, `region`, `smsEnabled`, `voiceEnabled` optional filters to `IncomingPhoneNumbersSearchFilters` interface
- Added `country`, `region`, `smsEnabled`, `voiceEnabled` optional filters to `AvailablePhoneNumbersSearchFilters` interface

<a name="3.0.3"></a>

## [3.0.3] 2021-11-4

### Added

- 1 new param `active` for CallSearchFilters

<a name="3.0.1"></a>

## [3.0.1] 2021-08-03

### Added

- 4 new properties for GetSpeechActionCallback

<a name="2.1.2"></a>

## [3.0.0] - 2021-05-06

### Added

- Add new `Utils` file
- Add API to verify a signature

<a name="2.1.2"></a>

## [2.1.2] - 2020-12-16

### Added

- Add `privacyMode` option to RecordUtterance PerCL command

<a name="2.1.1"></a>

## [2.1.1] - 2020-12-16

### Added

- Additional message statuses for TFN functionality

<a name="1.2.1"></a>

## [1.2.1] - 2020-10-14

### Added

- Add `Reject` PerCL command
- Add `privacyMode` option

### Changed

- Rename `setPersyUrl` to `setUrl`

### Fixed

- Properly handle empty response bodies
- Other Minor bug fixes

<a name="1.2"></a>

## [1.2] - 2019-10-16

### Changed

- Persephony is now FreeClimb
- Code cleanup
- Documentation Updates
- Test Update

### Fixed

- Update common response handler to not use bodu twice

<a name="1.1.1"></a>

## [1.1.1] - 2019-06-27

### Changed

- Minor updates to docs and code cleanup

<a name="1.1.0"></a>

## [1.1.0] - 2019-06-07

### Pull Requests

- Merge pull request [#22](https://gitlab.vailsys.com/vail-cloud-services/fc-boilerplates/javascript-sdk/issues/22) from PersephonyAPI/maintenance

<a name="1.0.0"></a>

## [1.0.0] - 2019-06-04

### Changed

- Change default api target

<a name="0.1.0"></a>

## [0.1.0] - 2019-05-30

### Added

- `PlayEarlyMedia` PerCL Command

<a name="0.0.2"></a>

## [0.0.2] - 2018-11-29

### Remove

- Remove `callConnectUrl` and `statusCallbackUrl` from api.calls#create

<a name="0.0.1"></a>

## [0.0.1] - 2018-11-13

### Added

- PerCL Support
- FreeClimb API Support
- README, LICENSE
- docs

### Changed

- Initial Release

[unreleased]: https://github.com/FreeClimbAPI/csharp-sdk/compare/v1.0.1...HEAD
