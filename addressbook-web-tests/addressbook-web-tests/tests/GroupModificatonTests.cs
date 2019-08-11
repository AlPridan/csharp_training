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

    public class GroupModificatonTests: AuthTestBase
    {
        [Test]
        public void GroupModificatioTest()
        {
            GroupData newData = new GroupData("mod1");
            newData.Header = null;
            newData.Footer = null;

            app.Groups.IfNoGroup();
            app.Groups.Modify(1, newData);
        }
    }
}
