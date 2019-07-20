using OpenQA.Selenium;

namespace WebAddressbookTests
{
    public class NavigatonHelper:HelperBase
    {
        private string baseURL;

        public NavigatonHelper(IWebDriver driver, string baseURL):base(driver)
        {
            this.baseURL = baseURL;
        }

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "/addressbook/");
        }

        public void GoToHome()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }

        public void GoToNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
        }
        public void GoToGroups()

        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
