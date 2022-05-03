using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestApi.Controllers
{
    
    [ApiController]
    public class TestControl : ControllerBase
    {

        [Route("api/testMethod")]
        [HttpGet]
        public ActionResult testMethod(string testParam)
        {
            return Ok(new { status = testParam });

        }


    }
}