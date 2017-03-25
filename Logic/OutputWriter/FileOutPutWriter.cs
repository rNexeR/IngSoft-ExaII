using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.OutputWriter
{
    public class FileOutPutWriter : IOutputWriter
    {
        private string _outputName;

        public FileOutPutWriter(string outputName)
        {
            this._outputName = outputName;
        }
        public void Write(string outputString)
        {
            File.WriteAllText(this._outputName, outputString);
        }
    }
}
