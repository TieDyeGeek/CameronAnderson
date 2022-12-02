using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Safari;

namespace CameronAnderson.Selenium.BaseTesting;

public class DriverWrapper : IDisposable
{
	public DriverWrapper()
	{
#if BUILDSERVER
		var options = new ChromeOptions();
		options.AddArguments("--headless");
		Driver = new ChromeDriver(@"C:\SeleniumWebDrivers\ChromeDriver", options);
#else
		Driver = new SafariDriver();
#endif
	}

	public IWebDriver Driver { get; set; }

	public void Dispose()
	{
		Driver.Quit();
	}
}
