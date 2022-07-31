using OpenQA.Selenium;

namespace CameronAnderson.Selenium.Base.Elements;

public class CheckBox : IWrapsElement
{
	public CheckBox(IWebElement webElement)
	{
		WrappedElement = webElement;
	}

	public IWebElement WrappedElement { get; private set; }
	public bool Selected => WrappedElement.Selected;
	public bool Enabled => WrappedElement.Enabled;

	public void Select(bool value)
	{
		if (Selected == value)
			return;

		WrappedElement.Click();
	}
}
