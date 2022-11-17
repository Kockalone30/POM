using OpenQA.Selenium;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page
{
    public class LoginPage
    {

        private IWebDriver _driver = WebDriver.Instance;

        public IWebElement UserName => _driver.FindElement(By.Name("UserName"));
        public IWebElement Password => _driver.FindElement(By.Name("Password"));
        public IWebElement Login => _driver.FindElement(By.Name("Login"));

        public void LoginOnPage(string name, string password)
        {
            UserName.SendKeys(name);
            Password.SendKeys(password);
            Login.Submit();
        }
    }
}
