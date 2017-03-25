using System;
using Autofac;
using Logic;
using Logic.Converter;
using Logic.DataTypeDetector;
using Logic.Exceptions;
using Logic.InputReader;
using Logic.OutputWriter;
using Logic.ParseOptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class CsvTests
    {
        [TestMethod]
        public void TestCorrectCsvFormat()
        {
            var inputReader = new Mock<IInputReader>();
            var csvParseOption = new Mock<ICsvParseOption>();
            var outputWriter = new Mock<IOutputWriter>();
            var dataTypeDetector = new Mock<DataTypeDetectorsRepository>();
            var converter = new CsvConverter(inputReader.Object, csvParseOption.Object, dataTypeDetector.Object, outputWriter.Object);

            converter.Convert();
        }
    }
}
