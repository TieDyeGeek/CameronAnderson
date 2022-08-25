using OpenQA.Selenium;

namespace CameronAnderson.Selenium.Base.Elements;

public class Hyperlink : Button
{
	public Hyperlink(IWebElement webElement) : base(webElement)
	{
	}

	public string LinkUrl => WrappedElement.GetAttribute("href");
}
