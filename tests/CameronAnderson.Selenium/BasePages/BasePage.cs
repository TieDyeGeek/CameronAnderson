using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Xunit;

namespace CameronAnderson.Selenium.BasePages;

public class BasePage<T> where T : BasePage<T>
{
	protected readonly IWebDriver WebDriver;

	public BasePage(IWebDriver driver)
	{
		WebDriver = driver;
		PageFactory.InitElements(WebDriver, this);
	}

	public static T Load(IWebDriver driver)
	{
		return (T)Activator.CreateInstance(typeof(T), driver);
	}

	protected void VerifyUrl(string url)
	{
		Assert.Equal($"{BaseTesting.Environment.Current()}{url}", WebDriver.Url, ignoreCase: true);
	}

	protected void WaitForElement(By by, double seconds = 10)
	{
		var wait = new WebDriverWait(WebDriver, TimeSpan.FromSeconds(seconds));
		wait.Until(e => e.FindElements(by).FirstOrDefault());
	}

	public virtual void WaitForElement(Expression<Func<T, object>> property, double seconds = 90)
	{
		var prop = typeof(T).GetProperty(ParsePropertyName(property),
			BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
		var attribute = (FindsByAttribute)prop.GetCustomAttribute(typeof(FindsByAttribute), false);
		WaitForElement(attribute.Finder, seconds);
	}

	private static string ParsePropertyName(Expression<Func<T, object>> property)
	{
		var body = property.Body.ToString();
		return body.Split('.').Last();
	}
}
