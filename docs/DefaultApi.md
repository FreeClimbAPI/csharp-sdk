# freeclimb.Api.DefaultApi

All URIs are relative to *https://www.freeclimb.com/apiserver*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BuyAPhoneNumber**](DefaultApi.md#buyaphonenumber) | **POST** /Accounts/{accountId}/IncomingPhoneNumbers | Buy a Phone Number |
| [**CreateAConference**](DefaultApi.md#createaconference) | **POST** /Accounts/{accountId}/Conferences | Create a Conference |
| [**CreateAQueue**](DefaultApi.md#createaqueue) | **POST** /Accounts/{accountId}/Queues | Create a Queue |
| [**CreateAnApplication**](DefaultApi.md#createanapplication) | **POST** /Accounts/{accountId}/Applications | Create an application |
| [**CreateKnowledgeBaseCompletion**](DefaultApi.md#createknowledgebasecompletion) | **POST** /Accounts/{accountId}/KnowledgeBases/{knowledgeBaseId}/Completion | Query the knowledge base |
| [**DeleteARecording**](DefaultApi.md#deletearecording) | **DELETE** /Accounts/{accountId}/Recordings/{recordingId} | Delete a Recording |
| [**DeleteAnApplication**](DefaultApi.md#deleteanapplication) | **DELETE** /Accounts/{accountId}/Applications/{applicationId} | Delete an application |
| [**DeleteAnIncomingNumber**](DefaultApi.md#deleteanincomingnumber) | **DELETE** /Accounts/{accountId}/IncomingPhoneNumbers/{phoneNumberId} | Delete an Incoming Number |
| [**DequeueAMember**](DefaultApi.md#dequeueamember) | **POST** /Accounts/{accountId}/Queues/{queueId}/Members/{callId} | Dequeue a Member |
| [**DequeueHeadMember**](DefaultApi.md#dequeueheadmember) | **POST** /Accounts/{accountId}/Queues/{queueId}/Members/Front | Dequeue Head Member |
| [**DownloadARecordingFile**](DefaultApi.md#downloadarecordingfile) | **GET** /Accounts/{accountId}/Recordings/{recordingId}/Download | Download a Recording File |
| [**FilterLogs**](DefaultApi.md#filterlogs) | **POST** /Accounts/{accountId}/Logs | Filter Logs |
| [**GetACall**](DefaultApi.md#getacall) | **GET** /Accounts/{accountId}/Calls/{callId} | Get a Call |
| [**GetAConference**](DefaultApi.md#getaconference) | **GET** /Accounts/{accountId}/Conferences/{conferenceId} | Get a Conference |
| [**GetAMember**](DefaultApi.md#getamember) | **GET** /Accounts/{accountId}/Queues/{queueId}/Members/{callId} | Get a Member |
| [**GetAParticipant**](DefaultApi.md#getaparticipant) | **GET** /Accounts/{accountId}/Conferences/{conferenceId}/Participants/{callId} | Get a Participant |
| [**GetAQueue**](DefaultApi.md#getaqueue) | **GET** /Accounts/{accountId}/Queues/{queueId} | Get a Queue |
| [**GetARecording**](DefaultApi.md#getarecording) | **GET** /Accounts/{accountId}/Recordings/{recordingId} | Get a Recording |
| [**GetAnAccount**](DefaultApi.md#getanaccount) | **GET** /Accounts/{accountId} | Get an Account |
| [**GetAnApplication**](DefaultApi.md#getanapplication) | **GET** /Accounts/{accountId}/Applications/{applicationId} | Get an Application |
| [**GetAnIncomingNumber**](DefaultApi.md#getanincomingnumber) | **GET** /Accounts/{accountId}/IncomingPhoneNumbers/{phoneNumberId} | Get an Incoming Number |
| [**GetAnSmsMessage**](DefaultApi.md#getansmsmessage) | **GET** /Accounts/{accountId}/Messages/{messageId} | Get an SMS Message |
| [**GetHeadMember**](DefaultApi.md#getheadmember) | **GET** /Accounts/{accountId}/Queues/{queueId}/Members/Front | Get Head Member |
| [**GetTenDLCSmsBrand**](DefaultApi.md#gettendlcsmsbrand) | **GET** /Accounts/{accountId}/Messages/10DLC/Brands/{brandId} | Get a 10DLC SMS Brand |
| [**GetTenDLCSmsBrands**](DefaultApi.md#gettendlcsmsbrands) | **GET** /Accounts/{accountId}/Messages/10DLC/Brands | Get list of SMS 10DLC Brands |
| [**GetTenDLCSmsCampaign**](DefaultApi.md#gettendlcsmscampaign) | **GET** /Accounts/{accountId}/Messages/10DLC/Campaigns/{campaignId} | Get a 10DLC SMS Campaign |
| [**GetTenDLCSmsCampaigns**](DefaultApi.md#gettendlcsmscampaigns) | **GET** /Accounts/{accountId}/Messages/10DLC/Campaigns | Get list of SMS 10DLC Campaigns |
| [**GetTenDLCSmsPartnerCampaign**](DefaultApi.md#gettendlcsmspartnercampaign) | **GET** /Accounts/{accountId}/Messages/10DLC/PartnerCampaigns/{campaignId} | Get a 10DLC SMS Partner Campaign |
| [**GetTenDLCSmsPartnerCampaigns**](DefaultApi.md#gettendlcsmspartnercampaigns) | **GET** /Accounts/{accountId}/Messages/10DLC/PartnerCampaigns | Get list of SMS 10DLC Partner Campaigns |
| [**GetTollFreeSmsCampaign**](DefaultApi.md#gettollfreesmscampaign) | **GET** /Accounts/{accountId}/Messages/TollFree/Campaigns/{campaignId} | Get a TollFree SMS Campaign |
| [**GetTollFreeSmsCampaigns**](DefaultApi.md#gettollfreesmscampaigns) | **GET** /Accounts/{accountId}/Messages/TollFree/Campaigns | Get list of TollFree Campaigns |
| [**ListActiveQueues**](DefaultApi.md#listactivequeues) | **GET** /Accounts/{accountId}/Queues | List Active Queues |
| [**ListAllAccountLogs**](DefaultApi.md#listallaccountlogs) | **GET** /Accounts/{accountId}/Logs | List All Account Logs |
| [**ListApplications**](DefaultApi.md#listapplications) | **GET** /Accounts/{accountId}/Applications | List applications |
| [**ListAvailableNumbers**](DefaultApi.md#listavailablenumbers) | **GET** /AvailablePhoneNumbers | List available numbers |
| [**ListCallLogs**](DefaultApi.md#listcalllogs) | **GET** /Accounts/{accountId}/Calls/{callId}/Logs | List Call Logs |
| [**ListCallRecordings**](DefaultApi.md#listcallrecordings) | **GET** /Accounts/{accountId}/Calls/{callId}/Recordings | List Call Recordings |
| [**ListCalls**](DefaultApi.md#listcalls) | **GET** /Accounts/{accountId}/Calls | List Calls |
| [**ListConferenceRecordings**](DefaultApi.md#listconferencerecordings) | **GET** /Accounts/{accountId}/Conferences/{conferenceId}/Recordings | List Conference Recordings |
| [**ListConferences**](DefaultApi.md#listconferences) | **GET** /Accounts/{accountId}/Conferences | List Conferences |
| [**ListIncomingNumbers**](DefaultApi.md#listincomingnumbers) | **GET** /Accounts/{accountId}/IncomingPhoneNumbers | List Incoming Numbers |
| [**ListMembers**](DefaultApi.md#listmembers) | **GET** /Accounts/{accountId}/Queues/{queueId}/Members | List Members |
| [**ListParticipants**](DefaultApi.md#listparticipants) | **GET** /Accounts/{accountId}/Conferences/{conferenceId}/Participants | List Participants |
| [**ListRecordings**](DefaultApi.md#listrecordings) | **GET** /Accounts/{accountId}/Recordings | List Recordings |
| [**ListSmsMessages**](DefaultApi.md#listsmsmessages) | **GET** /Accounts/{accountId}/Messages | List SMS Messages |
| [**MakeACall**](DefaultApi.md#makeacall) | **POST** /Accounts/{accountId}/Calls | Make a Call |
| [**MakeAWebrtcJwt**](DefaultApi.md#makeawebrtcjwt) | **POST** /Accounts/{accountId}/Calls/WebRTC/Token | Make a JWT for WebRTC calling |
| [**RemoveAParticipant**](DefaultApi.md#removeaparticipant) | **DELETE** /Accounts/{accountId}/Conferences/{conferenceId}/Participants/{callId} | Remove a Participant |
| [**SendAnSmsMessage**](DefaultApi.md#sendansmsmessage) | **POST** /Accounts/{accountId}/Messages | Send an SMS Message |
| [**StreamARecordingFile**](DefaultApi.md#streamarecordingfile) | **GET** /Accounts/{accountId}/Recordings/{recordingId}/Stream | Stream a Recording File |
| [**UpdateAConference**](DefaultApi.md#updateaconference) | **POST** /Accounts/{accountId}/Conferences/{conferenceId} | Update a Conference |
| [**UpdateALiveCall**](DefaultApi.md#updatealivecall) | **POST** /Accounts/{accountId}/Calls/{callId} | Update a Live Call |
| [**UpdateAParticipant**](DefaultApi.md#updateaparticipant) | **POST** /Accounts/{accountId}/Conferences/{conferenceId}/Participants/{callId} | Update a Participant |
| [**UpdateAQueue**](DefaultApi.md#updateaqueue) | **POST** /Accounts/{accountId}/Queues/{queueId} | Update a Queue |
| [**UpdateAnAccount**](DefaultApi.md#updateanaccount) | **POST** /Accounts/{accountId} | Manage an account |
| [**UpdateAnApplication**](DefaultApi.md#updateanapplication) | **POST** /Accounts/{accountId}/Applications/{applicationId} | Update an application |
| [**UpdateAnIncomingNumber**](DefaultApi.md#updateanincomingnumber) | **POST** /Accounts/{accountId}/IncomingPhoneNumbers/{phoneNumberId} | Update an Incoming Number |

<a id="buyaphonenumber"></a>
# **BuyAPhoneNumber**
> IncomingNumberResult BuyAPhoneNumber (BuyIncomingNumberRequest buyIncomingNumberRequest)

Buy a Phone Number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class BuyAPhoneNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var buyIncomingNumberRequest = new BuyIncomingNumberRequest(); // BuyIncomingNumberRequest | Incoming Number transaction details
            
            try
            {
                // Buy a Phone Number
                IncomingNumberResult result = apiInstance.BuyAPhoneNumber(buyIncomingNumberRequest);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.BuyAPhoneNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BuyAPhoneNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Buy a Phone Number
    ApiResponse<IncomingNumberResult> response = apiInstance.BuyAPhoneNumberWithHttpInfo(buyIncomingNumberRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.BuyAPhoneNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **buyIncomingNumberRequest** | [**BuyIncomingNumberRequest**](BuyIncomingNumberRequest.md) | Incoming Number transaction details |  |


### Return type

[**IncomingNumberResult**](IncomingNumberResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful Incoming Number transaction |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createaconference"></a>
# **CreateAConference**
> ConferenceResult CreateAConference (CreateConferenceRequest? createConferenceRequest = null)

Create a Conference

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class CreateAConferenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var createConferenceRequest = new CreateConferenceRequest?(); // CreateConferenceRequest? | Conference to create (optional) 
            
            try
            {
                // Create a Conference
                ConferenceResult result = apiInstance.CreateAConference(createConferenceRequest);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAConference: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAConferenceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Conference
    ApiResponse<ConferenceResult> response = apiInstance.CreateAConferenceWithHttpInfo(createConferenceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateAConferenceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **createConferenceRequest** | [**CreateConferenceRequest?**](CreateConferenceRequest?.md) | Conference to create | [optional]  |


### Return type

[**ConferenceResult**](ConferenceResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Details of created conference |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createaqueue"></a>
# **CreateAQueue**
> QueueResult CreateAQueue (QueueRequest? queueRequest = null)

Create a Queue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class CreateAQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var queueRequest = new QueueRequest?(); // QueueRequest? | Queue details used to create a queue (optional) 
            
            try
            {
                // Create a Queue
                QueueResult result = apiInstance.CreateAQueue(queueRequest);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a Queue
    ApiResponse<QueueResult> response = apiInstance.CreateAQueueWithHttpInfo(queueRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateAQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **queueRequest** | [**QueueRequest?**](QueueRequest?.md) | Queue details used to create a queue | [optional]  |


### Return type

[**QueueResult**](QueueResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfuly created queue |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createanapplication"></a>
# **CreateAnApplication**
> ApplicationResult CreateAnApplication (ApplicationRequest? applicationRequest = null)

Create an application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class CreateAnApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var applicationRequest = new ApplicationRequest?(); // ApplicationRequest? | Application Details (optional) 
            
            try
            {
                // Create an application
                ApplicationResult result = apiInstance.CreateAnApplication(applicationRequest);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateAnApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAnApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an application
    ApiResponse<ApplicationResult> response = apiInstance.CreateAnApplicationWithHttpInfo(applicationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateAnApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **applicationRequest** | [**ApplicationRequest?**](ApplicationRequest?.md) | Application Details | [optional]  |


### Return type

[**ApplicationResult**](ApplicationResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Application successfuly created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createknowledgebasecompletion"></a>
# **CreateKnowledgeBaseCompletion**
> CompletionResult CreateKnowledgeBaseCompletion (string knowledgeBaseId, CompletionRequest? completionRequest = null)

Query the knowledge base

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class CreateKnowledgeBaseCompletionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var knowledgeBaseId = "knowledgeBaseId_example";  // string | A string that uniquely identifies the KnowledgeBase resource.
            
            var completionRequest = new CompletionRequest?(); // CompletionRequest? | Completion request details (optional) 
            
            try
            {
                // Query the knowledge base
                CompletionResult result = apiInstance.CreateKnowledgeBaseCompletion(knowledgeBaseId, completionRequest);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.CreateKnowledgeBaseCompletion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateKnowledgeBaseCompletionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Query the knowledge base
    ApiResponse<CompletionResult> response = apiInstance.CreateKnowledgeBaseCompletionWithHttpInfo(knowledgeBaseId, completionRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.CreateKnowledgeBaseCompletionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **knowledgeBaseId** | **string** | A string that uniquely identifies the KnowledgeBase resource. |  |

| **completionRequest** | [**CompletionRequest?**](CompletionRequest?.md) | Completion request details | [optional]  |


### Return type

[**CompletionResult**](CompletionResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | KnowledgeaBase completion response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletearecording"></a>
# **DeleteARecording**
> void DeleteARecording (string recordingId)

Delete a Recording

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class DeleteARecordingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var recordingId = "recordingId_example";  // string | String that uniquely identifies this recording resource.
            
            try
            {
                // Delete a Recording
                apiInstance.DeleteARecording(recordingId);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteARecording: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteARecordingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a Recording
    apiInstance.DeleteARecordingWithHttpInfo(recordingId);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteARecordingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **recordingId** | **string** | String that uniquely identifies this recording resource. |  |


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Recording Deleted |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteanapplication"></a>
# **DeleteAnApplication**
> void DeleteAnApplication (string applicationId)

Delete an application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class DeleteAnApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var applicationId = "applicationId_example";  // string | String that uniquely identifies this application resource.
            
            try
            {
                // Delete an application
                apiInstance.DeleteAnApplication(applicationId);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAnApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAnApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an application
    apiInstance.DeleteAnApplicationWithHttpInfo(applicationId);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteAnApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **applicationId** | **string** | String that uniquely identifies this application resource. |  |


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful application deletion |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteanincomingnumber"></a>
# **DeleteAnIncomingNumber**
> void DeleteAnIncomingNumber (string phoneNumberId)

Delete an Incoming Number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class DeleteAnIncomingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var phoneNumberId = "phoneNumberId_example";  // string | String that uniquely identifies this phone number resource.
            
            try
            {
                // Delete an Incoming Number
                apiInstance.DeleteAnIncomingNumber(phoneNumberId);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DeleteAnIncomingNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAnIncomingNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an Incoming Number
    apiInstance.DeleteAnIncomingNumberWithHttpInfo(phoneNumberId);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DeleteAnIncomingNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **phoneNumberId** | **string** | String that uniquely identifies this phone number resource. |  |


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful Incoming Number deletion. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dequeueamember"></a>
# **DequeueAMember**
> QueueMember DequeueAMember (string queueId, string callId)

Dequeue a Member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class DequeueAMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | String that uniquely identifies the Queue that the Member belongs to.
            
            var callId = "callId_example";  // string | ID if the Call that the Member belongs to
            
            try
            {
                // Dequeue a Member
                QueueMember result = apiInstance.DequeueAMember(queueId, callId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DequeueAMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DequeueAMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dequeue a Member
    ApiResponse<QueueMember> response = apiInstance.DequeueAMemberWithHttpInfo(queueId, callId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DequeueAMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **queueId** | **string** | String that uniquely identifies the Queue that the Member belongs to. |  |

| **callId** | **string** | ID if the Call that the Member belongs to |  |


### Return type

[**QueueMember**](QueueMember.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted dequeue request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="dequeueheadmember"></a>
# **DequeueHeadMember**
> QueueMember DequeueHeadMember (string queueId)

Dequeue Head Member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class DequeueHeadMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | String that uniquely identifies this queue resource.
            
            try
            {
                // Dequeue Head Member
                QueueMember result = apiInstance.DequeueHeadMember(queueId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DequeueHeadMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DequeueHeadMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Dequeue Head Member
    ApiResponse<QueueMember> response = apiInstance.DequeueHeadMemberWithHttpInfo(queueId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DequeueHeadMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **queueId** | **string** | String that uniquely identifies this queue resource. |  |


### Return type

[**QueueMember**](QueueMember.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted dequeue request |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="downloadarecordingfile"></a>
# **DownloadARecordingFile**
> System.IO.Stream DownloadARecordingFile (string recordingId)

Download a Recording File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class DownloadARecordingFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var recordingId = "recordingId_example";  // string | String that uniquely identifies this recording resource.
            
            try
            {
                // Download a Recording File
                System.IO.Stream result = apiInstance.DownloadARecordingFile(recordingId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.DownloadARecordingFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadARecordingFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download a Recording File
    ApiResponse<System.IO.Stream> response = apiInstance.DownloadARecordingFileWithHttpInfo(recordingId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.DownloadARecordingFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **recordingId** | **string** | String that uniquely identifies this recording resource. |  |


### Return type

**System.IO.Stream**

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: audio/x-wav


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Download a Recording file represented with audio/x-wav mime-type |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="filterlogs"></a>
# **FilterLogs**
> LogList FilterLogs (FilterLogsRequest filterLogsRequest)

Filter Logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class FilterLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var filterLogsRequest = new FilterLogsRequest(); // FilterLogsRequest | Filter logs request paramters
            
            try
            {
                // Filter Logs
                LogList result = apiInstance.FilterLogs(filterLogsRequest);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.FilterLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the FilterLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Filter Logs
    ApiResponse<LogList> response = apiInstance.FilterLogsWithHttpInfo(filterLogsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.FilterLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **filterLogsRequest** | [**FilterLogsRequest**](FilterLogsRequest.md) | Filter logs request paramters |  |


### Return type

[**LogList**](LogList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved log list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getacall"></a>
# **GetACall**
> CallResult GetACall (string callId)

Get a Call

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetACallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var callId = "callId_example";  // string | String that uniquely identifies this call resource.
            
            try
            {
                // Get a Call
                CallResult result = apiInstance.GetACall(callId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetACall: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetACallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Call
    ApiResponse<CallResult> response = apiInstance.GetACallWithHttpInfo(callId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetACallWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **callId** | **string** | String that uniquely identifies this call resource. |  |


### Return type

[**CallResult**](CallResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Call Resource |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaconference"></a>
# **GetAConference**
> ConferenceResult GetAConference (string conferenceId)

Get a Conference

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAConferenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | A string that uniquely identifies this conference resource.
            
            try
            {
                // Get a Conference
                ConferenceResult result = apiInstance.GetAConference(conferenceId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAConference: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAConferenceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Conference
    ApiResponse<ConferenceResult> response = apiInstance.GetAConferenceWithHttpInfo(conferenceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAConferenceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **conferenceId** | **string** | A string that uniquely identifies this conference resource. |  |


### Return type

[**ConferenceResult**](ConferenceResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved conference |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getamember"></a>
# **GetAMember**
> QueueMember GetAMember (string queueId, string callId)

Get a Member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | String that uniquely identifies the Queue that the Member belongs to.
            
            var callId = "callId_example";  // string | ID of the Call that the Member belongs to
            
            try
            {
                // Get a Member
                QueueMember result = apiInstance.GetAMember(queueId, callId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Member
    ApiResponse<QueueMember> response = apiInstance.GetAMemberWithHttpInfo(queueId, callId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **queueId** | **string** | String that uniquely identifies the Queue that the Member belongs to. |  |

| **callId** | **string** | ID of the Call that the Member belongs to |  |


### Return type

[**QueueMember**](QueueMember.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved a queue member |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaparticipant"></a>
# **GetAParticipant**
> ConferenceParticipantResult GetAParticipant (string conferenceId, string callId)

Get a Participant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | ID of the conference this participant is in.
            
            var callId = "callId_example";  // string | ID of the Call associated with this participant.
            
            try
            {
                // Get a Participant
                ConferenceParticipantResult result = apiInstance.GetAParticipant(conferenceId, callId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAParticipant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAParticipantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Participant
    ApiResponse<ConferenceParticipantResult> response = apiInstance.GetAParticipantWithHttpInfo(conferenceId, callId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAParticipantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **conferenceId** | **string** | ID of the conference this participant is in. |  |

| **callId** | **string** | ID of the Call associated with this participant. |  |


### Return type

[**ConferenceParticipantResult**](ConferenceParticipantResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved conference participant |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaqueue"></a>
# **GetAQueue**
> QueueResult GetAQueue (string queueId)

Get a Queue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | A string that uniquely identifies this queue resource.
            
            try
            {
                // Get a Queue
                QueueResult result = apiInstance.GetAQueue(queueId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Queue
    ApiResponse<QueueResult> response = apiInstance.GetAQueueWithHttpInfo(queueId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **queueId** | **string** | A string that uniquely identifies this queue resource. |  |


### Return type

[**QueueResult**](QueueResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved queue |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getarecording"></a>
# **GetARecording**
> RecordingResult GetARecording (string recordingId)

Get a Recording

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetARecordingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var recordingId = "recordingId_example";  // string | String that uniquely identifies this recording resource.
            
            try
            {
                // Get a Recording
                RecordingResult result = apiInstance.GetARecording(recordingId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetARecording: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetARecordingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Recording
    ApiResponse<RecordingResult> response = apiInstance.GetARecordingWithHttpInfo(recordingId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetARecordingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **recordingId** | **string** | String that uniquely identifies this recording resource. |  |


### Return type

[**RecordingResult**](RecordingResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getanaccount"></a>
# **GetAnAccount**
> AccountResult GetAnAccount ()

Get an Account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAnAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            try
            {
                // Get an Account
                AccountResult result = apiInstance.GetAnAccount();
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAnAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAnAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an Account
    ApiResponse<AccountResult> response = apiInstance.GetAnAccountWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAnAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters



### Return type

[**AccountResult**](AccountResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Account Details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getanapplication"></a>
# **GetAnApplication**
> ApplicationResult GetAnApplication (string applicationId)

Get an Application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAnApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var applicationId = "applicationId_example";  // string | A string that uniquely identifies this application resource.
            
            try
            {
                // Get an Application
                ApplicationResult result = apiInstance.GetAnApplication(applicationId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAnApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAnApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an Application
    ApiResponse<ApplicationResult> response = apiInstance.GetAnApplicationWithHttpInfo(applicationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAnApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **applicationId** | **string** | A string that uniquely identifies this application resource. |  |


### Return type

[**ApplicationResult**](ApplicationResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Application Details |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getanincomingnumber"></a>
# **GetAnIncomingNumber**
> IncomingNumberResult GetAnIncomingNumber (string phoneNumberId)

Get an Incoming Number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAnIncomingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var phoneNumberId = "phoneNumberId_example";  // string | String that uniquely identifies this phone number resource.
            
            try
            {
                // Get an Incoming Number
                IncomingNumberResult result = apiInstance.GetAnIncomingNumber(phoneNumberId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAnIncomingNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAnIncomingNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an Incoming Number
    ApiResponse<IncomingNumberResult> response = apiInstance.GetAnIncomingNumberWithHttpInfo(phoneNumberId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAnIncomingNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **phoneNumberId** | **string** | String that uniquely identifies this phone number resource. |  |


### Return type

[**IncomingNumberResult**](IncomingNumberResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Incoming Phone Number result. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getansmsmessage"></a>
# **GetAnSmsMessage**
> MessageResult GetAnSmsMessage (string messageId)

Get an SMS Message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetAnSmsMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var messageId = "messageId_example";  // string | String that uniquely identifies this Message resource.
            
            try
            {
                // Get an SMS Message
                MessageResult result = apiInstance.GetAnSmsMessage(messageId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetAnSmsMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAnSmsMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an SMS Message
    ApiResponse<MessageResult> response = apiInstance.GetAnSmsMessageWithHttpInfo(messageId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetAnSmsMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **messageId** | **string** | String that uniquely identifies this Message resource. |  |


### Return type

[**MessageResult**](MessageResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The specific SMS message that’s been processed by FreeClimb |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getheadmember"></a>
# **GetHeadMember**
> QueueMember GetHeadMember (string queueId)

Get Head Member

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetHeadMemberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | String that uniquely identifies the Queue that the Member belongs to.
            
            try
            {
                // Get Head Member
                QueueMember result = apiInstance.GetHeadMember(queueId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetHeadMember: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHeadMemberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Head Member
    ApiResponse<QueueMember> response = apiInstance.GetHeadMemberWithHttpInfo(queueId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetHeadMemberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **queueId** | **string** | String that uniquely identifies the Queue that the Member belongs to. |  |


### Return type

[**QueueMember**](QueueMember.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved queue member |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettendlcsmsbrand"></a>
# **GetTenDLCSmsBrand**
> SMSTenDLCBrand GetTenDLCSmsBrand (string brandId)

Get a 10DLC SMS Brand

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetTenDLCSmsBrandExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var brandId = "brandId_example";  // string | String that uniquely identifies this brand resource.
            
            try
            {
                // Get a 10DLC SMS Brand
                SMSTenDLCBrand result = apiInstance.GetTenDLCSmsBrand(brandId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTenDLCSmsBrand: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenDLCSmsBrandWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a 10DLC SMS Brand
    ApiResponse<SMSTenDLCBrand> response = apiInstance.GetTenDLCSmsBrandWithHttpInfo(brandId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetTenDLCSmsBrandWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **brandId** | **string** | String that uniquely identifies this brand resource. |  |


### Return type

[**SMSTenDLCBrand**](SMSTenDLCBrand.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The specific SMS 10DLC Brand that’s been processed by FreeClimb |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettendlcsmsbrands"></a>
# **GetTenDLCSmsBrands**
> SMSTenDLCBrandsListResult GetTenDLCSmsBrands ()

Get list of SMS 10DLC Brands

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetTenDLCSmsBrandsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            try
            {
                // Get list of SMS 10DLC Brands
                SMSTenDLCBrandsListResult result = apiInstance.GetTenDLCSmsBrands();
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTenDLCSmsBrands: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenDLCSmsBrandsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of SMS 10DLC Brands
    ApiResponse<SMSTenDLCBrandsListResult> response = apiInstance.GetTenDLCSmsBrandsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetTenDLCSmsBrandsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters



### Return type

[**SMSTenDLCBrandsListResult**](SMSTenDLCBrandsListResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list SMS 10DLC brands |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettendlcsmscampaign"></a>
# **GetTenDLCSmsCampaign**
> SMSTenDLCCampaign GetTenDLCSmsCampaign (string campaignId)

Get a 10DLC SMS Campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetTenDLCSmsCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var campaignId = "campaignId_example";  // string | String that uniquely identifies this campaign resource.
            
            try
            {
                // Get a 10DLC SMS Campaign
                SMSTenDLCCampaign result = apiInstance.GetTenDLCSmsCampaign(campaignId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTenDLCSmsCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenDLCSmsCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a 10DLC SMS Campaign
    ApiResponse<SMSTenDLCCampaign> response = apiInstance.GetTenDLCSmsCampaignWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetTenDLCSmsCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **campaignId** | **string** | String that uniquely identifies this campaign resource. |  |


### Return type

[**SMSTenDLCCampaign**](SMSTenDLCCampaign.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The specific SMS 10DLC Campaign that’s been processed by FreeClimb |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettendlcsmscampaigns"></a>
# **GetTenDLCSmsCampaigns**
> SMSTenDLCCampaignsListResult GetTenDLCSmsCampaigns (string? brandId = null)

Get list of SMS 10DLC Campaigns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetTenDLCSmsCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var brandId = "brandId_example";  // string? | The unique identifier for a brand (optional) 
            
            try
            {
                // Get list of SMS 10DLC Campaigns
                SMSTenDLCCampaignsListResult result = apiInstance.GetTenDLCSmsCampaigns(brandId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTenDLCSmsCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenDLCSmsCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of SMS 10DLC Campaigns
    ApiResponse<SMSTenDLCCampaignsListResult> response = apiInstance.GetTenDLCSmsCampaignsWithHttpInfo(brandId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetTenDLCSmsCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **brandId** | **string?** | The unique identifier for a brand | [optional]  |


### Return type

[**SMSTenDLCCampaignsListResult**](SMSTenDLCCampaignsListResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list SMS 10DLC campaigns |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettendlcsmspartnercampaign"></a>
# **GetTenDLCSmsPartnerCampaign**
> SMSTenDLCPartnerCampaign GetTenDLCSmsPartnerCampaign (string campaignId)

Get a 10DLC SMS Partner Campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetTenDLCSmsPartnerCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var campaignId = "campaignId_example";  // string | String that uniquely identifies this campaign resource.
            
            try
            {
                // Get a 10DLC SMS Partner Campaign
                SMSTenDLCPartnerCampaign result = apiInstance.GetTenDLCSmsPartnerCampaign(campaignId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTenDLCSmsPartnerCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenDLCSmsPartnerCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a 10DLC SMS Partner Campaign
    ApiResponse<SMSTenDLCPartnerCampaign> response = apiInstance.GetTenDLCSmsPartnerCampaignWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetTenDLCSmsPartnerCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **campaignId** | **string** | String that uniquely identifies this campaign resource. |  |


### Return type

[**SMSTenDLCPartnerCampaign**](SMSTenDLCPartnerCampaign.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The specific SMS 10DLC Partner Campaign that’s been processed by FreeClimb |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettendlcsmspartnercampaigns"></a>
# **GetTenDLCSmsPartnerCampaigns**
> SMSTenDLCPartnerCampaignsListResult GetTenDLCSmsPartnerCampaigns (string? brandId = null)

Get list of SMS 10DLC Partner Campaigns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetTenDLCSmsPartnerCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var brandId = "brandId_example";  // string? | The unique identifier for a brand (optional) 
            
            try
            {
                // Get list of SMS 10DLC Partner Campaigns
                SMSTenDLCPartnerCampaignsListResult result = apiInstance.GetTenDLCSmsPartnerCampaigns(brandId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTenDLCSmsPartnerCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTenDLCSmsPartnerCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of SMS 10DLC Partner Campaigns
    ApiResponse<SMSTenDLCPartnerCampaignsListResult> response = apiInstance.GetTenDLCSmsPartnerCampaignsWithHttpInfo(brandId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetTenDLCSmsPartnerCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **brandId** | **string?** | The unique identifier for a brand | [optional]  |


### Return type

[**SMSTenDLCPartnerCampaignsListResult**](SMSTenDLCPartnerCampaignsListResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list SMS 10DLC partner campaigns |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettollfreesmscampaign"></a>
# **GetTollFreeSmsCampaign**
> SMSTollFreeCampaign GetTollFreeSmsCampaign (string campaignId)

Get a TollFree SMS Campaign

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetTollFreeSmsCampaignExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var campaignId = "campaignId_example";  // string | String that uniquely identifies this TollFree Campaign resource.
            
            try
            {
                // Get a TollFree SMS Campaign
                SMSTollFreeCampaign result = apiInstance.GetTollFreeSmsCampaign(campaignId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTollFreeSmsCampaign: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTollFreeSmsCampaignWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a TollFree SMS Campaign
    ApiResponse<SMSTollFreeCampaign> response = apiInstance.GetTollFreeSmsCampaignWithHttpInfo(campaignId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetTollFreeSmsCampaignWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **campaignId** | **string** | String that uniquely identifies this TollFree Campaign resource. |  |


### Return type

[**SMSTollFreeCampaign**](SMSTollFreeCampaign.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The specific SMS TollFree Campaign that’s been processed by FreeClimb |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettollfreesmscampaigns"></a>
# **GetTollFreeSmsCampaigns**
> SMSTollFreeCampaignsListResult GetTollFreeSmsCampaigns ()

Get list of TollFree Campaigns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class GetTollFreeSmsCampaignsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            try
            {
                // Get list of TollFree Campaigns
                SMSTollFreeCampaignsListResult result = apiInstance.GetTollFreeSmsCampaigns();
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.GetTollFreeSmsCampaigns: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTollFreeSmsCampaignsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of TollFree Campaigns
    ApiResponse<SMSTollFreeCampaignsListResult> response = apiInstance.GetTollFreeSmsCampaignsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.GetTollFreeSmsCampaignsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters



### Return type

[**SMSTollFreeCampaignsListResult**](SMSTollFreeCampaignsListResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list toll-free campaigns |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listactivequeues"></a>
# **ListActiveQueues**
> QueueList ListActiveQueues (string? alias = null)

List Active Queues

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListActiveQueuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var alias = "alias_example";  // string? | Return only the Queue resources with aliases that exactly match this name. (optional) 
            
            try
            {
                // List Active Queues
                QueueList result = apiInstance.ListActiveQueues(alias);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListActiveQueues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListActiveQueuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Active Queues
    ApiResponse<QueueList> response = apiInstance.ListActiveQueuesWithHttpInfo(alias);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListActiveQueuesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **alias** | **string?** | Return only the Queue resources with aliases that exactly match this name. | [optional]  |


### Return type

[**QueueList**](QueueList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfuly retrieved queue list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listallaccountlogs"></a>
# **ListAllAccountLogs**
> LogList ListAllAccountLogs ()

List All Account Logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListAllAccountLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            try
            {
                // List All Account Logs
                LogList result = apiInstance.ListAllAccountLogs();
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListAllAccountLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAllAccountLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List All Account Logs
    ApiResponse<LogList> response = apiInstance.ListAllAccountLogsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListAllAccountLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters



### Return type

[**LogList**](LogList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved log list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listapplications"></a>
# **ListApplications**
> ApplicationList ListApplications (string? alias = null)

List applications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListApplicationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var alias = "alias_example";  // string? | Return only applications with aliases that exactly match this value. (optional) 
            
            try
            {
                // List applications
                ApplicationList result = apiInstance.ListApplications(alias);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListApplications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListApplicationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List applications
    ApiResponse<ApplicationList> response = apiInstance.ListApplicationsWithHttpInfo(alias);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListApplicationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **alias** | **string?** | Return only applications with aliases that exactly match this value. | [optional]  |


### Return type

[**ApplicationList**](ApplicationList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Applications |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listavailablenumbers"></a>
# **ListAvailableNumbers**
> AvailableNumberList ListAvailableNumbers (string? phoneNumber = null, string? region = null, string? country = null, bool? voiceEnabled = null, bool? smsEnabled = null, bool? capabilitiesVoice = null, bool? capabilitiesSms = null, bool? capabilitiesTollFree = null, bool? capabilitiesTenDLC = null, bool? capabilitiesShortCode = null)

List available numbers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListAvailableNumbersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var phoneNumber = "phoneNumber_example";  // string? | PCRE-compatible regular expression to filter against `phoneNumber` field, which is in E.164 format. (optional) 
            
            var region = "region_example";  // string? | State or province of this phone number. (optional) 
            
            var country = "country_example";  // string? | Country of this phone number. (optional) 
            
            var voiceEnabled = true;  // bool? | Indicates whether the phone number can handle Calls. Typically set to true for all numbers. (optional)  (default to true)
            
            var smsEnabled = true;  // bool? | Indication of whether the phone number can handle sending and receiving SMS messages. Typically set to true for all numbers. (optional)  (default to true)
            
            var capabilitiesVoice = true;  // bool? |  (optional) 
            
            var capabilitiesSms = true;  // bool? |  (optional) 
            
            var capabilitiesTollFree = true;  // bool? |  (optional) 
            
            var capabilitiesTenDLC = true;  // bool? |  (optional) 
            
            var capabilitiesShortCode = true;  // bool? |  (optional) 
            
            try
            {
                // List available numbers
                AvailableNumberList result = apiInstance.ListAvailableNumbers(phoneNumber, region, country, voiceEnabled, smsEnabled, capabilitiesVoice, capabilitiesSms, capabilitiesTollFree, capabilitiesTenDLC, capabilitiesShortCode);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListAvailableNumbers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAvailableNumbersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List available numbers
    ApiResponse<AvailableNumberList> response = apiInstance.ListAvailableNumbersWithHttpInfo(phoneNumber, region, country, voiceEnabled, smsEnabled, capabilitiesVoice, capabilitiesSms, capabilitiesTollFree, capabilitiesTenDLC, capabilitiesShortCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListAvailableNumbersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **phoneNumber** | **string?** | PCRE-compatible regular expression to filter against &#x60;phoneNumber&#x60; field, which is in E.164 format. | [optional]  |

| **region** | **string?** | State or province of this phone number. | [optional]  |

| **country** | **string?** | Country of this phone number. | [optional]  |

| **voiceEnabled** | **bool?** | Indicates whether the phone number can handle Calls. Typically set to true for all numbers. | [optional] [default to true] |

| **smsEnabled** | **bool?** | Indication of whether the phone number can handle sending and receiving SMS messages. Typically set to true for all numbers. | [optional] [default to true] |

| **capabilitiesVoice** | **bool?** |  | [optional]  |

| **capabilitiesSms** | **bool?** |  | [optional]  |

| **capabilitiesTollFree** | **bool?** |  | [optional]  |

| **capabilitiesTenDLC** | **bool?** |  | [optional]  |

| **capabilitiesShortCode** | **bool?** |  | [optional]  |


### Return type

[**AvailableNumberList**](AvailableNumberList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Available Numbers List |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcalllogs"></a>
# **ListCallLogs**
> LogList ListCallLogs (string callId)

List Call Logs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListCallLogsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var callId = "callId_example";  // string | String that uniquely identifies this call resource.
            
            try
            {
                // List Call Logs
                LogList result = apiInstance.ListCallLogs(callId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListCallLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCallLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Call Logs
    ApiResponse<LogList> response = apiInstance.ListCallLogsWithHttpInfo(callId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListCallLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **callId** | **string** | String that uniquely identifies this call resource. |  |


### Return type

[**LogList**](LogList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Logs for this call |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcallrecordings"></a>
# **ListCallRecordings**
> RecordingList ListCallRecordings (string callId, string? dateCreated = null)

List Call Recordings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListCallRecordingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var callId = "callId_example";  // string | String that uniquely identifies this call resource.
            
            var dateCreated = "dateCreated_example";  // string? | Only show recordings created on the specified date, in the form *YYYY-MM-DD*. (optional) 
            
            try
            {
                // List Call Recordings
                RecordingList result = apiInstance.ListCallRecordings(callId, dateCreated);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListCallRecordings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCallRecordingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Call Recordings
    ApiResponse<RecordingList> response = apiInstance.ListCallRecordingsWithHttpInfo(callId, dateCreated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListCallRecordingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **callId** | **string** | String that uniquely identifies this call resource. |  |

| **dateCreated** | **string?** | Only show recordings created on the specified date, in the form *YYYY-MM-DD*. | [optional]  |


### Return type

[**RecordingList**](RecordingList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of recordings for a call |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listcalls"></a>
# **ListCalls**
> CallList ListCalls (bool? active = null, string? to = null, string? from = null, CallStatus? status = null, string? startTime = null, string? endTime = null, string? parentCallId = null, List<string>? applicationId = null)

List Calls

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListCallsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var active = false;  // bool? | If active is set to true then all calls of the nature queued, ringing, inProgress are returned in the query. (optional)  (default to false)
            
            var to = "to_example";  // string? | Only show Calls to this phone number. (optional) 
            
            var from = "from_example";  // string? | Only show Calls from this phone number. (optional) 
            
            var status = new CallStatus?(); // CallStatus? | Only show Calls currently in this status. May be `queued`, `ringing`, `inProgress`, `canceled`, `completed`, `failed`, `busy`, or `noAnswer`. (optional) 
            
            var startTime = "startTime_example";  // string? | Only show Calls that started at or after this time, given as YYYY-MM-DD hh:mm:ss. (optional) 
            
            var endTime = "endTime_example";  // string? | Only show Calls that ended at or before this time, given as YYYY-MM- DD hh:mm:ss. (optional) 
            
            var parentCallId = "parentCallId_example";  // string? | Only show Calls spawned by the call with this ID. (optional) 
            
            var applicationId = new List<string>?(); // List<string>? | Only show calls belonging to the given applicationId. This parameter can be repeated to return calls from multiple Applications. (optional) 
            
            try
            {
                // List Calls
                CallList result = apiInstance.ListCalls(active, to, from, status, startTime, endTime, parentCallId, applicationId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListCalls: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListCallsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Calls
    ApiResponse<CallList> response = apiInstance.ListCallsWithHttpInfo(active, to, from, status, startTime, endTime, parentCallId, applicationId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListCallsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **active** | **bool?** | If active is set to true then all calls of the nature queued, ringing, inProgress are returned in the query. | [optional] [default to false] |

| **to** | **string?** | Only show Calls to this phone number. | [optional]  |

| **from** | **string?** | Only show Calls from this phone number. | [optional]  |

| **status** | [**CallStatus?**](CallStatus?.md) | Only show Calls currently in this status. May be &#x60;queued&#x60;, &#x60;ringing&#x60;, &#x60;inProgress&#x60;, &#x60;canceled&#x60;, &#x60;completed&#x60;, &#x60;failed&#x60;, &#x60;busy&#x60;, or &#x60;noAnswer&#x60;. | [optional]  |

| **startTime** | **string?** | Only show Calls that started at or after this time, given as YYYY-MM-DD hh:mm:ss. | [optional]  |

| **endTime** | **string?** | Only show Calls that ended at or before this time, given as YYYY-MM- DD hh:mm:ss. | [optional]  |

| **parentCallId** | **string?** | Only show Calls spawned by the call with this ID. | [optional]  |

| **applicationId** | [**List&lt;string&gt;?**](string.md) | Only show calls belonging to the given applicationId. This parameter can be repeated to return calls from multiple Applications. | [optional]  |


### Return type

[**CallList**](CallList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successful retrieved call list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listconferencerecordings"></a>
# **ListConferenceRecordings**
> RecordingList ListConferenceRecordings (string conferenceId, string? callId = null, string? dateCreated = null)

List Conference Recordings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListConferenceRecordingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | Show only Recordings made during the conference with this ID.
            
            var callId = "callId_example";  // string? | Show only Recordings made during the Call with this ID. (optional) 
            
            var dateCreated = "dateCreated_example";  // string? | Only show Recordings created on this date, formatted as *YYYY-MM-DD*. (optional) 
            
            try
            {
                // List Conference Recordings
                RecordingList result = apiInstance.ListConferenceRecordings(conferenceId, callId, dateCreated);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListConferenceRecordings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListConferenceRecordingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Conference Recordings
    ApiResponse<RecordingList> response = apiInstance.ListConferenceRecordingsWithHttpInfo(conferenceId, callId, dateCreated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListConferenceRecordingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **conferenceId** | **string** | Show only Recordings made during the conference with this ID. |  |

| **callId** | **string?** | Show only Recordings made during the Call with this ID. | [optional]  |

| **dateCreated** | **string?** | Only show Recordings created on this date, formatted as *YYYY-MM-DD*. | [optional]  |


### Return type

[**RecordingList**](RecordingList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Recordings |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listconferences"></a>
# **ListConferences**
> ConferenceList ListConferences (string? status = null, string? alias = null, string? dateCreated = null, string? dateUpdated = null)

List Conferences

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListConferencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var status = "status_example";  // string? | Only show conferences that currently have the specified status. Valid values: `empty`, `populated`, `inProgress`, or `terminated`. (optional) 
            
            var alias = "alias_example";  // string? | List Conferences whose alias exactly matches this string. (optional) 
            
            var dateCreated = "dateCreated_example";  // string? | Only show Conferences that were created on the specified date, in the form *YYYY-MM-DD*. (optional) 
            
            var dateUpdated = "dateUpdated_example";  // string? | Only show Conferences that were last updated on the specified date, in the form *YYYY-MM-DD*. (optional) 
            
            try
            {
                // List Conferences
                ConferenceList result = apiInstance.ListConferences(status, alias, dateCreated, dateUpdated);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListConferences: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListConferencesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Conferences
    ApiResponse<ConferenceList> response = apiInstance.ListConferencesWithHttpInfo(status, alias, dateCreated, dateUpdated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListConferencesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **status** | **string?** | Only show conferences that currently have the specified status. Valid values: &#x60;empty&#x60;, &#x60;populated&#x60;, &#x60;inProgress&#x60;, or &#x60;terminated&#x60;. | [optional]  |

| **alias** | **string?** | List Conferences whose alias exactly matches this string. | [optional]  |

| **dateCreated** | **string?** | Only show Conferences that were created on the specified date, in the form *YYYY-MM-DD*. | [optional]  |

| **dateUpdated** | **string?** | Only show Conferences that were last updated on the specified date, in the form *YYYY-MM-DD*. | [optional]  |


### Return type

[**ConferenceList**](ConferenceList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Conferences |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listincomingnumbers"></a>
# **ListIncomingNumbers**
> IncomingNumberList ListIncomingNumbers (string? phoneNumber = null, string? alias = null, string? region = null, string? country = null, string? applicationId = null, bool? hasApplication = null, bool? voiceEnabled = null, bool? smsEnabled = null, bool? hasCampaign = null, bool? capabilitiesVoice = null, bool? capabilitiesSms = null, bool? capabilitiesTollFree = null, bool? capabilitiesTenDLC = null, bool? capabilitiesShortCode = null, string? tfnCampaignId = null, bool? offnet = null)

List Incoming Numbers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListIncomingNumbersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var phoneNumber = "phoneNumber_example";  // string? | Only show incoming phone number resources that match this PCRE-compatible regular expression. (optional) 
            
            var alias = "alias_example";  // string? | Only show incoming phone numbers with aliases that exactly match this value. (optional) 
            
            var region = "region_example";  // string? | State or province of this phone number. (optional) 
            
            var country = "country_example";  // string? | Country of this phone number. (optional) 
            
            var applicationId = "applicationId_example";  // string? | ID of the Application that FreeClimb should contact if a Call or SMS arrives for this phone number or a Call from this number is placed. An incoming phone number is not useful until associated with an applicationId. (optional) 
            
            var hasApplication = false;  // bool? | Indication of whether the phone number has an application linked to it. (optional)  (default to false)
            
            var voiceEnabled = true;  // bool? | Indicates whether the phone number can handle Calls. Typically set to true for all numbers. (optional)  (default to true)
            
            var smsEnabled = true;  // bool? | Indication of whether the phone number can handle sending and receiving SMS messages. Typically set to true for all numbers. (optional)  (default to true)
            
            var hasCampaign = true;  // bool? | Indication of whether the phone number has a campaign associated with it (optional) 
            
            var capabilitiesVoice = true;  // bool? |  (optional) 
            
            var capabilitiesSms = true;  // bool? |  (optional) 
            
            var capabilitiesTollFree = true;  // bool? |  (optional) 
            
            var capabilitiesTenDLC = true;  // bool? |  (optional) 
            
            var capabilitiesShortCode = true;  // bool? |  (optional) 
            
            var tfnCampaignId = "tfnCampaignId_example";  // string? | Only show incoming phone number resources that have been assigned to the provided TFNCampaign ID. (optional) 
            
            var offnet = true;  // bool? | Indication of whether the phone number was registered as an offnet number. This field will be rendered only for requests to the IncomingPhone number resource. (optional) 
            
            try
            {
                // List Incoming Numbers
                IncomingNumberList result = apiInstance.ListIncomingNumbers(phoneNumber, alias, region, country, applicationId, hasApplication, voiceEnabled, smsEnabled, hasCampaign, capabilitiesVoice, capabilitiesSms, capabilitiesTollFree, capabilitiesTenDLC, capabilitiesShortCode, tfnCampaignId, offnet);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListIncomingNumbers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListIncomingNumbersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Incoming Numbers
    ApiResponse<IncomingNumberList> response = apiInstance.ListIncomingNumbersWithHttpInfo(phoneNumber, alias, region, country, applicationId, hasApplication, voiceEnabled, smsEnabled, hasCampaign, capabilitiesVoice, capabilitiesSms, capabilitiesTollFree, capabilitiesTenDLC, capabilitiesShortCode, tfnCampaignId, offnet);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListIncomingNumbersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **phoneNumber** | **string?** | Only show incoming phone number resources that match this PCRE-compatible regular expression. | [optional]  |

| **alias** | **string?** | Only show incoming phone numbers with aliases that exactly match this value. | [optional]  |

| **region** | **string?** | State or province of this phone number. | [optional]  |

| **country** | **string?** | Country of this phone number. | [optional]  |

| **applicationId** | **string?** | ID of the Application that FreeClimb should contact if a Call or SMS arrives for this phone number or a Call from this number is placed. An incoming phone number is not useful until associated with an applicationId. | [optional]  |

| **hasApplication** | **bool?** | Indication of whether the phone number has an application linked to it. | [optional] [default to false] |

| **voiceEnabled** | **bool?** | Indicates whether the phone number can handle Calls. Typically set to true for all numbers. | [optional] [default to true] |

| **smsEnabled** | **bool?** | Indication of whether the phone number can handle sending and receiving SMS messages. Typically set to true for all numbers. | [optional] [default to true] |

| **hasCampaign** | **bool?** | Indication of whether the phone number has a campaign associated with it | [optional]  |

| **capabilitiesVoice** | **bool?** |  | [optional]  |

| **capabilitiesSms** | **bool?** |  | [optional]  |

| **capabilitiesTollFree** | **bool?** |  | [optional]  |

| **capabilitiesTenDLC** | **bool?** |  | [optional]  |

| **capabilitiesShortCode** | **bool?** |  | [optional]  |

| **tfnCampaignId** | **string?** | Only show incoming phone number resources that have been assigned to the provided TFNCampaign ID. | [optional]  |

| **offnet** | **bool?** | Indication of whether the phone number was registered as an offnet number. This field will be rendered only for requests to the IncomingPhone number resource. | [optional]  |


### Return type

[**IncomingNumberList**](IncomingNumberList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Incoming Phone Numbers |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listmembers"></a>
# **ListMembers**
> QueueMemberList ListMembers (string queueId)

List Members

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListMembersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | String that uniquely identifies the Queue that the Member belongs to.
            
            try
            {
                // List Members
                QueueMemberList result = apiInstance.ListMembers(queueId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListMembers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListMembersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Members
    ApiResponse<QueueMemberList> response = apiInstance.ListMembersWithHttpInfo(queueId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListMembersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **queueId** | **string** | String that uniquely identifies the Queue that the Member belongs to. |  |


### Return type

[**QueueMemberList**](QueueMemberList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved queue member list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listparticipants"></a>
# **ListParticipants**
> ConferenceParticipantList ListParticipants (string conferenceId, bool? talk = null, bool? listen = null, bool? dtmfPassThrough = null)

List Participants

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListParticipantsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | ID of the conference this participant is in.
            
            var talk = true;  // bool? | Only show Participants with the talk privilege. (optional) 
            
            var listen = true;  // bool? | Only show Participants with the listen privilege. (optional) 
            
            var dtmfPassThrough = true;  // bool? | Only show Participants with the dtmfPassThrough privilege. (optional) 
            
            try
            {
                // List Participants
                ConferenceParticipantList result = apiInstance.ListParticipants(conferenceId, talk, listen, dtmfPassThrough);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListParticipants: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListParticipantsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Participants
    ApiResponse<ConferenceParticipantList> response = apiInstance.ListParticipantsWithHttpInfo(conferenceId, talk, listen, dtmfPassThrough);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListParticipantsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **conferenceId** | **string** | ID of the conference this participant is in. |  |

| **talk** | **bool?** | Only show Participants with the talk privilege. | [optional]  |

| **listen** | **bool?** | Only show Participants with the listen privilege. | [optional]  |

| **dtmfPassThrough** | **bool?** | Only show Participants with the dtmfPassThrough privilege. | [optional]  |


### Return type

[**ConferenceParticipantList**](ConferenceParticipantList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved conference participant list |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listrecordings"></a>
# **ListRecordings**
> RecordingList ListRecordings (string? callId = null, string? conferenceId = null, string? dateCreated = null)

List Recordings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListRecordingsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var callId = "callId_example";  // string? | Show only Recordings made during the Call with this ID. (optional) 
            
            var conferenceId = "conferenceId_example";  // string? | Show only Recordings made during the conference with this ID. (optional) 
            
            var dateCreated = "dateCreated_example";  // string? | Only show Recordings created on this date, formatted as *YYYY-MM-DD*. (optional) 
            
            try
            {
                // List Recordings
                RecordingList result = apiInstance.ListRecordings(callId, conferenceId, dateCreated);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListRecordings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRecordingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List Recordings
    ApiResponse<RecordingList> response = apiInstance.ListRecordingsWithHttpInfo(callId, conferenceId, dateCreated);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListRecordingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **callId** | **string?** | Show only Recordings made during the Call with this ID. | [optional]  |

| **conferenceId** | **string?** | Show only Recordings made during the conference with this ID. | [optional]  |

| **dateCreated** | **string?** | Only show Recordings created on this date, formatted as *YYYY-MM-DD*. | [optional]  |


### Return type

[**RecordingList**](RecordingList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Recordings |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listsmsmessages"></a>
# **ListSmsMessages**
> MessagesList ListSmsMessages (string? to = null, string? from = null, string? beginTime = null, string? endTime = null, MessageDirection? direction = null, string? campaignId = null, string? brandId = null, bool? is10DLC = null)

List SMS Messages

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class ListSmsMessagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var to = "to_example";  // string? | Only show Messages to this phone number. (optional) 
            
            var from = "from_example";  // string? | Only show Messages from this phone number. (optional) 
            
            var beginTime = "beginTime_example";  // string? | Only show Messages sent at or after this time (GMT), given as *YYYY-MM-DD hh:mm:ss*. (optional) 
            
            var endTime = "endTime_example";  // string? | Only show messages sent at or before this time (GMT), given as *YYYY-MM-DD hh:mm*.. (optional) 
            
            var direction = new MessageDirection?(); // MessageDirection? | Either `inbound` or `outbound`. Only show Messages that were either *sent from* or *received by* FreeClimb. (optional) 
            
            var campaignId = "campaignId_example";  // string? | Only show messages associated with this campaign ID. (optional) 
            
            var brandId = "brandId_example";  // string? | Only show messages associated with this brand ID (optional) 
            
            var is10DLC = true;  // bool? | Only show messages that were sent as part of a 10DLC campaign. (optional) 
            
            try
            {
                // List SMS Messages
                MessagesList result = apiInstance.ListSmsMessages(to, from, beginTime, endTime, direction, campaignId, brandId, is10DLC);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.ListSmsMessages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSmsMessagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List SMS Messages
    ApiResponse<MessagesList> response = apiInstance.ListSmsMessagesWithHttpInfo(to, from, beginTime, endTime, direction, campaignId, brandId, is10DLC);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.ListSmsMessagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **to** | **string?** | Only show Messages to this phone number. | [optional]  |

| **from** | **string?** | Only show Messages from this phone number. | [optional]  |

| **beginTime** | **string?** | Only show Messages sent at or after this time (GMT), given as *YYYY-MM-DD hh:mm:ss*. | [optional]  |

| **endTime** | **string?** | Only show messages sent at or before this time (GMT), given as *YYYY-MM-DD hh:mm*.. | [optional]  |

| **direction** | [**MessageDirection?**](MessageDirection?.md) | Either &#x60;inbound&#x60; or &#x60;outbound&#x60;. Only show Messages that were either *sent from* or *received by* FreeClimb. | [optional]  |

| **campaignId** | **string?** | Only show messages associated with this campaign ID. | [optional]  |

| **brandId** | **string?** | Only show messages associated with this brand ID | [optional]  |

| **is10DLC** | **bool?** | Only show messages that were sent as part of a 10DLC campaign. | [optional]  |


### Return type

[**MessagesList**](MessagesList.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of messages |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="makeacall"></a>
# **MakeACall**
> CallResult MakeACall (MakeCallRequest? makeCallRequest = null)

Make a Call

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class MakeACallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var makeCallRequest = new MakeCallRequest?(); // MakeCallRequest? | Call details for making a call (optional) 
            
            try
            {
                // Make a Call
                CallResult result = apiInstance.MakeACall(makeCallRequest);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.MakeACall: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MakeACallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Make a Call
    ApiResponse<CallResult> response = apiInstance.MakeACallWithHttpInfo(makeCallRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.MakeACallWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **makeCallRequest** | [**MakeCallRequest?**](MakeCallRequest?.md) | Call details for making a call | [optional]  |


### Return type

[**CallResult**](CallResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Call that was created |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="makeawebrtcjwt"></a>
# **MakeAWebrtcJwt**
> string MakeAWebrtcJwt (CreateWebRTCToken createWebRTCToken)

Make a JWT for WebRTC calling

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class MakeAWebrtcJwtExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var createWebRTCToken = new CreateWebRTCToken(); // CreateWebRTCToken | Information needed to craft a JWT compatible with the platforms WebRTC APIs
            
            try
            {
                // Make a JWT for WebRTC calling
                string result = apiInstance.MakeAWebrtcJwt(createWebRTCToken);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.MakeAWebrtcJwt: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MakeAWebrtcJwtWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Make a JWT for WebRTC calling
    ApiResponse<string> response = apiInstance.MakeAWebrtcJwtWithHttpInfo(createWebRTCToken);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.MakeAWebrtcJwtWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **createWebRTCToken** | [**CreateWebRTCToken**](CreateWebRTCToken.md) | Information needed to craft a JWT compatible with the platforms WebRTC APIs |  |


### Return type

**string**

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The created JWT |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="removeaparticipant"></a>
# **RemoveAParticipant**
> void RemoveAParticipant (string conferenceId, string callId)

Remove a Participant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class RemoveAParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | ID of the conference this participant is in.
            
            var callId = "callId_example";  // string | ID of the Call associated with this participant.
            
            try
            {
                // Remove a Participant
                apiInstance.RemoveAParticipant(conferenceId, callId);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.RemoveAParticipant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RemoveAParticipantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a Participant
    apiInstance.RemoveAParticipantWithHttpInfo(conferenceId, callId);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.RemoveAParticipantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **conferenceId** | **string** | ID of the conference this participant is in. |  |

| **callId** | **string** | ID of the Call associated with this participant. |  |


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successfully deleted conference participant |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="sendansmsmessage"></a>
# **SendAnSmsMessage**
> MessageResult SendAnSmsMessage (MessageRequest messageRequest)

Send an SMS Message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class SendAnSmsMessageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var messageRequest = new MessageRequest(); // MessageRequest | Details to create a message
            
            try
            {
                // Send an SMS Message
                MessageResult result = apiInstance.SendAnSmsMessage(messageRequest);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.SendAnSmsMessage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendAnSmsMessageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send an SMS Message
    ApiResponse<MessageResult> response = apiInstance.SendAnSmsMessageWithHttpInfo(messageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.SendAnSmsMessageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **messageRequest** | [**MessageRequest**](MessageRequest.md) | Details to create a message |  |


### Return type

[**MessageResult**](MessageResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | The message has been accepted. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="streamarecordingfile"></a>
# **StreamARecordingFile**
> System.IO.Stream StreamARecordingFile (string recordingId)

Stream a Recording File

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class StreamARecordingFileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var recordingId = "recordingId_example";  // string | String that uniquely identifies this recording resource.
            
            try
            {
                // Stream a Recording File
                System.IO.Stream result = apiInstance.StreamARecordingFile(recordingId);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.StreamARecordingFile: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the StreamARecordingFileWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stream a Recording File
    ApiResponse<System.IO.Stream> response = apiInstance.StreamARecordingFileWithHttpInfo(recordingId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.StreamARecordingFileWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **recordingId** | **string** | String that uniquely identifies this recording resource. |  |


### Return type

**System.IO.Stream**

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: audio/x-wav


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Streaming a Recording represented with audio/x-wav mime-type |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateaconference"></a>
# **UpdateAConference**
> void UpdateAConference (string conferenceId, UpdateConferenceRequest? updateConferenceRequest = null)

Update a Conference

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateAConferenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | String that uniquely identifies this conference resource.
            
            var updateConferenceRequest = new UpdateConferenceRequest?(); // UpdateConferenceRequest? | Conference Details to update (optional) 
            
            try
            {
                // Update a Conference
                apiInstance.UpdateAConference(conferenceId, updateConferenceRequest);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAConference: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAConferenceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Conference
    apiInstance.UpdateAConferenceWithHttpInfo(conferenceId, updateConferenceRequest);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateAConferenceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **conferenceId** | **string** | String that uniquely identifies this conference resource. |  |

| **updateConferenceRequest** | [**UpdateConferenceRequest?**](UpdateConferenceRequest?.md) | Conference Details to update | [optional]  |


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful conference details update |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatealivecall"></a>
# **UpdateALiveCall**
> void UpdateALiveCall (string callId, UpdateCallRequest updateCallRequest)

Update a Live Call

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateALiveCallExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var callId = "callId_example";  // string | String that uniquely identifies this call resource.
            
            var updateCallRequest = new UpdateCallRequest(); // UpdateCallRequest | Call details to update
            
            try
            {
                // Update a Live Call
                apiInstance.UpdateALiveCall(callId, updateCallRequest);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateALiveCall: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateALiveCallWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Live Call
    apiInstance.UpdateALiveCallWithHttpInfo(callId, updateCallRequest);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateALiveCallWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **callId** | **string** | String that uniquely identifies this call resource. |  |

| **updateCallRequest** | [**UpdateCallRequest**](UpdateCallRequest.md) | Call details to update |  |


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Successfully queued call |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateaparticipant"></a>
# **UpdateAParticipant**
> ConferenceParticipantResult UpdateAParticipant (string conferenceId, string callId, UpdateConferenceParticipantRequest? updateConferenceParticipantRequest = null)

Update a Participant

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateAParticipantExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var conferenceId = "conferenceId_example";  // string | ID of the conference this participant is in.
            
            var callId = "callId_example";  // string | ID of the Call associated with this participant.
            
            var updateConferenceParticipantRequest = new UpdateConferenceParticipantRequest?(); // UpdateConferenceParticipantRequest? | Conference participant details to update (optional) 
            
            try
            {
                // Update a Participant
                ConferenceParticipantResult result = apiInstance.UpdateAParticipant(conferenceId, callId, updateConferenceParticipantRequest);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAParticipant: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAParticipantWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Participant
    ApiResponse<ConferenceParticipantResult> response = apiInstance.UpdateAParticipantWithHttpInfo(conferenceId, callId, updateConferenceParticipantRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateAParticipantWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **conferenceId** | **string** | ID of the conference this participant is in. |  |

| **callId** | **string** | ID of the Call associated with this participant. |  |

| **updateConferenceParticipantRequest** | [**UpdateConferenceParticipantRequest?**](UpdateConferenceParticipantRequest?.md) | Conference participant details to update | [optional]  |


### Return type

[**ConferenceParticipantResult**](ConferenceParticipantResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully retrieved conference participant |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateaqueue"></a>
# **UpdateAQueue**
> QueueResult UpdateAQueue (string queueId, QueueRequest? queueRequest = null)

Update a Queue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateAQueueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var queueId = "queueId_example";  // string | A string that uniquely identifies this Queue resource.
            
            var queueRequest = new QueueRequest?(); // QueueRequest? | Queue Details to update (optional) 
            
            try
            {
                // Update a Queue
                QueueResult result = apiInstance.UpdateAQueue(queueId, queueRequest);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAQueue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAQueueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a Queue
    ApiResponse<QueueResult> response = apiInstance.UpdateAQueueWithHttpInfo(queueId, queueRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateAQueueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **queueId** | **string** | A string that uniquely identifies this Queue resource. |  |

| **queueRequest** | [**QueueRequest?**](QueueRequest?.md) | Queue Details to update | [optional]  |


### Return type

[**QueueResult**](QueueResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Successfully updated queue |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateanaccount"></a>
# **UpdateAnAccount**
> void UpdateAnAccount (AccountRequest? accountRequest = null)

Manage an account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateAnAccountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var accountRequest = new AccountRequest?(); // AccountRequest? | Account details to update (optional) 
            
            try
            {
                // Manage an account
                apiInstance.UpdateAnAccount(accountRequest);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAnAccount: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAnAccountWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Manage an account
    apiInstance.UpdateAnAccountWithHttpInfo(accountRequest);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateAnAccountWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **accountRequest** | [**AccountRequest?**](AccountRequest?.md) | Account details to update | [optional]  |


### Return type

void (empty response body)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Successful Account update |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateanapplication"></a>
# **UpdateAnApplication**
> ApplicationResult UpdateAnApplication (string applicationId, ApplicationRequest? applicationRequest = null)

Update an application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateAnApplicationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var applicationId = "applicationId_example";  // string | A string that uniquely identifies this application resource.
            
            var applicationRequest = new ApplicationRequest?(); // ApplicationRequest? | Application details to update. (optional) 
            
            try
            {
                // Update an application
                ApplicationResult result = apiInstance.UpdateAnApplication(applicationId, applicationRequest);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAnApplication: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAnApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an application
    ApiResponse<ApplicationResult> response = apiInstance.UpdateAnApplicationWithHttpInfo(applicationId, applicationRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateAnApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **applicationId** | **string** | A string that uniquely identifies this application resource. |  |

| **applicationRequest** | [**ApplicationRequest?**](ApplicationRequest?.md) | Application details to update. | [optional]  |


### Return type

[**ApplicationResult**](ApplicationResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update Application |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateanincomingnumber"></a>
# **UpdateAnIncomingNumber**
> IncomingNumberResult UpdateAnIncomingNumber (string phoneNumberId, IncomingNumberRequest? incomingNumberRequest = null)

Update an Incoming Number

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using freeclimb.Api;
using freeclimb.Client;
using freeclimb.Model;

namespace Example
{
    public class UpdateAnIncomingNumberExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.freeclimb.com/apiserver";
            // Configure HTTP basic authorization: fc
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";

            var apiInstance = new DefaultApi(config);
            
            var phoneNumberId = "phoneNumberId_example";  // string | String that uniquely identifies this phone number resource.
            
            var incomingNumberRequest = new IncomingNumberRequest?(); // IncomingNumberRequest? | Incoming Number details to update (optional) 
            
            try
            {
                // Update an Incoming Number
                IncomingNumberResult result = apiInstance.UpdateAnIncomingNumber(phoneNumberId, incomingNumberRequest);
                Debug.WriteLine(result);                
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.UpdateAnIncomingNumber: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAnIncomingNumberWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update an Incoming Number
    ApiResponse<IncomingNumberResult> response = apiInstance.UpdateAnIncomingNumberWithHttpInfo(phoneNumberId, incomingNumberRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);    
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultApi.UpdateAnIncomingNumberWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|


| **phoneNumberId** | **string** | String that uniquely identifies this phone number resource. |  |

| **incomingNumberRequest** | [**IncomingNumberRequest?**](IncomingNumberRequest?.md) | Incoming Number details to update | [optional]  |


### Return type

[**IncomingNumberResult**](IncomingNumberResult.md)

### Authorization

[fc](../README.md#fc)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Updated Incoming Phone Number |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

