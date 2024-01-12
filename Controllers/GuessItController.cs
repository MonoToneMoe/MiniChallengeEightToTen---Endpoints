using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen___Endpoints.Services.GuessIt;

namespace MiniChallengeEightToTen___Endpoints.Controllers;
[ApiController]
[Route("[controller]")]
public class GuessItController : ControllerBase
{
    private readonly IGuessItService _guessItService;

    public GuessItController(IGuessItService guessItService)
    {
        _guessItService = guessItService;
    }

    [HttpGet]
    [Route("guessit/easy/{num}")]
    public string EasyRange(string num)
    {
        return _guessItService.EasyRange(num);
    }
    
    [HttpGet]
    [Route("guessit/medium/{num}")]
    public string MediumRange(string num)
    {
        return _guessItService.MediumRange(num);
    }

    [HttpGet]
    [Route("guessit/hard/{num}")]
    public string HardRange(string num)
    {
        return _guessItService.HardRange(num);
    }
}