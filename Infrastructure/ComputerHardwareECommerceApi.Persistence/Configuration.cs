

using Microsoft.Extensions.Configuration;

namespace ComputerHardwareECommerceApi.Persistence
{
    public static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configuration = new();
                configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ComputerHardwareECommerceApi.Api"));
                configuration.AddJsonFile("appsettings.json");
                return configuration.GetConnectionString("DefaultConnection");
            }
        }
    }
}
