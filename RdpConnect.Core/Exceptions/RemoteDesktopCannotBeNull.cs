using System;
using System.Collections.Generic;
using System.Text;

namespace RdpConnect.Core.Exceptions
{
    public class RemoteDesktopCannotBeNull : Exception
    {
        public RemoteDesktopCannotBeNull(string message) : base(message) { }
    }
}
