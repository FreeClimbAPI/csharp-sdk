## Introduction
The FreeClimb C# SDK will allow you to easily use the FreeClimb API in a C# application.


## Testing your Installation
Test the SDK is working by sending yourself a text message.

```C#
using com.freeclimb;
using com.freeclimb.api;
using com.freeclimb.api.message;
...

FreeClimbClient client = new FreeClimbClient("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "your_auth_token");
// Numbers must follow the E.164 formatting standard for phone numbers
// An example US number in E.164 would be: +1Area_CodePhoneNumber
// So the US number 202-555-0175 in E.164 formating would be +12025550175
string to = "your_phone_number";
string from = "a_freeclimb_phone_number_in_your_account";
Message message = client.getMessagesRequester.create(from, to, "Hello from C#");
```

When you run this code you should get a text message. This indicates that you've successfully setup your SDK.

## Documentation
The [FreeClimb documentation ](https://docs.freeclimb.com/docs) has guides on [getting started](https://docs.freeclimb.com/docs/getting-started-with-freeclimb) with FreeClimb, as well as the [API reference](https://docs.freeclimb.com/reference/using-the-api) and [PerCL reference](https://docs.freeclimb.com/reference/percl-overview).

The C# SDK uses standard [XML Documentation Comments](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments).
[Docfx](https://dotnet.github.io/docfx/index.html) consumes these comments and generates a static documentation site.
To build the documentation, install docfx and run `docfx docs/docfx.json --serve`.

## Getting Help
If you are experiencing difficulties, contact our support team at [support@freeclimb.com](mailto:support@freeclimb.com).
