using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.OutputWriter
{
    public class ConsoleOutputWriter : IOutputWriter
    {
        public void Write(string outputString)
        {
            Console.WriteLine(outputString);
        }
    }
}
