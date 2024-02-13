using CI.BRE.REPOSITERY.Entities;
using CI.BRE.SERVICE.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CI.BRE.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArgumentValueController : ControllerBase
    {
        private readonly IServices<SpsBrArgumentValue> _argumentvalue;
        public ArgumentValueController(IServices<SpsBrArgumentValue> argumentvalue)
        {
            _argumentvalue = argumentvalue;

        }

        [HttpPost("Add")]
        public async Task<IActionResult> CreatePost(InsertData post)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var createdPost = await _argumentvalue.AddAsync(post);
            return CreatedAtAction(nameof(CreatePost), createdPost);
        }
    }
}

