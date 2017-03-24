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
        [ExpectedException(typeof(MoreColumnsThanHeadersException))]
        public void TestMoreColumnsThanHeaders()
        {
            var input_reader = new Mock<IInputReader>();
            var csvParseOption = new Mock<ICsvParseOption>();
            var outputWriter = new Mock<IOutputWriter>();
            var dataTypeDetector = new Mock<DataTypeDetectorsRepository>();
            var converter = new CsvConverter(input_reader.Object, csvParseOption.Object, dataTypeDetector.Object, outputWriter.Object);

            converter.Convert();
            /*
            var builder = new ContainerBuilder();

            builder.RegisterInstance(input_reader.Object).As<IInputReader>();
            builder.RegisterInstance(csvParseOption.Object).As<ICsvParseOption>();
            builder.RegisterInstance(outputWriter.Object).As<IOutputWriter>();

            builder.Register(c => new CsvConverter(c.Resolve<IInputReader>(), c.Resolve<ICsvParseOption>(), c.Resolve<IOutputWriter>()));

            var container = builder.Build();
            container.Resolve<CsvConverter>();*/
        }

        [TestMethod]
        [ExpectedException(typeof(LessColumnsThanHeadersException))]
        public void TestLessColumnsThanHeaders()
        {
            var input_reader = new Mock<IInputReader>();
            var csvParseOption = new Mock<ICsvParseOption>();
            var outputWriter = new Mock<IOutputWriter>();
            var dataTypeDetector = new Mock<DataTypeDetectorsRepository>();
            var converter = new CsvConverter(input_reader.Object, csvParseOption.Object, dataTypeDetector.Object, outputWriter.Object);

            converter.Convert();
        }

        [TestMethod]
        [ExpectedException(typeof(BadHeaderNameException))]
        public void TestBadHeaderName()
        {
            var input_reader = new Mock<IInputReader>();
            var csvParseOption = new Mock<ICsvParseOption>();
            var outputWriter = new Mock<IOutputWriter>();
            var dataTypeDetector = new Mock<DataTypeDetectorsRepository>();
            var converter = new CsvConverter(input_reader.Object, csvParseOption.Object, dataTypeDetector.Object, outputWriter.Object);

            converter.Convert();
        }

        [TestMethod]
        public void TestCorrectCsvFormat()
        {
            var input_reader = new Mock<IInputReader>();
            var csvParseOption = new Mock<ICsvParseOption>();
            var outputWriter = new Mock<IOutputWriter>();
            var dataTypeDetector = new Mock<DataTypeDetectorsRepository>();
            var converter = new CsvConverter(input_reader.Object, csvParseOption.Object, dataTypeDetector.Object, outputWriter.Object);

            converter.Convert();
        }
    }
}
