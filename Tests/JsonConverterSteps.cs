using System;
using System.Collections;
using System.Linq;
using Logic.Converter;
using Logic.DataTypeDetector;
using Logic.InputReader;
using Logic.OutputWriter;
using Logic.ParseOptions;
using Moq;
using TechTalk.SpecFlow;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [Binding]
    public class JsonConverterSteps
    {
        private string []_csvArray;
        private CsvConverter _converter;
        private string _output;

        [Given(@"the next table representation of csv file")]
        public void GivenTheNextTableRepresentationOfCsvFile(Table table)
        {
            _csvArray = new string[table.RowCount+1];
            _csvArray[0] = string.Join(",", table.Header.ToArray());
            for (int i = 1; i < _csvArray.Length; i++)
            {
                _csvArray[i] = string.Join(",", table.Rows[i-1].Values.ToArray());
            }
        }
        
        [When(@"I press convert to Json")]
        public void WhenIPressConvertToJson()
        {
            var outputWriter = new Mock<IOutputWriter>();
            _output = "";
            outputWriter.Setup(x => x.Write(It.IsAny<string>())).Callback<string>(r => _output = r);

            var inputReader = new Mock<IInputReader>();
            inputReader.Setup(x => x.GetInput()).Returns(string.Join("\n", _csvArray));


            ICsvParseOption csvParseOption = new JsonParseOption();

            List<ITypeDetector> detectors = new List<ITypeDetector>();
            detectors.Add(new IntTypeDetector());
            detectors.Add(new DateTypeDetector());
            detectors.Add(new StringTypeDetector());
            DataTypeDetectorsRepository dataTypeDetectorsRepository = new DataTypeDetectorsRepository(detectors);

            _converter = new CsvConverter(inputReader.Object,csvParseOption,dataTypeDetectorsRepository,outputWriter.Object);
            _converter.Convert();
        }
        
        [Then(@"the result should be '(.*)'")]
        public void ThenTheResultShouldBe(string p0)
        {
            Assert.AreEqual(_output, p0);
        }
    }
}
