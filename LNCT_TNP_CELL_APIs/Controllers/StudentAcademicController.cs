using DemoApiUsingJWT.Request;
using DemoApiUsingJWT.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApiUsingJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAcademicController : ControllerBase
    {
        private IStudentAcademicService _studentAcademicService;

        public StudentAcademicController(IStudentAcademicService studentAcademicService)
        {
            _studentAcademicService = studentAcademicService;
        }

        // GET: api/<StudentAcademicController>
        [HttpGet]
        public IActionResult StudentAcademicList()
        {
            var result = _studentAcademicService.GetAllStudentAcademic();
            return Ok(result);
        }

        // GET api/<StudentAcademicController>/5
        [HttpGet("{id}")]
        public IActionResult GetStudentAcademic(int id)
        {
            var result = _studentAcademicService.GetStudentAcademic(id);
            return Ok(result);
        }

        // POST api/<StudentAcademicController>
        [HttpPost]
        public IActionResult PostStudentAcademic(StudentAcademicRequestModel studentAcademicRequestModel)
        {
            _studentAcademicService.AddStudentAcademic(studentAcademicRequestModel);
            return Ok();
        }

        // PUT api/<StudentAcademicController>/5
        [HttpPut("{id}")]
        public IActionResult PutStudentAcademic(StudentAcademicRequestModel studentAcademicRequestModel, int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            bool updatedSA =_studentAcademicService.UpdatedStudentAcademic(studentAcademicRequestModel);
            return Ok(updatedSA);
        }

        // DELETE api/<StudentAcademicController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteStudentAcademic(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var deltStudent = _studentAcademicService.DeleteStudentAcademic(id);
            return Ok(deltStudent);
        }
    }
}
