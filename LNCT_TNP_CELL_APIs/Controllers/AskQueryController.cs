using DemoApiUsingJWT.Request;
using DemoApiUsingJWT.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApiUsingJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AskQueryController : ControllerBase
    {
        private IAskQueryService _askQueryService;

        public AskQueryController(IAskQueryService askQueryService)
        {
            _askQueryService = askQueryService;
        }
        // GET: api/<AskQueryController>
        [HttpGet]
        public IActionResult QueryList()
        {
            var result = _askQueryService.GetAllQuery();
            return Ok(result);
        }

        // GET api/<AskQueryController>/5
        [HttpGet("{id}")]
        public IActionResult GetQuery(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var result = _askQueryService.GetQuery(id); 
            return Ok(result);
        }

        // POST api/<AskQueryController>
        [HttpPost]
        public IActionResult CreateQuery(AskQueryRequestModel askQuery)
        {
            if (askQuery == null)
            {
                return BadRequest();
            }
            var created = _askQueryService.CreateQuery(askQuery);

            return Ok(created);
        }

        // PUT api/<AskQueryController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateQuery(int id, AskQueryRequestModel askQuery)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var updated = _askQueryService.UpdateQuery(askQuery);
            return Ok(updated);
        }

        // DELETE api/<AskQueryController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var getStudent = _askQueryService.DeleteQuery(id);
            if (getStudent == null)
            {
                return NotFound();
            }

            return Ok(getStudent);
        }
    }
}
