using System;
using System.Collections;
using System.Collections.Generic;

namespace Logic.Converter
{
    public class Csv
    {
        public ICollection Rows { get; set; }
        public ICollection<string> Headers { get; set; }

        public Csv()
        {
        }
    }
}