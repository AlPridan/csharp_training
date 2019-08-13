using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace WebAddressbookTests
{
    public class ContactHelper:HelperBase
    {
        protected bool acceptNextAlert;

        public ContactHelper(ApplicationManager manager) 
            : base(manager)
        {
        }

        public ContactData GetContactInformationFromTable(int index)
        {
            manager.Navigator.GoToHome();

            IList<IWebElement> cells = driver.FindElements(By.Name("entry"))[index]
                .FindElements(By.TagName("td"));
            string lastName = cells[1].Text;
            string firstName = cells[2].Text;
            string address = cells[3].Text;
            string allEmail = cells[4].Text;
            string allPhones = cells[5].Text;

            return new ContactData(firstName, lastName)
            {
                Address = address,
                AllPhones = allPhones,
                AllEmail = allEmail
            };
        }

        public ContactData GetContactInformationFromEditFrom(int index)
        {
            manager.Navigator.GoToHome();
            InitContactModification(0);
            string firstName = driver.FindElement(By.Name("firstname")).GetAttribute("value");
            string lastName = driver.FindElement(By.Name("lastname")).GetAttribute("value");
            string address = driver.FindElement(By.Name("address")).GetAttribute("value");

            string homePhone = driver.FindElement(By.Name("home")).GetAttribute("value");
            string mobilePhone = driver.FindElement(By.Name("mobile")).GetAttribute("value");
            string workPhone = driver.FindElement(By.Name("work")).GetAttribute("value");

            string email1 = driver.FindElement(By.Name("email")).GetAttribute("value");
            string email2 = driver.FindElement(By.Name("email2")).GetAttribute("value");
            string email3 = driver.FindElement(By.Name("email3")).GetAttribute("value");

            return new ContactData(firstName, lastName)
            {
                Address = address,
                TelHome = homePhone,
                TelMobile = mobilePhone,
                TelWork = workPhone,
                Email1 = email1,
                Email2 = email2,
                Email3 = email3
            };
        }

        public ContactHelper RemoveContact(int b)
        {
            manager.Navigator.GoToHome();
            SelectChbox(b);
            Alerts(true);
            DeleteBtn();
            CloseAlert();
            manager.Navigator.GoToHome();
            return this;
        }

        public ContactHelper IfNoContact()
        {
            if (!IsElementPresent(By.Name("selected[]")))
            {
                ContactData contact = new ContactData("someone","else");
                contact.Address = "Street";
                contact.LastName = "Fun";
                CreateContact(contact);
            }
            return this;
        }

        public ContactHelper Modify(int b, ContactData newData)
        {
            manager.Navigator.GoToHome();
            InitContactModification(b);
            FillContactForm(newData);
            Submit();
            manager.Navigator.GoToHome();
            return this;
        }

        public ContactHelper InitContactModification(int b)
        {
            driver.FindElement(By.XPath("(//img[@alt='Edit'])[" + (b+1) + "]")).Click();
            return this;
        }

        public ContactHelper CreateContact(ContactData group)
        {
            manager.Navigator.GoToNewContact();
            FillContactForm(group);
            Submit();
            return this;
        }

        public ContactHelper SelectChbox(int index)
        {
            driver.FindElement(By.XPath("//tr[" + (index + 2) + "]/td/input")).Click();
            return this;
        }

        public ContactHelper Submit()
        {
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            contactCache = null;
            return this;
        }

        public ContactHelper DeleteBtn()
        {
            driver.FindElement(By.XPath("//input[starts-with(@value,'Delete')]")).Click();
            return this;
        }

        // ALerts
        public ContactHelper Alerts(bool choose)
        {
            acceptNextAlert = choose;
            return this;
        }

        public string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }

        public ContactHelper CloseAlert()
        {
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            contactCache = null;
            return this;
        }

        public ContactHelper FillContactForm(ContactData group)
        {
            Type(By.Name("firstname"), group.FirstName);
            Type(By.Name("middlename"), group.MiddleName);
            Type(By.Name("lastname"), group.LastName);
            Type(By.Name("nickname"), group.NickName);
            Type(By.Name("title"), group.Title);
            Type(By.Name("company"), group.Company);
            Type(By.Name("address"), group.Address);
            Type(By.Name("home"), group.TelHome);
            Type(By.Name("mobile"), group.TelMobile);
            Type(By.Name("work"), group.TelWork);
            Type(By.Name("fax"), group.TelFax);
            Type(By.Name("email"), group.Email1);
            Type(By.Name("email2"), group.Email2);
            Type(By.Name("email3"), group.Email3);
            Type(By.Name("homepage"), group.HomePage);
            Type2(By.Name("bday"), group.BDay);
            Type2(By.Name("bmonth"), group.BMonth);
            Type(By.Name("byear"), group.BYear);
            Type2(By.Name("aday"), group.ADay);
            Type2(By.Name("amonth"), group.AMonth);
            Type(By.Name("ayear"), group.AYear);
            Type(By.Name("address2"), group.SecAddress);
            Type(By.Name("phone2"), group.SecHome);
            Type(By.Name("notes"), group.SecNotes);
            return this;
        }

        private List<ContactData> contactCache = null;

        public List<ContactData> GetContactsList()
        {
            if(contactCache == null)
            {
                contactCache = new List<ContactData>();
                manager.Navigator.GoToHome();
                ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("tr[name=entry]"));
                foreach (IWebElement element in elements)
                {
                    contactCache.Add(new ContactData(element.FindElement(By.XPath(".//td[3]")).Text, element.FindElement(By.XPath(".//td[2]")).Text));
                }
            }
             return new List<ContactData>(contactCache);
        }

        public int GetContactCount()
        {
            return driver.FindElements(By.CssSelector("tr[name=entry]")).Count;
        }
    }
}