using System.Drawing;
using System.Windows.Forms;
using inputmanager;
using myplayer;

namespace Game
{
    public class GameForm:Form
    {
        public UserControl1 userControl;

        public GameForm()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.Text = "Game v.1.0.0";
            this.SetStyle(ControlStyles.Selectable, true);
            this.TabStop = true;
            this.KeyPreview = true;

            this.KeyDown += GameForm_KeyDown;
            this.KeyUp += GameForm_KeyUp;

            userControl = new UserControl1();
            userControl.Location = new Point(0, 0);
            userControl.Size = new Size(1680, 1050);

            this.Controls.Add(userControl);
        }

        public void GameForm_KeyDown(object sender, KeyEventArgs e)
        {
            InputManager.Press(e);
            MyPlayer.W = InputManager.W;
            MyPlayer.A = InputManager.A;
            MyPlayer.S = InputManager.S;
            MyPlayer.D = InputManager.D;
        }

        public void GameForm_KeyUp(object sender, KeyEventArgs e)
        {
            InputManager.Release(e);
            MyPlayer.W = InputManager.W;
            MyPlayer.A = InputManager.A;
            MyPlayer.S = InputManager.S;
            MyPlayer.D = InputManager.D;
        }
    }
}
