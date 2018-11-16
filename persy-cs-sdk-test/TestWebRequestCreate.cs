using System;
using System.IO;
using System.Net;
using Telerik.JustMock;

namespace persy_cs_sdk_test
{
    public class TestWebRequestCreate : IWebRequestCreate
    {
        private static WebRequest nextRequest;

        private static object lockObject = new object();

        public static WebRequest NextRequest
        {
            get
            {
                return nextRequest;
            }

            set
            {
                lock (lockObject)
                {
                    nextRequest = value;
                }
            }
        }

        public WebRequest Create(Uri uri)
        {
            return nextRequest;
        }

        public static Stream GenerateStreamFromString(string str)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(str);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public static Stream GenerateStreamFromByteArray(byte[] array)
        {
            MemoryStream stream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(array);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        public static HttpWebRequest MockHttpWebRequestWithGivenResponseCode(HttpStatusCode httpStatusCode)
        {
            var response = Mock.Create<HttpWebResponse>();
            Mock.Arrange(() => response.StatusCode).Returns(httpStatusCode);
            Mock.Arrange(() => response.StatusDescription).Returns(httpStatusCode.ToString());
            Mock.Arrange(() => response.GetResponseStream()).Returns(new System.IO.MemoryStream());

            var request = Mock.Create<HttpWebRequest>();
            Mock.Arrange(() => request.GetResponse()).Returns(response);
            Mock.Arrange(() => request.GetRequestStream()).Returns(new System.IO.MemoryStream());

            NextRequest = request;

            return request;
        }

        public static HttpWebRequest MockHttpWebRequestWithGivenResponseCode(HttpStatusCode httpStatusCode, string content)
        {
            var response = Mock.Create<HttpWebResponse>();
            Mock.Arrange(() => response.StatusCode).Returns(httpStatusCode);
            Mock.Arrange(() => response.StatusDescription).Returns(httpStatusCode.ToString());
            Mock.Arrange(() => response.GetResponseStream()).Returns(GenerateStreamFromString(content));

            var request = Mock.Create<HttpWebRequest>();
            Mock.Arrange(() => request.GetResponse()).Returns(response);
            Mock.Arrange(() => request.GetRequestStream()).Returns(new System.IO.MemoryStream());

            NextRequest = request;

            return request;
        }

        public static HttpWebRequest MockHttpWebRequestWithGivenResponseCode(HttpStatusCode httpStatusCode, byte[] content)
        {
            var response = Mock.Create<HttpWebResponse>();
            Mock.Arrange(() => response.StatusCode).Returns(httpStatusCode);
            Mock.Arrange(() => response.StatusDescription).Returns(httpStatusCode.ToString());
            Mock.Arrange(() => response.GetResponseStream()).Returns(GenerateStreamFromByteArray(content));

            var request = Mock.Create<HttpWebRequest>();
            Mock.Arrange(() => request.GetResponse()).Returns(response);
            Mock.Arrange(() => request.GetRequestStream()).Returns(new System.IO.MemoryStream());

            NextRequest = request;

            return request;
        }
    }
}
