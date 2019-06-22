using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GropCreationTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroups();
            InitNewGroupCreation();
            GroupData group = new GroupData("al1");
            group.Header = "al2";
            group.Footer = "al3";
            FillGroupForm(group);
            Submit();
            GoToGroups();
        }
     }
}
