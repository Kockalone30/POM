using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using WebDriver = SeleniumPOM.Driver.WebDriver;

namespace SeleniumPOM.Page;

public class HomePage
{
    private IWebDriver driver = WebDriver.Instance;

    public IWebElement Initial => driver.FindElement(By.Id("Initial"));

    public IWebElement FirstName => driver.FindElement(By.Id("FirstName"));

    public IWebElement MidleName => driver.FindElement(By.Id("LastName"));

    public IWebElement Female => driver.FindElement(By.Name("Female"));

    public IWebElement Hindi => driver.FindElement(By.Name("Hindi"));

    public IWebElement SaveButton => driver.FindElement(By.Name("Save"));

    public IWebElement HtmlPopup => driver.FindElement(By.LinkText("HtmlPopup"));

    public IWebElement Generate => driver.FindElement(By.Name("generate"));


    public void TitleName(string option)
    {
        SelectElement drop = new SelectElement(driver.FindElement(By.Id("TitleId")));
        drop.SelectByText(option); 
    }

    public void Alert()
    {
        Generate.Click();
        driver.SwitchTo().Alert().Accept();
        driver.SwitchTo().Alert().Accept();

    }


}
