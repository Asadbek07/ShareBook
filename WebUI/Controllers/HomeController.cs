using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    [Route("api/home")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Our beatiful API is working!";
        }
    }
}
