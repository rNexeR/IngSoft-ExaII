using System.Text.RegularExpressions;

namespace Logic.DataTypeDetector
{
    public class DateTypeDetector : ITypeDetector
    {
        private Regex regex;

        public DateTypeDetector()
        {
            regex = new Regex(@"#[0-9][0-9]/[0-9][0-9]/[0-9][0-9][0-9][0-9]#");
        }

        public bool Detect(string stringField)
        {
            Match match = regex.Match(stringField);
            return match.Success;
        }
    }
}