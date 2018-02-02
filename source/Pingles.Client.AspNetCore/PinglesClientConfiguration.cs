namespace Pingles.Client.AspNetCore
{
    public class PinglesClientConfiguration
    {
        public string PinglesServerUrl { get; }
        public string AppName { get; }
        public int Frequency { get; }

        public PinglesClientConfiguration(string pinglesServerUrl, string appName)
        {
            PinglesServerUrl = pinglesServerUrl;
            AppName = appName;
            Frequency = 10;
        }
    }
}