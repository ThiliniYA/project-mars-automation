using NUnit.Framework;
using OpenQA.Selenium;
using qa_dotnet_cucumber.Pages;
using Reqnroll;

namespace qa_dotnet_cucumber.Steps
{
    [Binding]
    public class LoginStepsMars
    {
        private readonly IWebDriver _driver;
        private readonly LoginPageMars _loginPage;

        public LoginStepsMars(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPageMars(driver);
        }

        [Given("I am on the Mars login page")]
        public void GivenIAmOnTheMarsLoginPage()
        {
            _driver.Navigate().GoToUrl("http://localhost:5003/Home");
            Assert.That(_loginPage.IsAtLoginPage(), Is.True, "Not on Mars login page");
        }

        [When("I enter Mars email '(.*)' and password '(.*)'")]
        public void WhenIEnterMarsCredentials(string email, string password)
        {
            _loginPage.EnterEmail(email);
            _loginPage.EnterPassword(password);
        }

        [When("I click the Mars login button")]
        public void WhenIClickTheMarsLoginButton()
        {
            _loginPage.ClickLogin();
        }

        [Then("I should be logged into Mars successfully")]
        public void ThenIShouldBeLoggedIntoMarsSuccessfully()
        {
            Assert.That(_driver.Url.Contains("Profile"), "Login did not navigate to Profile page");
        }
    }
}

