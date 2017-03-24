using System;
using System.Collections.Generic;
using Logic.DataTypeDetector;
using Logic.InputReader;
using Logic.OutputWriter;
using Logic.ParseOptions;

namespace Logic.Converter
{
    public class CsvConverter
    {
        private IOutputWriter _outputWriter;
        private ICsvParseOption _csvParseOption;
        private IInputReader _input_reader;
        private IDataTypeDetectorsRepository _detectorsRepository;
        private readonly CsvParser _parser;

        public CsvConverter(IInputReader input_reader, ICsvParseOption csvParseOption, IDataTypeDetectorsRepository detectorsRepository, IOutputWriter outputWriter)
        {
            this._input_reader = input_reader;
            this._csvParseOption = csvParseOption;
            this._outputWriter = outputWriter;
            this._detectorsRepository = detectorsRepository;
            this._parser = new CsvParser();
        }

        public void Convert()
        {
            var csvString = _input_reader.GetInput();
            var csv = _parser.Parse(csvString);
            var outputString = "";

            foreach (var row in csv.Rows)
            {
                var rowString = _csvParseOption.CreateRow();
                var fieldsString = new List<string>();
                for (var i = 0; i < csv.Headers.Count; i++)
                {
                    fieldsString.Add(_csvParseOption.CreateField);
                }
                rowString += _csvParseOption.AddFields(fieldsString);
                rowString += _csvParseOption.CloseRow();
                outputString += rowString;
            }

            _outputWriter.Write(outputString);
        }
    }
}