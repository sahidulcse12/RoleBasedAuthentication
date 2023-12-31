using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace RoleBasedAuthentication.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/manager")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new List<string> { "muhit", "sahid", "jakir" };
        }
    }
}
