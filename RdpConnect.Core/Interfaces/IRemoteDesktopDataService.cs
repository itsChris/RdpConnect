using RdpConnect.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RdpConnect.Core.Interfaces
{
    public interface IRemoteDesktopDataService
    {
        IEnumerable<RemoteDesktop> GetAllRemoteDesktops();
    }
}
