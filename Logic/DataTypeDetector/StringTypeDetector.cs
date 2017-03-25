using System;

namespace Logic.DataTypeDetector
{
    public class StringTypeDetector : ITypeDetector
    {
        public bool Detect(string stringField)
        {
            var intTypeDetector = new IntTypeDetector();
            var dateTypeDetector = new DateTypeDetector();
            if (!intTypeDetector.Detect(stringField) && !dateTypeDetector.Detect(stringField))
            {
                return true;
            }
            return false;
        }

        public string Parse(string stringField)
        {
            string stringParse = "\""+stringField+"\"";
            return stringParse;
        }
    }
}