using Microsoft.AspNetCore.Mvc;

namespace UserHomework.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<string>> Get()
        {
            return Ok(StaticDb.Usernames);
        }

        [HttpGet("{index}")]
        public ActionResult<string> GetByIndex(int index)
        {
            if (index <= 0)
            {
                return BadRequest("Invalid index number");
            }
            if (index >= StaticDb.Usernames.Count)
            {
                return NotFound($"Username with index:[{index}] was not found");
            }

            return Ok(StaticDb.Usernames[index]);
        }
    }
}
