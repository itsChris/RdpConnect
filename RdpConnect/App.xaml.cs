using RdpConnect.Infrastructure.Data;
using RdpConnect.UI.ViewModels;
using System.Windows;

namespace RdpConnect
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void App_Startup(object sender, StartupEventArgs e)
        {
            var mainWindow = new MainWindow(new ClientViewModel(new ClientDataService()));
            mainWindow.Show();
        }
    }
}
