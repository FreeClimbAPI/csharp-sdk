using com.persephony.api;
using System;
using System.Collections.Generic;

namespace persy_cs_sdk_test
{
    public class TestRequester : APIRequester
    {
        public TestRequester(String accountId, String authToken) : base(accountId, authToken)
        { }

        public new string getAccountId { get { return base.getAccountId; } }
        public new string getAuthToken { get { return base.getAuthToken; } }
        public new string getPersyUrl { get { return base.getPersyUrl; } }
        public new void setPersyUrl(string newUrl) { base.setPersyUrl(newUrl); } 
        public new string GET(string path) { return base.GET(path); }
        public new string GET(string path, IDictionary<string, string> query) { return base.GET(path,query); }
        public new string POST(string path, string payload) { return base.POST(path, payload); }
        public new void DELETE(string path) { base.DELETE(path); }
    }
}
