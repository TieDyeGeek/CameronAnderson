using CameronAnderson.Selenium.BasePages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CameronAnderson.Selenium.RestaurantLevels;

public class RestaurantLevelsPage : PageWithNavigationLinks<RestaurantLevelsPage>
{
	[FindsBy(How.TagName, "h1")]
	private IWebElement Heading { get; set; }
	public string HeadingText => Heading.Text;

	public RestaurantLevelsPage(IWebDriver driver) : base(driver)
	{
		WaitForElement(x => x.Heading);
		VerifyUrl("RestaurantLevels");
	}
}
