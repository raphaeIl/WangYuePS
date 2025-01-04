using Microsoft.AspNetCore.Mvc;

namespace NTR.SDKServer.Controllers
{
    namespace NTR.SDKServer.Controllers
    {
        [ApiController]
        [Route("/")]
        public class ServerController : ControllerBase
        {
            private readonly ILogger<LauncherSDKController> _logger;

            public ServerController(ILogger<LauncherSDKController> logger)
            {
                _logger = logger;
            }

            [Route("logs")]
            public IResult PostLogs()
            {
                return Results.Text(@"
{
    ""code"": 0,
    ""message"": ""success"",
}
");
            }

            [Route("maintain/queryEntry")]
            public IResult PostQueryEntry()
            {
                return Results.Text(@"
{
    ""code"": 0,
    ""msg"": ""ok"",
    ""data"": {
        ""open_status"": 1,
        ""content"": ""seggs"",
        ""isWhite"": true
    }
}
");
            }

            [Route("v1/health/service/adamas_game_Server")]
            public IResult GetGameServer()
            {
                return Results.Text(@"
[
  {
    ""Service"": {
      ""ID"": ""seggs_server"",
      ""Address"": ""192.168.86.32"",
      ""Port"": 6969
    }
  }
]
");
            }
        }
    }
}
