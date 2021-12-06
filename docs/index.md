## Introduction
The FreeClimb C# SDK will allow you to easily use the FreeClimb API in a C# application.

## SDK Installation
Download and uncompress. You can open the solution file in Visual Studio.


## Testing your Installation
Test the SDK is working by sending yourself a phone call.

```C#
using com.freeclimb;
using com.freeclimb.api;
using com.freeclimb.api.call;
...

FreeClimbClient client = new FreeClimbClient("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "your_api_key");
string to = "your_phone_number";
string from = "a_freeclimb_phone_number_in_your_account";
// the last (null) parameter is a URL that is called with status on your call (like when it ends). Not used in this example
Call call = client.getCallsRequester.create(to, from, "https://www.freeclimb.com/testApp/voice", null);

```

When you run this code you should get a phone call. On answering the call, you should hear a short message ("Thanks for using FreeClimb!"). This indicates that you've successfully setup your SDK.

`https://www.freeclimb.com/testApp/voice` contains a small FreeClimb application. When a request is made to its `/voice` endpoint, it will respond with the following PerCL script, which produces the message you heard.

```json
[{"Say": {"text": "Thanks for using FreeClimb!"}}]
```

## Documentation
The [FreeClimb documentation ](http://docs.freeclimb.com/docs) has guides on [getting started](http://docs.freeclimb.com/docs/getting-started-with-freeclimb) with FreeClimb, as well as the [API reference](http://docs.freeclimb.com/reference/using-the-api) and [PerCL reference](http://docs.freeclimb.com/reference/percl-overview).

The C# SDK uses standard [XML Documentation Comments](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments).
[Docfx](https://dotnet.github.io/docfx/index.html) consumes these comments and generates a static documentation site.
To build the documentation, install docfx and run `docfx docs/docfx.json --serve`.

## Getting Help
If you are experiencing difficulties, contact our support team at [support@freeclimb.com](mailto:support@freeclimb.com).
