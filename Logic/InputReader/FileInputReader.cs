using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.InputReader
{
    public class FileInputReader : IInputReader
    {
        private string filePath = "";
        public FileInputReader(string filePath)
        {
            if(!File.Exists(filePath))
            {
                throw new FileNotFoundException("The file " + filePath + " if not exist");
            }
            this.filePath = filePath;
        }
        public string GetInput()
        {
                StreamReader str = new StreamReader(filePath);
                string fileReaded = str.ReadToEnd();
                return fileReaded;
            
        }
    }
}
