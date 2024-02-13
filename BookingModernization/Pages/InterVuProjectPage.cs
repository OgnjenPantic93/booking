using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;
using System;
using System.Linq;
using NUnit.Framework;

namespace BookingModernization.Pages
{
    public class InterVuProjectPage
    {
        
        private readonly BaseContextSetUp contextSetUp;
        private readonly Actions action;

        public InterVuProjectPage(BaseContextSetUp contextSetUp)
        { this.contextSetUp = contextSetUp; }
        public EndClientandMyAgencyDetails EndClient => new EndClientandMyAgencyDetails(contextSetUp);
       
        public void DropDownCountry(IWebElement element, string country)
        {
            SelectElement CountryList = new SelectElement(element);
            CountryList.SelectByText(country);
        }
        public void DropDownInterviewType(IWebElement InterviewType, string i)
        {
            SelectElement interviewType = new SelectElement(InterviewType);
            interviewType.SelectByValue(i);
        }
        public void toolTip(IWebElement toolTip, IWebElement toolTipHover, string toolTipText)      //Ne radi hover iz nekog razloga
        {
            action.ClickAndHold(toolTip).Build().Perform();
            Assert.AreEqual(toolTipText, toolTipHover.Text);
        }

        public void NavigateToTheInterVuPage()
        {
            var urlInterVu = new UriBuilder(contextSetUp.BookingAppBaseUrl)
            {
                Path = "booking/intervu/book-a-project"
            };
            contextSetUp.Browser.Navigate().GoToUrl(urlInterVu.Uri);
        }

    }
}
