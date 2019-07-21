using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]

    public class ContactModificatonTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("mod1");
            newData.MiddleName = "Rattington";
            newData.SecNotes = "some of the text";
            newData.BDay = "5";
            newData.BMonth = "May";
            newData.BYear = "1980";
            newData.LastName = "Albatros";
            newData.NickName = "MickyMouse";
            newData.Address = "1st newYork";
            newData.TelFax = "919";
            newData.Title = "RudeMouse";
            newData.Company = "Disney";
            newData.TelHome = "888";
            newData.TelWork = "777";
            newData.TelMobile = "666";
            newData.Email1 = "xx1@disney.com";
            newData.Email2 = "xx2@disney.com";
            newData.Email3 = "xx3@disney.com";
            newData.HomePage = "everMore.com";
            newData.SecAddress = "Krizhopol 3st";
            newData.SecHome = "5 building";
            newData.ADay = "20";
            newData.AMonth = "April";
            newData.AYear = "1999";

            app.Contacts.Modify(2, newData);
        }
    }
}