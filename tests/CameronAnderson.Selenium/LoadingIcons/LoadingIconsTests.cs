using CameronAnderson.Selenium.BaseTesting;
using System.Linq;
using Xunit;

namespace CameronAnderson.Selenium.LoadingIcons;

public class LoadingIconsTests : BaseTest
{
	public LoadingIconsTests(DriverWrapper driverWrapper) : base(driverWrapper)
	{
	}

	[Fact]
	public void VerifyNoBrokenLinks()
	{
		var page = Load().GoToLoadingIconsPage();
		var iconsCount = page.LoadingIconCards.Count;

		for (int i = 0; i < iconsCount; i++)
		{
			var card = page.LoadingIconCards[i];
			page = card.VerifyLinkExists();
		}
	}

	[Fact]
	public void VerifyTitlesExist()
	{
		var page = Load().GoToLoadingIconsPage();

		Assert.True(page.LoadingIconCards
			.All(x => !string.IsNullOrWhiteSpace(x.Title)),
			"Title Missing");
	}

	[Fact]
	public void VerifyEveryOtherSideFormatting()
	{
		var page = Load().GoToLoadingIconsPage();
		var iconsCount = page.LoadingIconCards.Count;

		for (int i = 0; i < iconsCount; i++)
		{
			var isEven = i % 2 == 0;
			var card = page.LoadingIconCards[i];
			Assert.True(isEven == card.TitleIsOnRight, $"{card.Title} is on the wrong side");
		}
	}
}
