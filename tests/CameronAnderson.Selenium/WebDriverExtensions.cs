using OpenQA.Selenium;

namespace CameronAnderson.Selenium
{
	public static class WebDriverExtensions
	{
		private const string Local = "https://localhost:5001/";
		private const string Prod = "https://cameronanderson.info/";

		public static void GoToPage(this IWebDriver driver, string page)
		{
			driver.Navigate().GoToUrl(Local + page);
		}
	}
}
