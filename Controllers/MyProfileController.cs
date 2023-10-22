using API_CSHARP_PROFILE.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace API_CSHARP_PROFILE.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MyProfileController : ControllerBase
    {
        private readonly IMyProfileService _myProfileService;
        public MyProfileController()
        { }

        [HttpGet("Contact")]
        public async Task<ActionResult> Get()
        {
            var result = await _myProfileService.ContactApplyAsync();
            return result.Data;
        }
    }
}