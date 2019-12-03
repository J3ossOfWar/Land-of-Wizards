using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using myplayer;

namespace Game
{
    public partial class UserControl1 : UserControl
    {
        public GamePanel GamePanel;

        public UserControl1()
        {
            InitializeComponent();

            GamePanel = new GamePanel();
            GamePanel.BackColor = Color.Black;
            GamePanel.Dock = DockStyle.Fill;

            GamePanel.MouseUp += GamePanel_MouseUp;
            GamePanel.MouseDown += GamePanel_MouseDown;

            this.Controls.Add(GamePanel);
        }

        public void GamePanel_MouseUp(object sender, MouseEventArgs e)
        {
            GamePanel.Focus();
            if (e.Button == MouseButtons.Left)
            {
                if (GamePanel.attackTimer>=15)
                {
                    MyPlayer.isAttacking = true;
                    MyPlayer.worldX2 = (short)(e.X + MyPlayer.moveX);
                    MyPlayer.worldY2 = (short)(e.Y + MyPlayer.moveY);
                    GamePanel.attackTimer = 0;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                MyPlayer.isShelding = false;
            }
        }

        public void GamePanel_MouseDown(object sender, MouseEventArgs e)
        {
            GamePanel.Focus();
            if (e.Button == MouseButtons.Right)
            {
                MyPlayer.isShelding = true;
            }
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Luncher.StartGame.streamWriter.WriteLine("exit");
            Luncher.StartGame.streamWriter.Flush();
            Application.Exit();
        }
    }
}
