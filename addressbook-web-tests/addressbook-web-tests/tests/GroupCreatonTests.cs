using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroups();
            app.Groups.InitNewGroupCreation();
            GroupData group = new GroupData("al1");
            group.Header = "al2";
            group.Footer = "al3";
            app.Groups.FillGroupForm(group);
            app.Groups.Submit();
            app.Navigator.GoToGroups();
        }
     }
}
