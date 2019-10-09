## Introduction
The Persephony C# SDK will allow you to easily use the Persephony API in a C# application.


## Testing your Installation
Test the SDK is working by sending yourself a text message.

```C#
using com.persephony;
using com.persephony.api;
using com.persephony.api.message;
...

PersyClient client = new PersyClient("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "your_auth_token");
// Numbers must follow the E.164 formatting standard for phone numbers
// An example US number in E.164 would be: +1Area_CodePhoneNumber
// So the US number 202-555-0175 in E.164 formating would be +12025550175
string to = "your_phone_number";
string from = "a_persephony_phone_number_in_your_account";
Message message = client.getMessagesRequester.create(from, to, "Hello from C#");
```

When you run this code you should get a text message. This indicates that you've successfully setup your SDK.

## Documentation
The [Persephony documentation ](https://www.persephony.com/docs) has guides on [getting started](https://www.persephony.com/docs/getting-started) with Persephony, as well as the [API reference](https://www.persephony.com/docs/api), [PerCL reference](https://www.persephony.com/docs/percl), and several useful [tutorials.](https://www.persephony.com/docs/tutorials)/.

The C# SDK uses standard [XML Documentation Comments](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments).
[Docfx](https://dotnet.github.io/docfx/index.html) consumes these comments and generates a static documentation site.
To build the documentation, install docfx and run `docfx docs/docfx.json --serve`.

## Getting Help
If you are experiencing difficulties, contact our support team at [support@persephony.com](mailto:support@persephony.com).
