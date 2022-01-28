using DemoApiUsingJWT.DbModels;
using DemoApiUsingJWT.Request;
using DemoApiUsingJWT.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApiUsingJWT.Controllers
{
   // [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StudentRegisterController : ControllerBase
    {
        public IAdminService _adminService;
        public StudentRegisterController(IAdminService adminService)
        {
            _adminService = adminService;
        }
      
        // GET: api/<StudentRegisterController>
        [HttpGet]
        public IActionResult StudentList()
        {
            var result = _adminService.GetAllStudents();
            return Ok(result);
        }

        // GET api/<StudentRegisterController>/5
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var result = _adminService.GetStudent(id);
            return Ok(result);
        }

        // POST api/<StudentRegisterController>
       
        [HttpPost]
        public IActionResult CreateStudent(StudentRegisterRequestModel student)
        {
            if (student == null)
            {
                return BadRequest();
            }
             _adminService.AddStudent(student);
            //DbContext.TblStudentRegisters.Add(student);
            //DbContext.SaveChanges();
            //var getStudent = DbContext.TblStudentRegisters.FirstOrDefault(x => x.StudentId == student.StudentId);
            //return CreatedAtAction("Create", new { id = getStudent.StudentId }, getStudent);

            return Ok();
        }


        // PUT api/<StudentRegisterController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, StudentRegisterRequestModel student)
        {
            if (id != student.StudentId)
            {
                return BadRequest();
            }
            
             bool updated = _adminService.UpdateStudent(id, student);
             return Ok(updated);
            
           // return NoContent();
        }

        // DELETE api/<StudentRegisterController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var getStudent = _adminService.DeleteStudent(id);
            if (getStudent == null)
            {
                return NotFound();
            }
            
            return Ok(getStudent);
        }

       

    }

   
}
