using RdpConnect.Core.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace RdpConnect.Core.Entities
{
    public class RemoteUser : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Password { get; set; }

        public RemoteUser(string name, string password)
        {
            Id = Guid.NewGuid();
            Name = name;
            Password = password;
        }
    }
}
