using FootballFieldManagement.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFieldManagement.App.HostBuilders
{
    public static class AddDbContextHostBuilder
    {
        public static IHostBuilder AddDbContext(this IHostBuilder host)
        {
            host.ConfigureServices((context, services) =>
            {
                string connectionString = context.Configuration.GetConnectionString("mssqlserver");

                Action<DbContextOptionsBuilder> configureDbContext = o => o.UseSqlServer(connectionString);

                services.AddDbContext<FootballFieldManagementDbContext>(configureDbContext);
                services.AddSingleton<FootballFieldManagementDbContextFactory>(new FootballFieldManagementDbContextFactory(configureDbContext));
            });
            return host;
        }
    }
}
