using System.Drawing;

namespace myplayer
{
    public static class MyPlayer
    {
        public static short worldX = 815, worldY = 413;
        public static short moveX = 0, moveY = 0;
        public static short perspectiveX = 815, perspectiveY = 413;

        public static bool W = false, S = false, A = false, D = false;

        public static bool isAttacking = false;
        public static short worldX2, worldY2;

        public static byte speed = 20;
        public static short experience = 0;
        public static byte hitpoint = 10;

        public static bool isShelding=false;

        public static byte accountType;

        public static void Move()
        {
            if (W == true)
            {
                moveY = (short)(moveY - speed);
            }
            if (S == true)
            {
                moveY = (short)(moveY + speed);
            }
            if (D == true)
            {
                moveX = (short)(moveX + speed);
            }
            if (A == true)
            {
                moveX = (short)(moveX - speed);
            }

            worldX = (short)(815 + moveX);
            worldY = (short)(413 + moveY);
        }
    }
}