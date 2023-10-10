using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using AuthTask.Models;

namespace AuthTask.Controllers
{
    [RoutePrefix("api/data")]
    public class AuthApiController : ApiController
    {
        private readonly string SecretKey = "your-secret-key"; // Replace with your secret key
        private readonly SymmetricSecurityKey _securityKey;

        private readonly DotNetTrainingEntities Db = new DotNetTrainingEntities(); // Adjust your context here

        public AuthApiController()
        {
            _securityKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(SecretKey));
        }

        [Route("getdata")]
        public IHttpActionResult GetData()
        {
            var data = Db.Users.ToList();
            return Ok(data);
        }

        [Route("setdata")]
        public IHttpActionResult SetData(User data)
        {
            if (data.FirstName != "")
            {
                Db.Users.Add(data);
                Db.SaveChanges();
                return Ok("Done");
            }
            return BadRequest("Fail");
        }

        [Route("get/token"), HttpPost]
        public IHttpActionResult GetToken(Login X)
        {
            // Check if the user exists in the database
            var isUserExist = Db.Logins.Any(i => i.UserName == X.UserName && i.Password == X.Password);

            if (isUserExist)
            {
                var token = GenerateToken(X.UserName);
                return Ok(new { Token = token });
            }
            else
            {
                return BadRequest("User does not exist");
            }
        }

        private string GenerateToken(string username)
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, username),
                // Add any additional claims as needed
            };

            var token = new JwtSecurityToken(
                issuer: "your-issuer", // Replace with your issuer
                audience: "your-audience", // Replace with your audience
                claims: claims,
                notBefore: DateTime.UtcNow,
                expires: DateTime.UtcNow.AddHours(1), // Token expiration time
                signingCredentials: new SigningCredentials(_securityKey, SecurityAlgorithms.HmacSha256)
            );

             return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
