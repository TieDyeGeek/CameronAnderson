using CameronAnderson.Selenium.BasePages;
using OpenQA.Selenium;

namespace CameronAnderson.Selenium.Resume;

public class ResumePage : PageWithNavigationLinks<ResumePage>
{
	public ResumePage(IWebDriver driver) : base(driver)
	{
		VerifyUrl("resume");
	}
}
