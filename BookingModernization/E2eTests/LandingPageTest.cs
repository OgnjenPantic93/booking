using BookingModernization.Pages;
using NUnit.Framework;

namespace BookingModernization.E2eTests
{
    public class LandingPageTest : BaseContextSetUp
    {
        private LandingPage landingPage;
        private ForstaProjectPage forstaProjectPage;

        [SetUp]
        public void LandingPage()
        {
            landingPage = new LandingPage(this);
            landingPage.NavigateToBooking();
            landingPage.LandingIsSuccesfull();
        }

        [Test]
        public void TestCase1()
        {
            landingPage.ContinueAsGuest();
            forstaProjectPage = new ForstaProjectPage(this);
            forstaProjectPage.loadedSuccessfull();
            forstaProjectPage.InterVuBookNow();
        }

    }
}
