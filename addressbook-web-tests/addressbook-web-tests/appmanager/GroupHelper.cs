using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class GroupHelper:HelperBase
    {
        public GroupHelper(ApplicationManager manager) 
            : base(manager)
        {
        }

        public GroupHelper CreateGroup(GroupData group)
        {
            manager.Navigator.GoToGroups();
            InitNewGroupCreation();
            FillGroupForm(group);
            Submit();
            manager.Navigator.GoToGroups();
            return this;
        }

        public List<GroupData> GetGroupList()
        {
            List<GroupData> groups=new List<GroupData>();
            manager.Navigator.GoToGroups();
            ICollection<IWebElement> elements=driver.FindElements(By.CssSelector("span.group"));
            foreach(IWebElement element in elements)
            {
                groups.Add(new GroupData(element.Text));
            }
            return groups;
        }

        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.Navigator.GoToGroups();
            Select(v);
            InitGroupModification();
            FillGroupForm(newData);
            Submit();
            manager.Navigator.GoToGroups();
            return this;
        }

        public GroupHelper RemoveGroup(int v)
        {
            manager.Navigator.GoToGroups();
            Select(v);
            DeleteBtn();
            manager.Navigator.GoToGroups();
            return this;
        }

        public GroupHelper IfNoGroup()
        {
            if (!IsElementPresent(By.Name("selected[]")))
            {
                GroupData group = new GroupData("Num1");
                CreateGroup(group);
            }
            return this;
        }

        public GroupHelper Select(int index)
        {
            driver.FindElement(By.XPath("(//input[@name='selected[]'])[" + (index+1) + "]")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper DeleteBtn()
        {
            driver.FindElement(By.XPath("//input[starts-with(@value,'Delete')]")).Click();
            return this;
        }

        public GroupHelper Submit()
        {
            driver.FindElement(By.XPath("//input[@type='submit']")).Click();
            return this;
        }

        public GroupHelper FillGroupForm(GroupData group)
        {
            Type(By.Name("group_name"), group.Name);
            Type(By.Name("group_header"), group.Header);
            Type(By.Name("group_footer"), group.Footer);
            return this;
        }



        public GroupHelper InitNewGroupCreation()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }
    }
}
