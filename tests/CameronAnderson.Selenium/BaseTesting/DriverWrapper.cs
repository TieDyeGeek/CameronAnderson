using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Safari;
using System;

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
