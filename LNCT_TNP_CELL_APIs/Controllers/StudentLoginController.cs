using DemoApiUsingJWT.DbModels;
using DemoApiUsingJWT.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace DemoApiUsingJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentLoginController : ControllerBase
    {
        public IConfiguration _configuration;
        private CoreDbContext DbContext = new CoreDbContext();

        public StudentLoginController(IConfiguration config)
        {
            _configuration = config;
        }

        [HttpPost]
        public IActionResult Login(StudentLoginRequestModel student)
        {
            if (student != null)
            {
                var user = GetUser(student.EnrollmentNo, student.Password);
                if (user != null)
                {
                    string token = GenerateJWTToken(student.EnrollmentNo, student.Password);
                    return Ok(token);
                }
            }
            return Ok("Model is not valid.");
        }
        private string GenerateJWTToken(string enroll,string passw)
        {
            //create claims details based on the user information
            var claims = new[] 
            {
                    new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                    new Claim("EnrollmentNo", enroll),
                    new Claim("Password", passw)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));

            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_configuration["Jwt:Issuer"], _configuration["Jwt:Audience"], claims, expires: DateTime.UtcNow.AddDays(1), signingCredentials: signIn);

            var jwtToken=new JwtSecurityTokenHandler().WriteToken(token);
            return jwtToken;
        }

        private TblStudentRegister GetUser(string EnrollmentNo, string password)
        {
            return DbContext.TblStudentRegisters.FirstOrDefault(u => u.EnrollmentNo == EnrollmentNo && u.Password == password);
        }
    }
}
