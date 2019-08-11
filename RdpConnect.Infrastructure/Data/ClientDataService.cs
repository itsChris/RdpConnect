using RdpConnect.Core.Entities;
using RdpConnect.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RdpConnect.Infrastructure.Data
{
    public class ClientDataService : IClientDataService
    {
        private List<Client> Clients;

        public ClientDataService()
        {
            Clients = new List<Client>();
            Clients.Add(new Client("Company"));
            Clients.Add(new Client("Enterprise"));
            Clients.Add(new Client("Westeros"));
        }

        public IEnumerable<Client> GetAllClients()
        {

            foreach (var client in Clients)
                yield return client;
        }

        public Client GetByGuid(Guid guid)
        {
            return Clients.Find(c => c.Id.Equals(guid));
        }
    }
}
