using CameronAnderson.Selenium.Base;
using CameronAnderson.Selenium.Base.Elements;
using CameronAnderson.Selenium.Fibonacci;
using CameronAnderson.Selenium.Home;
using CameronAnderson.Selenium.LoadingIcons;
using CameronAnderson.Selenium.RestaurantLevels;
using CameronAnderson.Selenium.Resume;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CameronAnderson.Selenium.BasePages;

public class PageWithNavigationLinks<T> : BasePage<T> where T : PageWithNavigationLinks<T>
{
	[FindsBy(How.ClassName, "navbar-brand")]
	protected NavigationLink<HomePage> Title { get; set; }

	[FindsBy(How.ClassName, "navbar-toggler")]
	protected IWebElement HamburgerMenu { get; set; }

	[FindsBy(How.Id, "HomeLink")]
	protected NavigationLink<HomePage> HomeLink { get; set; }

	[FindsBy(How.Id, "ResumeLink")]
	protected NavigationLink<ResumePage> ResumeLink { get; set; }

	[FindsBy(How.Id, "LoadingIconsLink")]
	protected NavigationLink<LoadingIconsPage> LoadingIconsLink { get; set; }

	[FindsBy(How.Id, "FibonacciLink")]
	protected NavigationLink<FibonacciCounterPage> FibonacciCounterLink { get; set; }

	[FindsBy(How.Id, "RestaurantLevelsLink")]
	protected NavigationLink<RestaurantLevelsPage> RestaurantLevelsLink { get; set; }

	[FindsBy(How.Id, "SourceLink")]
	protected IWebElement SourceLink { get; set; }

	public PageWithNavigationLinks(IWebDriver driver) : base(driver)
	{
		WaitForElement(x => x.Title);
	}

	public HomePage GoToHomePage()
	{
		OpenHamburgerMenu();
		return HomeLink.Click();
	}

	public HomePage ClickTitle()
	{
		OpenHamburgerMenu();
		return Title.Click();
	}

	public ResumePage GoToResumePage()
	{
		OpenHamburgerMenu();
		return ResumeLink.Click();
	}

	public LoadingIconsPage GoToLoadingIconsPage()
	{
		OpenHamburgerMenu();
		return LoadingIconsLink.Click();
	}

	public FibonacciCounterPage GoToFibonacciPage()
	{
		OpenHamburgerMenu();
		return FibonacciCounterLink.Click();
	}

	public RestaurantLevelsPage GoToRestaurantLevelsPage()
	{
		OpenHamburgerMenu();
		return RestaurantLevelsLink.Click();
	}

	protected void OpenHamburgerMenu()
	{
		if (HamburgerMenu.Displayed)
			HamburgerMenu.Click();
	}

	public void ClickSourceLink()
	{
		SourceLink.Click();
	}
}
