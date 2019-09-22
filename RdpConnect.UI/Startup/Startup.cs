using Microsoft.Extensions.DependencyInjection;
using RdpConnect.Core.Interfaces.Data;
using RdpConnect.Infrastructure.Data;
using RdpConnect.Core.Events;
using RdpConnect.UI.ViewModels;

namespace RdpConnect.UI.Startup
{
    class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(typeof(MainWindow));
            services.AddTransient(typeof(MainViewModel));

            services.AddTransient(typeof(ClientNavigateViewModel));
            services.AddTransient(typeof(ClientViewModel));
            services.AddSingleton(typeof(ClientEvent));
            services.AddScoped<IClientDataService, ClientDataService>();
        }
    }
}
