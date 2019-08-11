using RdpConnect.Core.Entities;
using RdpConnect.Core.Interfaces;
using RdpConnect.Core.Events;
using System;

namespace RdpConnect.UI.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        private readonly IClientDataService _clientDataService;
        private readonly ClientEvent _clientEvent;

        private Client _client;
        public Client Client
        {
            get
            {
                return _client;
            }
            set
            {
                _client = value;
                OnPropertyChanged();
            }
        }

        public ClientViewModel(IClientDataService clientDataService, ClientEvent clientEvent)
        {
            _clientDataService = clientDataService;
            _clientEvent = clientEvent;
            _clientEvent.Subscribe(OnOpenClientView);
        }

        public void Load(Guid clientGuid)
        {
            Client = _clientDataService.GetByGuid(clientGuid);
        }

        private void OnOpenClientView(Guid clientGuid)
        {
            Load(clientGuid);
        }
    }
}
