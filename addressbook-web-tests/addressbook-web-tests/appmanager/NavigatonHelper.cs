using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigatonHelper:HelperBase
    {
        private string baseURL;

        public NavigatonHelper(ApplicationManager manager,string baseURL) 
            :base(manager)
        {
            this.baseURL = baseURL;
        }

        public void GoToHomePage()
        {
            if (driver.Url == baseURL + "/addressbook/")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }

        public void GoToHome()
        {
            if (driver.Url == baseURL + "/addressbook/"
                && IsElementPresent(By.XPath("//input[@value='Send e-Mail']")))
            {
                return;
            }
            driver.FindElement(By.LinkText("home")).Click();
        }

        public void GoToNewContact()
        {
            if (driver.Url == baseURL + "/addressbook/group.php"
                && IsElementPresent(By.Name("new")))
            {
                return;
            }
            driver.FindElement(By.LinkText("add new")).Click();
        }

        public void GoToGroups()
        {
            if(driver.Url == baseURL + "addressbook/edit.php"
                && IsElementPresent(By.Name("photo")))
            {
                return;
            }
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
