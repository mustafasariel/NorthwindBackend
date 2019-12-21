using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Core.Utilities.Security.Encryption;

namespace Core.Utilities.Security.jwt
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get;  }

        TokenOptions _tokenOptions;

        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection(key: "TokenOptions").Get<TokenOptions>();
        }
        public AccessToken CreateToken(User user, List<Claim> claims)
        {

            var securityKey = SecurityHelper.CreateSecurityKey(_tokenOptions.SecurityKey);

            return null;
        }
    }
}