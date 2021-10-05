using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using SeleniumExtras.PageObjects;

namespace CameronAnderson.Selenium
{
	public class BasePage
	{
		public IWebDriver _driver;

		public BasePage(IWebDriver driver)
		{
			_driver = driver;
			PageFactory.InitElements(_driver, this);
		}

		protected void WaitForElement(By by, double seconds = 10)
		{
			var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(seconds));
			wait.Until(e => e.FindElements(by).FirstOrDefault());
		}
	}
}
