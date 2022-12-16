using OpenQA.Selenium;

namespace CameronAnderson.Selenium.Base.Elements;

public class TextInput : IWrapsElement
{
	public TextInput(IWebElement webElement)
	{
		WrappedElement = webElement;
	}

	public IWebElement WrappedElement { get; private set; }

	public virtual string Text => WrappedElement.Text;
	public virtual bool Enabled => WrappedElement.Enabled;

	public virtual void SetText(string value)
	{
		Clear();
		SendKeys(value);
	}

	public virtual void Clear()
	{
		WrappedElement.Clear();
	}

	public virtual void SendKeys(string text)
	{
		if (string.IsNullOrEmpty(text)) return;

		WrappedElement.SendKeys(text);
	}
}
