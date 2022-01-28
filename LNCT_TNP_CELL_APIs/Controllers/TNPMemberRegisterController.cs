using DemoApiUsingJWT.Request;
using DemoApiUsingJWT.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApiUsingJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TNPMemberRegisterController : ControllerBase
    {
        public IAdminService _adminService;

        public TNPMemberRegisterController(IAdminService adminService)
        {
            this._adminService = adminService;
        }
        // GET: api/<TNPMemberRegisterController>
        [HttpGet]
        public IActionResult GetAllTNPMember()
        {
           var result =_adminService.GetAllTNPMember();
            return Ok(result);
        }

        // GET api/<TNPMemberRegisterController>/5
        [HttpGet("{id}")]
        public IActionResult GetTNPMember(int id)
        {
            TnpMemberRegisterRequestModel tNPMemberRegister = new TnpMemberRegisterRequestModel();
            if (id == null)
            {
                return BadRequest();
            }
            var result = _adminService.GetTNPMember(id);
            return Ok(result);
        }

        // POST api/<TNPMemberRegisterController>
        [HttpPost]
        public IActionResult CreateTNPMember(TnpMemberRegisterRequestModel tNPMemberRegister)
        {
            if (tNPMemberRegister == null)
            {
                return BadRequest();
            }
            _adminService.AddTNPMember(tNPMemberRegister);
            //return CreatedAtAction("Create", new { id = addedTnp.Tnpid }, addedTnp);
            return Ok();
        }

        // PUT api/<TNPMemberRegisterController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateTNPMember(int id, TnpMemberRegisterRequestModel tnpMemberRegister)
        {
            if (id == null)
            {
                return BadRequest();
            }


            bool updateTnp = _adminService.UpdateTNPMember(tnpMemberRegister);
            return Ok(updateTnp);
        }

        // DELETE api/<TNPMemberRegisterController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteTNPMember(int id)
        {
            var getTNP = _adminService.DeleteTnpMember(id);
            if (getTNP == null)
            {
                return NotFound();
            }

            return Ok(getTNP);
        }
    }
}
