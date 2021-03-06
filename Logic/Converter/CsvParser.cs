using System;
using System.Linq;
using Logic.Exceptions;

namespace Logic.Converter
{
    public class CsvParser
    {
        public CsvParser()
        {
        }

        public Csv Parse(string csvString)
        {
            var ret = new Csv();
            var data = csvString.Split('\n');

            for (var i = 0; i < data.Length; i++)
            {
                //var columns = data[i].Split(',');
                var columns = data[i].Split('"')
                     .Select((element, index) => index % 2 == 0  // If even index
                                           ? element.Split(new[] { ',' })  // Split the item
                                           : new string[] { element })  // Keep the entire item
                     .SelectMany(element => element).ToArray();
                if (i == 0)
                    SetHeaders(columns, ref ret);
                else
                    AddDataRow(columns, ref ret);

            }
            return ret;
        }

        private void AddDataRow(string[] columns, ref Csv ret)
        {
            if(columns.Length > ret.Headers.Count)
                throw new MoreColumnsThanHeadersException($"Found {columns.Length} columns and only {ret.Headers.Count} headers");
            else if (columns.Length < ret.Headers.Count)
                throw new LessColumnsThanHeadersException(
                    $"Found {columns.Length} columns and only {ret.Headers.Count} headers");
            else
            {
                ret.Rows.Add(columns.ToList());
            }
        }

        private void SetHeaders(string[] columns, ref Csv csv)
        {
            foreach (var field in columns)
            {
                if (field.Length == 0)
                    throw new HeaderNameCannotBeBlankException("Blank Header found");
                else if (field.Contains(" "))
                    throw new HeaderNameCannotContainSpacesException("Space found in Header");
                else
                {
                    string tmp = field.Replace("\r", "");
                    csv.Headers.Add(tmp);
                }
            }
        }
    }
}