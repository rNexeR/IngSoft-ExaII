using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.ParseOptions;
namespace Logic.ParseOptions
{
    public class XMLParseOption : ICsvParseOption
    {
        //private XML _xml;
        //private int sizeRow = 0;
        //private List<string> beforeFilesNames = new List<string>();
        //private List<string> FilesNames = new List<string>();
        //private List<string> tmpFilesNames = new List<string>();

        private string _xml;
        public XMLParseOption()
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
