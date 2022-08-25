using OpenQA.Selenium;

namespace CameronAnderson.Selenium.Base.Elements;

public class Button : IWrapsElement
{
	public Button(IWebElement webElement)
	{
		WrappedElement = webElement;
	}

	public IWebElement WrappedElement { get; private set; }
	public bool Enabled => WrappedElement.Enabled;
	public bool Displayed => WrappedElement.Displayed;
	public string Text => WrappedElement.Text;

	public void Click()
	{
		WrappedElement.Click();
	}
}
