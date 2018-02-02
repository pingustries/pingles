using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Pingles.Models;

namespace Pingles.Client.AspNetCore
{
    public class PinglesBackgroundService : HostedService
    {
        private readonly PinglesClientConfiguration _config;
        private readonly HttpClient _client;

        public PinglesBackgroundService(PinglesClientConfiguration config)
        {
            _config = config;
            _client = new HttpClient {BaseAddress = new Uri(config.PinglesServerUrl)};
        }

        protected override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            await SayHello();

            while (!cancellationToken.IsCancellationRequested)
            {
                await SayIAmAlive();

                await Task.Delay(_config.Frequency * 1000, cancellationToken);
            }
        }

        private async Task SayIAmAlive()
        {
            await Post(new IAmAlive{AppName = _config.AppName}, "api/heartbeat");
        }

        private async Task SayHello()
        {
            await Post(new RegisterPingle { AppName = _config.AppName }, "api/register");
        }

        private async Task Post(object payload, string url)
        {
            var content = new StringContent(JsonConvert.SerializeObject(payload), Encoding.UTF8, "application/json");
            await _client.PostAsync(url, content);
        }
    }
}
