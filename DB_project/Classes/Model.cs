using System;
using System.Runtime.Remoting.Channels.Tcp;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using RemoteSharedTCP;
using RemoteSharedHTTP;
using System.Collections.Generic;
using System.Runtime.Remoting.Activation;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Remoting.Lifetime;

namespace DB_project.Classes
{
    public class Model
    {
        public SharedTCP SharedTCP;
        public SharedHTTP SharedHTTP;

        public Model()
        {
            //TCP Client
            TcpChannel channelTCP = new TcpChannel(new Dictionary<string, string> { { "port", "0" }, { "secure", "true" },
                                                                                    { "protectionLevel", "EncryptAndSign" },
                                                                                    { "TokenlmpersonationLevel", "Impersonation" } },
                                    new BinaryClientFormatterSinkProvider(),
                                    new BinaryServerFormatterSinkProvider { TypeFilterLevel = TypeFilterLevel.Full });
            ChannelServices.RegisterChannel(channelTCP, false);
            SharedTCP = (SharedTCP)Activator.CreateInstance(typeof(SharedTCP), null, new object[] { new UrlAttribute("tcp://localhost:9999/TCP") });

            if (SharedTCP == null)
            {
                Console.WriteLine("Сервер TCP недоступен");
                return;
            }

            ILease leaseTCP = (ILease)SharedTCP.GetLifetimeService();
            MyClientSponsor clientTCPSponsor = new MyClientSponsor();
            leaseTCP.Register(clientTCPSponsor);


            //HTTP Client
            RemotingConfiguration.Configure("Client.config", false);
            SharedHTTP = new SharedHTTP();

            if (SharedHTTP == null)
            {
                Console.WriteLine("Сервер HTTP недоступен");
                return;
            }

            ILease leaseHTTP = (ILease)SharedHTTP.GetLifetimeService();
            MyClientSponsor clientHTTPSponsor = new MyClientSponsor();
            leaseHTTP.Register(clientHTTPSponsor);
        }
    }
}