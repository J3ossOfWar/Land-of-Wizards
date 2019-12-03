using otherplayer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace GameServer_V._1._0._0
{
    static class Database
    {
        static object _lock = new object();
        public static Dictionary<string, Account> users = new Dictionary<string, Account>();

        static FileStream databaseFS;
        static BinaryFormatter databaseBF;

        static Account account;
        static OtherPlayer player;

        public static void loadDatabase()
        {
            Console.WriteLine("Loading database");

            databaseFS = new FileStream("myDatabase.txt", FileMode.Open);
            databaseBF = new BinaryFormatter();

            users = (Dictionary<string, Account>)databaseBF.Deserialize(databaseFS);

            databaseFS.Close();

            foreach (var user in Database.users)
            {
                user.Value.isOpen = false;
            }

            Console.WriteLine("Database loaded successfully\nThere were " + users.Count + " number of accounts loaded");
        }

        public static void storeDatabase()
        {
            Console.WriteLine("Storing database");

            databaseFS = new FileStream("myDatabase.txt", FileMode.OpenOrCreate);
            databaseBF = new BinaryFormatter();

            databaseBF.Serialize(databaseFS, users);
            databaseFS.Flush();

            databaseFS.Close();
            Console.WriteLine("Database stored successfully\nThere were " + users.Count + " accounts stored");
        }

        public static void addDatabase(Account account)
        {
            Console.WriteLine("Adding in Database");

            lock (_lock)
            {
                accessDatabase(1, account.username, account);
            }

            Console.WriteLine("Account added in database successfully");
        }

        public static void removeDatabase(Account account)
        {
            Console.WriteLine("Removing from database");

            lock (_lock)
            {
                accessDatabase(2, account.username, account);
            }

            Console.WriteLine("Account removed from database successfully");
        }

        public static void updateDatabase(Account account, OtherPlayer player)
        {
            Console.WriteLine("Updating database");

            lock (_lock)
            {
                accessDatabase(3, account.username, player);
            }

            Console.WriteLine("Database updated successfully");
        }

        public static void accessDatabase(int operationType, string username, object accountORplayer)
        {
            if (operationType == 1)
            {
                account = (Account)accountORplayer;
                users.Add(username, account);
            }
            else if (operationType == 2)
            {
                account = (Account)accountORplayer;
                users.Remove(username);
            }
            else if (operationType == 3)
            {
                player = (OtherPlayer)accountORplayer;
                users[username].player = player;
            }
        }
    }
}
