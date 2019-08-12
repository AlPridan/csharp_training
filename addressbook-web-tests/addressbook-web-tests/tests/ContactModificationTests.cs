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

    public class ContactModificatonTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("MUR","NIT");
            newData.MiddleName = null;
            newData.SecNotes = null;
            newData.BDay = "15";
            newData.BMonth = "April";
            newData.BYear = null;
            newData.LastName = "Lo";
            newData.NickName = null;
            newData.Address = null;
            newData.TelFax = null;
            newData.Title = null;
            newData.Company = null;
            newData.TelHome = null;
            newData.TelWork = null;
            newData.TelMobile = null;
            newData.Email1 = null;
            newData.Email2 = null;
            newData.Email3 = null;
            newData.HomePage = null;
            newData.SecAddress = null;
            newData.SecHome = null;
            newData.ADay = null;
            newData.AMonth = null;
            newData.AYear = null;
            app.Contacts.IfNoContact();

            List<ContactData> oldContacts = app.Contacts.GetContactsList();

            app.Contacts.Modify(0, newData);

            List<ContactData> newContacts = app.Contacts.GetContactsList();
            oldContacts[0].Name = newData.Name;
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}