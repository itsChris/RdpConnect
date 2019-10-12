using System;
using System.Collections.Generic;
using System.Text;

namespace RdpConnect.UI.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public ClientNavigateViewModel ClientNavigateViewModel { get;}
        public ClientViewModel ClientViewModel { get;}

        public MainViewModel(ClientNavigateViewModel clientNavigateViewModel, ClientViewModel clientViewModel)
        {
            ClientNavigateViewModel = clientNavigateViewModel;
            ClientViewModel = clientViewModel;
        }

        public void Load()
        {
            ClientNavigateViewModel.Load();
        }
    }
}
