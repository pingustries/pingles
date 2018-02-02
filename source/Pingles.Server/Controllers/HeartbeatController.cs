using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pingles.Models;

namespace Pingles.Server.Controllers
{
    [Route("api/[controller]")]
    public class HeartbeatController : Controller
    {
        private readonly ILogger<HeartbeatController> _logger;

        public HeartbeatController(ILogger<HeartbeatController> logger)
        {
            _logger = logger;
        }
        // POST api/values
        [HttpPost]
        public void Post(IAmAlive iAmAlive)
        {
            _logger.LogInformation($"Server: {iAmAlive.AppName}");
        }
    }
}
