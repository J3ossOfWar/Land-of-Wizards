using System;
using System.Collections.Generic;
using System.Drawing;

namespace otherplayer
{
    [Serializable]
    public class OtherPlayer
    {
        public static Dictionary<string,OtherPlayer> players = new Dictionary<string,OtherPlayer>();

        public string username;

        public short worldX=815, worldY=413;
        public short moveX, moveY;
        public short perspectiveX =815, perspectiveY=413;

        public bool isAttacking = false;
        public short worldX2, worldY2;
        
        public Bitmap m;
        public byte accountType;
        public byte playerWidth;
        public byte playerHeight;

        public byte hitpoints = 100;

        public short experience;

        public OtherPlayer(short worldX, short worldY, short moveX, short moveY, bool isAttacking, short worldX2, short worldY2, string username, string avatarPath, short experience,byte accountType)
        {
            this.worldX = worldX;
            this.worldY = worldY;

            this.moveX = moveX;
            this.moveY = moveY;

            this.isAttacking = isAttacking;
            this.worldX2 = worldX2;
            this.worldY2 = worldY2;

            this.username = username;

            m = new Bitmap(avatarPath);
            this.accountType = accountType;
            playerWidth = (byte)m.Width;
            playerHeight = (byte)m.Height;

            this.experience = experience;
        }

        public void Move(short moveX, short moveY)
        {
            perspectiveX = (short)(worldX - moveX);
            perspectiveY = (short)(worldY - moveY);
        }

        public void draw(Graphics g)
        {
            g.DrawImage(m, perspectiveX, perspectiveY, 50, 50);
        }
    }
}