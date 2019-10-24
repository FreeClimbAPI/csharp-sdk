using com.freeclimb.api;
using System;
using System.Collections.Generic;

namespace freeclimb_cs_sdk_test
{
    public class TestRequester : APIRequester
    {
        public TestRequester(String accountId, String authToken) : base(accountId, authToken)
        { }

        public new string getAccountId { get { return base.getAccountId; } }
        public new string getAuthToken { get { return base.getAuthToken; } }
        public new string getfreeClimbUrl { get { return base.GetFreeClimbUrl; } }
        public new void setfreeClimbUrl(string newUrl) { base.SetFreeClimbUrl(newUrl); } 
        public new string GET(string path) { return base.GET(path); }
        public new string GET(string path, IDictionary<string, string> query) { return base.GET(path,query); }
        public new string POST(string path, string payload) { return base.POST(path, payload); }
        public new void DELETE(string path) { base.DELETE(path); }
    }
}
