using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ParseOptions
{
    public class JsonParseOption : ICsvParseOption
    {
        private string _json;

        public JsonParseOption()
        {
            _json = "{\"Rows\":[";
        }
        public void AddRow()
        {
            _json += "{";
        }

        public void CloseRow()
        {
            _json += "},";
        }

        public void AddField(string fieldValue, string fieldName)
        {
            _json += $"\"{fieldName}\":{fieldValue},";
        }

        public override string ToString()
        {
            return (_json + "]}").Replace(",]", "]").Replace(",}", "}") ;
        }
    }
}
