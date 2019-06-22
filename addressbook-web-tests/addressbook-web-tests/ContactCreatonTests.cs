using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreatonTests : TestBase
    {
        [Test]
        public void ContactCreatonTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToNewContact();
            ContactData group = new ContactData("Micky");
            group.MiddleName = "Rat";
            group.SecNotes = "some of the text";
            group.BDay = "12";
            group.BMonth = "September";
            group.BYear = "1990";
            group.LastName = "Mouse";
            group.NickName = "MickyMouse";
            group.Address = "2st newYork";
            group.TelFax = "999";
            group.Title = "RudeMouse";
            group.Company = "Disney";
            group.TelHome = "888";
            group.TelWork = "777";
            group.TelMobile = "666";
            group.Email1 = "mm1@disney.com";
            group.Email2 = "mm2@disney.com";
            group.Email3 = "mm3@disney.com";
            group.HomePage = "neverMore.com";
            group.SecAddress = "Krizhopol 3st";
            group.SecHome = "35 building";
            group.ADay = "5";
            group.AMonth = "May";
            group.AYear = "1995";
            FillContactForm(group);
            Submit();
        }

    }
}
