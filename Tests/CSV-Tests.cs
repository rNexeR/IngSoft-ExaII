using System;
using Logic;
using Logic.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CsvTests
    {
        [TestMethod]
        [ExpectedException(typeof(MoreColumnsThanHeadersException))]
        public void TestMoreColumnsThanHeaders()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(LessColumnsThanHeadersException))]
        public void TestLessColumnsThanHeaders()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(BadHeaderNameException))]
        public void TestBadHeaderName()
        {
            
        }

        [TestMethod]
        public void TestCorrectCsvFormat()
        {

        }

        //[TestMethod]
        //public void Test
    }
}
