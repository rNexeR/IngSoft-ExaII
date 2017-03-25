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
        public FileInputReader(string fPath)
        {
            if(!File.Exists(fPath))
            {
                throw new FileNotFoundException("The file " + fPath + " if not exist");
            }
            this.filePath = fPath;
        }
        public string GetInput()
        {
                StreamReader str = new StreamReader(filePath);
                string fileReaded = str.ReadToEnd();
                return fileReaded;
            
        }
    }
}
