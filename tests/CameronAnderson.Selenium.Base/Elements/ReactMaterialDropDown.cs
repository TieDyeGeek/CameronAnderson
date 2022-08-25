using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

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
	public void Click() => WrappedElement.Click();

	public void SelectOption(string text)
	{
		Search(text);
		WrappedElement.SendKeys(Keys.ArrowDown);
		WrappedElement.SendKeys(Keys.Enter);

		Wait.Seconds(5);
	}

	public void Search(string text)
	{
		Clear();

		if (text == null) return;

		WrappedElement.SendKeys(text);
		Wait.Seconds(2);
	}

	public void Clear()
	{
		var by = By.ClassName("MuiAutocomplete-clearIndicator");
		Click();
		Wait.Seconds(0.5);

		if (WebDriver.ElementExists(by))
		{
			Click();
			var clearButton = WebDriver.FindElement(by);

			clearButton.Click();
			Wait.Seconds(5);
		}
	}

	private List<DropDownOption> GatherOptions()
	{
		if (WebDriver == null) return new List<DropDownOption>();

		Click();

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
		return !element.GetAttribute("aria-disabled")
			.Equals("true", StringComparison.OrdinalIgnoreCase);
	}
}
