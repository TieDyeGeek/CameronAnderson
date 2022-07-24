using OpenQA.Selenium;

namespace CameronAnderson.Selenium.Base.Elements;

/// <summary>
/// This is an (untested) example of how a more complex
/// JS based dropdown could be implemented.
///
/// Based on a Material UI React application.
/// </summary>
public class ReactMaterialDropDown : IWrapsElement, INeedWebDriver
{
	public ReactMaterialDropDown(IWebElement webElement)
	{
		WrappedElement = webElement;
	}

	public IWebDriver? WebDriver { get; set; }
	public IWebElement WrappedElement { get; private set; }

	public List<DropDownOption> Options => GatherOptions();

	public List<DropDownOption> AvailableOptions =>
		Options.Where(x => x.Enabled).ToList();

	public string SelectedOption => WrappedElement.Text;

	public void SelectOption(string text)
	{
		Clear();
		Search(text);
		WrappedElement.SendKeys(Keys.ArrowDown);
		WrappedElement.SendKeys(Keys.Enter);

		Thread.Sleep(1000);
	}

	public void Search(string text)
	{
		Clear();

		if (text == null) return;

		WrappedElement.SendKeys(text);

		Thread.Sleep(2000);
	}

	public void Clear()
	{
		var clearButton = WrappedElement
			.FindElement(By.ClassName("MuiAutocomplete-clearIndicator"));

		clearButton.Click();
	}

	private List<DropDownOption> GatherOptions()
	{
		if (WebDriver == null) return new List<DropDownOption>();

		WrappedElement.Click();

		return WebDriver
			.FindElements(By.ClassName("MuiAutocomplete-option"))
			.Select(Map).ToList();
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
		return element.GetAttribute("aria-disabled")
			.Equals("true", StringComparison.OrdinalIgnoreCase);
	}
}