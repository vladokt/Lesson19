using DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration.Json;

namespace API
{
    /// <summary>
    /// Startup extention class. Configuring and connecting database.
    /// </summary>
    public static class StartupExtension
    {
        /// <summary>
        /// Register appDbContext.
        /// </summary>
        public static void ConfigureDbConnection(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>();
        }

        //public static void ConfigureDbConnection(this IServiceCollection services, IConfiguration configuration)
        //{
        //    services.AddDbContext<AppDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        //}
    }
}