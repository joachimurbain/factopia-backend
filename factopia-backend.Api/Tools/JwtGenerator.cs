using factopia_backend.Domain.Models;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace factopia_backend.Api.Tools
{
    public class JwtGenerator
    {
        private IConfiguration _config;

        public JwtGenerator(IConfiguration config)
        {
            _config = config;
        }
        public string Generate(User user)
        {
            if (user is null)
            {
                throw new ArgumentNullException("user is null");
            }

            string key = _config.GetSection("tokenInfo").GetSection("secretKey").Value;
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
            SigningCredentials signingKey = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512);

            Claim[] myClaims =
            {
                new Claim(ClaimTypes.Sid, user.Id.ToString()),
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim(ClaimTypes.Email, user.Email)
        };

            JwtSecurityToken jwt = new JwtSecurityToken(
                    claims: myClaims,
                    signingCredentials: signingKey,
                    expires: DateTime.Now.AddDays(7),
                    issuer: "https://localhost:7030",
                    audience: "http://localhost:4200"
                );

            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();

            return handler.WriteToken(jwt);
        }

    }
}
