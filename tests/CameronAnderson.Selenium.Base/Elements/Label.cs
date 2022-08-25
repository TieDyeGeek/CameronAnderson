using OpenQA.Selenium;

namespace CameronAnderson.Selenium.Base.Elements;

public class Label : IWrapsElement
{
	public Label(IWebElement webElement)
	{
		WrappedElement = webElement;
	}

	public IWebElement WrappedElement { get; private set; }
	public string Text => WrappedElement.Text;
}
