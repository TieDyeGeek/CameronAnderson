using System;
using System.Collections.Generic;
using System.Linq;
using CameronAnderson.Selenium.Base.Elements;
using CameronAnderson.Selenium.BasePages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CameronAnderson.Selenium.RestaurantLevels;

public class RestaurantLevelsPage : PageWithNavigationLinks<RestaurantLevelsPage>
{
	[FindsBy(How.TagName, "h1")]
	private IWebElement Heading { get; set; }
	public string HeadingText => Heading.Text;

	[FindsBy(How.Id, "minimumLevel")]
	private DropDown MinimumLevelDropDown { get; set; }
	public List<double> AvailableMinimumOptions => MinimumLevelDropDown
		.AvailableOptions
		.Select(x => Double.Parse(x.Text))
		.ToList();

	[FindsBy(How.Id, "maximumLevel")]
	private DropDown MaximumLevelDropDown { get; set; }
	public List<double> AvailableMaximumOptions => MaximumLevelDropDown
		.AvailableOptions
		.Select(x => Double.Parse(x.Text))
		.ToList();

	public RestaurantLevelsPage(IWebDriver driver) : base(driver)
	{
		WaitForElement(x => x.Heading);
		VerifyUrl("/RestaurantLevels");
	}

	public RestaurantLevelsPage SetMinimumLevel(double minimum)
	{
		var text = minimum.ToString("0.#");
		MinimumLevelDropDown.SelectOption(text);
		return this;
	}

	public RestaurantLevelsPage SetMaximumLevel(double maximum)
	{
		MaximumLevelDropDown.SelectOption(maximum.ToString("0.#"));
		return this;
	}
}
