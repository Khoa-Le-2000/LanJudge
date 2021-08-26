using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerTestCode.Model
{
    class SqlParam
    {
        public string Name;
        public object Value;

        public SqlParam(string name, object value)
        {
            Name = name;
            Value = value;
        }
    }
}
