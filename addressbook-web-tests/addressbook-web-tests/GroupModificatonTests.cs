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

    public class GroupModificatonTests:TestBase
    {
        [Test]
        public void GroupModificatioTest()
        {
            GroupData newData = new GroupData("mod1");
            newData.Header = "mod2";
            newData.Footer = "mod3";

            app.Groups.Modify(1, newData);
        }
    }
}
