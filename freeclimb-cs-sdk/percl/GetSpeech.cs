using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using com.freeclimb.api;

namespace com.freeclimb.percl
{
    /// <summary>
    /// GetSpeech PerCL command.
    /// </summary>
    [JsonObject]
    public class GetSpeech : PerCLCommand
    {
        [JsonProperty(PropertyName = "actionUrl")]
        private string actionUrl = string.Empty;

        [JsonProperty(PropertyName = "grammarType")]
        private EGrammarType grammarType = EGrammarType.NONE;

        [JsonProperty(PropertyName = "grammarFile")]
        private string grammarFile = string.Empty;

        [JsonProperty(PropertyName = "grammarRule")]
        private string grammarRule = string.Empty;

        [JsonProperty(PropertyName = "playBeep")]
        private EBool playBeep = EBool.NONE;

        [JsonProperty(PropertyName = "noInputTimeoutMs")]
        private int noInputTimeoutMs = int.MinValue;

        [JsonProperty(PropertyName = "recognitionTimeoutMs")]
        private int recognitionTimeoutMs = int.MinValue;

        [JsonProperty(PropertyName = "confidenceThreshold")]
        private float confidenceThreshold = float.MinValue;

        [JsonProperty(PropertyName = "nBestListLength")]
        private int nBestListLength = int.MinValue;

        [JsonProperty(PropertyName = "sensitivityLevel")]
        private float sensitivityLevel = float.MinValue;

        [JsonProperty(PropertyName = "speechCompleteTimeoutMs")]
        private int speechCompleteTimeoutMs = int.MinValue;

        [JsonProperty(PropertyName = "speechIncompleteTimeoutMs")]
        private int speechIncompleteTimeoutMs = int.MinValue;

        [JsonProperty(PropertyName = "prompts")]
        private List<IGetSpeechNestable> prompts = new List<IGetSpeechNestable>();

        /// <summary>
        /// Helper method to build a JSON string from a GetSpeech instance.
        /// </summary>
        /// <returns>A JSON string equivalent to the GetSpeech instance.</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public override string toJson()
        {
            try
            {
                JsonSerializer jsonSerializer = JsonSerializer.Create();
                jsonSerializer.NullValueHandling = NullValueHandling.Ignore;

                StringBuilder strb = new StringBuilder();
                jsonSerializer.Serialize(new StringWriter(strb), toKvp());

                return strb.ToString();
            }
            catch (Exception e)
            {
                throw new FreeClimbJSONException(e.Message);
            }
        }

        /// <summary>
        /// Retrieve the grammarType value.
        /// </summary>
        /// <returns>The grammarType value of the object.</returns>
        /// <see cref="EGrammarType">GrammarType enumeration.</see>
        public EGrammarType getGrammarType { get { return this.grammarType; } }

        /// <summary>
        /// Set the grammarType value.
        /// </summary>
        /// <param name="val">grammarType value.</param>
        /// <see cref="EGrammarType">GrammarType enumeration.</see>
        public void setGrammarType(EGrammarType val) { this.grammarType = val; }

        /// <summary>
        /// Retrieve the grammarRule value.
        /// </summary>
        /// <returns>The grammarRule value of the object.</returns>
        public string getGrammarRule { get { return this.grammarRule; } }

        /// <summary>
        /// Set the grammarRule value.
        /// </summary>
        /// <param name="val">grammarRule value.</param>
        public void setGrammarRule(string val) { this.grammarRule = val; }

        /// <summary>
        /// Retrieve the grammarFile value.
        /// </summary>
        /// <returns>The grammarFile value of the object.</returns>
        public string getGrammarFile { get { return this.grammarFile; } }

        /// <summary>
        /// Set the grammarFile value.
        /// </summary>
        /// <param name="val">grammarFile value.</param>
        public void setGrammarFile(string val) { this.grammarFile = val; }

        /// <summary>
        /// Retrieve the playBeep value.
        /// </summary>
        /// <returns>The playBeep value of the object.</returns>
        /// <see cref="EBool">Bool enumeration.</see>
        public EBool getPlayBeep { get { return this.playBeep; } }

        /// <summary>
        /// Set the playBeep value.
        /// </summary>
        /// <param name="val">playBeep value.</param>
        /// <see cref="EBool">Bool enumeration.</see>
        public void setPlayBeep(EBool val) { this.playBeep = val; }

        /// <summary>
        /// Retrieve the noInputTimeoutMs value.
        /// </summary>
        /// <returns>The noInputTimeoutMs value of the object.</returns>
        public int getNoInputTimeoutMs { get { return this.noInputTimeoutMs; } }

        /// <summary>
        /// Set the noInputTimeoutMs value.
        /// </summary>
        /// <param name="val">noInputTimeoutMs value.</param>
        public void setNoInputTimeoutMs(int val) { this.noInputTimeoutMs = val; }

        /// <summary>
        /// Retrieve the recognitionTimeoutMs value.
        /// </summary>
        /// <returns>The recognitionTimeoutMs value of the object.</returns>
        public int getRecognitionTimeoutMs { get { return this.recognitionTimeoutMs; } }

        /// <summary>
        /// Set the recognitionTimeoutMs value.
        /// </summary>
        /// <param name="val">recognitionTimeoutMs value.</param>
        public void setRecognitionTimeoutMs(int val) { this.recognitionTimeoutMs = val; }

        /// <summary>
        /// Retrieve the actionUrl value.
        /// </summary>
        /// <returns>The actionUrl value of the object.</returns>
        public string getActionUrl { get { return this.actionUrl; } }

        /// <summary>
        /// Set the actionUrl value.
        /// </summary>
        /// <param name="val">actionUrl value.</param>
        public void setActionUrl(string val) { this.actionUrl = val; }

        /// <summary>
        /// Retrieve the confidenceThreshold value.
        /// </summary>
        /// <returns>The confidenceThreshold value of the object.</returns>
        public float getConfidenceThreshold { get { return this.confidenceThreshold; } }

        /// <summary>
        /// Set the confidenceThreshold value.
        /// </summary>
        /// <param name="val">confidenceThreshold value.</param>
        public void setConfidenceThreshold(float val) { this.confidenceThreshold = val; }

        /// <summary>
        /// Retrieve the sensitivityLevel value.
        /// </summary>
        /// <returns>The sensitivityLevel value of the object.</returns>
        public float getSensitivityLevel { get { return this.sensitivityLevel; } }

        /// <summary>
        /// Set the sensitivityLevel value.
        /// </summary>
        /// <param name="val">sensitivityLevel value.</param>
        public void setSensitivityLevel(float val) { this.sensitivityLevel = val; }

        /// <summary>
        /// Retrieve the nBestListLength value.
        /// </summary>
        /// <returns>The nBestListLength value of the object.</returns>
        public int getNBestListLength { get { return this.nBestListLength; } }

        /// <summary>
        /// Set the nBestListLength value.
        /// </summary>
        /// <param name="val">nBestListLength value.</param>
        public void setNBestListLength(int val) { this.nBestListLength = val; }

        /// <summary>
        /// Retrieve the speechCompleteTimeoutMs value.
        /// </summary>
        /// <returns>The speechCompleteTimeoutMs value of the object.</returns>
        public int getSpeechCompleteTimeoutMs { get { return this.speechCompleteTimeoutMs; } }

        /// <summary>
        /// Set the speechCompleteTimeoutMs value.
        /// </summary>
        /// <param name="val">speechCompleteTimeoutMs value.</param>
        public void setSpeechCompleteTimeoutMs(int val) { this.speechCompleteTimeoutMs = val; }

        /// <summary>
        /// Retrieve the speechIncompleteTimeoutMs value.
        /// </summary>
        /// <returns>The speechIncompleteTimeoutMs value of the object.</returns>
        public int getSpeechIncompleteTimeoutMs { get { return this.speechIncompleteTimeoutMs; } }

        /// <summary>
        /// Set the speechIncompleteTimeoutMs value.
        /// </summary>
        /// <param name="val">speechIncompleteTimeoutMs value.</param>
        public void setSpeechIncompleteTimeoutMs(int val) { this.speechIncompleteTimeoutMs = val; }

        /// <summary>
        /// Retrieve the IGetSpeechNestable list reference.
        /// </summary>
        /// <returns>The IGetSpeechNestable list reference of object.</returns>
        public List<IGetSpeechNestable> getPrompts { get { return this.prompts.ToList<IGetSpeechNestable>(); } }

        /// <summary>
        /// Adds the IGetSpeechNestable to end of instance list.
        /// </summary>
        /// <param name="val">IGetSpeechNestable value.</param>
        public void setPrompts(IGetSpeechNestable val) { this.prompts.Add(val); }

        /// <summary>
        /// Creates GetSpeech PerCL with require fields. 
        /// </summary>
        /// <param name="actionUrl">Url to retrieve actions.</param>
        /// <param name="grammarFile">Grammar file.</param>
        public GetSpeech(string actionUrl, string grammarFile)
        {
            this.actionUrl = actionUrl;
            this.grammarFile = grammarFile;
        }

        /// <summary>
        /// Retrieve the KVP Dictionary for the GetSpeech instance. 
        /// </summary>
        /// <returns>KVP Dictionary</returns>
        /// <exception cref="FreeClimbJSONException">Thrown upon deserialize failure.</exception>
        public override IDictionary<string, object> toKvp()
        {
            // change all properties with settings to a dictionary
            IDictionary<string, object> props = new Dictionary<string, object>();

            if (this.actionUrl == string.Empty)
            {
                throw new FreeClimbJSONException("actionUrl is a required parameter");
            }

            props.Add("actionUrl", this.actionUrl);

            if (this.grammarFile == string.Empty)
            {
                throw new FreeClimbJSONException("grammarFile is a required parameter");
            }

            props.Add("grammarFile", this.grammarFile);

            if (this.grammarRule != string.Empty)
            {
                props.Add("grammarRule", this.grammarRule);
            }

            if (getGrammarType != EGrammarType.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getGrammarType);
                props.Add("grammarType", attr.Value);
            }

            if (getPlayBeep != EBool.NONE)
            {
                EnumMemberAttribute attr = EnumHelper.GetAttributeOfType<EnumMemberAttribute>(getPlayBeep);
                props.Add("playBeep", bool.Parse(attr.Value));
            }

            if (this.confidenceThreshold != float.MinValue)
            {
                props.Add("confidenceThreshold", this.confidenceThreshold);
            }

            if (this.sensitivityLevel != float.MinValue)
            {
                props.Add("sensitivityLevel", this.sensitivityLevel);
            }

            if (this.noInputTimeoutMs != int.MinValue)
            {
                props.Add("noInputTimeoutMs", this.noInputTimeoutMs);
            }

            if (this.recognitionTimeoutMs != int.MinValue)
            {
                props.Add("recognitionTimeoutMs", this.recognitionTimeoutMs);
            }

            if (this.speechCompleteTimeoutMs != int.MinValue)
            {
                props.Add("speechCompleteTimeoutMs", this.speechCompleteTimeoutMs);
            }

            if (this.speechIncompleteTimeoutMs != int.MinValue)
            {
                props.Add("speechIncompleteTimeoutMs", this.speechIncompleteTimeoutMs);
            }

            if (this.nBestListLength != int.MinValue)
            {
                props.Add("nBestListLength", this.nBestListLength);
            }

            List<object> promptList = new List<object>();
            foreach (PerCLCommand promptCommand in prompts.ToList<IGetSpeechNestable>())
            {
                promptList.Add(promptCommand.toKvp());
            }
            props.Add("prompts", promptList);

            IDictionary<string, object> command = new Dictionary<string, object>();
            command.Add("GetSpeech", props);

            return command;
        }
    }
}
