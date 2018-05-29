using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase;
using SuperSocket.SocketBase.Protocol;
namespace SSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press any keycode to start this demo");

            Console.ReadKey();
            Console.WriteLine();

            var server = new AppServer();

            //Setup the server
            if (!server.Setup(2002))
            {
                Console.WriteLine("failed to setup the server");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();

            //Strat the server
            if (!server.Start())
            {
                Console.WriteLine("failed to start the server");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("the server start successfully,press 'q' to stop the server");

            //Emit Session Connected
            server.NewSessionConnected += Server_NewSessionConnected;
            //Emit RquestReceived
            //server.NewRequestReceived += Server_NewRequestReceived;

            while (Console.ReadKey().KeyChar != 'q')
            {
                Console.WriteLine();
                continue;
            }

            //Stop the server
            server.Stop();

            Console.WriteLine("the server has been stoped!");
            Console.ReadKey();
        }

        private static void Server_NewRequestReceived(AppSession session, StringRequestInfo requestInfo)
        {
            switch (requestInfo.Key)
            {
                    case("ECHO"):
                        session.Send(requestInfo.Body);
                        break;
                    case("ADD"):
                        session.Send(requestInfo.Parameters.Select(p=>Convert.ToInt32(p)).Sum().ToString());
                        break;
                    case("MULT"):
                        var result = 1;
                        foreach (var factor in requestInfo.Parameters.Select(p=>Convert.ToInt32(p)))
                        {
                            result *= factor;
                        }
                        session.Send(result.ToString());
                        break;
            }
        }

        private static void Server_NewSessionConnected(AppSession session)
        {
            session.Send("Welcome to SuperSocket Telnet Server");
        }
    }
}
