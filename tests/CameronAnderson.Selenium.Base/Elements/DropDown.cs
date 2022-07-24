using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CameronAnderson.Selenium.Base.Elements;

public class DropDown : IWrapsElement
{
	public DropDown(IWebElement webElement)
	{
		WrappedElement = webElement;
	}

	public IWebElement WrappedElement { get; private set; }
	private SelectElement SelectElement => new SelectElement(WrappedElement);

	public List<DropDownOption> Options =>
		SelectElement.Options.Select(Map).ToList();

	public List<DropDownOption> AvailableOptions =>
		Options.Where(x => x.Enabled).ToList();

	public DropDownOption SelectedOption => Map(SelectElement.SelectedOption);


	public void SelectOption(string text)
	{
		SelectElement.SelectByText(text);
	}

	private static DropDownOption Map(IWebElement element)
	{
		return new DropDownOption
		{
			Text = element.Text,
			Enabled = IsEnabled(element)
		};
	}

	private static bool IsEnabled(IWebElement element)
	{
		return element.GetAttribute("disabled") == null;
	}
}