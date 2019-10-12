using RdpConnect.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RdpConnect.Core.Shared.Event
{
    public abstract class BaseEvent<T> : IBaseEvent where T: EventData
    {
        public delegate void EventCallBack(T data);
        public event EventCallBack Event;
        public virtual void Fire(T data)
        {
            Event(data);
        }
        public void Subscribe(EventCallBack callBack)
        {
            Event += callBack;
        }
        public void UnSubscribe(EventCallBack callBack)
        {
            Event -= callBack;
        }
        public bool IsCallBackSubscribed(EventCallBack callBack)
        {
            if (callBack != null)
            {
                foreach (EventCallBack subscribedCallBack in Event.GetInvocationList())
                {
                    if (subscribedCallBack == callBack)
                        return true;
                }
            }
            return false;
        }
    }
}
