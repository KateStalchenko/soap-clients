using Microsoft.Extensions.Configuration;

namespace ProductSoapClient.Configuration
{
    public class ConfigurationReader
    {
        public static IConfiguration Read()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var configurationRoot = builder.Build();

            return configurationRoot.GetSection(nameof(Configuration)).Get<Configuration>();
        }
    }
}