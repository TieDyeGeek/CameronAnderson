﻿using CameronAnderson.Selenium.Home;
using OpenQA.Selenium;
using System.Threading;
using Xunit;

namespace CameronAnderson.Selenium.BaseTesting;

public class BaseTest : IClassFixture<DriverWrapper>
{
	private readonly DriverWrapper _driverWrapper;
	protected IWebDriver WebDriver => _driverWrapper.Driver;

	public BaseTest(DriverWrapper driverWrapper)
	{
		_driverWrapper = driverWrapper;
	}

	protected HomePage Load()
	{
		WebDriver.GoToPage("");
		return HomePage.Load(WebDriver);
	}

	protected void Wait(double seconds)
	{
		Thread.Sleep((int)(seconds * 1000));
	}

	protected void VerifyNumberOfTabs(int expectedCount)
	{
		var currentTabCount = WebDriver.WindowHandles.Count;
		Assert.Equal(expectedCount, currentTabCount);
	}

	protected void SwitchToTab(int tabNumber)
	{
		var tabs = WebDriver.WindowHandles;
		WebDriver.SwitchTo().Window(tabs[tabNumber - 1]);
	}
}
