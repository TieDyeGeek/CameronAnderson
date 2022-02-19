using CameronAnderson.Selenium.BaseTesting;
using OpenQA.Selenium;

namespace CameronAnderson.Selenium;

public static class WebDriverExtensions
{
	public static void GoToPage(this IWebDriver driver, string page)
	{
		driver.Navigate().GoToUrl(Environment.Current() + page);
	}
}
