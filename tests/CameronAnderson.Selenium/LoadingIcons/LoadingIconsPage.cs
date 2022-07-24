using CameronAnderson.Selenium.BasePages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace CameronAnderson.Selenium.LoadingIcons;

public class LoadingIconsPage : PageWithNavigationLinks<LoadingIconsPage>
{
	[FindsBy(How.TagName, "H1")]
	private IWebElement TitleText { get; set; }

	public List<LoadingIconCard> LoadingIconCards { get; set; }

	public LoadingIconsPage(IWebDriver driver) : base(driver)
	{
		WaitForElement(x => x.TitleText);
		VerifyUrl("/loading");
		LoadCards();
	}

	private void LoadCards()
	{
		LoadingIconCards = WebDriver
			.FindElements(By.ClassName("li-card"))
			.Select(x => new LoadingIconCard(x, WebDriver))
			.ToList();

		Assert.True(LoadingIconCards.Any(),
			"No loading icons present");
	}
}
