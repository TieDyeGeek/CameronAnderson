using CameronAnderson.Selenium.BaseTesting;
using Xunit;

namespace CameronAnderson.Selenium.RestaurantLevels;

public class RestaurantLevelsTests : BaseTest
{
	public RestaurantLevelsTests(DriverWrapper driverWrapper) : base(driverWrapper)
	{
	}

	[Fact]
	public void HeadingTest()
	{
		var page = Load()
			.GoToRestaurantLevelsPage();

		Assert.Equal("Restaurant Levels", page.HeadingText);
	}
}
