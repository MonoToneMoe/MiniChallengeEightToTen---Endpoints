using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen___Endpoints.Services.EightBall;

namespace MiniChallengeEightToTen___Endpoints.Controllers;

[ApiController]
[Route("[controller]")]
public class EightBallController : ControllerBase
{
    private readonly IEightBallService _eightBallService;

    public EightBallController(IEightBallService eightBallService)
    {
        _eightBallService = eightBallService;
    }

    [HttpGet]
    [Route("eightball")]
    public string EightBall()
    {
        return _eightBallService.EightBall();
    }
}