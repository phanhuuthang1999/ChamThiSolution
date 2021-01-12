using ChamThiSolution.ProxyObject.Interfaces;
using System;

namespace ChamThiSolution.ProxyObject.EventsWrapper
{
    public class ClientEventsWrapper : MarshalByRefObject
    {
        public event EndChannel EndChannelReceived;

        public event GetLogin LoginReceived;

        public event EnableExam ExamReceived;

        public event NopBai NopBaiReceived;

        public void NopBaiReceiveHandler()
        {
            if (NopBaiReceived != null)
            {
                NopBaiReceiveHandler();
            }
        }

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

        public void ExamReceivedHandler()
        {
            if (ExamReceived != null)
            {
                ExamReceived();
            }

        }



    }
}
