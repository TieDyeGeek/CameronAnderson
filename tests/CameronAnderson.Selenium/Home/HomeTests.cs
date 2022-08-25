using CameronAnderson.Selenium.Base;
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
		var expectedUrl = "https://github.com/tiedyegeek/CameronAnderson";

		var page = Load();
		Assert.Equal(expectedUrl, page.SourceLink.LinkUrl);

		page.ClickSourceLink();
		Wait.Seconds(2);

		VerifyNumberOfTabs(2);
		SwitchToOtherTab();

		Assert.Equal(expectedUrl, WebDriver.Url);
	}
}
