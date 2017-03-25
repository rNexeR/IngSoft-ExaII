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
        private readonly IOutputWriter _outputWriter;
        private readonly ICsvParseOption _csvParseOption;
        private readonly IInputReader _inputReader;
        private readonly DataTypeDetectorsRepository _detectorsRepository;
        private readonly CsvParser _parser;

        public CsvConverter(IInputReader inputReader, ICsvParseOption csvParseOption, DataTypeDetectorsRepository detectorsRepository, IOutputWriter outputWriter)
        {
            this._inputReader = inputReader;
            this._csvParseOption = csvParseOption;
            this._outputWriter = outputWriter;
            this._detectorsRepository = detectorsRepository;
            this._parser = new CsvParser();
        }

        public void Convert()
        {
            var csvString = _inputReader.GetInput();
            var csv = _parser.Parse(csvString);

            foreach (var row in csv.Rows)
            {
                _csvParseOption.AddRow();
                for (var i = 0; i < csv.Headers.Count; i++)
                {
                    var tmp = _detectorsRepository.FormatField(row[i]);
                    string field = tmp.Replace("\r", "");
                    _csvParseOption.AddField(field, csv.Headers[i]);
                }
                _csvParseOption.CloseRow();
            }

            _outputWriter.Write(_csvParseOption.ToString());
        }
    }
}