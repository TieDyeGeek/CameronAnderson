using OtpNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameronAnderson.Secure
{
	public class OtpAuthorize : IAuthorize
	{
		private string OtpKey => "";

		public bool CanAccess(string password)
		{
			var key = Base32Encoding.ToBytes(OtpKey);
			var totp = new Totp(key);
			var authorized = totp.VerifyTotp(password, out var timeStepMatched);

			return authorized;
		}
	}
}
