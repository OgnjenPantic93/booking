using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Drawing;

namespace BookingModernization
{
    public class BaseContextSetUp
    {
        private readonly ReportGenerator reportGenerator = new ReportGenerator();
        private string testName;
        public IWebDriver Browser { get; private set; }
        public Uri BookingAppBaseUrl { get; private set; }
        public WebDriverWait Wait { get; private set; }

        [SetUp]
        public void TestBeging()
        {
            testName = TestContext.CurrentContext.Test.Name;
            reportGenerator.CreateTestInReport(testName);

            ChromeOptions chromeOption = new ChromeOptions();
            //chromeOption.AddArguments("--headless=new");
            Browser = new ChromeDriver(chromeOption);

            Browser.Manage().Window.Size = new Size(1936, 1048);
            BookingAppBaseUrl = new Uri("http://modernization-frontend.s3-website-us-east-1.amazonaws.com/");
            Wait = new WebDriverWait(Browser, TimeSpan.FromSeconds(double.Parse("10")));

        }

        [TearDown]
        public void TestEnd()
        {
            string TestPath = TestContext.CurrentContext.Test.FullName;
            TestStatus status = TestContext.CurrentContext.Result.Outcome.Status;
            string message = TestContext.CurrentContext.Result.Message;
            string stackTrace = string.Empty + TestContext.CurrentContext.Result.StackTrace;
            reportGenerator.AddTestsResultToReport(testName, TestPath, status, message, stackTrace, Browser);

            Browser.Dispose();
        }
    }
}
