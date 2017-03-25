using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.DataTypeDetector;

namespace Logic.DataTypeParser
{
    class IntTypeParser : ITypeParser
    {
        public dynamic Parse(string stringField)
        {
            int value;
            int.TryParse(stringField, out value);
            return value;
        }
    }
}
