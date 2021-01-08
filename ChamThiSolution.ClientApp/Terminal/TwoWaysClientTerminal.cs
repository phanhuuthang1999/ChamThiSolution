﻿using Common;
using System;
using System.Collections;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters;

namespace ChamThiSolution.ClientApp.Terminal
{
    public class TwoWaysClientTerminal
    {
        private TcpChannel m_Channel;

        public T Connect<T>(string serverName, int port,
            string distributedObjectName, string tcpChannelName)
        {
            //m_Channel = CreateTcpChannel(tcpChannelName);
            //TcpChannel test = new TcpChannel();
            //ChannelServices.RegisterChannel(test, false);

            string fullServerAddress = string.Format(
                "tcp://{0}:{1}/{2}", serverName, port, distributedObjectName);

            // Create a proxy from remote object.
            T res = (T)Activator.GetObject(typeof(T), fullServerAddress);

            return res;
        }

        private static TcpChannel CreateTcpChannel(string tcpChannelName)
        {
            BinaryServerFormatterSinkProvider serverFormatter =
                new BinaryServerFormatterSinkProvider();

            serverFormatter.TypeFilterLevel = TypeFilterLevel.Full;

            BinaryClientFormatterSinkProvider clientProv =
                new BinaryClientFormatterSinkProvider();

            Hashtable props = new Hashtable();
            props["name"] = tcpChannelName;
            props["port"] = 0;

            return new TcpChannel(props, clientProv, serverFormatter);
        }

        public void Disconnect()
        {
            
            if (m_Channel != null)
            {
                try
                {
                    ChannelServices.UnregisterChannel(m_Channel);
                }
                catch (Exception ex)
                {
                    UICommon.ShowMsgErrorString(ex.Message);
                }
            }
        }
    }
}