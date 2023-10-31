using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ProgrammingCourse.Examples
{
    internal class JwtExample
    {
        public void Run()
        {
            var jwtExample = new JwtExample();
            var secret = "43234kj2h34k2jh34k2jh34kj2h34kj2h34k2h34j23k4h";
            var expires = DateTime.UtcNow.AddMinutes(3);
            var data = new List<Claim>
            {
                new Claim("role", "admin"),
                new Claim("user_type", "worker"),
                new Claim("name", "John Doe")
            };

            var token = jwtExample.CreateToken(secret, expires, data);
            Console.WriteLine($"Token: {token}");

            Console.Write("Validation: ");
            try
            {
                jwtExample.ValidateToken(token, secret);
                Console.WriteLine("Token Valid");
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Invalid - {exc.Message}");
            }
        }

        public void CreateExampleToken()
        {
            var claims = new List<Claim>
            {
                new Claim("role", "admin"),
                new Claim("name", "John")
            };

            var secret = Encoding.ASCII.GetBytes("23423423423423423423423423434234");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(secret),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            Console.WriteLine(tokenHandler.WriteToken(token));
        }

        public string CreateToken(string secret, DateTime expires, IList<Claim> claims)
        {
            var secretBytes = Encoding.ASCII.GetBytes(secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = expires,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(secretBytes),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public void ValidateToken(string token, string secret)
        {
            var secretBytes = Encoding.ASCII.GetBytes(secret);

            var validationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(secretBytes),
                ValidateAudience = false,
                ValidateIssuer = false,
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            tokenHandler.ValidateToken(token, validationParameters, out _);
        }
    }
}
