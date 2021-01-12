using ChamThiSolution.ProxyObject.Interfaces;
using System;

namespace ChamThiSolution.ProxyObject.EventsWrapper
{
    public class ClientEventsWrapper : MarshalByRefObject
    {
        public event EndChannel EndChannelReceived;
        public event ButtonEnable ButtonEnableReceived;

        public event GetLogin LoginReceived;

        public void EndChannelReceiveHandler()
        {
            if (EndChannelReceived != null)
            {
                EndChannelReceived();
            }
        }

        public bool LoginReceivedHandler(string taikhoan, string matkhau)
        {
            if (LoginReceived != null)
            {
                LoginReceived(taikhoan, matkhau);
            }
            return true;
        }
        public void ButtonEnableReceivedHandler()
        {
            if (ButtonEnableReceived != null)
            {
                ButtonEnableReceived();
            }
        }
    }
}
