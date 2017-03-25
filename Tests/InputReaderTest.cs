using Logic.InputReader;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Tests
{
    [TestClass]
    public class InputReaderTest
    {
        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestFileExist()
        {
            FileInputReader fir = new FileInputReader("hola.txt");
        }
    }
}
