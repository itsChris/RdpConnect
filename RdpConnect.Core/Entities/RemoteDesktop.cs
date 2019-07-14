using RdpConnect.Core.Shared;
using RdpConnect.Core.Exceptions;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace RdpConnect.Core.Entities
{
    public class RemoteDesktop : BaseEntity<Guid>
    {
        public IPEndPoint Address { get; set; }
        public List<RemoteUser> RemoteUsers { get; private set; }

        public RemoteDesktop(string IP, int port)
        {
            if (string.IsNullOrEmpty(IP))
                throw new ArgumentNullException("IP");

            //Id = Guid.NewGuid();
            Address = new IPEndPoint(IPAddress.Parse(IP), port);
            RemoteUsers = new List<RemoteUser>();
        }

        public void AddRemoteUser(RemoteUser remoteUser)
        {
            if (remoteUser != null)
                RemoteUsers.Add(remoteUser);
            else
                throw new RemoteUserCannotBeNull("Null can not be added to RemoteUsers");
        }
    }
}
