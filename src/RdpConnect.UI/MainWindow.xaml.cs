using RdpConnect.UI.ViewModels;
using System;
using System.Windows;

namespace RdpConnect
{
    public partial class MainWindow : Window
    {
        public MainViewModel MainViewModel { get;}

        public MainWindow(MainViewModel mainViewModel)
        {
            InitializeComponent();
            MainViewModel = mainViewModel;
            DataContext = MainViewModel;
            Loaded += WindowLoaded;
        }

        private void WindowLoaded(object sender, RoutedEventArgs e)
        {
            MainViewModel.Load();
        }
    }
}
