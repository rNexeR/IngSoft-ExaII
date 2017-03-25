using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.ParseOptions
{
    public class XML
    {
        public List<string> rows { get; set; }
        public int sizeTags { get; set; }
        public int sizeRows { get; set; }
        public List<string> tags { get; set; }
        public XML()
        {
            rows = new List<string>();
            tags = new List<string>();
            sizeTags = 0;
            sizeRows = 0;
        }
    }
}
