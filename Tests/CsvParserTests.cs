using System;
using System.Linq;
using Logic.Converter;
using Logic.Exceptions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CsvParserTests
    {
        [TestMethod]
        [ExpectedException(typeof(MoreColumnsThanHeadersException))]
        public void TestMoreColumnsThanHeaders()
        {
            var dataArray = new[]
               {
                "nombre,apellido,edad",
                "nexer,rodriguez,21,1804",
                "kevin,estevez,20",
                "tonio,mejia,21",
                "josue,barahona,21,1804"
            };

            var data = $"{string.Join("\n", dataArray)}";

            var parser = new CsvParser();
            var csv = parser.Parse(data);
        }

        [TestMethod]
        [ExpectedException(typeof(LessColumnsThanHeadersException))]
        public void TestLessColumnsThanHeaders()
        {
            var dataArray = new[]
                {
                "nombre,apellido,edad,depto",
                "nexer,rodriguez,21",
                "kevin,estevez,20",
                "tonio,mejia,21",
                "josue,barahona,21"
            };

            var data = $"{string.Join("\n", dataArray)}";

            var parser = new CsvParser();
            var csv = parser.Parse(data);
        }

        [TestMethod]
        [ExpectedException(typeof(HeaderNameCannotContainSpacesException))]
        public void TestHeaderNameContainingSpaces()
        {
            var dataArray = new[]
                {
                "nombre de cliente,apellido,edad,depto",
                "nexer,rodriguez,21",
                "kevin,estevez,20",
                "tonio,mejia,21",
                "josue,barahona,21"
            };

            var data = $"{string.Join("\n", dataArray)}";

            var parser = new CsvParser();
            var csv = parser.Parse(data);
        }

        [TestMethod]
        [ExpectedException(typeof(HeaderNameCannotBeBlankException))]
        public void TestBlankHeaderName()
        {
            var dataArray = new[]
                {
                ",apellido,edad,depto",
                "nexer,rodriguez,21",
                "kevin,estevez,20",
                "tonio,mejia,21",
                "josue,barahona,21"
            };

            var data = $"{string.Join("\n", dataArray)}";

            var parser = new CsvParser();
            var csv = parser.Parse(data);
        }

        [TestMethod]
        public void TestCorrectParse()
        {
            var dataArray = new[]
            {
                "nombre,apellido,edad",
                "nexer,rodriguez,21",
                "kevin,estevez,20",
                "tonio,mejia,21",
                "josue,barahona,21"
            };

            var data = $"{string.Join("\n", dataArray)}";

            var parser = new CsvParser();
            var csv = parser.Parse(data);
            Assert.IsTrue(csv.Headers.Count == 3);
        }
    }
}
