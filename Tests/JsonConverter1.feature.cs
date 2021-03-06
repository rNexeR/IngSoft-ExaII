﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.1.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("JsonConverter")]
    public partial class JsonConverterFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "JsonConverter.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "JsonConverter", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("convert CSV to JSON")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ConvertCSVToJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("convert CSV to JSON", new string[] {
                        "mytag"});
#line 4
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "nombre",
                        "apellido",
                        "edad"});
            table1.AddRow(new string[] {
                        "nexer",
                        "rodriguez",
                        "21"});
            table1.AddRow(new string[] {
                        "kevin",
                        "estevez",
                        "21"});
            table1.AddRow(new string[] {
                        "tonio",
                        "mejia",
                        "20"});
            table1.AddRow(new string[] {
                        "josue",
                        "barahona",
                        "21"});
#line 5
 testRunner.Given("the next table representation of csv file", ((string)(null)), table1, "Given ");
#line 11
 testRunner.When("I press convert to Json", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then("the result should be \'{\"Rows\":[{\"nombre\":\"nexer\",\"apellido\":\"rodriguez\",\"edad\":21" +
                    "},{\"nombre\":\"kevin\",\"apellido\":\"estevez\",\"edad\":21},{\"nombre\":\"tonio\",\"apellido\"" +
                    ":\"mejia\",\"edad\":20},{\"nombre\":\"josue\",\"apellido\":\"barahona\",\"edad\":21}]}\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
