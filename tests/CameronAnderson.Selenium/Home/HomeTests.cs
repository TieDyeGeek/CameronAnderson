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
			.GoToLoadingIconsPage()
			.GoToFibonacciPage()
			.GoToRestaurantLevelsPage();
	}
}
