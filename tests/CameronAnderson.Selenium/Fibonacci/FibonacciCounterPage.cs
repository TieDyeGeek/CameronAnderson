using System.Numerics;
using CameronAnderson.Selenium.Base.Elements;
using CameronAnderson.Selenium.BasePages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Xunit;

namespace CameronAnderson.Selenium.Fibonacci;

public class FibonacciCounterPage : PageWithNavigationLinks<FibonacciCounterPage>
{
	[FindsBy(How.ClassName, "btn-primary")]
	private Button IncrementButton { get; set; }

	[FindsBy(How.TagName, "p")]
	private Label CurrentNumberLabel { get; set; }

	public FibonacciCounterPage(IWebDriver driver) : base(driver)
	{
		WaitForElement(x => x.IncrementButton);
		VerifyUrl("/fibonacci");
	}

	public FibonacciCounterPage ClickButton()
	{
		IncrementButton.Click();
		return this;
	}

	public FibonacciCounterPage VerifyNumberIs(BigInteger expectedValue)
	{
		Assert.Equal(expectedValue, GetCurrentNumber());
		return this;
	}

	private BigInteger? GetCurrentNumber()
	{
		var isNumber = BigInteger.TryParse(CurrentNumberLabel.Text
			.Replace("Current number: ", "")
			.Replace(",", "")
			, out var number);

		return isNumber ? number : null;
	}
}
