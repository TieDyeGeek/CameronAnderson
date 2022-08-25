using System.Threading;
using CameronAnderson.Selenium.Home;
using OpenQA.Selenium;
using Xunit;

namespace CameronAnderson.Selenium.BaseTesting;

public class BaseTest : IClassFixture<DriverWrapper>
{
	private readonly DriverWrapper _driverWrapper;
	protected IWebDriver WebDriver => _driverWrapper.Driver;

	public BaseTest(DriverWrapper driverWrapper)
	{
		_driverWrapper = driverWrapper;
	}

	protected HomePage Load()
	{
		WebDriver.GoToPage("");
		return HomePage.Load(WebDriver);
	}

	protected void Wait(double seconds)
	{
		Thread.Sleep((int)(seconds * 1000));
	}

	protected void VerifyNumberOfTabs(int expectedCount)
	{
		var currentTabCount = WebDriver.WindowHandles.Count;
		Assert.Equal(expectedCount, currentTabCount);
	}

	/// <summary>
	/// Switch to the Xth tab
	/// </summary>
	/// <param name="tabNumber">1 indexed number of the tab to switch to</param>
	protected void SwitchToTab(int tabNumber)
	{
		var tabs = WebDriver.WindowHandles;
		WebDriver.SwitchTo().Window(tabs[tabNumber - 1]);
	}

	protected void SwitchToNextTab()
	{
		SwitchToTab(GetCurrentTabNumber() + 1);
	}

	protected void SwitchToPreviousTab()
	{
		SwitchToTab(GetCurrentTabNumber() - 1);
	}

	/// <returns>1 indexed tab number</returns>
	protected int GetCurrentTabNumber()
	{
		var tabs = WebDriver.WindowHandles;
		return tabs.IndexOf(WebDriver.CurrentWindowHandle) + 1;
	}
}
