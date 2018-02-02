using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pingles.Models;

namespace Pingles.Server.Controllers
{
    [Route("api/[controller]")]
    public class RegisterController : Controller
    {
        private readonly ILogger<RegisterController> _logger;

        public RegisterController(ILogger<RegisterController> logger)
        {
            _logger = logger;
        }
        // POST api/values
        [HttpPost]
        public void Post(RegisterPingle register)
        {
            _logger.LogInformation($"Server: {register.AppName}");
        }
    }
}
