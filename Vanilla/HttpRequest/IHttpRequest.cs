using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public interface IHttpRequest
    {
        string Request();
        void RequestAsync(AsyncCallback<string> callback);
        List<Cookie> GetResponseObj();
    }
}
