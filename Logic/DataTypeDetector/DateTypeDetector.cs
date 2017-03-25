using System;
using System.Text.RegularExpressions;

namespace Logic.DataTypeDetector
{
    public class DateTypeDetector : ITypeDetector
    {
        private Regex _regex;

        public DateTypeDetector()
        {
            _regex = new Regex(@"#[0-9][0-9]/[0-9][0-9]/[0-9][0-9][0-9][0-9]#");
        }

        public bool Detect(string stringField)
        {
            Match match = _regex.Match(stringField);
            return match.Success;
        }

        public string Parse(string stringField)
        {
            string tmp = stringField.Replace("#", "");
            var dt = tmp.Split('/');
            int day,month,year;
            int.TryParse(dt[0], out day);
            int.TryParse(dt[1], out month);
            int.TryParse(dt[2], out year);
            DateTime date = new DateTime(year, month, day);
            string isoDate = date.ToString("MMM ddd d HH:mm yyy");
            return "\"" + isoDate + "\"";
        }
    }
}