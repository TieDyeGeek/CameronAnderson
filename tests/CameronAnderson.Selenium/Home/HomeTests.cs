using CameronAnderson.Selenium.BaseTesting;
using Xunit;

namespace CameronAnderson.Selenium.Home;

public class HomeTests : BaseTest
{
	public HomeTests(DriverWrapper driverWrapper) : base(driverWrapper)
	{
	}

	[Fact]
	public void NavigationLinksTest()
	{
		Load()
			.GoToResumePage()
			.GoToHomePage()
			.GoToLoadingIconsPage()
			.GoToFibonacciPage()
			.GoToRestaurantLevelsPage()
			.ClickTitle();
	}

	[Fact]
	public void HeadingTest()
	{
		var page = Load();
		Assert.Equal("Hello, world!", page.HeadingText);
	}

	[Fact]
	public void SourceButtonTest()
	{
		Load().ClickSourceLink();
		Wait(2);

		VerifyNumberOfTabs(2);
		SwitchToNextTab();

		Assert.Equal("https://github.com/tiedyegeek/CameronAnderson", WebDriver.Url);
	}
}
