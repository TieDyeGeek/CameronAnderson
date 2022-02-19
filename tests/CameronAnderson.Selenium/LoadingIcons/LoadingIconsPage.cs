using CameronAnderson.Selenium.BasePages;
using OpenQA.Selenium;

namespace CameronAnderson.Selenium.LoadingIcons;

public class LoadingIconsPage : PageWithNavigationLinks<LoadingIconsPage>
{
	public LoadingIconsPage(IWebDriver driver) : base(driver)
	{
		VerifyUrl("loading");
	}
}
