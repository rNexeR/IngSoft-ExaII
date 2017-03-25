using Logic.ParseOptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Converter;
using Logic.DataTypeDetector;

namespace IngSoft_ExaII
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "";
            string optionParse = "";
            string outputFile = "a.out";

            if (args.Length >=2)
            {
                inputFile = args[0];
                optionParse = args[1];
                if (args.Length == 3)
                    outputFile = args[2];
            }

            Console.WriteLine($"inputFile: {inputFile} | optionParse: {optionParse} | outputFile: {outputFile}");

            IDictionary<string, Func<ICsvParseOption>> parseOptions = new Dictionary<string, Func<ICsvParseOption>>();
            parseOptions.Add("json", () => new JsonParseOption());
            //parseOptions.Add("xml", () => new XmlParseOption());

            var typesRepository = new DataTypeDetectorsRepository();
            //typesRepository adds

            var csvParseOption = parseOptions[optionParse]();
            //var inputReader = new FileInputReader(inputFile);
            //var outputWriter = new OutputWriter(outputFile);
            //var csvConverter = new CsvConverter(inputReader, csvParseOption, typesRepository, outputWriter);
            //csvConverter.Convert();

            Console.ReadLine();
        }
    }
}
