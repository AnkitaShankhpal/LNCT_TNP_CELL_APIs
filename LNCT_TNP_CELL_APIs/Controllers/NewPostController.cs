using DemoApiUsingJWT.Request;
using DemoApiUsingJWT.Service;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApiUsingJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewPostController : ControllerBase
    {
        private INewPostService _newPostService;
        public NewPostController(INewPostService newPostService)
        {
            _newPostService = newPostService;
        }
        // GET: api/<NewPostController>
        [HttpGet]
        public IActionResult NewPostList()
        {
            var result = _newPostService.GetPostList();
            return Ok(result);
        }

        // GET api/<NewPostController>/5
        [HttpGet("{id}")]
        public IActionResult GetNewPost(int id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var result = _newPostService.getNewPost(id);
            return Ok(result);
        }


        // POST api/<NewPostController>
        [HttpPost]
        public IActionResult CreateQuery(NewPostRequestModel newPostRequestModel)
        {
            if (newPostRequestModel == null)
            {
                return BadRequest();
            }
            var created = _newPostService.createNewPost(newPostRequestModel);

            return Ok(created);
        }

        // PUT api/<NewPostController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateNewPost(int id, NewPostRequestModel newPostRequestModel)
        {
            if (id == null)
            {
                return BadRequest();
            }
            var updated = _newPostService.updateNewPost(newPostRequestModel);
            return Ok(updated);
        }

        // DELETE api/<NewPostController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deleted = _newPostService.DeleteNewPost(id);
            if (deleted == null)
            {
                return NotFound();
            }

            return Ok(deleted);
        }
    }
}
