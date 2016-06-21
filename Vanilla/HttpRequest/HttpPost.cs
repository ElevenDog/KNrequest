using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class HttpPost : HttpRequest
    {
        public virtual string PostData
        {
            get;
            set;
        }
        public HttpPost(string uri)
            : base(uri)
        {
            base.Method = "POST";
            base.ContentType = "application/x-www-form-urlencoded";
        }
        public HttpPost(string uri, Dictionary<string, string> postDataDic)
            : this(uri)
        {
            int num = 0;
            StringBuilder stringBuilder = new StringBuilder();
            foreach (KeyValuePair<string, string> current in postDataDic)
            {
                bool flag = num > 0;
                if (flag)
                {
                    stringBuilder.AppendFormat("&{0}={1}", current.Key, current.Value);
                }
                else
                {
                    stringBuilder.AppendFormat("{0}={1}", current.Key, current.Value);
                }
                int num2 = num;
                num = num2 + 1;
            }
            this.PostData = stringBuilder.ToString();
        }
        protected override void WriteBody(Stream reqStream)
        {
            bool flag = !string.IsNullOrEmpty(this.PostData);
            if (flag)
            {
                byte[] bytes = this.ReqEncoding.GetBytes(this.PostData);
                reqStream.Write(bytes, 0, bytes.Length);
            }
        }
        protected override void AppendHeaders(WebHeaderCollection headers)
        {
            headers.Add(HttpRequestHeader.ContentEncoding, base.ReqEncoding.EncodingName);
            base.AppendHeaders(headers);
        }
    }
}
