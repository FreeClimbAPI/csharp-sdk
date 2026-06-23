# freeclimb.Model.TTSEngine

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **TTSEngineName** |  | [optional] 
**Parameters** | **Dictionary&lt;string, Object&gt;** | Parameters for the TTS engine. The parameters are specific to the engine and are documented in the engine&#39;s documentation. | [optional] 


## Example

```csharp
using Newtonsoft.Json;
using freeclimb.Model;

string json = "{\"name\":\"freeclimb.standard\"}";

// create an instance of TTSEngine from a JSON string
TTSEngine tTSEngine = JsonConvert.DeserializeObject<TTSEngine>(json);
```
[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

