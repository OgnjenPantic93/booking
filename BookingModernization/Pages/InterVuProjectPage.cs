using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Linq;

namespace BookingModernization.Pages
{
    public class InterVuProjectPage
    {
        
        private readonly BaseContextSetUp contextSetUp;
        private SelectElement DropDown = new SelectElement(EndClient);

        public InterVuProjectPage(BaseContextSetUp contextSetUp)
        { this.contextSetUp = contextSetUp; }
        public EndClientandMyAgencyDetails EndClient => new EndClientandMyAgencyDetails(contextSetUp);
       
        public void DropDownCountry(string country)
        {
            SelectElement CountryList = new SelectElement(EndClient.POCountry);
            CountryList.SelectByText(country);
        }
        public void Drop

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
