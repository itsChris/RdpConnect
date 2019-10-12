using RdpConnect.Core.Shared.Event;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;

namespace RdpConnect.Core.UnitTest.Shared.Event
{
    public class BaseEventShould
    {
        [Fact]
        public void SubscribeGivenMethodToEventCallBackEvent()
        {
            //EventData mockeventData = new Mock<EventData>().Object;
            BaseEvent<EventData> mockEvent = new Mock<BaseEvent<EventData>>().Object;
            mockEvent.Subscribe(MockCallBack);

            Assert.True(mockEvent.IsCallBackSubscribed(MockCallBack));
        }

        private void MockCallBack(EventData eventData)
        { }
    }
}
