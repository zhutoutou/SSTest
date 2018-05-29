using System;
using SuperSocket.SocketBase;
using SuperSocket.SocketEngine;

namespace SSTest
{
    public class BootStrapStart
    {
        static void Main(string[] args)
        {

            Console.WriteLine("press any keycode to start this demo");

            Console.ReadKey();
            Console.WriteLine();

            var server = BootstrapFactory.CreateBootstrap();

            //Setup the server
            if (!server.Initialize())
            {
                
                Console.WriteLine("failed to initialize!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();

            //Strat the server
            if (server.Start() == StartResult.Failed)
            {
                Console.WriteLine("failed to start the server");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("the server start successfully,press 'q' to stop the server");

            //Emit Session Connected
            //server.NewSessionConnected += Server_NewSessionConnected;
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
    }
}