namespace CameronAnderson.Selenium.BaseTesting;

public static class Environment
{
	public const string Local = "https://localhost:5001/";
	public const string Prod = "https://cameronanderson.co/";

	public static string Current()
	{
#if BUILDSERVER
		return Prod;
#else
		return Local;
#endif
	}
}
