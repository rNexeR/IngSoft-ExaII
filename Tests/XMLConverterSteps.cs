using Logic.Converter;
using Logic.DataTypeDetector;
using Logic.InputReader;
using Logic.OutputWriter;
using Logic.ParseOptions;
using Moq;
using System;
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
            var outputWriter = new Mock<IOutputWriter>();
            string output = "";
            outputWriter.Setup(x => x.Write(It.IsAny<string>())).Callback<string>(r => output = r);

            var inputReader = new Mock<IInputReader>();
            inputReader.Setup(x => x.GetInput()).Returns(string.Join("\n", _csvArray));
            xml = new XML();

            ICsvParseOption csvParseOption = new XMLParseOption(xml);


            DataTypeDetectorsRepository dataTypeDetectorsRepository = new DataTypeDetectorsRepository();

            _converter = new CsvConverter(inputReader.Object, csvParseOption, dataTypeDetectorsRepository, outputWriter.Object);
            _converter.Convert();
            Console.WriteLine(output);
        }
        
        [Then(@"the final result should be '(.*)'")]
        public void ThenTheFinalResultShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
