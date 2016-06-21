using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class ParamCollection : Collection<ParamPair>
    {
        public ParamCollection()
        {
        }
        public ParamCollection(IEnumerable<ParamPair> items)
        {
            foreach (ParamPair current in items)
            {
                base.Add(current);
            }
        }
        public void Add(string name, string value)
        {
            base.Add(new ParamPair(name, value));
        }
    }
}
