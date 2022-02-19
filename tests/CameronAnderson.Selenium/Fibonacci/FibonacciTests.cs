using CameronAnderson.Selenium.BaseTesting;
using Xunit;

namespace CameronAnderson.Selenium.Fibonacci;

public class FibonacciTests : BaseTest
{
	public FibonacciTests(DriverWrapper driverWrapper) : base(driverWrapper)
	{
	}

	[Fact]
	public void First1000Numbers()
	{
		var numbers = FibonacciNumbers.First1000();
		var page = Load().GoToFibonacciPage();

		foreach(var number in numbers)
		{
			page.VerifyNumberIs(number)
				.ClickButton();
		}
	}
}
