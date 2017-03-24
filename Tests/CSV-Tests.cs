using System;
using Autofac;
using Logic;
using Logic.Converter;
using Logic.Exceptions;
using Logic.FileReader;
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
            var file_reader = new Mock<IFileReader>();
            var csvParseOption = new Mock<ICsvParseOption>();
            var outputWriter = new Mock<IOutputWriter>();
            var converter = new CsvConverter(file_reader.Object, csvParseOption.Object, outputWriter.Object);

            converter.Convert();
            /*
            var builder = new ContainerBuilder();

            builder.RegisterInstance(file_reader.Object).As<IFileReader>();
            builder.RegisterInstance(csvParseOption.Object).As<ICsvParseOption>();
            builder.RegisterInstance(outputWriter.Object).As<IOutputWriter>();

            builder.Register(c => new CsvConverter(c.Resolve<IFileReader>(), c.Resolve<ICsvParseOption>(), c.Resolve<IOutputWriter>()));

            var container = builder.Build();
            container.Resolve<CsvConverter>();*/
        }

        [TestMethod]
        [ExpectedException(typeof(LessColumnsThanHeadersException))]
        public void TestLessColumnsThanHeaders()
        {
            var file_reader = new Mock<IFileReader>();
            var csvParseOption = new Mock<ICsvParseOption>();
            var outputWriter = new Mock<IOutputWriter>();
            var converter = new CsvConverter(file_reader.Object, csvParseOption.Object, outputWriter.Object);

            converter.Convert();
        }

        [TestMethod]
        [ExpectedException(typeof(BadHeaderNameException))]
        public void TestBadHeaderName()
        {
            var file_reader = new Mock<IFileReader>();
            var csvParseOption = new Mock<ICsvParseOption>();
            var outputWriter = new Mock<IOutputWriter>();
            var converter = new CsvConverter(file_reader.Object, csvParseOption.Object, outputWriter.Object);

            converter.Convert();
        }

        [TestMethod]
        public void TestCorrectCsvFormat()
        {
            var file_reader = new Mock<IFileReader>();
            var csvParseOption = new Mock<ICsvParseOption>();
            var outputWriter = new Mock<IOutputWriter>();
            var converter = new CsvConverter(file_reader.Object, csvParseOption.Object, outputWriter.Object);

            converter.Convert();
        }

        [TestMethod]
        public void TestDataTypeDetection()
        {
            var file_reader = new Mock<IFileReader>();
            var csvParseOption = new Mock<ICsvParseOption>();
            var outputWriter = new Mock<IOutputWriter>();
            var converter = new CsvConverter(file_reader.Object, csvParseOption.Object, outputWriter.Object);

            converter.Convert();
        }
    }
}
