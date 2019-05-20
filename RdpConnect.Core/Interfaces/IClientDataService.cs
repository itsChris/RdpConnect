using System.Collections.Generic;
using RdpConnect.Core.Entities;

namespace RdpConnect.Core.Interfaces
{
    public interface IClientDataService
    {
        IEnumerable<Client> GetAllClients();
    }
}