using Microsoft.Extensions.Configuration;
using OtpNet;

namespace CameronAnderson.Secure;

public class OtpAuthorize : IAuthorize
{
	private string OtpKey { get; set; }

	public OtpAuthorize(IConfiguration configuration)
	{
		OtpKey = configuration["OtpKey"];
	}

	public bool CanAccess(string password)
	{
		var key = Base32Encoding.ToBytes(OtpKey);
		var totp = new Totp(key);
		var authorized = totp.VerifyTotp(password, out var timeStepMatched);

		return authorized;
	}
}
