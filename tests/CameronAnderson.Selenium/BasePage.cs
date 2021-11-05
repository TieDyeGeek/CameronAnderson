using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Linq;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using Xunit;
using CameronAnderson.Selenium.Translations;
using System.Reflection;

namespace CameronAnderson.Selenium
{
	public class BasePage<T>
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

		public void VerifyTranslations()
		{
			var properties = GetProperties();

			if (!properties.Any()) Assert.Fail("No properties to translate");

			foreach(var property in properties)
			{
				var element = (IWebElement)property.GetValue(this);
				var attribute = (TranslationKeyAttribute)property.GetCustomAttribute(typeof(TranslationKeyAttribute));

				CheckTranslationAgainstResourceFile(attribute.Key, element.Text);
			}
		}

		private List<PropertyInfo> GetProperties()
		{
			var t = typeof(T);
			var properties = t.GetProperties(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
				.Where(prop => Attribute.IsDefined(prop, typeof(TranslationKeyAttribute)));

			return properties.ToList();
		}

		private void CheckTranslationAgainstResourceFile(string key, string text)
		{
			if (key.Equals("asdf"))
				Assert.Equal("Click me", text);

			if (key.Equals(";lkj"))
				Assert.Equal("Fibonacci Counter", text);
		}
	}
}
