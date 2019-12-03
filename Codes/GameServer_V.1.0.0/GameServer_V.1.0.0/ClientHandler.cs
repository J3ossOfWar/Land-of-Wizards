using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using otherplayer;
using System.Threading;

namespace GameServer_V._1._0._0
{
    class ClientHandler
    {
        public TcpClient client;
        StreamReader sr;
        StreamWriter sw;
        NetworkStream networkStream;
        BinaryFormatter bfTCP;

        string operation;
        string response;
        string username;
        string password;
        string accountType;

        Account account;

        public ClientHandler(TcpClient client)
        {
            this.client = client;
            sr = new StreamReader(client.GetStream());
            sw = new StreamWriter(client.GetStream());
            networkStream = client.GetStream();
            bfTCP = new BinaryFormatter();
        }

        public void handleClient()
        {
            try
            {
                operation = sr.ReadLine();

                Console.WriteLine(operation);

                if (operation.Equals("1"))
                {
                    username = sr.ReadLine();
                    password = sr.ReadLine();
                    if (Database.users.ContainsKey(username))
                    {
                        if (Database.users[username].isOpen == false)
                        {
                            if (Database.users[username].password.Equals(password))
                            {
                                response = "true";
                                sw.WriteLine(response);
                                sw.Flush();
                                bfTCP.Serialize(networkStream, Database.users[username].player);
                                networkStream.Flush();

                                Database.users[username].isOpen = true;

                                if (sr.ReadLine().Equals("exit"))
                                {
                                    Database.users[username].isOpen = false;
                                    Database.storeDatabase();
                                    OtherPlayer.players.Remove(username);
                                    sr.Close();
                                    sw.Close();
                                    networkStream.Close();
                                }
                            }
                            else
                            {
                                response = "Password is wrong";
                                sw.WriteLine(response);
                                sw.Flush();
                                sr.Close();
                                sw.Close();
                                networkStream.Close();
                            }
                        }
                        else
                        {
                            response = "account is open";
                            sw.WriteLine(response);
                            sw.Flush();
                            sr.Close();
                            sw.Close();
                            networkStream.Close();
                        }
                    }
                    else
                    {
                        response = "Username isn't found";
                        sw.WriteLine(response);
                        sw.Flush();
                        sr.Close();
                        sw.Close();
                        networkStream.Close();
                    }
                }
                else if (operation.Equals("2"))
                {
                    username = sr.ReadLine();
                    password = sr.ReadLine();
                    accountType = sr.ReadLine();

                    account = new Account(username, password, byte.Parse(accountType));
                    Database.addDatabase(account);

                    Database.storeDatabase();
                }
                else if (operation.Equals("3"))
                {
                    username = sr.ReadLine();
                    password = sr.ReadLine();

                    Database.removeDatabase(Database.users[username]);

                    Database.storeDatabase();
                }
            }

            catch (Exception)
            {
                Console.WriteLine("error");
                Database.users[username].isOpen = false;
                Database.storeDatabase();
                OtherPlayer.players.Remove(username);
            }
        }    
    }
}