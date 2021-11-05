using CameronAnderson.Selenium.Translations;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Numerics;
using Xunit;

namespace CameronAnderson.Selenium.Fibonacci
{
	public class FibonacciCounterPage : BasePage<FibonacciCounterPage>
	{
		[TranslationKey("asdf")]
		[FindsBy(How.ClassName, "btn-primary")]
		private IWebElement IncrementButton { get; set; }

		[TranslationKey("jkl;")]
		[FindsBy(How.TagName, "h1")]
		private IWebElement Title {  get; set; }

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
}
