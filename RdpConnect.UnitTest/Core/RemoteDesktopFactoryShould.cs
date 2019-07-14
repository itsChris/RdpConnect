using RdpConnect.Core.Entities;
using Xunit;
using RdpConnect.Core.Factories;

namespace RdpConnect.UnitTest.Core
{
    public class RemoteDesktopFactoryShould
    {
        [Fact]
        public void CreateRemoteDesktop()
        {
            Client client = new Client("Test");

            RemoteDesktop remoteDesktop = RemoteDesktopFactory.CreateRemoteDesktop(client, "127.0.0.1", 4444);

            Assert.NotNull(remoteDesktop);
            Assert.Equal("127.0.0.1", remoteDesktop.Address.Address.ToString());
            Assert.Equal(4444, remoteDesktop.Address.Port);
        }

        [Fact]
        public void CreateRemoteDesktopAndAddItToClient()
        {
            Client client = new Client("Test");

            RemoteDesktop remoteDesktop = RemoteDesktopFactory.CreateRemoteDesktop(client, "127.0.0.1", 4444);

            Assert.Contains(remoteDesktop, client.RemoteDesktops);

        }
    }
}
