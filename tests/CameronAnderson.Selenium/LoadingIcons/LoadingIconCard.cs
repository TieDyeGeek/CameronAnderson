using OpenQA.Selenium;
using System.Linq;
using Xunit;

namespace CameronAnderson.Selenium.LoadingIcons;
public class LoadingIconCard
{
	private readonly IWebElement _loadingIcon;
	private readonly IWebDriver _webDriver;

	public LoadingIconCard(IWebElement card, IWebDriver webDriver)
	{
		_webDriver = webDriver;
		_loadingIcon = card.FindElement(By.ClassName("loading-icon"));
		Title = card.FindElement(By.ClassName("li-title")).Text;
		TitleIsOnRight = card.FindElements(By.ClassName("li-title-right")).Any();
	}

	public string Title { get; }

	public bool TitleIsOnRight { get; }

	public LoadingIconsPage VerifyLinkExists()
	{
		_loadingIcon.Click();
		var pageNotFound = _webDriver
			.FindElements(By.TagName("h1"))
			.Any(x => x.Text.Equals("404"));

		Assert.False(pageNotFound, $"{Title} link broken");
		_webDriver.Navigate().Back();
		return LoadingIconsPage.Load(_webDriver);
	}
}
