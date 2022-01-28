using DemoApiUsingJWT.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApiUsingJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminLoginController : ControllerBase
    {
        private ILoginService _loginService;
        public AdminLoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }

        [HttpPost]
        public IActionResult Admin_Login(string UserName, string password)
        {
            var str = _loginService.Admin_Login(UserName, password);    
            return Ok(str);
        }

    }
}
