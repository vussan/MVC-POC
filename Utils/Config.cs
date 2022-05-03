using Microsoft.Extensions.Configuration;

namespace Utils
{
    public class Config
    {
        private static readonly IConfiguration _config;
        static Config()
        {
            var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _config = configurationBuilder.Build();

            configurationBuilder.AddJsonFile($"appsettings.{_config.GetSection("ENV").Value}.json", optional: true);
            _config = configurationBuilder.Build();
        }

        public static string ConnectionString { get { return _config.GetConnectionString("Default"); } }
        public static string TokenIssuer { get { return _config.GetSection("Token:Issuer").Value; } }

    }
}