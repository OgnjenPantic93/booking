using System;
using System.Linq;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace BookingModernization.Pages
{
    public class LandingPage
    {
        private readonly BaseContextSetUp contextSetUp;
        private IWebElement ContinueAsGuestButton { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@href='/booking']"))); }
        private IWebElement CreatAnAccountButton { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(""))); }
        private IWebElement RequestADemoButton { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(""))); }
        private IWebElement LogInButton { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.Id(""))); }
        private IWebElement Title { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@title='Forsta']"))); }

        public LandingPage(BaseContextSetUp contextSetUp)
        {
            this.contextSetUp = contextSetUp;
        }

        public void ContinueAsGuest() => ContinueAsGuestButton.Click();
        public void CreatAnAccount() => CreatAnAccountButton.Click();
        public void RequestADemo() => RequestADemoButton.Click();
        public void LogIn() => LogInButton.Click();

        public void NavigateToBooking()
        {
            contextSetUp.Browser.Navigate().GoToUrl(contextSetUp.BookingAppBaseUrl);
        }
        public bool LandingIsSuccesfull()
        {
            return ContinueAsGuestButton.Displayed;
            Assert.AreEqual("Forsta", Title.Text);
        }
    }
}
