using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;

namespace GameServer_V._1._0._0
{
    class ServerLauncher
    {
        public static Dictionary<string, string> dict = new Dictionary<string, string>();
        public static List<ClientHandler> clientHandlers = new List<ClientHandler>();

        static TcpListener listener;
        static TcpClient client;
        static ClientHandler ch;
        static Thread cThread;
        static Thread ac;
        static Thread data;

        static void Main(string[] args)
        {
            try
            {
                Database.loadDatabase();

                listener = new TcpListener(System.Net.IPAddress.Any, 8080);
                listener.Start();

                ac = new Thread(acceptClients);
                ac.Start();

                data = new Thread(UDPserver.getInfo);
                data.Start();
            }
            catch (Exception)
            {
                
            }
        }

        static void acceptClients()
        {
            while (true)
            {
                Console.WriteLine("Server awaiting clients...");
                client = listener.AcceptTcpClient();
                Console.WriteLine("Client Accepted");

                ch = new ClientHandler(client);
                cThread = new Thread(ch.handleClient);
                cThread.Start();
                clientHandlers.Add(ch);
            }
        }
    }
}