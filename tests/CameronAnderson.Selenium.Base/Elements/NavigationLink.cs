using CameronAnderson.Selenium.Base.Exceptions;
using OpenQA.Selenium;

namespace CameronAnderson.Selenium.Base.Elements;

public class NavigationLink<T> : IWrapsElement, INeedWebDriver
	where T : BasePage<T>
{
	public NavigationLink(IWebElement webElement)
	{
		WrappedElement = webElement;
	}

	public IWebElement WrappedElement { get; private set; }
	public IWebDriver? WebDriver { get; set; }
	public bool Enabled => WrappedElement.Enabled;

	public T Click()
	{
		WrappedElement.Click();

		if (WebDriver == null) throw new PageException("Unable to navigate: Missing WebDriver");

		return BasePage<T>.Load(WebDriver);
	}
}
