using Logic.Converter;
using Logic.DataTypeDetector;
using Logic.InputReader;
using Logic.OutputWriter;
using Logic.ParseOptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public class XMLConverterSteps
    {
        private string[] _csvArray;
        private CsvConverter _converter;
        private XML xml;
        private string _output;
        [Given(@"the next table of csv representation file")]
        public void GivenTheNextTableOfCsvRepresentationFile(Table table)
        {
            _csvArray = new string[table.RowCount + 1];
            _csvArray[0] = string.Join(",", table.Header.ToArray());
            for (int i = 1; i < _csvArray.Length; i++)
            {
                _csvArray[i] = string.Join(",", table.Rows[i - 1].Values.ToArray());
            }
        }
        
        [When(@"I press convert to XML")]
        public void WhenIPressConvertToXML()
        {
            xml = new XML();
            var outputWriter = new Mock<IOutputWriter>();
            _output = "";
            outputWriter.Setup(x => x.Write(It.IsAny<string>())).Callback<string>(r => _output = r);

            var inputReader = new Mock<IInputReader>();
            inputReader.Setup(x => x.GetInput()).Returns(string.Join("\n", _csvArray));
            
            ICsvParseOption csvParseOption = new XMLParseOption();
            List<ITypeDetector> detectors = new List<ITypeDetector>();
            detectors.Add(new IntTypeDetector());
            detectors.Add(new DateTypeDetector());
            detectors.Add(new StringTypeDetector());
            DataTypeDetectorsRepository dataTypeDetectorsRepository = new DataTypeDetectorsRepository(detectors);

            _converter = new CsvConverter(inputReader.Object, csvParseOption, dataTypeDetectorsRepository, outputWriter.Object);
            _converter.Convert();

        }
        
        [Then(@"the final result should be '(.*)'")]
        public void ThenTheFinalResultShouldBe(string p0)
        {
            Console.WriteLine(p0);
            Console.WriteLine(_output);
            Assert.AreEqual(_output, p0);
        }
    }
}
