using FootballFieldManagement.App.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballFieldManagement.App.HostBuilders
{
    public static class AddViewHostBuilder
    {
        public static IHostBuilder AddView(this IHostBuilder host)
        {
            host.ConfigureServices(service =>
            {
                service.AddSingleton<MainWindowView>();
            });
            return host;
        }
    }
}
