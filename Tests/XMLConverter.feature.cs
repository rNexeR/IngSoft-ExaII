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
    [NUnit.Framework.DescriptionAttribute("XMLConverter")]
    public partial class XMLConverterFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "XMLConverter.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "XMLConverter", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("convert CSV to XML")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void ConvertCSVToXML()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("convert CSV to XML", new string[] {
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
 testRunner.Given("the next table of csv representation file", ((string)(null)), table1, "Given ");
#line 11
 testRunner.When("I press convert to XML", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 12
 testRunner.Then(@"the final result should be '<Rows><Row><nombre>""nexer""</nombre><apellido>""rodriguez""</apellido><edad>21</edad></Row><Row><nombre>""kevin""</nombre><apellido>""estevez""</apellido><edad>21</edad></Row><Row><nombre>""tonio""</nombre><apellido>""mejia""</apellido><edad>20</edad></Row><Row><nombre>""josue""</nombre><apellido>""barahona""</apellido><edad>21</edad></Row></Rows>'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
