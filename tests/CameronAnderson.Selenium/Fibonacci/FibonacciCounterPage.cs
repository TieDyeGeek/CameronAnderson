using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using Xunit;

namespace CameronAnderson.Selenium.Fibonacci
{
	public class FibonacciCounterPage : BasePage
	{
		[FindsBy(How.ClassName, "btn-primary")]
		private IWebElement IncrementButton { get; set; }

		[FindsBy(How.TagName, "p")]
		private IWebElement CurrentNumberLabel { get; set; }

		public FibonacciCounterPage(IWebDriver driver) : base(driver)
		{
			WaitForElement(By.TagName("h1"));
		}

		public static FibonacciCounterPage Load(IWebDriver driver)
		{
			driver.GoToPage("Fibonacci");
			return new(driver);
		}

		public FibonacciCounterPage ClickButton()
		{
			IncrementButton.Click();
			return this;
		}

		public FibonacciCounterPage VerifyNumberIs(ulong expectedValue)
		{
			Assert.Equal(expectedValue, GetCurrentNumber());
			return this;
		}

		private ulong? GetCurrentNumber()
		{
			var isNumber = ulong.TryParse(CurrentNumberLabel.Text
				.Replace("Current number: ", "")
				.Replace(",", "")
				, out var number);

			return isNumber ? number : null;
		}

		public FibonacciCounterPage VerifyNumberIsMax()
		{
			Assert.Equal("Current number: Max ulong value reached", CurrentNumberLabel.Text);
			return this;
		}
	}
}
