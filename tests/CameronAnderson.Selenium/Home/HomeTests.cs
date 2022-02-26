using CameronAnderson.Selenium.BaseTesting;
using Xunit;

namespace CameronAnderson.Selenium.Home;

public class HomeTests : BaseTesting.BaseTest
{
	public HomeTests(DriverWrapper driverWrapper) : base(driverWrapper)
	{
	}

	[Fact]
	public void NavigationLinksTest()
	{
		Load()
			.GoToResumePage()
			.GoToLoadingIconsPage()
			.GoToFibonacciPage()
			.GoToRestaurantLevelsPage();
	}
}
