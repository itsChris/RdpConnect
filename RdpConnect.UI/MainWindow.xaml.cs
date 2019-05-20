using RdpConnect.UI.ViewModels;
using System;
using System.Windows;

namespace RdpConnect
{
    public partial class MainWindow : Window
    {
        private ClientViewModel _clientViewModel;

        public MainWindow(ClientViewModel clientViewModel)
        {
            InitializeComponent();
            _clientViewModel = clientViewModel;
            DataContext = _clientViewModel;
            Loaded += WindowLoaded;
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            _clientViewModel.Load();
        }
    }
}
