using RdpConnect.Core.Entities;
using RdpConnect.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RdpConnect.Infrastructure.Data
{
    public class ClientDataService : IClientDataService
    {
        public IEnumerable<Client> GetAllClients()
        {
            yield return new Client("Company");
            yield return new Client("Enterprise");
            yield return new Client("Westeros");
        }
    }
}
