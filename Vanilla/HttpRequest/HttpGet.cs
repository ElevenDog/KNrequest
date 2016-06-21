using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class HttpGet : HttpRequest
    {
        private ParamCollection queryParams = new ParamCollection();
        public virtual ParamCollection Params
        {
            get
            {
                return this.queryParams;
            }
        }
        public HttpGet(string uri)
            : base(uri)
        {
            base.Method = "GET";
        }
        protected override string ConstructUri()
        {
            string text = this.Uri;
            bool flag = this.Params != null;
            if (flag)
            {
                foreach (ParamPair current in this.Params)
                {
                    text += string.Format("{0}={1}&", current.Name, current.Value);
                }
                text = text.TrimEnd(new char[]
				{
					'&'
				});
            }
            return text;
        }
    }
}
