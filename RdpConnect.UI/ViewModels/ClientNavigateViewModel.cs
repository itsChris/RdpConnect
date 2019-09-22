using RdpConnect.Core.Entities;
using RdpConnect.Core.Interfaces.Data;
using RdpConnect.Core.Events;
using System;
using System.Collections.ObjectModel;

namespace RdpConnect.UI.ViewModels
{
    public class ClientNavigateViewModel : ViewModelBase
    {
        private readonly IClientDataService _clientDataService;
        private readonly ClientEvent _clientEvent;

        private Client _selectedClient;

        public ObservableCollection<Client> Clients { get; set; }

        public Client SelectedClient
        {
            get { return _selectedClient; }
            set
            {
                _selectedClient = value;
                OnPropertyChanged();

                if (_selectedClient != null)
                    _clientEvent.Fire(_selectedClient.Id);
            }
        }

        public ClientNavigateViewModel(IClientDataService clientDataService, ClientEvent clientEvent)
        {
            Clients = new ObservableCollection<Client>();
            _clientDataService = clientDataService;
            _clientEvent = clientEvent;
        }

        public void Load()
        {
            var clients = _clientDataService.GetAllClients();

            Clients.Clear();

            foreach (var client in clients)
                Clients.Add(client);
        }
    }
}
