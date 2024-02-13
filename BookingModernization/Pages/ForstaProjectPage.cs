using System;
using System.Linq;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

namespace BookingModernization.Pages
{
    public class ForstaProjectPage
    {
        private readonly BaseContextSetUp contextSetUp;
        private IWebElement InterVuProjcetButton { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@href='/booking/intervu/book-a-project']"))); }
        private IWebElement ForstaProjectLiveButton { get => contextSetUp.Wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@href='/booking/vision/book-a-project']"))); }

        public ForstaProjectPage(BaseContextSetUp contextSetUp)
        {
            this.contextSetUp = contextSetUp;
        }

        public void InterVuBookNow() => InterVuProjcetButton.Click();
        public void LiveBookNow() => ForstaProjectLiveButton.Click();
        public bool loadedSuccessfull()
        {
            contextSetUp.Wait.Until(_ => "booking" == new Uri(_.Url).Segments.Last());
            return InterVuProjcetButton.Displayed;
        }
    }
}
