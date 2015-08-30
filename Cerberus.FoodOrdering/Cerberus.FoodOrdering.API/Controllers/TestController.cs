using System.Web.Http;

namespace Cerberus.FoodOrdering.API.Controllers
{
    public class TestController : ApiController
    {
        [HttpGet]
        [Route("api/test/testok")]
        public IHttpActionResult TestOk()
        {
            return Ok();
        }

        [HttpGet]
        [Route("api/test/testbadrequest")]
        public IHttpActionResult TestBadRequest()
        {
            return BadRequest();
        }

        [HttpGet]
        [Route("api/test/testnotfound")]
        public IHttpActionResult TestNotFound()
        {
            return NotFound();
        }
    }
}