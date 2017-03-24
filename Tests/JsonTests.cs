using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Tests
{
    [TestClass]
    public class JsonTests
    {
        [Given(@"the next table representation of csv file")]
        public void GivenTheNextTableRepresentationOfCsvFile(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I press convert to Json")]
        public void WhenIPressConvertToJson()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the result should be '(.*)'")]
        public void ThenTheResultShouldBe(string p0)
        {
            Console.WriteLine(p0);
            ScenarioContext.Current.Pending();
        }

    }
}
