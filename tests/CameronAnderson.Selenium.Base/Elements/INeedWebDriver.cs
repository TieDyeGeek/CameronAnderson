using OpenQA.Selenium;

namespace CameronAnderson.Selenium.Base.Elements;

public interface INeedWebDriver
{
	IWebDriver? WebDriver { get; set; }
}
