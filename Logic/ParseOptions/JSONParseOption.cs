using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ParseOptions
{
    class JsonParseOption : ICsvParseOption
    {
        public void AddRow()
        {
            throw new NotImplementedException();
        }

        public void CloseRow()
        {
            throw new NotImplementedException();
        }

        public void AddField(string fieldValue, string fieldName)
        {
            throw new NotImplementedException();
        }
    }
}
