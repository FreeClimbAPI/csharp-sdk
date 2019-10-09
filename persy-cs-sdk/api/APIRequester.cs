using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Web;

namespace com.persephony.api
{
    /// <summary>
    /// The APIRequester is the base class for various *Requestor classes which
    /// each wrap a portion of the Persephony API. This class abstracts away the
    /// messiness that can be directly interacting with the API over HTTP to reduce
    /// code duplication in these child Requesters and ease their development.
    /// </summary> 
    public class APIRequester
    {
        /// <summary>
        /// The URL of the Persephony API 
        /// </summary> 
        protected static string PERSY_URL = "https://www.persephony.com/apiserver";

        private string credAccountId;
        private string credAuthToken;
        private string persyUrl;

        /// <summary>
        /// Create a new APIRequester.
        /// </summary>
        /// <param name="credAccountId">The accountId to use to authenticate requests.</param>
        /// <param name="credAuthToken">The authToken to use to authenticate requests.</param>
        protected APIRequester(string credAccountId, string credAuthToken)
        { 
		    this.credAccountId = credAccountId;
		    this.credAuthToken = credAuthToken;
		    this.persyUrl = APIRequester.PERSY_URL;
        }

        /// <summary>
        /// Retrieve  accountId object value.
        /// </summary>
        /// <returns>The accountId being used for authentication.</returns>
        protected string getAccountId { get { return this.credAccountId; } }

        /// <summary>
        /// Retrieve  authToken object value.
        /// </summary>
        /// <returns>The authToken being used for authentication.</returns>
        protected string getAuthToken { get { return this.credAuthToken; } }

        /// <summary>
        /// Retrieve  Persephony API Url object value.
        /// </summary>
        /// <returns>The url being used for the Persephony API.</returns>
        public string getPersyUrl { get { return this.persyUrl; } }

        /// <summary>
        /// Allows SDK developers to change which instance of the Persephony API that the APIRequester points to.
        /// </summary>
        /// <param name="newUrl">The new URL to use in place of the default APIRequester.PERSY_URL.</param>
        protected void setPersyUrl(string newUrl) { this.persyUrl = newUrl; }

        /// <summary>
        /// Make an HTTP GET request to the Persephony API
        /// </summary>
        /// <param name="path">The URI path to make a request to. This path may also contain GET query parameters.</param>
	    /// <returns>A string containing the HTTP response body of the request.</returns>
        /// <exception cref="PersyException">Thrown upon failed request.</exception>
        protected string GET(string path)
        {
            return this.GET(path, null);
        }

        /// <summary>
        ///	Make an HTTP GET request to the Persephony API
        /// </summary>
        /// <param name="path">The URI path to make a request to. This path may also contain GET query parameters.</param>
        /// <param name="query">A Dictionary to use to build the GET query string.</param>
	    /// <returns>A string containing the HTTP response body of the request.</returns>
        /// <exception cref="PersyException">Thrown upon failed request.</exception>
        protected string GET(string path, IDictionary<string, string> query)
        {
            HttpWebRequest request = createRequest("GET", path, query);
            return readResponse(request);
        }

        /// <summary>
        /// Make an HTTP GET request to the Persephony API.
        /// </summary>
        /// <param name="path">The URI path to make a request to. This path may also contain GET query parameters.</param>
        /// <returns>Raw Stream to read the response body from the request.</returns>
        /// <exception cref="PersyException">Thrown upon failed request.</exception>
        protected Stream GETStream(string path)
        {
            return this.GETStream(path, null);
        }

        /// <summary>
        ///	Make an HTTP GET request to the Persephony API
        /// </summary>
        /// <param name="path">The URI path to make a request to. This path may also contain GET query parameters.</param>
        /// <param name="query">A Dictionary to use to build the GET query string.</param>
        /// <returns>Raw Stream to read the response body from the request.</returns>
        /// <exception cref="PersyException">Thrown upon failed request.</exception>
        protected Stream GETStream(string path, IDictionary<string, string> query)
        {
            HttpWebRequest request = createRequest("GET", path, query);
            return returnResponseStream(request);
        }

        /// <summary>
        ///	Make a HTTP POST request to the Persephony API.
        /// </summary>
        /// <param name="path">The URI path to make a request to. This path may also contain GET query parameters.</param>
        /// <param name="payload">The JSON payload to send in the body of the request.</param>
        /// <returns>A string containing the HTTP response body of the request.</returns>
        /// <exception cref="PersyException">Thrown upon failed request.</exception>
        protected string POST(string path, String payload)
        {
            HttpWebRequest request = createRequest("POST", path);
            sendPayload(request, payload);
            return readResponse(request);
        }

        /// <summary>
        ///	Make a HTTP DELETE request to the Persephony API.
        /// </summary>
        /// <param name="path">The URI path to make a request to.</param>
        /// <exception cref="PersyException">Thrown upon failed request.</exception>
        protected void DELETE(string path)
        {
            readResponse(createRequest("DELETE", path));
        }

        /// <summary>
        ///	Converts a HashMap into a HTTP GET query string to append to a URL. 
        /// </summary>
        /// <param name="query">A Dictionary to use to build the GET query string.</param>
        private string toQueryString(IDictionary<String, String> query) 
        {
            StringBuilder pathAndQuery = new StringBuilder();
            if (query != null)
            {
                foreach (KeyValuePair<string, string> entry in query)
                {
                    if (pathAndQuery.Length > 0)
                    {
                        pathAndQuery.Append("&");
                    }

                    pathAndQuery.Append(HttpUtility.UrlEncode((entry.Key).Replace(" ", "-SpAcE-")).Replace("-SpAcE-", "%20"));
                    pathAndQuery.Append("=");
                    pathAndQuery.Append(HttpUtility.UrlEncode((entry.Value).Replace(" ", "-SpAcE-")).Replace("-SpAcE-", "%20"));
                }

                return String.Format("?{0}",pathAndQuery.ToString());
            }

            return string.Empty;
        }

        /// <summary>
        ///	Send the provided payload in the body of an instantiated HTTP request.
        /// </summary>
        /// <param name="request">An existing HTTP request through APIRequester.establishConneciton().</param>
        /// <param name="payload">The payload to send in the body of the request.</param>
        /// <exception cref="PersyConnectionException">Thrown upon failed requesr.</exception>
        private void sendPayload(HttpWebRequest request, string payload) 
        {
            if (payload == null) { return; }
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    request.ContentType = "application/json; charset = utf-8";
                    streamWriter.Write(payload);
                    streamWriter.Flush();
                }
            }
		    catch (Exception e)
            {
                throw new PersyConnectionException(String.Format("Could not send request to Persephony API: {0}", e.Message));
            }
        }

        /// <summary>
        ///	Instantiated HTTP request.
        /// </summary>
        /// <param name="method">HTTP request method.</param>
        /// <param name="path">Base Uri path.</param>
        /// <param name="query">A Dictionary to use to build query string.</param>
        /// <exception cref="PersySDKException">Thrown upon failed Uri creation.</exception>
        /// <exception cref="PersyConnectionException">Thrown upon failed HTTP request creation.</exception>
        private HttpWebRequest createRequest(string method, string path, IDictionary<string, string> query = null)
        {
            Uri uri;
		    try 
            {
                if ((query != null) &&
                    (query.Count > 0))
                {
                    uri = new Uri(this.persyUrl + path + toQueryString(query));
                }
                else
                {
                    uri = new Uri(this.persyUrl + path);
                }
            }
		    catch (Exception e)
            {
                throw new PersySDKException(String.Format("Could not understand builtin Persephony URL and path:{0}",e.Message));
            }

            HttpWebRequest request;
            try
            {
                request = WebRequest.Create(uri) as HttpWebRequest;
                request.Method = method;
                request.ServicePoint.Expect100Continue = false;
                request.Headers.Add("Authorization",
                                    String.Format("Basic {0}", Convert.ToBase64String(Encoding.UTF8.GetBytes(String.Format("{0}:{1}", credAccountId, credAuthToken)))));
            }
            catch (Exception e)
            {
                throw new PersyConnectionException(String.Format("Could not initiate connection to Persephony API servers:{0}", e.Message));
            }

            return request;
        }

        /// <summary>
        ///	Read the response to a HTTP request.
        /// </summary>
        /// <param name="request">HTTP requestion.</param>
        /// <returns>String containing the response body of the request.</returns>
        /// <exception cref="PersyConnectionException">Thrown upon connection failure.</exception>
        /// <exception cref="PersyErrorResponseException">Thrown upon unsuccessful HTTP request.</exception>
        private string readResponse(HttpWebRequest request)
        {
            HttpWebResponse response;

            try
            {
                response = request.GetResponse() as HttpWebResponse;
            }
            catch (WebException e)
            {
                response = e.Response as HttpWebResponse;
            }
            catch (Exception e)
            {
                throw new PersyConnectionException(String.Format("Could not read response from Persephony API: {0}", e.Message));
            }

            if ((response != null) &&
                ((int)response.StatusCode >= 200) &&
                ((int)response.StatusCode < 300))
            {
                try
                {
                    using (StreamReader streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        return streamReader.ReadToEnd();
                    }
                }
                catch (Exception e)
                {
                    throw new PersyConnectionException(String.Format("Could not read response from Persephony API: {0}",e.Message));
                }
            }
            else
            {
                PersyError error = new PersyError(500, "No response could be retrieved from Persephony", -1, String.Empty);
                if (response != null)
                {
                    error = new PersyError((int)response.StatusCode, response.StatusDescription ?? response.StatusCode.ToString("G"), -1, String.Empty);
                }
                throw new PersyErrorResponseException(error);
            }
        }

        /// <summary>
        ///	Read the response to a HTTP request.
        /// </summary>
        /// <param name="request">Returns the raw InputStream from the HTTP connection primarily for use with downloading and streaming Recordings.</param>
        /// <returns>Stream representing the response body from the HTTP request.</returns>
        /// <exception cref="PersyConnectionException">Thrown upon connection failure.</exception>
        /// <exception cref="PersyErrorResponseException">Thrown upon unsuccessful HTTP request.</exception>
        private Stream returnResponseStream(HttpWebRequest request)
        {
            HttpWebResponse response;

            try
            {
                response = request.GetResponse() as HttpWebResponse;
            }
            catch (WebException e)
            {
                response = e.Response as HttpWebResponse;
            }
            catch (Exception e)
            {
                throw new PersyConnectionException(String.Format("Could not read response from Persephony API: {0}", e.Message));
            }

            if (((int)response.StatusCode >= 200) &&
                 ((int)response.StatusCode < 300))
            {
                try
                {
                    return response.GetResponseStream();
                }
                catch (Exception e)
                {
                    throw new PersyConnectionException(String.Format("Could not read response from Persephony API: {0}", e.Message));
                }
            }
            else
            {
                throw new PersyErrorResponseException((int)response.StatusCode, response.StatusDescription ?? response.StatusCode.ToString("G"), -1, string.Empty);
            }
        }        
    }
}
