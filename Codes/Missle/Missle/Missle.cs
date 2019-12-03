using System;
using System.Collections.Generic;
using System.Drawing;

namespace missle
{
    public class Missle
    {
        public static List<Missle> Missles = new List<Missle>();
        public static List<Missle> MisslesToRemove = new List<Missle>();

        public int x1, y1;
        public int x2, y2;

        public int dTotal = 80;

        public float missleSize;

        public bool firsttime = true;

        public int dX;
        public int dY;

        public int moveX;
        public int moveY;

        public string username;

        public Missle(int x1, int y1, int x2, int y2, int moveX, int moveY,string username)
        {
            this.x1 = x1 + moveX;
            this.y1 = y1 + moveY;

            this.x2 = x2;
            this.y2 = y2;

            this.moveX = moveX;
            this.moveY = moveY;

            this.username = username;

            missleSize = 50;
        }

        public void draw(Graphics g)
        {
            g.FillEllipse(Brushes.Red, (float)x1 - moveX - missleSize / 2, (float)y1 - moveY - missleSize / 2, missleSize, missleSize);
        }

        public void move()
        {
            if (x1 > -50 + moveX && x1 < 1700 + moveX &&
                y1 > -50 + moveY && y1 < 1100 + moveY)
            {
                if (x2 - moveX < 864 && y2 < 549 - moveY)
                {
                    if (firsttime)
                    {
                        dX = (int)(dTotal * Math.Cos(Math.Atan2(y1 - y2, x1 - x2)));
                        dY = (int)(dTotal * Math.Sin(Math.Atan2(y1 - y2, x1 - x2)));
                        firsttime = false;
                    }
                    x1 -= dX;
                    y1 -= dY;
                }
                else if (x2 - moveX < 864 && y2 > 549 - moveY)
                {
                    if (firsttime)
                    {
                        dX = (int)(dTotal * Math.Cos(Math.Atan2(y2 - y1, x1 - x2)));
                        dY = (int)(dTotal * Math.Sin(Math.Atan2(y2 - y1, x1 - x2)));
                        firsttime = false;
                    }
                    x1 -= dX;
                    y1 += dY;
                }
                else if (x2 - moveX > 864 && y2 < 549 - moveY)
                {
                    if (firsttime)
                    {
                        dX = (int)(dTotal * Math.Cos(Math.Atan2(y1 - y2, x2 - x1)));
                        dY = (int)(dTotal * Math.Sin(Math.Atan2(y1 - y2, x2 - x1)));
                        firsttime = false;
                    }
                    x1 += dX;
                    y1 -= dY;
                }
                else
                {
                    if (firsttime)
                    {
                        dX = (int)(dTotal * Math.Cos(Math.Atan2(y2 - y1, x2 - x1)));
                        dY = (int)(dTotal * Math.Sin(Math.Atan2(y2 - y1, x2 - x1)));
                        firsttime = false;
                    }
                    x1 += dX;
                    y1 += dY;
                }
            }
            else
            {
                if (!(MisslesToRemove.Contains(this)))
                {
                    MisslesToRemove.Add(this);
                }
            }
        }   
    }
}

