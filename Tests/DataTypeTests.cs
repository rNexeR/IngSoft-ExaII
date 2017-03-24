using System;
using Logic.DataTypeDetector;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class DataTypeTests
    {
        [TestMethod]
        public void TestCorrectStringTypeDetection()
        {
            var stringField = "Testing String";
            var stringTypeDetector = new StringTypeDetector();
            Assert.IsTrue(stringTypeDetector.Detect(stringField));
        }

        [TestMethod]
        public void TestBadIntTypeDetection()
        {
            var intField = "1.2";
            var intTypeDetector = new IntTypeDetector();
            Assert.IsFalse(intTypeDetector.Detect(intField));
        }

        [TestMethod]
        public void TestCorrectIntTypeDetection()
        {
            var intField = "123";
            var intTypeDetector = new IntTypeDetector();
            Assert.IsTrue(intTypeDetector.Detect(intField));
        }

        [TestMethod]
        public void TestBadDateTypeDetection()
        {
            var dateField = "#13/10/2017";
            var dateTypeDetector = new DateTypeDetector();
            Assert.IsFalse(dateTypeDetector.Detect(dateField));
        }

        [TestMethod]
        public void TestCorrectDateTypeDetection()
        {
            var dateField = "#13/10/2017#";
            var dateTypeDetector = new DateTypeDetector();
            Assert.IsTrue(dateTypeDetector.Detect(dateField));
        }
    }
}
