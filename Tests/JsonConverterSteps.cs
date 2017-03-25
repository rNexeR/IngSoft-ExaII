using System;
using System.Collections;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public class JsonConverterSteps
    {
        [Given(@"the next table representation of csv file")]
        public void GivenTheNextTableRepresentationOfCsvFile(Table table)
        {
            //_csvArray = new ArrayList();
        }
        
        [When(@"I press convert to Json")]
        public void WhenIPressConvertToJson()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be '(.*)'")]
        public void ThenTheResultShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
