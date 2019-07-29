using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupCreationTests : AuthTestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("al1");
            group.Header = "al2";
            group.Footer = "al3";

            app.Groups.CreateGroup(group);
        }

        [Test]
        public void EmprtyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.Groups.CreateGroup(group);
        }
    }
}
