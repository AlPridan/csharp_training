using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactRemovalTests:TestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToHome();
            app.Contacts.SelectChbox(1);
            app.Contacts.Alerts(true);
            app.Groups.DeleteBtn();
            app.Contacts.CloseAlert();
            app.Navigator.GoToHome();
        }


    }
}
