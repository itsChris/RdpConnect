using RdpConnect.Core.Entities;
using RdpConnect.Core.Interfaces;
using System.Collections.ObjectModel;

namespace RdpConnect.UI.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        private readonly IClientDataService _clientDataService;
        private Client _selectedClient;

        public ClientViewModel(IClientDataService clientDataService)
        {
            Clients = new ObservableCollection<Client>();
            this._clientDataService = clientDataService;
        }

        public void Load()
        {
            var clients = _clientDataService.GetAllClients();

            Clients.Clear();

            foreach (var client in clients)
                Clients.Add(client);
        }

        public ObservableCollection<Client> Clients { get; set; }

        public Client SelectedClient
        {
            get { return _selectedClient; }
            set
            {
                _selectedClient = value;
                OnPropertyChanged();
            }
        }
    }
}
