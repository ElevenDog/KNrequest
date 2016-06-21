using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vanilla
{
    public class ParamPair : IComparable<ParamPair>
    {
        public string Name
        {
            get;
            set;
        }
        public string Value
        {
            get;
            set;
        }
        public ParamPair()
        {
        }
        public ParamPair(string name, string value)
        {
            this.Name = name;
            this.Value = value;
        }
        public int CompareTo(ParamPair other)
        {
            bool flag = this.Name == null;
            int result;
            if (flag)
            {
                bool flag2 = other.Name == null;
                if (flag2)
                {
                    bool flag3 = this.Value == null;
                    if (flag3)
                    {
                        result = ((other.Value == null) ? 0 : -1);
                    }
                    else
                    {
                        result = ((other.Value == null) ? 1 : this.Value.CompareTo(other.Value));
                    }
                }
                else
                {
                    result = -1;
                }
            }
            else
            {
                int num = this.Name.CompareTo(other.Name);
                bool flag4 = num == 0;
                if (flag4)
                {
                    num = this.Value.CompareTo(other.Value);
                }
                result = num;
            }
            return result;
        }
    }
}
