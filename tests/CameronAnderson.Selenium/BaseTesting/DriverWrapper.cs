using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Safari;

namespace CameronAnderson.Selenium.BaseTesting;

public class DriverWrapper : IDisposable
{
	public DriverWrapper()
	{
#if BUILDSERVER
		var options = new EdgeOptions();
		options.AddArgument("headless");
		Driver = new EdgeDriver(options);
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
