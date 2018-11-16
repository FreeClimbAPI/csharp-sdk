## Introduction
The Persephony C# SDK will allow you to easily use the Persephony API in a C# application.


## Testing your Installation
Test the SDK is working by sending yourself a phone call.

```C#
using com.persephony;
using com.persephony.api;
using com.persephony.api.call;
...

PersyClient client = new PersyClient("ACXXXXXXXXXXXXXXXXXXXXXXXXXXXXX", "your_auth_token");
string to = "your_phone_number";
string from = "a_persephony_phone_number_in_your_account";
// the last (null) parameter is a URL that is called with status on your call (like when it ends). Not used in this example
Call call = client.getCallsRequester.create(to, from, "https://www.persephony.com/testApp/voice", null);

```

When you run this code you should get a phone call. On answering the call, you should hear a short message ("Thanks for using Persephony!"). This indicates that you've successfully setup your SDK.

`https://www.persephony.com/testApp/voice` contains a small Persephony application. When a request is made to its `/voice` endpoint, it will respond with the following PerCL script, which produces the message you heard.

```json
[{"Say": {"text": "Thanks for using Persephony!"}}]
```

## Documentation
The [Persephony documentation ](https://www.persephony.com/docs) has guides on [getting started](https://www.persephony.com/docs/getting-started) with Persephony, as well as the [API reference](https://www.persephony.com/docs/api), [PerCL reference](https://www.persephony.com/docs/percl), and several useful [tutorials.](https://www.persephony.com/docs/tutorials)/.

The C# SDK uses standard [XML Documentation Comments](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/xmldoc/xml-documentation-comments).
[Docfx](https://dotnet.github.io/docfx/index.html) consumes these comments and generates a static documentation site.
To build the documentation, install docfx and run `docfx docs/docfx.json --serve`.

## Getting Help
If you are experiencing difficulties, contact our support team at [support@persephony.com](mailto:support@persephony.com).
