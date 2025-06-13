﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace TestingToolshopDemoWithSelenium.Features
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CreateAnAccount")]
    [NUnit.Framework.FixtureLifeCycleAttribute(NUnit.Framework.LifeCycle.InstancePerTestCase)]
    public partial class CreateAnAccountFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "CreateAnAccount", "As a user, I want to be able to navigate to the sign in page, click \"Register you" +
                "r account\",\r\nand be redirected to a page containing a form that I can fill out, " +
                "submit, and then be taken \r\nback to the sign in page.", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "CreateAnAccount.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I fill out the form with valid information and an account is created")]
        [NUnit.Framework.CategoryAttribute("happy")]
        [NUnit.Framework.TestCaseAttribute("John", "Smith", "01/01/1982", "1 Fake Street", "FA65 9AL", "Fake City", "Fake", "United Kingdom", "01234567890", "fake.email@hotmail.com", "52x+8=Hc79FjRTQ9", null)]
        [NUnit.Framework.TestCaseAttribute("Sarah-Jane", "Smith", "14/04/1987", "5 Fake Lane", "FA89 9YZ", "Fake City", "Fake", "United Kingdom", "01433567790", "sarah.j.smith@hotmail.com", "5W4WHsFL!+b$9!pQ", null)]
        public async System.Threading.Tasks.Task IFillOutTheFormWithValidInformationAndAnAccountIsCreated(string firstName, string lastName, string dateOfBirth, string street, string postalCode, string city, string state, string country, string phone, string email, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "happy"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("firstName", firstName);
            argumentsOfScenario.Add("lastName", lastName);
            argumentsOfScenario.Add("dateOfBirth", dateOfBirth);
            argumentsOfScenario.Add("street", street);
            argumentsOfScenario.Add("postalCode", postalCode);
            argumentsOfScenario.Add("city", city);
            argumentsOfScenario.Add("state", state);
            argumentsOfScenario.Add("country", country);
            argumentsOfScenario.Add("phone", phone);
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("password", password);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("I fill out the form with valid information and an account is created", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 8
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 9
 await testRunner.GivenAsync("I am on the home page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 10
 await testRunner.WhenAsync("I click \"Sign In\" in the nav bar", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 11
 await testRunner.AndAsync("I click \"Register your account\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
                global::Reqnroll.Table table1 = new global::Reqnroll.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth",
                            "Street",
                            "PostalCode",
                            "City",
                            "State",
                            "Country",
                            "Phone",
                            "Email",
                            "Password"});
                table1.AddRow(new string[] {
                            string.Format("{0}", firstName),
                            string.Format("{0}", lastName),
                            string.Format("{0}", dateOfBirth),
                            string.Format("{0}", street),
                            string.Format("{0}", postalCode),
                            string.Format("{0}", city),
                            string.Format("{0}", state),
                            string.Format("{0}", country),
                            string.Format("{0}", phone),
                            string.Format("{0}", email),
                            string.Format("{0}", password)});
#line 12
 await testRunner.AndAsync("I fill out the form with the following information:", ((string)(null)), table1, "And ");
#line hidden
#line 15
 await testRunner.AndAsync("I click on the \"Register\" button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 16
 await testRunner.ThenAsync("I am taken to the sign in page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I click the \"Register\" button without filling out the form")]
        [NUnit.Framework.CategoryAttribute("sad")]
        [NUnit.Framework.TestCaseAttribute("", "", "", "", "", "", "", "", "", "", "", null)]
        public async System.Threading.Tasks.Task IClickTheRegisterButtonWithoutFillingOutTheForm(string firstName, string lastName, string dateOfBirth, string street, string postalCode, string city, string state, string country, string phone, string email, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "sad"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("firstName", firstName);
            argumentsOfScenario.Add("lastName", lastName);
            argumentsOfScenario.Add("dateOfBirth", dateOfBirth);
            argumentsOfScenario.Add("street", street);
            argumentsOfScenario.Add("postalCode", postalCode);
            argumentsOfScenario.Add("city", city);
            argumentsOfScenario.Add("state", state);
            argumentsOfScenario.Add("country", country);
            argumentsOfScenario.Add("phone", phone);
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("password", password);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("I click the \"Register\" button without filling out the form", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 24
 await testRunner.GivenAsync("I am on the home page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 25
 await testRunner.WhenAsync("I click \"Sign In\" in the nav bar", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 26
 await testRunner.AndAsync("I click \"Register your account\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
                global::Reqnroll.Table table2 = new global::Reqnroll.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth",
                            "Street",
                            "PostalCode",
                            "City",
                            "State",
                            "Country",
                            "Phone",
                            "Email",
                            "Password"});
                table2.AddRow(new string[] {
                            string.Format("{0}", firstName),
                            string.Format("{0}", lastName),
                            string.Format("{0}", dateOfBirth),
                            string.Format("{0}", street),
                            string.Format("{0}", postalCode),
                            string.Format("{0}", city),
                            string.Format("{0}", state),
                            string.Format("{0}", country),
                            string.Format("{0}", phone),
                            string.Format("{0}", email),
                            string.Format("{0}", password)});
#line 27
 await testRunner.AndAsync("I fill out the form with the following information:", ((string)(null)), table2, "And ");
#line hidden
#line 30
 await testRunner.AndAsync("I click on the \"Register\" button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 31
 await testRunner.ThenAsync("I receive an error message for each field", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I try to create various valid and invalid passwords")]
        [NUnit.Framework.TestCaseAttribute("John", "Smith", "01/01/1982", "1 Fake Street", "FA65 9AL", "Fake City", "Fake", "United Kingdom", "01234567890", "fake.email@hotmail.com", "", null)]
        [NUnit.Framework.TestCaseAttribute("John", "Smith", "01/01/1982", "1 Fake Street", "FA65 9AL", "Fake City", "Fake", "United Kingdom", "01234567890", "fake.email@hotmail.com", "P", null)]
        [NUnit.Framework.TestCaseAttribute("John", "Smith", "01/01/1982", "1 Fake Street", "FA65 9AL", "Fake City", "Fake", "United Kingdom", "01234567890", "fake.email@hotmail.com", "Passwor", null)]
        [NUnit.Framework.TestCaseAttribute("John", "Smith", "01/01/1982", "1 Fake Street", "FA65 9AL", "Fake City", "Fake", "United Kingdom", "01234567890", "fake.email@hotmail.com", "Egj@svn1", null)]
        public async System.Threading.Tasks.Task ITryToCreateVariousValidAndInvalidPasswords(string firstName, string lastName, string dateOfBirth, string street, string postalCode, string city, string state, string country, string phone, string email, string password, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("firstName", firstName);
            argumentsOfScenario.Add("lastName", lastName);
            argumentsOfScenario.Add("dateOfBirth", dateOfBirth);
            argumentsOfScenario.Add("street", street);
            argumentsOfScenario.Add("postalCode", postalCode);
            argumentsOfScenario.Add("city", city);
            argumentsOfScenario.Add("state", state);
            argumentsOfScenario.Add("country", country);
            argumentsOfScenario.Add("phone", phone);
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("password", password);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("I try to create various valid and invalid passwords", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 37
 await testRunner.GivenAsync("I am on the home page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 38
 await testRunner.WhenAsync("I click \"Sign In\" in the nav bar", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 39
 await testRunner.AndAsync("I click \"Register your account\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
                global::Reqnroll.Table table3 = new global::Reqnroll.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth",
                            "Street",
                            "PostalCode",
                            "City",
                            "State",
                            "Country",
                            "Phone",
                            "Email",
                            "Password"});
                table3.AddRow(new string[] {
                            string.Format("{0}", firstName),
                            string.Format("{0}", lastName),
                            string.Format("{0}", dateOfBirth),
                            string.Format("{0}", street),
                            string.Format("{0}", postalCode),
                            string.Format("{0}", city),
                            string.Format("{0}", state),
                            string.Format("{0}", country),
                            string.Format("{0}", phone),
                            string.Format("{0}", email),
                            string.Format("{0}", password)});
#line 40
 await testRunner.AndAsync("I fill out the form with the following information:", ((string)(null)), table3, "And ");
#line hidden
#line 43
 await testRunner.AndAsync("I click on the \"Register\" button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 44
 await testRunner.ThenAsync("The password is either valid or invalid", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("I try to create an account when one already exists with the same email")]
        [NUnit.Framework.CategoryAttribute("sad")]
        [NUnit.Framework.TestCaseAttribute("Jane", "Doe", "1992-07-24", "5 Fake Lane", "FA74 9YZ", "Fake City", "Fake", "United Kingdom", "01833264720", "customer@practicesoftwaretesting.com", "4i3AF-F1r7E2qEsq", null)]
        public async System.Threading.Tasks.Task ITryToCreateAnAccountWhenOneAlreadyExistsWithTheSameEmail(string firstName, string lastName, string dateOfBirth, string street, string postalCode, string city, string state, string country, string phone, string email, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "sad"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("firstName", firstName);
            argumentsOfScenario.Add("lastName", lastName);
            argumentsOfScenario.Add("dateOfBirth", dateOfBirth);
            argumentsOfScenario.Add("street", street);
            argumentsOfScenario.Add("postalCode", postalCode);
            argumentsOfScenario.Add("city", city);
            argumentsOfScenario.Add("state", state);
            argumentsOfScenario.Add("country", country);
            argumentsOfScenario.Add("phone", phone);
            argumentsOfScenario.Add("email", email);
            argumentsOfScenario.Add("password", password);
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("I try to create an account when one already exists with the same email", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 53
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
#line 54
 await testRunner.GivenAsync("I am on the home page", ((string)(null)), ((global::Reqnroll.Table)(null)), "Given ");
#line hidden
#line 55
 await testRunner.WhenAsync("I click \"Sign In\" in the nav bar", ((string)(null)), ((global::Reqnroll.Table)(null)), "When ");
#line hidden
#line 56
 await testRunner.AndAsync("I click \"Register your account\"", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
                global::Reqnroll.Table table4 = new global::Reqnroll.Table(new string[] {
                            "FirstName",
                            "LastName",
                            "DateOfBirth",
                            "Street",
                            "PostalCode",
                            "City",
                            "State",
                            "Country",
                            "Phone",
                            "Email",
                            "Password"});
                table4.AddRow(new string[] {
                            string.Format("{0}", firstName),
                            string.Format("{0}", lastName),
                            string.Format("{0}", dateOfBirth),
                            string.Format("{0}", street),
                            string.Format("{0}", postalCode),
                            string.Format("{0}", city),
                            string.Format("{0}", state),
                            string.Format("{0}", country),
                            string.Format("{0}", phone),
                            string.Format("{0}", email),
                            string.Format("{0}", password)});
#line 57
 await testRunner.AndAsync("I fill out the form with the following information:", ((string)(null)), table4, "And ");
#line hidden
#line 60
 await testRunner.AndAsync("I click on the \"Register\" button", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 61
 await testRunner.ThenAsync("I receive an error message stating that an account already exists", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
