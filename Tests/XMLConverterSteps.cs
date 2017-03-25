using System;
using TechTalk.SpecFlow;

namespace Tests
{
    [Binding]
    public class XMLConverterSteps
    {
        [Given(@"the next table of csv representation file")]
        public void GivenTheNextTableOfCsvRepresentationFile(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press convert to XML")]
        public void WhenIPressConvertToXML()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the final result should be '(.*)'")]
        public void ThenTheFinalResultShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
