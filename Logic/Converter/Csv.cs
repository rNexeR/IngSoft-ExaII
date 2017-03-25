using System;
using System.Collections;
using System.Collections.Generic;

namespace Logic.Converter
{
    public class Csv
    {
        public List<List<string>> Rows { get; set; }
        public List<string> Headers { get; set; }

        public Csv()
        {
            Headers = new List<string>();
            Rows = new List<List<string>>();
        }
    }
}