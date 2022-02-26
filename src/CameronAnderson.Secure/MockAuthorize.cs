namespace CameronAnderson.Secure;

public class MockAuthorize : IAuthorize
{
	public bool CanAccess(string password)
	{
		return "TieDyeGeek".Equals(password);
	}
}
