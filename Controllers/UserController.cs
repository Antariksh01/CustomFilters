using CustomFilters.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomFilters.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [MySampleFilterAttribute("Test")]
    public class UserController : ControllerBase
    {
        public string Get()
        {
            return "Hello World";
        }
    }
}
