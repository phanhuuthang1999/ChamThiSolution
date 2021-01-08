using ChamThiSolution.ProxyObject.Interfaces;
using System;

namespace ChamThiSolution.ProxyObject.EventsWrapper
{
    public class ClientEventsWrapper : MarshalByRefObject
    {
        public event EndChannel EndChannelReceived;
        public event GetConnection ConnectionReceived;

        public event GetLogin LoginReceived;

        public void EndChannelReceiveHandler()
        {
            if (EndChannelReceived != null)
            {
                EndChannelReceived();
            }
        }

        public void ConnectionReceiveHandler()
        {
            if (ConnectionReceived != null)
            {
                ConnectionReceived();
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
    }
}
