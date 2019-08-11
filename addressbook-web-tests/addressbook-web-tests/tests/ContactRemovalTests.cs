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
            app.Contacts.RemoveContact(1);
        }


    }
}
