using RdpConnect.Core.Shared.Event;
using System;

namespace RdpConnect.Core.Events
{
    public class ClientEventData : EventData
    {
        public Guid ClientId { get; set; }

        public ClientEventData(Guid clientId)
        {
            ClientId = clientId;
        }
    }
}
