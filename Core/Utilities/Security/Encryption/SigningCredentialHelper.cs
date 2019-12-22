using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Encryption
{
    /// <summary>
    /// SigningCredentials oluşturan bir class
    /// </summary>
    public class SigningCredentialHelper
    {
        /// <summary>
        /// securityKey parametresini alıp SigningCredentials create eder.
        /// </summary>
        /// <param name="securityKey"></param>
        /// <returns></returns>
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, algorithm: SecurityAlgorithms.HmacSha256Signature);
        }
    }
}