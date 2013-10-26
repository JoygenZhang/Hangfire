﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HangFire.Tests.Server
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class JobManagerFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "JobManager.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Job manager", "\r\n  As a user, I expect that my enqueued jobs will be processed by the Server.", ProgrammingLanguage.CSharp, new string[] {
                        "redis"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "Job manager")))
            {
                HangFire.Tests.Server.JobManagerFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Manager should perform a job")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Job manager")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void ManagerShouldPerformAJob()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Manager should perform a job", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
     testRunner.Then("the job should be performed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Successfully performed job should have the Succeeded state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Job manager")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void SuccessfullyPerformedJobShouldHaveTheSucceededState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully performed job should have the Succeeded state", ((string[])(null)));
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 14
     testRunner.Then("its state should be Succeeded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
      testRunner.And("the job should be removed from the dequeued list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("After performing the broken job, it should have the Failed state")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Job manager")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void AfterPerformingTheBrokenJobItShouldHaveTheFailedState()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("After performing the broken job, it should have the Failed state", ((string[])(null)));
#line 17
this.ScenarioSetup(scenarioInfo);
#line 18
    testRunner.Given("an enqueued broken job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 19
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 20
     testRunner.Then("its state should be Failed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 21
      testRunner.And("the job should be removed from the dequeued list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("An unexisting job should not be processed, but it should be removed from the dequ" +
            "eued list")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Job manager")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void AnUnexistingJobShouldNotBeProcessedButItShouldBeRemovedFromTheDequeuedList()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("An unexisting job should not be processed, but it should be removed from the dequ" +
                    "eued list", ((string[])(null)));
#line 23
this.ScenarioSetup(scenarioInfo);
#line 24
    testRunner.Given("the \'unexisting\' job, that was enqueued", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
     testRunner.Then("there should be no performing actions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
      testRunner.But("the \'unexisting\' job should be removed from the dequeued list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Worker should processes only jobs in the Enqueued state, but it should remove the" +
            " job from the dequeued list anyway")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Job manager")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void WorkerShouldProcessesOnlyJobsInTheEnqueuedStateButItShouldRemoveTheJobFromTheDequeuedListAnyway()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Worker should processes only jobs in the Enqueued state, but it should remove the" +
                    " job from the dequeued list anyway", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 30
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
      testRunner.And("its state is Processing", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 33
     testRunner.Then("the job should not be performed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 34
      testRunner.But("it should be removed from the dequeued list", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "But ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Disposable job should be disposed after processing")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "Job manager")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("redis")]
        public virtual void DisposableJobShouldBeDisposedAfterProcessing()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Disposable job should be disposed after processing", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
    testRunner.Given("an enqueued job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
     testRunner.When("the manager processes the next job", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 39
     testRunner.Then("the job should be disposed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
