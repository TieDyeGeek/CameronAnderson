using CameronAnderson.Selenium.BaseTesting;
using Xunit;

namespace CameronAnderson.Selenium.Resume;

public class ResumeTests : BaseTest
{
	public ResumeTests(DriverWrapper driverWrapper) : base(driverWrapper)
	{
	}

	[Fact]
	public void HeadingTest()
	{
		var page = Load()
			.GoToResumePage();

		Assert.Equal("Cameron Anderson", page.HeadingText);
	}
}
