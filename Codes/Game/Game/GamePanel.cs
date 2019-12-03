using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using myplayer;
using map;
using otherplayer;
using missle;

namespace Game
{
    public class GamePanel : Panel
    {
        public Timer GameTicker;
        public Map map;
        OtherPlayer p;

        public string animationfilepath;
        public int AnimationCounter = 1;

        public int attackTimer;

        UdpClient UdpClient = new UdpClient();
        
        IPEndPoint iPEndPoint = new IPEndPoint(IPAddress.Parse(Luncher.StartGame.serveripTxtBox.Text), 8090);

        public GamePanel()
        {
            this.DoubleBuffered = true;
            map = new Map(@".\Images\map.bmp");
            if (MyPlayer.accountType==1)
            {
                animationfilepath = @".\Images\Charecters\Youssef\Down\Down2.png";
            }
            if (MyPlayer.accountType == 2)
            {
                animationfilepath = @".\Images\Charecters\Moataz\Down\Down2.png";
            }
            if (MyPlayer.accountType == 3)
            {
                animationfilepath = @".\Images\Charecters\Hoda\Down\Down2.png";
            }

            GameTicker = new Timer();
            GameTicker.Interval = 34;
            GameTicker.Tick += GameTicker_Tick;
            GameTicker.Start();

            this.SetStyle(ControlStyles.Selectable, true);
            this.TabStop = true;
        }

        private void GameTicker_Tick(object sender, EventArgs e)
        {
            MyPlayer.Move();

            animation();
            Networking();
            collision();
            attackTimer++;

            foreach (var player in OtherPlayer.players.Values)
            {
                player.Move(MyPlayer.moveX, MyPlayer.moveY);
                if (player.isAttacking)
                {
                    MyPlayer.isAttacking = false;
                    Missle m = new Missle(player.perspectiveX, player.perspectiveY, player.worldX2, player.worldY2, MyPlayer.moveX, MyPlayer.moveY, player.username);
                    Missle.Missles.Add(m);
                }
            }
            foreach (var missle in Missle.Missles)
            {
                missle.move();
            }
            foreach (var m in Missle.MisslesToRemove)
            {
                Missle.Missles.Remove(m);
            }
            Missle.MisslesToRemove.Clear();

            Luncher.StartGame.Game.userControl.lvlLabel.Text = "Level : "+(1+(MyPlayer.experience / 100));
            Luncher.StartGame.Game.userControl.ExperienceBar.Value = MyPlayer.experience%100;
            Luncher.StartGame.Game.userControl.Hitpoint.Value = MyPlayer.hitpoint;
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            map.Draw(MyPlayer.moveX, MyPlayer.moveY, e.Graphics);

            foreach (var missle in Missle.Missles)
            {
                missle.draw(e.Graphics);
            }

            foreach (var player in OtherPlayer.players.Values)
            {
                player.draw(e.Graphics);
            }
        }

        public void Networking()
        {
            try
            {
                p = new OtherPlayer(MyPlayer.worldX, MyPlayer.worldY, MyPlayer.moveX, MyPlayer.moveY, MyPlayer.isAttacking, MyPlayer.worldX2, MyPlayer.worldY2,
                Luncher.StartGame.username, animationfilepath, MyPlayer.experience, MyPlayer.accountType);

                MemoryStream ms = new MemoryStream();
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, p);
                byte[] data = ms.GetBuffer();
                UdpClient.Send(data, data.Length, iPEndPoint);
                Console.WriteLine("sent");

                MemoryStream ms1 = new MemoryStream();
                BinaryFormatter bf1 = new BinaryFormatter();
                byte[] dataRecevied = UdpClient.Receive(ref iPEndPoint);
                ms1 = new MemoryStream(dataRecevied);
                OtherPlayer.players = (Dictionary<string, OtherPlayer>)bf1.Deserialize(ms1);
                Console.WriteLine("recieved");
            }
            catch (Exception)
            {
                MessageBox.Show("error");
                Networking();
            }
        }

        public void collision()
        {
            foreach (var m in Missle.Missles)
            {
                foreach (var p in OtherPlayer.players.Values)
                {
                    if (p.username == m.username)
                        continue;

                    double p_center_x = p.worldX + p.playerWidth / 2;
                    double p_center_y = p.worldY + p.playerHeight / 2;

                    double m_center_x = m.x1 + m.missleSize / 2.0;
                    double m_center_y = m.y1 + m.missleSize / 2.0;

                    double dist =
                        Math.Sqrt(Math.Pow(p_center_x - m_center_x, 2)
                                + Math.Pow(p_center_y - m_center_y, 2));

                    if (dist <= (p.playerHeight / 2.0 + m.missleSize / 2.0))
                    {
                        Missle.MisslesToRemove.Add(m);
                        if (m.username==Luncher.StartGame.username)
                        {
                            MyPlayer.experience++;
                        }
                        if (p.username==Luncher.StartGame.username && MyPlayer.isShelding==false)
                        {
                            MyPlayer.hitpoint--;
                        }
                    }
                }
            }
        }

        public void animation()
        {
            if (MyPlayer.accountType==1)
            {
                if (MyPlayer.W == true)
                {
                    if (AnimationCounter > 3)
                    {
                        AnimationCounter = 1;
                    }
                    animationfilepath = @".\Images\Charecters\Youssef\Up\Up" + AnimationCounter + ".png";
                }
                if (MyPlayer.S == true)
                {
                    if (AnimationCounter > 3)
                    {
                        AnimationCounter = 1;
                    }
                    animationfilepath = @".\Images\Charecters\Youssef\Down\Down" + AnimationCounter + ".png";
                }
                if (MyPlayer.A == true)
                {
                    if (AnimationCounter > 3)
                    {
                        AnimationCounter = 1;
                    }
                    animationfilepath = @".\Images\Charecters\Youssef\Left\Left" + AnimationCounter + ".png";
                }
                if (MyPlayer.D == true)
                {
                    if (AnimationCounter > 3)
                    {
                        AnimationCounter = 1;
                    }
                    animationfilepath = @".\Images\Charecters\Youssef\Right\Right" + AnimationCounter + ".png";
                }
            }

            if (MyPlayer.accountType == 2)
            {
                if (MyPlayer.W == true)
                {
                    if (AnimationCounter > 3)
                    {
                        AnimationCounter = 1;
                    }
                    animationfilepath = @".\Images\Charecters\Moataz\Up\Up" + AnimationCounter + ".png";
                }
                if (MyPlayer.S == true)
                {
                    if (AnimationCounter > 3)
                    {
                        AnimationCounter = 1;
                    }
                    animationfilepath = @".\Images\Charecters\Moataz\Down\Down" + AnimationCounter + ".png";
                }
                if (MyPlayer.A == true)
                {
                    if (AnimationCounter > 3)
                    {
                        AnimationCounter = 1;
                    }
                    animationfilepath = @".\Images\Charecters\Moataz\Left\Left" + AnimationCounter + ".png";
                }
                if (MyPlayer.D == true)
                {
                    if (AnimationCounter > 3)
                    {
                        AnimationCounter = 1;
                    }
                    animationfilepath = @".\Images\Charecters\Moataz\Right\Right" + AnimationCounter + ".png";
                }
            }

            if (MyPlayer.accountType == 3)
            {
                if (MyPlayer.W == true)
                {
                    if (AnimationCounter > 3)
                    {
                        AnimationCounter = 1;
                    }
                    animationfilepath = @".\Images\Charecters\Hoda\Up\Up" + AnimationCounter + ".png";
                }
                if (MyPlayer.S == true)
                {
                    if (AnimationCounter > 3)
                    {
                        AnimationCounter = 1;
                    }
                    animationfilepath = @".\Images\Charecters\Hoda\Down\Down" + AnimationCounter + ".png";
                }
                if (MyPlayer.A == true)
                {
                    if (AnimationCounter > 3)
                    {
                        AnimationCounter = 1;
                    }
                    animationfilepath = @".\Images\Charecters\Hoda\Left\Left" + AnimationCounter + ".png";
                }
                if (MyPlayer.D == true)
                {
                    if (AnimationCounter > 3)
                    {
                        AnimationCounter = 1;
                    }
                    animationfilepath = @".\Images\Charecters\Hoda\Right\Right" + AnimationCounter + ".png";
                }
            }

            AnimationCounter++;
        }
    }
}