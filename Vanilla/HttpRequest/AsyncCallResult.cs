using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public delegate void AsyncCallback<T>(AsyncCallResult<T> result);

    [Serializable]
    public class AsyncCallResult
    {
        public bool Success
        {
            get;
            set;
        }
        public Exception Exception
        {
            get;
            set;
        }
    }

    [Serializable]
    public class AsyncCallResult<T> : AsyncCallResult
    {
        public T Data
        {
            get;
            set;
        }
    }
}
