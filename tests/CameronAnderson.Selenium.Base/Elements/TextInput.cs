using OpenQA.Selenium;

namespace CameronAnderson.Selenium.Base.Elements;

public class TextInput : IWrapsElement
{
	public TextInput(IWebElement webElement)
	{
		WrappedElement = webElement;
	}

	public IWebElement WrappedElement { get; private set; }

	public string Text => WrappedElement.Text;
	public bool Enabled => WrappedElement.Enabled;

	public void SetText(string value)
	{
		Clear();
		SendKeys(value);
	}

	public void Clear()
    {
		WrappedElement.Clear();
    }

	public void SendKeys(string text)
    {
		if (string.IsNullOrEmpty(text)) return;

		WrappedElement.SendKeys(text);
    }
}
