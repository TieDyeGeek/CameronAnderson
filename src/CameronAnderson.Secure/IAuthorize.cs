namespace CameronAnderson.Secure;

public interface IAuthorize
{
	bool CanAccess(string password);
}
