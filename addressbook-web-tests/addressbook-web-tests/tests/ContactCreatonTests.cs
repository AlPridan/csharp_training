using NUnit.Framework;
using System.Collections.Generic;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreatonTests : AuthTestBase
    {
        [Test]
        public void ContactCreatonTest()
        {
            ContactData contact = new ContactData("Micky","Mouse");
            contact.MiddleName = "Rat";
            contact.SecNotes = "some of the text";
            contact.BDay = "12";
            contact.BMonth = "September";
            contact.BYear = "1990";
            contact.LastName = "Mouse";
            contact.NickName = "MickyMouse";
            contact.Address = "2st newYork";
            contact.TelFax = "999";
            contact.Title = "RudeMouse";
            contact.Company = "Disney";
            contact.TelHome = "888";
            contact.TelWork = "777";
            contact.TelMobile = "666";
            contact.Email1 = "mm1@disney.com";
            contact.Email2 = "mm2@disney.com";
            contact.Email3 = "mm3@disney.com";
            contact.HomePage = "neverMore.com";
            contact.SecAddress = "Krizhopol 3st";
            //contact.SecHome = "35 building";
            contact.ADay = "5";
            contact.AMonth = "May";
            contact.AYear = "1995";

            List<ContactData> oldContacts = app.Contacts.GetContactsList();

            app.Contacts.CreateContact(contact);

            List<ContactData> newContacts = app.Contacts.GetContactsList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);
        }
    }
}
