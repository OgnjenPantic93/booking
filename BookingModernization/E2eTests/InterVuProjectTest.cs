using BookingModernization.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;

namespace BookingModernization.E2eTests
{
    public class InterVuProjectTest : BaseContextSetUp
    {
        private InterVuProjectPage interVuProjectPage;

        [SetUp]
        public void InterVuPageOpening()
        {
            interVuProjectPage = new InterVuProjectPage(this);
            interVuProjectPage.NavigateToTheInterVuPage();
        }
        [Test]
        public void EndClientCheckBox()
        {

            interVuProjectPage.EndClient.POFirstName.SendKeys("Ognjen");
            interVuProjectPage.EndClient.POLastName.SendKeys("Pantic");
            interVuProjectPage.EndClient.POEmail.SendKeys("ognjen@test.com");
            interVuProjectPage.EndClient.POPhone.SendKeys("111666");
            interVuProjectPage.EndClient.POCompany.SendKeys("Itekako");
            interVuProjectPage.DropDownCountry("Denmark");

            interVuProjectPage.EndClient.ContactSameAsAbove.Click();
            Assert.IsFalse(interVuProjectPage.EndClient.COCompany.Enabled);
            //Assert.AreEqual("Ognjen", interVuProjectPage.COFirstName.Text);
            //Assert.AreEqual(interVuProjectPage.COFirstName.Text, "Pantic");
            //Assert.AreEqual(interVuProjectPage.COFirstName.Text, "ognjen@test.com");
            //Assert.AreEqual(interVuProjectPage.COFirstName.Text, "111666");
            //Assert.AreEqual(interVuProjectPage.COFirstName.Text, "Itekako");
            //Assert.AreEqual(interVuProjectPage.COFirstName.Text, "Denmark");
        }
        [Test]
        public void EndClientInformaiton()
        {
            SelectElement dropdown = new SelectElement(interVuProjectPage.EndClient.POCountry);
            SelectElement intervju = new SelectElement(interVuProjectPage.EndClient.InterviewType);
            SelectElement cams = new SelectElement(interVuProjectPage.EndClient.UsingWebCams);
            SelectElement market = new SelectElement(interVuProjectPage.EndClient.Market);

            interVuProjectPage.EndClient.POFirstName.SendKeys("Ognjen");
            interVuProjectPage.EndClient.POLastName.SendKeys("Pantic");
            interVuProjectPage.EndClient.POEmail.SendKeys("ognjen@test.com");
            interVuProjectPage.EndClient.POPhone.SendKeys("111666");
            interVuProjectPage.EndClient.POCompany.SendKeys("Itekako");
            dropdown.SelectByText("Denmark");

            interVuProjectPage.EndClient.COFirstName.SendKeys("Irena");
            interVuProjectPage.EndClient.COLastName.SendKeys("Ducic");
            interVuProjectPage.EndClient.COEmail.SendKeys("emailIrena@test.com");
            interVuProjectPage.EndClient.COPhone.SendKeys("123");
            interVuProjectPage.EndClient.COCompany.SendKeys("kocka");
            dropdown.SelectByText("Colombia");

            intervju.SelectByValue("2");
            cams.SelectByText("Yes");
            market.SelectByText("Finland");

            interVuProjectPage.EndClient.AddNerMarket.Click();
            Assert.IsTrue(interVuProjectPage.EndClient.AddedMarket.Enabled);



        }

    }
}
