using CameronAnderson.Selenium.BasePages;
using OpenQA.Selenium;

namespace CameronAnderson.Selenium.RestaurantLevels;

public class RestaurantLevelsPage : PageWithNavigationLinks<RestaurantLevelsPage>
{
	public RestaurantLevelsPage(IWebDriver driver) : base(driver)
	{
		VerifyUrl("RestaurantLevels");
	}
}
