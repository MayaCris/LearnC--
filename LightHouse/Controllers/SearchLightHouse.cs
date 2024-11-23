
using Microsoft.AspNetCore.Mvc;

[Controller]
[Route("api/[controller]")]
public class SearchLightHouse: ControllerBase
{
    [HttpPost]
    [Route("TurnOnTheLight")]
    public async Task<IActionResult> TurnOnTheLight()
    {
        return Ok();
    }
}