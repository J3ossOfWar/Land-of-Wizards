using otherplayer;
using System;

namespace GameServer_V._1._0._0
{
    [Serializable]
    class Account
    {
        public static int numberOfAccounts = 0;

        public string username;
        public string password;

        public bool isOpen;

        public OtherPlayer player;

        public int charecterType=0;
        public string avatar;

        public Account(string username, string password,byte charecterType)
        {
            numberOfAccounts = numberOfAccounts + 1;

            this.username = username;
            this.password = password;

            isOpen = false;

            this.charecterType = charecterType;

            if (charecterType==1)
            {
                avatar = @".\Images\Charecters\Youssef\Down\Down2.png";
            }
            if (charecterType == 2)
            {
                    avatar = @".\Images\Charecters\Moataz\Down\Down2.png";
            }
            if (charecterType == 3)
            {
                avatar = @".\Images\Charecters\Hoda\Down\Down2.png";
            }

            player = new OtherPlayer(815, 413, 0, 0, false, 0, 0, username, avatar, 0, charecterType);
        }
    }
}

