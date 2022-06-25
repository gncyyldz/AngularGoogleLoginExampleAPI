using AngularGoogleLoginExampleAPI.Services.Abstractions;
using AngularGoogleLoginExampleAPI.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AngularGoogleLoginExampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        readonly IGoogleIdTokenValidationService _googleIdTokenValidationService;

        public UsersController(IGoogleIdTokenValidationService googleIdTokenValidationService)
        {
            _googleIdTokenValidationService = googleIdTokenValidationService;
        }

        [HttpPost]
        public async Task<IActionResult> Login(GoogleLoginVM model)
        {
            Token token = await _googleIdTokenValidationService.ValidateIdTokenAsync(model);
            return Ok(token);
        }
    }
}
