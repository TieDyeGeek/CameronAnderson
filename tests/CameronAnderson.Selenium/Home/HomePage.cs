using CameronAnderson.Selenium.BasePages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CameronAnderson.Selenium.Home;

public class HomePage : PageWithNavigationLinks<HomePage>
{
	[FindsBy(How.TagName, "h1")]
	private IWebElement Heading { get; set; }
	public string HeadingText => Heading.Text;

	public HomePage(IWebDriver driver) : base(driver)
	{
		WaitForElement(x => x.Heading);
	}
}
