using OpenQA.Selenium;

namespace CameronAnderson.Selenium
{
	public static class WebDriverExtensions
	{
		private const string Local = "https://localhost:5001/";
		private const string Prod = "https://cameronanderson.co/";

		public static void GoToPage(this IWebDriver driver, string page)
		{
			var baseUrl = Prod;

#if BUILDSERVER
			baseUrl = Prod;
#endif

			driver.Navigate().GoToUrl(baseUrl + page);
		}
	}
}
