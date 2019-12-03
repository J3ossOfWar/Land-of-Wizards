using System;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Game
{
    public partial class NewAccountForm : Form
    {
        TcpClient client;
        public StreamReader streamReader;
        public StreamWriter streamWriter;
        public string accountType;

        Bitmap m;

        public NewAccountForm()
        {
            InitializeComponent();
            comboBox1.SelectedValueChanged += ComboBox1_SelectedValueChanged;
        }

        private void ComboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Youssef"))
            {
                accountType = ""+1;
                m = new Bitmap(@".\Images\Charecters\Youssef\Down\Down2.png");
                pictureBox1.Image = m;
            }
            if (comboBox1.Text.Equals("Moataz"))
            {
                accountType = ""+2;
                m = new Bitmap(@".\Images\Charecters\Moataz\Down\Down2.png");
                pictureBox1.Image = m;
            }
            if (comboBox1.Text.Equals("Hoda"))
            {
                accountType = "" + 3;
                m = new Bitmap(@".\Images\Charecters\Hoda\Down\Down2.png");
                pictureBox1.Image = m;
            }
        }

        private void createLbl_Click(object sender, EventArgs e)
        {
            client = new TcpClient(Luncher.StartGame.serveripTxtBox.Text, 8080);
            streamReader = new StreamReader(client.GetStream());
            streamWriter = new StreamWriter(client.GetStream());

            streamWriter.WriteLine("2"); streamWriter.Flush();
            streamWriter.WriteLine(usernameTxt.Text); streamWriter.Flush();
            streamWriter.WriteLine(passwordTxt.Text); streamWriter.Flush();
            streamWriter.WriteLine(accountType); streamWriter.Flush();

            client.Close();
            streamReader.Close();
            streamWriter.Close();
            Luncher.StartGame.Show();
            this.Hide();
        }
    }
}
