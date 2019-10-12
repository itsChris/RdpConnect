using RdpConnect.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RdpConnect.Core.Shared.Event
{
    public class EventAggregator
    {
        private List<IBaseEvent> _events;
        public void Register(IBaseEvent newEvent)
        {
            _events.Add(newEvent);
        }
        public void UnRegister(IBaseEvent _event)
        {
            _events.Remove(_event);
        }
        public T GetEvent<T>() where T: class, IBaseEvent
        {
            return _events.Find(e => e.GetType() == typeof(T)) as T;
        }
    }
}
