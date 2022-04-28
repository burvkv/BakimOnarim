using Microsoft.IdentityModel.Tokens;

namespace bakimonarim.core.Utilities.Security.Encryption
{
    public partial class SecurityKeyHelper
    {
        public class SigningCredentialsHelper
        {
            public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
            {
                return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);
            }
        }
    }
}
