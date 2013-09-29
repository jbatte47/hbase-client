﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18213
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace _specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("HBase JSON")]
    public partial class HBaseJSONFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "HBaseJson.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "HBase JSON", "In order to work with HBase content in the JSON format\r\nAs an application develop" +
                    "er\r\nI want to be able to create and parse HBase JSON content using basic informa" +
                    "tion", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Create JSON for single cell")]
        [NUnit.Framework.TestCaseAttribute("1", "alpha", "", "", "hello world", "HBaseJson_1Alpha_HelloWorld", null)]
        [NUnit.Framework.TestCaseAttribute("1", "alpha", "x", "", "hello world", "HBaseJson_1AlphaX_HelloWorld", null)]
        [NUnit.Framework.TestCaseAttribute("1", "alpha", "", "4", "hello world", "HBaseJson_1Alpha4_HelloWorld", null)]
        [NUnit.Framework.TestCaseAttribute("1", "alpha", "x", "4", "hello world", "HBaseJson_1AlphaX4_HelloWorld", null)]
        public virtual void CreateJSONForSingleCell(string row, string column, string qualifier, string timestamp, string value, string expectedJson, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create JSON for single cell", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("I have a cell with a {0}, {1}, {2}, {3}, and {4}", row, column, qualifier, timestamp, value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.When("I convert my cell to JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
 testRunner.Then(string.Format("my JSON content should be equivalent to the resource called \"{0}\"", expectedJson), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Parse JSON for single cell")]
        [NUnit.Framework.TestCaseAttribute("HBaseJson_1Alpha_HelloWorld", "1", "alpha", "", "", "hello world", null)]
        [NUnit.Framework.TestCaseAttribute("HBaseJson_1AlphaX_HelloWorld", "1", "alpha", "x", "", "hello world", null)]
        [NUnit.Framework.TestCaseAttribute("HBaseJson_1Alpha4_HelloWorld", "1", "alpha", "", "4", "hello world", null)]
        [NUnit.Framework.TestCaseAttribute("HBaseJson_1AlphaX4_HelloWorld", "1", "alpha", "x", "4", "hello world", null)]
        public virtual void ParseJSONForSingleCell(string initialJson, string row, string column, string qualifier, string timestamp, string value, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parse JSON for single cell", exampleTags);
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
 testRunner.Given(string.Format("I have JSON content equal to the resource called \"{0}\"", initialJson), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
 testRunner.When("I convert my JSON to a cell", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
 testRunner.Then(string.Format("my cell should have a {0}, {1}, {2}, {3}, and {4}", row, column, qualifier, timestamp, value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Create JSON for a set of cells")]
        public virtual void CreateJSONForASetOfCells()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create JSON for a set of cells", ((string[])(null)));
#line 28
this.ScenarioSetup(scenarioInfo);
#line 29
 testRunner.Given("I have created a set of cells", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "row",
                        "column",
                        "qualifier",
                        "timestamp",
                        "value"});
            table1.AddRow(new string[] {
                        "1",
                        "alpha",
                        "",
                        "",
                        "hello world"});
#line 30
 testRunner.And("I have added a cell to my set with the following properties:", ((string)(null)), table1, "And ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "row",
                        "column",
                        "qualifier",
                        "timestamp",
                        "value"});
            table2.AddRow(new string[] {
                        "1",
                        "alpha",
                        "x",
                        "",
                        "hello world"});
#line 33
 testRunner.And("I have added a cell to my set with the following properties:", ((string)(null)), table2, "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "row",
                        "column",
                        "qualifier",
                        "timestamp",
                        "value"});
            table3.AddRow(new string[] {
                        "1",
                        "alpha",
                        "",
                        "4",
                        "hello world"});
#line 36
 testRunner.And("I have added a cell to my set with the following properties:", ((string)(null)), table3, "And ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "row",
                        "column",
                        "qualifier",
                        "timestamp",
                        "value"});
            table4.AddRow(new string[] {
                        "1",
                        "alpha",
                        "x",
                        "4",
                        "hello world"});
#line 39
 testRunner.And("I have added a cell to my set with the following properties:", ((string)(null)), table4, "And ");
#line 42
 testRunner.When("I convert my set of cells to JSON", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 43
 testRunner.Then("my JSON content should be equivalent to the resource called \"HBaseJson_Set_HelloW" +
                    "orld\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Parse JSON for a set of cells")]
        public virtual void ParseJSONForASetOfCells()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Parse JSON for a set of cells", ((string[])(null)));
#line 45
this.ScenarioSetup(scenarioInfo);
#line 46
 testRunner.Given("I have JSON content equal to the resource called \"HBaseJson_Set_HelloWorld\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 47
 testRunner.When("I convert my JSON to a set of cells", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.Then("my set should contain 4 cells", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "row",
                        "column",
                        "qualifier",
                        "timestamp",
                        "value"});
            table5.AddRow(new string[] {
                        "1",
                        "alpha",
                        "",
                        "",
                        "hello world"});
#line 49
 testRunner.And("one of the cells in my set should have the following properties:", ((string)(null)), table5, "And ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "row",
                        "column",
                        "qualifier",
                        "timestamp",
                        "value"});
            table6.AddRow(new string[] {
                        "1",
                        "alpha",
                        "x",
                        "",
                        "hello world"});
#line 52
 testRunner.And("one of the cells in my set should have the following properties:", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "row",
                        "column",
                        "qualifier",
                        "timestamp",
                        "value"});
            table7.AddRow(new string[] {
                        "1",
                        "alpha",
                        "",
                        "4",
                        "hello world"});
#line 55
 testRunner.And("one of the cells in my set should have the following properties:", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "row",
                        "column",
                        "qualifier",
                        "timestamp",
                        "value"});
            table8.AddRow(new string[] {
                        "1",
                        "alpha",
                        "x",
                        "4",
                        "hello world"});
#line 58
 testRunner.And("one of the cells in my set should have the following properties:", ((string)(null)), table8, "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
