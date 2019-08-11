using System;
using System.Collections.Generic;
using System.Text;

namespace RdpConnect.Core.Shared
{
    public abstract class BaseEvent<T>
    {
        public delegate void EventDelegate(T data);
        public event EventDelegate Event;
        public void Fire(T data)
        {
            Event(data);
        }
        public void Subscribe(EventDelegate func)
        {
            Event += func;
        }
        public void UnSubscribe(EventDelegate func)
        {
            Event -= func;
        }
    }
}
