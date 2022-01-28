using DemoApiUsingJWT.Request;
using DemoApiUsingJWT.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApiUsingJWT.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class StudentsProfileController : ControllerBase
    {
        public IStudentsProfileService _studentsProfileService;

        public StudentsProfileController(IStudentsProfileService studentsProfileService)
        {
            _studentsProfileService = studentsProfileService;
        }
        // GET: api/<StudentProfileController>
        [HttpGet]
        public IActionResult StudentProfileList()
        {
            var result = _studentsProfileService.GetAllStudentProfile();
            return Ok(result);
        }

        // GET api/<StudentProfileController>/5
        [HttpGet("{id}")]
        public IActionResult GetStudentProfile(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var result = _studentsProfileService.GetStudentProfile(id);
            return Ok(result);
        }

        // POST api/<StudentProfileController>
        [HttpPost]
        public IActionResult CreateStudentProfile(StudentProfileRequestModel student)
        {
            if (student == null)
            {
                return BadRequest();
            }
            _studentsProfileService.AddStudentProfile(student);

            return Ok();
        }

        // PUT api/<StudentProfileController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateTNPMember(int id, StudentProfileRequestModel student)
        {
            if (id == null)
            {
                return BadRequest();
            }
            bool updatestd = _studentsProfileService.UpdateStudentProfile(student);
            return Ok(updatestd);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var getStudent = _studentsProfileService.DeleteStudentProfile(id);
            if (getStudent == null)
            {
                return NotFound();
            }

            return Ok(getStudent);
        }
    }
}
