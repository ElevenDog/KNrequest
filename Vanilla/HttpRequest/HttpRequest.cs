using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Vanilla
{
    public abstract class HttpRequest : IHttpRequest
    {
        protected string Uri;
        private static readonly object syncRequestObj;
        public bool IsSSL = false;
        public bool AllowAutoRedirect
        {
            get;
            set;
        }
        public string Host
        {
            get;
            set;
        }
        public int HttpTimeOut
        {
            get;
            set;
        }
        public string Referer
        {
            get;
            set;
        }
        public string UserAgent
        {
            get;
            set;
        }
        public string Connection
        {
            get;
            set;
        }
        public string Accept
        {
            get;
            set;
        }
        public Dictionary<string, string> Headers
        {
            get;
            set;
        }
        public List<Cookie> CookieList
        {
            get;
            set;
        }
        public SecurityProtocolType SPT
        {
            get;
            set;
        }
        public List<Cookie> RspCookieList
        {
            get;
            set;
        }
        public ProxyIP ProxyIP
        {
            get;
            set;
        }
        public string CookieString
        {
            get;
            set;
        }
        protected virtual string Method
        {
            get;
            set;
        }
        public virtual Encoding ReqEncoding
        {
            get;
            set;
        }
        public virtual Encoding RepEncoding
        {
            get;
            set;
        }
        public virtual string ContentType
        {
            get;
            set;
        }
        public virtual string CertPath
        {
            get;
            set;
        }
        public virtual string CertPassword
        {
            get;
            set;
        }
        static HttpRequest()
        {
            HttpRequest.syncRequestObj = new object();
            ServicePointManager.DefaultConnectionLimit = 20;
        }
        protected HttpRequest(string uri)
        {
            this.Uri = uri;
            this.ReqEncoding = Encoding.UTF8;
            this.RepEncoding = Encoding.UTF8;
            this.HttpTimeOut = 60000;
            this.Headers = new Dictionary<string, string>();
            this.SPT = SecurityProtocolType.Ssl3;
            this.AllowAutoRedirect = true;
        }
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData, ref uint pcchCookieData, int dwFlags, IntPtr lpReserved);
        [DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int InternetSetCookieEx(string lpszURL, string lpszCookieName, string lpszCookieData, int dwFlags, IntPtr dwReserved);
        private static string GetCookies(string url)
        {
            uint num = 256u;
            StringBuilder stringBuilder = new StringBuilder((int)num);
            bool flag = !HttpRequest.InternetGetCookieEx(url, null, stringBuilder, ref num, 8192, IntPtr.Zero);
            string result;
            if (flag)
            {
                bool flag2 = num < 0u;
                if (flag2)
                {
                    result = null;
                    return result;
                }
                stringBuilder = new StringBuilder((int)num);
                bool flag3 = !HttpRequest.InternetGetCookieEx(url, null, stringBuilder, ref num, 8192, IntPtr.Zero);
                if (flag3)
                {
                    result = null;
                    return result;
                }
            }
            result = stringBuilder.ToString();
            return result;
        }
        public static List<Cookie> GetAllCookies(CookieContainer cc)
        {
            List<Cookie> list = new List<Cookie>();
            Hashtable hashtable = (Hashtable)cc.GetType().InvokeMember("m_domainTable", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField, null, cc, new object[0]);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (object current in hashtable.Values)
            {
                SortedList sortedList = (SortedList)current.GetType().InvokeMember("m_list", BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.GetField, null, current, new object[0]);
                foreach (CookieCollection cookieCollection in sortedList.Values)
                {
                    foreach (Cookie cookie in cookieCollection)
                    {
                        list.Add(cookie);
                        stringBuilder.AppendLine(string.Concat(new string[]
						{
							cookie.Domain,
							":",
							cookie.Name,
							"____",
							cookie.Value,
							"\r\n"
						}));
                    }
                }
            }
            return list;
        }
        private bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        public virtual string Request()
        {
            bool isSSL = this.IsSSL;
            if (isSSL)
            {
                ServicePointManager.SecurityProtocol = this.SPT;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(this.ValidateServerCertificate);
            }
            HttpWebRequest httpWebRequest = WebRequest.Create(this.ConstructUri()) as HttpWebRequest;
            httpWebRequest.AllowAutoRedirect = this.AllowAutoRedirect;
            httpWebRequest.Timeout = this.HttpTimeOut;
            httpWebRequest.ReadWriteTimeout = this.HttpTimeOut;
            bool flag = this.ProxyIP != null;
            if (flag)
            {
                WebProxy proxy = new WebProxy(this.ProxyIP.IP, this.ProxyIP.Port);
                httpWebRequest.Proxy = proxy;
            }
            bool flag2 = !string.IsNullOrEmpty(this.UserAgent);
            if (flag2)
            {
                httpWebRequest.UserAgent = this.UserAgent;
            }
            bool flag3 = !string.IsNullOrEmpty(this.Referer);
            if (flag3)
            {
                httpWebRequest.Referer = this.Referer;
            }
            bool flag4 = !string.IsNullOrEmpty(this.Accept);
            if (flag4)
            {
                httpWebRequest.Accept = this.Accept;
            }
            bool flag5 = !string.IsNullOrEmpty(this.Host);
            if (flag5)
            {
                httpWebRequest.Host = this.Host;
            }
            bool flag6 = !string.IsNullOrEmpty(this.Connection);
            if (flag6)
            {
                httpWebRequest.Connection = this.Connection;
            }
            bool flag7 = this.Headers != null;
            if (flag7)
            {
                httpWebRequest.Headers = new WebHeaderCollection();
                foreach (KeyValuePair<string, string> current in this.Headers)
                {
                    httpWebRequest.Headers.Add(current.Key, current.Value);
                }
            }
            CookieContainer cookieContainer = new CookieContainer();
            httpWebRequest.CookieContainer = cookieContainer;
            bool flag8 = this.CookieList != null;
            if (flag8)
            {
                foreach (Cookie current2 in this.CookieList)
                {
                    httpWebRequest.CookieContainer.Add(current2);
                }
            }
            bool flag9 = !string.IsNullOrEmpty(this.Method);
            if (flag9)
            {
                httpWebRequest.Method = this.Method;
            }
            bool flag10 = !string.IsNullOrEmpty(this.ContentType);
            if (flag10)
            {
                httpWebRequest.ContentType = this.ContentType;
            }
            this.PrepareRequest(httpWebRequest);
            bool flag11 = httpWebRequest.Method == "POST";
            if (flag11)
            {
                httpWebRequest.ServicePoint.Expect100Continue = false;
                using (Stream requestStream = httpWebRequest.GetRequestStream())
                {
                    this.WriteBody(requestStream);
                }
            }
            string result;
            try
            {
                WebResponse response = httpWebRequest.GetResponse();
                this.RspCookieList = HttpRequest.GetAllCookies(httpWebRequest.CookieContainer);
                HttpWebResponse httpWebResponse = response as HttpWebResponse;
                string text = this.RetrieveResponse(response);
                httpWebResponse.Close();
                result = text;
            }
            catch (WebException ex)
            {
                throw ex;
            }
            finally
            {
                httpWebRequest.Abort();
            }
            return result;
        }
        public void RequestAsync(AsyncCallback<string> callback)
        {
            new Thread(new ParameterizedThreadStart(this.DoRequest))
            {
                IsBackground = true,
                Name = string.Format("RequestingThread:{0}", this.Uri)
            }.Start(callback);
        }
        private void DoRequest(object state)
        {
            AsyncCallback<string> asyncCallback = state as AsyncCallback<string>;
            AsyncCallResult<string> asyncCallResult = new AsyncCallResult<string>();
            try
            {
                asyncCallResult.Data = this.Request();
                asyncCallResult.Success = true;
            }
            catch (Exception exception)
            {
                asyncCallResult.Success = false;
                asyncCallResult.Exception = exception;
            }
            finally
            {
                asyncCallback(asyncCallResult);
            }
        }
        protected virtual string ConstructUri()
        {
            return this.Uri;
        }
        protected virtual void AppendHeaders(WebHeaderCollection headers)
        {
        }
        protected virtual void PrepareRequest(HttpWebRequest webRequest)
        {
        }
        protected virtual void WriteBody(Stream reqStream)
        {
        }
        protected virtual string RetrieveResponse(WebResponse webResponse)
        {
            string result = string.Empty;
            Stream responseStream = webResponse.GetResponseStream();
            using (StreamReader streamReader = new StreamReader(responseStream, this.RepEncoding))
            {
                result = streamReader.ReadToEnd();
            }
            webResponse.Close();
            return result;
        }
        public List<Cookie> GetResponseObj()
        {
            throw new NotImplementedException();
        }
    }
}
