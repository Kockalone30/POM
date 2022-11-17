using NUnit.Framework;
using SeleniumPOM.Driver;
using SeleniumPOM.Page;

namespace SeleniumPOM;

public class TestClass
{
    private LoginPage _loginPage;
    private HomePage HomePage;

    [SetUp]

    public void BeforeScenario()
    {
        WebDriver.Initialize();
        _loginPage = new LoginPage();
        HomePage = new HomePage();

    }

    [TearDown]
    public void AfterScenario()
    {
        WebDriver.CleanUp();
    }


    [Test]

    public void TC01_FillInputWithValidData_ShouldAllDataDisplayedInInput()
    {

        Login("execute", "automation");
        HomePage.Initial.SendKeys("DS");
        HomePage.TitleName("Mr");
        HomePage.FirstName.SendKeys("Dusan");
        HomePage.MidleName.SendKeys("Sal");
        HomePage.Female.Click();
        HomePage.Hindi.Click();
        HomePage.SaveButton.Click();

    }

    [Test]
    public void TC02_OpenPopUp_ShouldDisplayed()
    {
        Login("execute", "automation");
        HomePage.HtmlPopup.Click();
    
    }


    [Test]
    public void TC03_OpenAlert_ShouldDisplayed()
    {
        Login("execute", "automation");
        HomePage.Alert();
     
    }


    public void Login(string name, string pass)
    {
        _loginPage.LoginOnPage(name, pass);
    }
}
