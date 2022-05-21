using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Features.Platforms.TestInboundConnection;

[ApiController]
[Route(Routes.Platforms)]
public class TestInboundConnection : ControllerBase
{
    public TestInboundConnection()
    {
    }

    [HttpPost]
    [Produces("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public ActionResult Handle()
    {
        Console.WriteLine("--> Inbound POST @ Command Service");
        return Ok("Inbound test from Command Service");
    }
}
