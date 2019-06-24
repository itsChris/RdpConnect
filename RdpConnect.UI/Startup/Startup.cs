using Microsoft.Extensions.DependencyInjection;
using RdpConnect.Core.Interfaces;
using RdpConnect.Infrastructure.Data;
using RdpConnect.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RdpConnect.UI.Startup
{
    class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(typeof(MainWindow));
            services.AddTransient(typeof(ClientViewModel));
            services.AddScoped<IClientDataService, ClientDataService>();
        }
    }
}
