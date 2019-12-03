using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using otherplayer;

namespace GameServer_V._1._0._0
{
    static class UDPserver
    {
        static UdpClient myServer = new UdpClient(8090);
        static IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 0);

        static OtherPlayer p;

        static byte[] dataRecieving;
        static MemoryStream msR;
        static BinaryFormatter bfR;

        static byte[] dataSending;
        static MemoryStream msS;
        static BinaryFormatter bfS;

        public static void getInfo()
        {
            while (true)
            {
                try
                {
                    dataRecieving = myServer.Receive(ref endPoint);
                    msR = new MemoryStream(dataRecieving);
                    bfR = new BinaryFormatter();
                    p = (OtherPlayer)bfR.Deserialize(msR);
                    Database.updateDatabase(Database.users[p.username], p);
                    OtherPlayer.players[p.username] = Database.users[p.username].player;
                    msS = new MemoryStream();
                    bfS = new BinaryFormatter();
                    bfS.Serialize(msS, OtherPlayer.players);
                    dataSending = msS.GetBuffer();
                    myServer.Send(dataSending, dataSending.Length, endPoint);
                }
                catch (System.Exception)
                {
                    continue;
                }
            }
        }
    }
}