using Logic.ParseOptions;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Logic.Converter;
using Logic.DataTypeDetector;
using Logic.InputReader;
using Logic.OutputWriter;

namespace IngSoft_ExaII
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "";
            string optionParse = "";
            string outputFile = "a.out";

            if (args.Length >= 2)
            {
                inputFile = args[0];
                optionParse = args[1].ToLower();
                if (args.Length == 3)
                    outputFile = args[2];
            }
            else
            {
                return;
            }

            Console.WriteLine($"inputFile: {inputFile} | optionParse: {optionParse} | outputFile: {outputFile}");

            IDictionary<string, Func<ICsvParseOption>> parseOptions = new Dictionary<string, Func<ICsvParseOption>>();
            parseOptions.Add("json", () => new JsonParseOption());
            parseOptions.Add("xml", () => new XmlParseOption());

            var typesList = new List<ITypeDetector>
            {
                new DateTypeDetector(),
                new IntTypeDetector(),
                new StringTypeDetector()
            };

            var typesRepository = new DataTypeDetectorsRepository(typesList);

            var csvParseOption = parseOptions[optionParse]();
            var inputReader = new FileInputReader(inputFile);
            var outputWriter = new FileOutPutWriter(outputFile);
            //var csvConverter = new CsvConverter(inputReader, csvParseOption, typesRepository, outputWriter);
            //csvConverter.Convert();

            
             var builder = new ContainerBuilder();
            builder.Register(c => new CsvConverter(
                c.Resolve<IInputReader>(),
                c.Resolve<ICsvParseOption>(),
                c.Resolve<DataTypeDetectorsRepository>(),
                c.Resolve<IOutputWriter>()
                ));
            builder.RegisterInstance(inputReader).As<IInputReader>();
            builder.RegisterInstance(csvParseOption).As<ICsvParseOption>();
            builder.RegisterInstance(outputWriter).As<IOutputWriter>();
            builder.RegisterInstance(typesRepository).As<DataTypeDetectorsRepository>();

            using (var container = builder.Build())
            {
                container.Resolve<CsvConverter>().Convert();
            }
             

            Console.ReadLine();
        }
    }
}
