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
}
