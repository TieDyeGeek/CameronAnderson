using OpenQA.Selenium;

namespace CameronAnderson.Selenium.Base;

public static class SearchContextExtensions
{
	public static bool ElementExists(this ISearchContext driver, By by)
	{
		var elements = driver.FindElements(by);
		return elements.Any();
	}
}
