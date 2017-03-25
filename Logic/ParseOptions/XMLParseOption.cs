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
        private readonly XML _xml;
        private int sizeRow = 0;
        private List<string> beforeFilesNames;
        private List<string> FilesNames;
        private List<string> tmpFilesNames;
        public XMLParseOption(XML xml)
        {
            this._xml = xml; 
        }
        public void AddField(string fieldValue, string fieldName)
        {
            _xml.tags.Add("<" + fieldName + ">" + fieldValue + "</" + fieldName + ">");
            tmpFilesNames.Add("<" + fieldName + ">" + fieldValue + "</" + fieldName + ">");
            beforeFilesNames.Add(fieldName);

        }

        public void AddRow()
        {

            for(int i=0; i < beforeFilesNames.Count; i++)
            {
                if (!FilesNames.Contains(beforeFilesNames[i]))
                {
                    FilesNames.Add(beforeFilesNames[i]);
                }
            }
            string tmp = "<Row>";
            for(int i=_xml.sizeTags; i<(FilesNames.Count +_xml.sizeTags); i++)
            {
                tmp += " " + tmpFilesNames[i];
            }
            _xml.rows.Add(tmp);
            _xml.sizeTags +=3;
        }

        public void CloseRow()
        {
            string tmp = " </Row>";
            _xml.rows[sizeRow] += tmp;
        }
        public string GetCSVParsedToXML()
        {
            string tmp = "<Rows> ";
            for(int i=0; i<_xml.rows.Count; i++)
            {
                tmp += _xml.rows[i];
            }
            tmp += " </Rows>";
            return tmp;
        }
    }
}
