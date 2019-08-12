using System.Collections.Generic;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests: AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            app.Contacts.IfNoContact();
            List<ContactData> oldContacts = app.Contacts.GetContactsList();

            app.Contacts.RemoveContact(0);

            List<ContactData> newContacts = app.Contacts.GetContactsList();

            oldContacts.RemoveAt(0);
            Assert.AreEqual(oldContacts, newContacts);
        }


    }
}
