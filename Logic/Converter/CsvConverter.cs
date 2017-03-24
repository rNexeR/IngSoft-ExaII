using Logic.InputReader;
using Logic.OutputWriter;
using Logic.ParseOptions;

namespace Logic.Converter
{
    public class CsvConverter
    {
        private IOutputWriter _outputWriter;
        private ICsvParseOption _csvParseOption;
        private IInputReader _fileReader;

        public CsvConverter(IInputReader fileReader, ICsvParseOption csvParseOption, IOutputWriter outputWriter)
        {
            this._fileReader = fileReader;
            this._csvParseOption = csvParseOption;
            this._outputWriter = outputWriter;
        }

        public void Convert()
        {
            throw new System.NotImplementedException();
        }

        public void CheckFormat()
        {
            throw new System.NotImplementedException();
        }
    }
}