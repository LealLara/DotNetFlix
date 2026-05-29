using DotNetFlix.Application.Interfaces.Services.Pattern;
using Microsoft.AspNetCore.Mvc;

namespace DotNetFlix.Api.Controllers
{
    [ApiController]
    [Route("api/PatternAccess")]
    public class PatternAccessController : ControllerBase
    {
        private readonly IPatternAccessService _patternService;
        public PatternAccessController(IPatternAccessService patternAccessService)
        {
            _patternService = patternAccessService;
        }

        [HttpPost("pattern-register")]
        public async Task<IActionResult> PatternRegister()
        {
            try
            {
                return Ok(await _patternService.CreatePatternRegister());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Falha ao efetuar ação");
            }
        }
    }
}