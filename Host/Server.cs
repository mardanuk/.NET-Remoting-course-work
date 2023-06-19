using System;
using System.Collections.Generic;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Serialization.Formatters;
using RemoteSharedTCP;

namespace Host
{
    class Server
    {
        static void Main(string[] args)
        {
            //TCP Server
            TcpChannel tcpChannel = new TcpChannel(new Dictionary<string, string> { { "port", "9999" }, { "secure", "true" }, 
                                                                                    { "protectionLevel", "EncryptAndSign" }, 
                                                                                    { "impersonate", "false" } },
                                    new BinaryClientFormatterSinkProvider(),
                                    new BinaryServerFormatterSinkProvider { TypeFilterLevel = TypeFilterLevel.Full });
            ChannelServices.RegisterChannel(tcpChannel, false);
            RemotingConfiguration.ApplicationName = "TCP";
            RemotingConfiguration.RegisterActivatedServiceType(typeof(SharedTCP));

            Console.WriteLine("______________________\nServer TCP started...");


            //HTTP Server
            RemotingConfiguration.Configure("Server.config", false);

            Console.WriteLine("Server HTTP started...\n______________________");
            Console.ReadLine();
        }
    }
}