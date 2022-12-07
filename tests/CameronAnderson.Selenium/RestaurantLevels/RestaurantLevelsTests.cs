using System.Collections.Generic;
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

	[Fact]
	public void MinimumOptionsDefaultTest()
	{
		var page = Load()
			.GoToRestaurantLevelsPage();

		var expectedMinimums = new List<double> { 1, 2, 3, 4 };

		Assert.Equal(expectedMinimums, page.AvailableMinimumOptions);
	}

	[Fact]
	public void MaximumOptionsDefaultTest()
	{
		var page = Load()
			.GoToRestaurantLevelsPage();

		var expectedMaximums = new List<double> { 1, 2, 3, 4 };

		Assert.Equal(expectedMaximums, page.AvailableMaximumOptions);
	}

	[Theory]
	[InlineData(1)]
	[InlineData(2)]
	[InlineData(3)]
	[InlineData(4)]
	public void MinimumDisablesMaximumsTest(double minimum)
	{
		var page = Load()
			.GoToRestaurantLevelsPage()
			.SetMinimumLevel(minimum);

		var maximumsEnabled = page.AvailableMaximumOptions;

		Assert.All(maximumsEnabled, x => Assert.True(x >= minimum));
	}

	[Theory]
	[InlineData(1)]
	[InlineData(2)]
	[InlineData(3)]
	[InlineData(4)]
	public void MaximumDisablesMinimumsTest(double maximum)
	{
		var page = Load()
			.GoToRestaurantLevelsPage()
			.SetMaximumLevel(maximum);

		var minimumsEnabled = page.AvailableMinimumOptions;

		Assert.All(minimumsEnabled, x => Assert.True(x >= maximum));
	}
}
