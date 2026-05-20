using OpenQA.Selenium;

namespace qa_dotnet_cucumber.Pages
{
	public class LoginPageMars
	{
		private readonly IWebDriver _driver;

		// Locators
		private readonly By EmailField = By.Id("email");
		private readonly By PasswordField = By.Id("password");
		private readonly By LoginButton = By.XPath("//button[text()='Login']");

		public LoginPageMars(IWebDriver driver)
		{
			_driver = driver;
		}

		public void EnterEmail(string email)
		{
			_driver.FindElement(EmailField).Clear();
			_driver.FindElement(EmailField).SendKeys(email);
		}

		public void EnterPassword(string password)
		{
			_driver.FindElement(PasswordField).Clear();
			_driver.FindElement(PasswordField).SendKeys(password);
		}

		public void ClickLogin()
		{
			_driver.FindElement(LoginButton).Click();
		}

		public bool IsAtLoginPage()
		{
			return _driver.Url.Contains("/Home");
		}
	}
}
