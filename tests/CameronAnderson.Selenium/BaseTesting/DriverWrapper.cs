using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;

namespace CameronAnderson.Selenium.BaseTesting;

public class DriverWrapper : IDisposable
{
    public DriverWrapper()
    {
        var options = new EdgeOptions();

#if BUILDSERVER
        options.AddArgument("headless");
#endif

        Driver = new EdgeDriver(options);
    }

    public IWebDriver Driver { get; set; }

    public void Dispose()
    {
        Driver.Quit();
    }
}
