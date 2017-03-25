using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.ParseOptions;
namespace Logic.ParseOptions
{
    public class XmlParseOption : ICsvParseOption
    {
        private string _xml;
        public XmlParseOption()
        {
            this._xml = "<Rows>";
            
        }
        public void AddField(string fieldValue, string fieldName)
        {
            _xml += "<" + fieldName + ">" + fieldValue + "</" + fieldName + ">";
        }

        public void AddRow()
        {
            _xml += "<Row>";
        }

        public void CloseRow()
        {
            _xml += "</Row>";
        }
        public override string ToString()
        {
            return _xml += "</Rows>";
         
        }
    }
}
