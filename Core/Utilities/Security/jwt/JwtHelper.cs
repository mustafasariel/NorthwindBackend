using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Core.Utilities.Security.Encryption;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Core.Extentions;
using System.Linq;

namespace Core.Utilities.Security.jwt
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get;  }

        TokenOptions _tokenOptions;

        DateTime _accessTokenExpiration;

        public JwtHelper(IConfiguration configuration)
        {
            Configuration = configuration;
            _tokenOptions = Configuration.GetSection(key: "TokenOptions").Get<TokenOptions>();
            _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
        }
        public AccessToken CreateToken(User user, List<Role> claims)
        {
            //new SymmetricSecurityKey(Encoding.UTF8.GetBytes(securityKey));
            var securityKey = SecurityHelper.CreateSecurityKey(_tokenOptions.SecurityKey);

            var signingCredentials = SigningCredentialHelper.CreateSigningCredentials(securityKey);

            return null;
        }

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<Role> roles)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                //claims: claims,
                signingCredentials: signingCredentials

                );

            return null;

        }

        IEnumerable<Claim> SetClaims(User user,List<Role> roles )
        {
            var claims = new List<Claim>();
            claims.AddEmail(user.Email);
            claims.AddName($"{user.FirstName} {user.LastName}");
            claims.AddNameIdentifier(user.Id.ToString());
            claims.AddRoles(roles.Select(c => c.Name).ToArray());

            return claims;
        }
    }
}