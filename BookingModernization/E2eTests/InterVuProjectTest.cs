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
            interVuProjectPage.DropDownCountry(interVuProjectPage.EndClient.POCountry, "Denmark");

            interVuProjectPage.EndClient.ContactSameAsAbove.Click();
            Assert.IsFalse(interVuProjectPage.EndClient.COCompany.Enabled);
            //Assert.AreEqual("Ognjen", interVuProjectPage.COFirstName.Text); --- Ovde mi vraća prazan string, kad je disablovano kao da je prazan.
            //Assert.AreEqual("Pantic", interVuProjectPage.COFirstName.Text); --- Moram malo bolje da istražim šta je i kako da dođem do rešenja. 
            //Assert.AreEqual("ognjen@test.com"interVuProjectPage.COFirstName.Text);
            //Assert.AreEqual("111666", interVuProjectPage.COFirstName.Text);
            //Assert.AreEqual("Itekako", interVuProjectPage.COFirstName.Text);
            //Assert.AreEqual("Denmark"interVuProjectPage.COFirstName.Text);
        }
        [Test]
        public void EndClientInformaiton()
        {

            interVuProjectPage.EndClient.POFirstName.SendKeys("Ognjen");
            interVuProjectPage.EndClient.POLastName.SendKeys("Pantic");
            interVuProjectPage.EndClient.POEmail.SendKeys("ognjen@test.com");
            interVuProjectPage.EndClient.POPhone.SendKeys("111666");
            interVuProjectPage.EndClient.POCompany.SendKeys("Itekako");
            interVuProjectPage.DropDownCountry(interVuProjectPage.EndClient.POCountry ,"Denmark");

            interVuProjectPage.EndClient.COFirstName.SendKeys("Irena");
            interVuProjectPage.EndClient.COLastName.SendKeys("Ducic");
            interVuProjectPage.EndClient.COEmail.SendKeys("emailIrena@test.com");
            interVuProjectPage.EndClient.COPhone.SendKeys("123");
            interVuProjectPage.EndClient.COCompany.SendKeys("kocka");

            interVuProjectPage.DropDownInterviewType(interVuProjectPage.EndClient.InterviewType, "2");


            interVuProjectPage.EndClient.AddNerMarket.Click();
            Assert.IsTrue(interVuProjectPage.EndClient.AddedMarket.Enabled);
        }

        [Test]
        public void hoverOverToolTip()
        {
            interVuProjectPage.toolTip(interVuProjectPage.EndClient.PhoneToolTip, interVuProjectPage.EndClient.HoverToolTip, "Enter your country code and phone number (drop the 0).");
        }

    }
}
