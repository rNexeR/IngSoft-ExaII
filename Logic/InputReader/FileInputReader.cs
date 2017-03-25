using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.InputReader
{
    class FileInputReader : IInputReader
    {
        private string filePath = "";
        public FileInputReader(string filePath)
        {
            this.filePath = filePath;
        }
        public string GetInput()
        {
            if (File.Exists(filePath))
            {
                StreamReader str = new StreamReader(filePath);
                string fileReaded = str.ReadToEnd();
                return fileReaded;
            }
            else
            {
                throw new FileNotFoundException("The file " + filePath + " if not exist");
            }
        }
    }
}
