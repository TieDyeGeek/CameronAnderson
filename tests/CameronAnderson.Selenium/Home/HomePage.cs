using CameronAnderson.Selenium.BasePages;
using OpenQA.Selenium;

namespace CameronAnderson.Selenium.Home;

public class HomePage : PageWithNavigationLinks<HomePage>
{
	public HomePage(IWebDriver driver) : base(driver)
	{
	}
}
