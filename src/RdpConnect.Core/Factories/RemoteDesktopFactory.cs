using RdpConnect.Core.Entities;
using System.Collections.Generic;

namespace RdpConnect.Core.Factories
{
    static public class RemoteDesktopFactory
    {
        static public RemoteDesktop CreateRemoteDesktop(Client client, string IP, int port)
        {
            var remotedesktop = new RemoteDesktop(IP, port);
            client.AddRemoteDestop(remotedesktop);

            return remotedesktop;
        }

        static public RemoteDesktop CreateRemoteDesktopWidthRemoteUsers(Client client, string IP, int port, IList<RemoteUser> remoteUsers)
        {
            var remotedesktop = new RemoteDesktop(IP, port);
            foreach (var remoteuser in remoteUsers)
                remotedesktop.AddRemoteUser(remoteuser);

            client.AddRemoteDestop(remotedesktop);

            return remotedesktop;
        }
    }
}
