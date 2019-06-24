using Microsoft.Extensions.DependencyInjection;
using RdpConnect.Infrastructure.Data;
using RdpConnect.UI.Startup;
using RdpConnect.UI.ViewModels;
using System;
using System.Windows;

namespace RdpConnect
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; } 

        private void App_Startup(object sender, StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            var startup = new Startup();

            startup.ConfigureServices(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = ServiceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();
        }
    }
}
