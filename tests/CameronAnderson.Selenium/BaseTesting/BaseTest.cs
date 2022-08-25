using System.Linq;
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

	protected void VerifyNumberOfTabs(int expectedCount)
	{
		var currentTabCount = WebDriver.WindowHandles.Count;
		Assert.Equal(expectedCount, currentTabCount);
	}

	protected void SwitchToOtherTab()
	{
		var tabs = WebDriver.WindowHandles;
		var desiredTab = tabs.First(x => !x.Equals(WebDriver.CurrentWindowHandle));

		WebDriver.SwitchTo().Window(desiredTab);
	}
}
