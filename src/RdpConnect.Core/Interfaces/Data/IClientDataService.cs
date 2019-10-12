using System;
using System.Collections.Generic;
using RdpConnect.Core.Entities;

namespace RdpConnect.Core.Interfaces.Data
{
    public interface IClientDataService
    {
        IEnumerable<Client> GetAllClients();
        Client GetByGuid(Guid guid);
    }
}