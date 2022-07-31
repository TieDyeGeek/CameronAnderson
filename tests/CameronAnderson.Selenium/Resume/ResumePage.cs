using CameronAnderson.Selenium.BasePages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CameronAnderson.Selenium.Resume;

public class ResumePage : PageWithNavigationLinks<ResumePage>
{
	[FindsBy(How.ClassName, "name")]
	private IWebElement Heading { get; set; }
	public string HeadingText => Heading.Text;

	public ResumePage(IWebDriver driver) : base(driver)
	{
		WaitForElement(x => x.Heading);
		VerifyUrl("/resume");
	}
}
