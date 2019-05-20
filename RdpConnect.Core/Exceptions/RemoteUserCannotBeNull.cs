using System;
using System.Collections.Generic;
using System.Text;

namespace RdpConnect.Core.Exceptions
{
    public class RemoteUserCannotBeNull : Exception
    {
        public RemoteUserCannotBeNull(string message) : base(message) { }
    }
}
