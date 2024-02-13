using System.IO;
using NUnit.Framework;
using OpenQA.Selenium;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework.Interfaces;

namespace BookingModernization
{
    [SetUpFixture]
    class ReportGenerator
    {
        private static readonly AventStack.ExtentReports.ExtentReports report = new AventStack.ExtentReports.ExtentReports();
        private ExtentTest test;
        private readonly ExtentV3HtmlReporter htmlReporter;
        private readonly string reportPath = TestContext.CurrentContext.TestDirectory + "\\Report";

        public ReportGenerator()
        {
            htmlReporter = new ExtentV3HtmlReporter(reportPath + "\\ExtentReport.html");
            htmlReporter.Config.DocumentTitle = "Report";
            htmlReporter.Config.ReportName = "Automation Testing Report";
            report.AttachReporter(htmlReporter);
        }

        [OneTimeSetUp]
        public void TestSuiteStart()
        {
            if (Directory.Exists(reportPath))
            {
                Directory.Delete(reportPath, true);
            }
            Directory.CreateDirectory(reportPath);
        }

        public void CreateTestInReport(string testName) => test = report.CreateTest(testName);

        public void AddTestsResultToReport(string testName, string testPath, TestStatus status, string message, string stacktrace, IWebDriver browser)
        {
            switch (status)
            {
                case TestStatus.Passed:
                    test.Log(Status.Pass, testPath);
                    break;
                case TestStatus.Failed:
                    test.Log(Status.Fail, message + ". Stacktrace: " + stacktrace);
                    TakeScreenshot(testName, browser);
                    break;
                case TestStatus.Skipped:
                    test.Log(Status.Skip, message + " Stacktrace: " + stacktrace);
                    break;
                default:
                    test.Log(Status.Warning, message + " Stacktrace: " + stacktrace);
                    break;
            }
        }

        private void TakeScreenshot(string testName, IWebDriver browser)
        {
            var screenshotPath = (reportPath + $"\\{testName}_exception.png").ToString();
            ((ITakesScreenshot)browser).GetScreenshot().SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);
        }

        [OneTimeTearDown]
        public void TestSuiteEnd() => report.Flush();
    }
}
