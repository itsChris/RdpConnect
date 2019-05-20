using RdpConnect.Core.Exceptions;
using RdpConnect.Core.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace RdpConnect.Core.Entities
{
    public class Client : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public List<RemoteDesktop> RemoteDesktops { get; private set; }

        public Client(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
            RemoteDesktops = new List<RemoteDesktop>();
        }

        public void AddRemoteDestop(RemoteDesktop remoteDesktop)
        {
            if (remoteDesktop != null)
                RemoteDesktops.Add(remoteDesktop);
            else
                throw new RemoteDesktopCannotBeNull("Null can not be added to RemoteDesktops");
        }
    }
}
