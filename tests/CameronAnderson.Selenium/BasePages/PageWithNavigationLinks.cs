using CameronAnderson.Selenium.Fibonacci;
using CameronAnderson.Selenium.Home;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CameronAnderson.Selenium.BasePages;

public class PageWithNavigationLinks<T> : BasePage<T> where T : PageWithNavigationLinks<T>
{
	[FindsBy(How.ClassName, "navbar-brand")]
	protected IWebElement Title { get; set; }

	[FindsBy(How.ClassName, "navbar-toggler")]
	protected IWebElement HamburgerMenu { get; set; }

	[FindsBy(How.Id, "HomeLink")]
	protected IWebElement HomeLink { get; set; }

	[FindsBy(How.Id, "ResumeLink")]
	protected IWebElement ResumeLink { get; set; }

	[FindsBy(How.Id, "LoadingIconsLink")]
	protected IWebElement LoadingIconsLink { get; set; }

	[FindsBy(How.Id, "FibonacciLink")]
	protected IWebElement FibonacciCounterLink { get; set; }

	[FindsBy(How.Id, "RestaurantLevelsLink")]
	protected IWebElement RestaurantLevelsLink { get; set; }

	public PageWithNavigationLinks(IWebDriver driver) : base(driver)
	{
		WaitForElement(x => x.Title);
	}

	public HomePage GoToHomePage()
	{
		OpenHamburgerMenu();
		FibonacciCounterLink.Click();
		return HomePage.Load(WebDriver);
	}

	public FibonacciCounterPage GoToFibonacciPage()
	{
		OpenHamburgerMenu();
		FibonacciCounterLink.Click();
		return FibonacciCounterPage.Load(WebDriver);
	}

	protected void OpenHamburgerMenu()
	{
		if (HamburgerMenu.Displayed)
			HamburgerMenu.Click();
	}
}
