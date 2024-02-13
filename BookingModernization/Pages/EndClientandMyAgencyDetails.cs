using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Linq;

namespace BookingModernization.Pages
{
    public class EndClientandMyAgencyDetails
    {
        private readonly BaseContextSetUp contextSetUp;
        private IWebElement NextButton { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("//*[@id='client - and - agency - collapse - body']/div/button"))); }
        private IWebElement EndClinedExpandCollaps { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.Id("//*[@id='client - and - agency - collapse - body']"))); }
        public IWebElement ContactSameAsAbove { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/div[1]/label/input"))); }

        public EndClientandMyAgencyDetails(BaseContextSetUp contextSetUp)
        { this.contextSetUp = contextSetUp; }
        public IWebElement POFirstName { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[1]/app-new-user-details/div/app-input-control[1]/div/input"))); }
        public IWebElement POLastName { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[1]/app-new-user-details/div/app-input-control[2]/div/input"))); }
        public IWebElement POEmail { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section [1]/app-new-user-details/div/app-input-control[3]/div/input"))); }
        public IWebElement POPhone { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[1]/app-new-user-details/div/app-input-control[4]/div/input"))); }
        public IWebElement POCompany { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[1]/app-new-user-details/div/app-input-control[5]/div/input"))); }
        public IWebElement POCountry { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[1]/app-new-user-details/div/app-select-control/div/select"))); }
        public IWebElement COFirstName { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/app-new-user-details/div/app-input-control[1]/div/input"))); }
        public IWebElement COLastName { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/app-new-user-details/div/app-input-control[2]/div/input"))); }
        public IWebElement COEmail { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/app-new-user-details/div/app-input-control[3]/div/input"))); }
        public IWebElement COPhone { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/app-new-user-details/div/app-input-control[4]/div/input"))); }
        public IWebElement COCompany { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/app-new-user-details/div/app-input-control[5]/div/input"))); }
        public IWebElement COCountry { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/div[2]/div[2]/app-select-control/div/select"))); }
        public IWebElement InterviewType => contextSetUp.Browser.FindElement(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/div[2]/div[4]/div[2]/app-respondent-market/div/div[1]/app-select-control/div/select"));
        public IWebElement UsingWebCams => contextSetUp.Browser.FindElement(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/div[2]/div[2]/app-select-control/div/select"));
        public IWebElement Market => contextSetUp.Browser.FindElement(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/div[2]/div[4]/div/app-respondent-market/div/div[1]/app-select-control/div/select"));
        public IWebElement AddNerMarket => contextSetUp.Browser.FindElement(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/div[2]/div[4]/div[2]/div/button[2]"));
        public IWebElement Remove => contextSetUp.Browser.FindElement(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/div[2]/div[4]/div[2]/div/button[1]"));
        public IWebElement AddedMarket => contextSetUp.Browser.FindElement(By.XPath("//*[@id='client-and-agency-collapse-body']/div/div/section[2]/div[2]/div[4]/div[2]/app-respondent-market/div/div[1]/app-select-control/div/select"));
    }
}
