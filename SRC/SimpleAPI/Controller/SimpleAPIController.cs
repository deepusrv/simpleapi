using Microsoft.AspNetCore.Mvc;

namespace Simpleapi.SimpleApiController
{
    [ApiController]
    [Route("api/[controller]")]
    public class SimpleAPIController :ControllerBase
    {
    [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Les Jackson";
        }
    }
};