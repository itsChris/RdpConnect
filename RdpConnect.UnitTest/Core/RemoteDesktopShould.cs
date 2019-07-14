using RdpConnect.Core.Entities;
using RdpConnect.Core.Exceptions;
using System;
using Xunit;

namespace RdpConnect.UnitTest.Core
{
    public class RemoteDesktopShould
    {
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void ThrowArgumentNullExceptionWithNullorEmptyIP(string IP)
        {
            Assert.Throws<ArgumentNullException>(() => new RemoteDesktop(IP, 4444));
            
        }

        [Fact]
        public void CreateRemoteDesktop()
        {
            string IP = "127.0.0.1";
            int port = 4444;

            RemoteDesktop remoteDesktop = new RemoteDesktop(IP, port);

            Assert.Equal(IP, remoteDesktop.Address.Address.ToString());
            Assert.Equal(port, remoteDesktop.Address.Port);
        }

        [Fact]
        public void CreateRemoteDesktopandRemoteUserShouldnotbeNull()
        {
            string IP = "127.0.0.1";
            int port = 4444;

            RemoteDesktop remoteDesktop = new RemoteDesktop(IP, port);

            Assert.NotNull(remoteDesktop.RemoteUsers);
        }

        [Fact]
        public void AddRemoteUserToItsRemoteUsersProperty()
        {
            string testuser = "testname";
            string testpassword = "pass01";
            string IP = "127.0.0.1";
            int port = 4444;

            RemoteUser remoteUser = new RemoteUser(testuser, testpassword);
            RemoteDesktop remoteDesktop = new RemoteDesktop(IP, port);

            remoteDesktop.AddRemoteUser(remoteUser);

            Assert.Contains(remoteUser, remoteDesktop.RemoteUsers);
        }

        [Fact]
        public void ThrowRemoteUserCannotBeNullWhenAddNullRemoteUser()
        {
            string IP = "127.0.0.1";
            int port = 4444;

            RemoteDesktop remoteDesktop = new RemoteDesktop(IP, port);

            Assert.Throws<RemoteUserCannotBeNull>(() => remoteDesktop.AddRemoteUser(null));
        }
    }
}
