using RdpConnect.Core.Entities;
using RdpConnect.Core.Interfaces;
using System.Collections.ObjectModel;

namespace RdpConnect.UI.ViewModels
{
    public class RemoteDesktopViewModel : ViewModelBase
    {
        private readonly IRemoteDesktopDataService _remoteDesktopDataService;
        public ObservableCollection<RemoteDesktop> RemoteDesktops { get; set; }

        public RemoteDesktopViewModel(IRemoteDesktopDataService remoteDesktopDataService)
        {
            _remoteDesktopDataService = remoteDesktopDataService;
        }

        public void Load()
        {
            //TODO Filter by client
            var desktops = _remoteDesktopDataService.GetAllRemoteDesktops();

            RemoteDesktops.Clear();

            foreach (var remotedesktop in desktops)
                RemoteDesktops.Add(remotedesktop);
        }
    }
}
