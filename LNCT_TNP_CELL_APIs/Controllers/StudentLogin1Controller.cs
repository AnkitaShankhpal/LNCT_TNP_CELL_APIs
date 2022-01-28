using DemoApiUsingJWT.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApiUsingJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentLogin1Controller : ControllerBase
    {
        private ILoginService _loginService;
        public StudentLogin1Controller(ILoginService loginService)
        {
            _loginService = loginService;
        }
        
        [HttpPost]
        public IActionResult StudentLogin(string EnrollmentNo, string password)
        {
            var str = _loginService.Student_Login(EnrollmentNo, password);
            return Ok(str);
        }

    }  
}
